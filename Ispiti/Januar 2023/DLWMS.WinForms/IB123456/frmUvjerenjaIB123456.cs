using DLWMS.Data;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB123456
{
    public partial class frmUvjerenjaIB123456 : Form
    {

        DLWMSDbContext _db = new DLWMSDbContext();
        private Student _student;

        public frmUvjerenjaIB123456()
        {
            InitializeComponent();
        }

        public frmUvjerenjaIB123456(Student student) : this()
        {
            this._student = student;
        }

        private void frmUvjerenjaIB123456_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            cmbVrsta.SelectedIndex = 0;
        }

        private void UcitajPodatke()
        {
            var lista = _db.StudentiUvjerenjaIB123456.Where(x => x.Student.Id == _student.Id).ToList();
            dgvUvjerenja.DataSource = lista;
            this.Text = $"Broj uvjerenja -> {lista.Count}";

            //Provjera da li postoji najmanje jedan zahtjev kako bi omogucili da se rade operacije sa threadovima
            #region Thread dugme

            if (lista.Count > 0)
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }

            #endregion

        }

        #region Novi zahtjev i DGV funckije
        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            var forma = new frmNovoUvjerenjeIB123456(_student);
            Hide();
            forma.ShowDialog();
            UcitajPodatke();
            Show();
        }



        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var kolona = dgvUvjerenja.Columns[e.ColumnIndex];
            var red = dgvUvjerenja.Rows[e.RowIndex].DataBoundItem as StudentiUvjerenjaIB123456;

            if (kolona is DataGridViewButtonColumn)
                if (kolona.Index == 5)
                {
                    if (MessageBox.Show("Brisanje?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _db.Remove(red);
                        _db.SaveChanges();
                        UcitajPodatke();
                    }
                }
                else
                {
                    Form forma = new Izvjestaji.frmIzvjestajIB123456(red);
                    Hide();
                    forma.ShowDialog();
                    Show();
                    UcitajPodatke();
                }
        }

        #endregion

        #region Threadovi
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string ispis = "";
            var isNumerical = int.TryParse(txtBrojZahtjeva.Text, out int brojZahtjeva); //out kreira varijablu brojZahtjeva ukoliko je parse uspjesan

            if (isNumerical)
            {
                var vrsta = cmbVrsta.SelectedItem.ToString();
                var svrha = txtSvrha.Text;
                var slika = dgvUvjerenja.Rows[0].Cells[3].Value as byte[];  
                //iz datagridview-a uzimamo sliku jer zadatak trazi minimalno jedno uvjerenje kako bi dodali nova uvjerenja pomocu threadova

                var thread = new Thread(() => dodajUvjerenja(brojZahtjeva, _student, vrsta, svrha, slika));
                thread.Start();
            }
        }

        private void dodajUvjerenja(int brojZahtjeva, Student student, string vrsta, string svrha, byte[] slika)
        {


            for (int i = 0; i < brojZahtjeva; i++)
            {
                var uvjerenje = new StudentiUvjerenjaIB123456()
                {
                    StudentId = student.Id,
                    VrstaUvjerenja = vrsta,
                    SvrhaUvjerenja = svrha,
                    VrijemeKreiranja = DateTime.Now,
                    Uplatnica = slika,
                    Printano = false,
                };
                _db.Add(uvjerenje);
                _db.SaveChanges();

                Action ac = () =>
                {
                    rtbInfo.Text += $"{DateTime.Now} -> {vrsta} {student.BrojIndeksa} - {student} u svrhu {svrha}" + Environment.NewLine;
                };

                BeginInvoke(ac);
                Thread.Sleep(300);
            }

            MessageBox.Show($"Uspjesno ste dodali {brojZahtjeva} uvjerenja.", "Uspjesno dodavanje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BeginInvoke(UcitajPodatke);
        }
        #endregion

    }
}
