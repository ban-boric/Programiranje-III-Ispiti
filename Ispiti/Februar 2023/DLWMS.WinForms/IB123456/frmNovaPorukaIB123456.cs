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
    public partial class frmNovaPorukaIB123456 : Form
    {
        DLWMSDbContext _db = new DLWMSDbContext();
        private StudentiPredmeti _student;

        public frmNovaPorukaIB123456(StudentiPredmeti student)
        {
            InitializeComponent();
            cmbPredmet.DataSource = _db.Predmeti.ToList();
            this._student = student;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!Helpers.Validator.ValidirajKontrolu(rtbSadrzaj, errorProvider1, Kljucevi.ObaveznaVrijednost) ||
                !Helpers.Validator.ValidirajKontrolu(pbSlika, errorProvider1, Kljucevi.ObaveznaVrijednost))
            {
                return;
            }

            if (dtpValidnost.Value <= DateTime.Now)
            {
                errorProvider1.SetError(dtpValidnost, Kljucevi.PogresanDatum);
                errorProvider1.GetError(dtpValidnost);
                return;
            }

            var noviRekord = new StudentiPorukeIB123456
            {
                Predmet = cmbPredmet.SelectedItem as Predmet,
                Sadrzaj = rtbSadrzaj.Text,
                Slika = ImageHelper.FromImageToByte(pbSlika.Image),
                Validnost = dtpValidnost.Value,
                StudentId = _student.Student.Id,
            };

            _db.StudentiPoruke.Add(noviRekord);
            _db.SaveChanges();
            MessageBox.Show("Uspjesno dodan rekord!", "Informacija", MessageBoxButtons.OK);
            Close();
        }

        private void pbSlika_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
