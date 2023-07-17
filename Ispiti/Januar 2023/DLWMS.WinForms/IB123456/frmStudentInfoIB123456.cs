using DLWMS.Data;
using DLWMS.WinForms.Helpers;
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
    public partial class frmStudentInfoIB123456 : Form
    {
        private Student _student;

        public frmStudentInfoIB123456()
        {
            InitializeComponent();
        }

        public frmStudentInfoIB123456(Student student) : this()
        {
            this._student = student;
            this.Text = _student.BrojIndeksa;
            lblImePrezime.Text = _student.ImePrezime;
            lblProsjek.Text = _student.Prosjek.ToString();
            pbSlika.Image = ImageHelper.FromByteToImage(_student.Slika);
        }
    }
}
