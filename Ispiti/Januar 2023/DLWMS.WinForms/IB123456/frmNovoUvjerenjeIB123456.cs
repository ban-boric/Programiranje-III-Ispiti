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
    public partial class frmNovoUvjerenjeIB123456 : Form
    {
        DLWMSDbContext _db = new DLWMSDbContext();
        private Student _student;

        public frmNovoUvjerenjeIB123456()
        {
            InitializeComponent();
            cmbVrsta.SelectedIndex = 0;
        }

        public frmNovoUvjerenjeIB123456(Student student) : this()
        {
            this._student = student;
        }

        #region Sacuvaj
        private void button1_Click(object sender, EventArgs e)
        {
            //Unutar Validator klase potrebno je dodati RichTextBox funkciju kako bi se validacija izvrsila.
            if (!Helpers.Validator.ValidirajKontrolu(rtbSvrha, errorProvider1, Kljucevi.ObaveznaVrijednost) || !Helpers.Validator.ValidirajKontrolu(pbUplatnica, errorProvider1, Kljucevi.ObaveznaVrijednost))
            {
                return;
            }

            var rekord = new StudentiUvjerenjaIB123456()
            {
                StudentId = _student.Id,
                VrijemeKreiranja = DateTime.Now,
                VrstaUvjerenja = cmbVrsta.Text,
                SvrhaUvjerenja = rtbSvrha.Text,
                Uplatnica = ImageHelper.FromImageToByte(pbUplatnica.Image),
                Printano = false
            };

            _db.StudentiUvjerenjaIB123456.Add(rekord);
            _db.SaveChanges();

            Close();
            MessageBox.Show("Uspjesno dodano uvjerenje!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
