using DLWMS.Data;
using DLWMS.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB123456
{
    public partial class frmPorukeIB123456 : Form
    {
        private StudentiPredmeti _student;
        DLWMSDbContext _db = new DLWMSDbContext();
        List<StudentiPorukeIB123456> lista = new List<StudentiPorukeIB123456>();

        public frmPorukeIB123456()
        {
            InitializeComponent();
        }

        public frmPorukeIB123456(StudentiPredmeti student) : this()
        {
            this._student = student;
        }

        private void frmPorukeIB123456_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        #region Ucitavanje
        private void UcitajPodatke()
        {
            lblStudent.Text = $"Poruke studenta: {_student.Student}";

            lista = _db.StudentiPoruke.Include(x => x.Student).Where(x => x.StudentId == _student.Student.Id && x.Validnost > DateTime.Now).ToList();

            dgvPoruke.DataSource = lista;

            this.Text = $"Broj poruka: {lista.Count()}";

            cmbPredmet.DataSource = _db.Predmeti.ToList();

            if (lista.Count > 0)
            {
                btnDodaj.Enabled = true;
                btnPrintaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
                btnPrintaj.Enabled = false;
            }
        }
        #endregion


        private void btnPoruka_Click(object sender, EventArgs e)
        {

            var forma = new frmNovaPorukaIB123456(_student);
            Hide();
            forma.ShowDialog();
            Show();
            UcitajPodatke();
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            var kolona = dgvPoruke.Columns[e.ColumnIndex];
            var red = dgvPoruke.Rows[e.RowIndex].DataBoundItem as StudentiPorukeIB123456;
            if (kolona is DataGridViewButtonColumn)
            {
                if (MessageBox.Show("Ukloniti poruku?", "Uklanjanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _db.StudentiPoruke.Remove(red);
                    _db.SaveChanges();
                }
            }
            UcitajPodatke();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var poruke = _db.StudentiPoruke.Include(x => x.Student).Where(x => x.StudentId == _student.Student.Id && x.Validnost > DateTime.Now).ToList();
            var forma = new frmIzvjestajIB123456(poruke);
            Hide();
            forma.ShowDialog();
            Close();
        }

        #region Threadovi

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int brojPoruka;
            bool isNumerical = int.TryParse(txtBrojPoruka.Text, out brojPoruka);
            if (isNumerical)
            {
                var predmet = cmbPredmet.SelectedItem as Predmet;
                var datum = dtpValidnost.Value;

                var thread = new Thread(() => dodajPoruku(brojPoruka, predmet, datum, _student.Student));
                thread.Start();
            }

        }

        private void dodajPoruku(int brojPoruka, Predmet predmet, DateTime datum, Student student)
        {
            var slika = lista[0].Slika;
            if (datum <= DateTime.Now)
            {
                MessageBox.Show($"Datum nije validan. Unesite noviji datum!");
                return;
            }
            for (int i = 0; i < brojPoruka; i++)
            {
                var poruka = new StudentiPorukeIB123456()
                {
                    Predmet = predmet,
                    Student = lista[0].Student,
                    Slika = slika,
                    Sadrzaj = i.ToString() + ". GENERISANA PORUKA",
                    Validnost = datum
                };
                _db.StudentiPoruke.Add(poruka);
                _db.SaveChanges();

                Action ac = () =>
                {
                    rtbInfo.Text += $"{DateTime.Now} -> generisana poruka za {student.Ime} {student.Prezime} " +
                    $"na predmetu {predmet}" + Environment.NewLine;
                    Azuriraj(); //ova metoda stavlja kursor na kraj teksta te ako je puno poruka prikazuju nam se najnovije poruke
                };
                BeginInvoke(ac);
                Thread.Sleep(300);
            }
            MessageBox.Show($"Studentu {student.Ime} {student.Prezime} je dodano {brojPoruka} novih poruka na predmetu " +
                $"{predmet} koje su validne do {datum}");
            BeginInvoke(UcitajPodatke);
        }

        private void Azuriraj()
        {
            rtbInfo.SelectionStart = rtbInfo.Text.Length;
            rtbInfo.ScrollToCaret();
        }

        #endregion
    }
}
