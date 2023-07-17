using DLWMS.Data;
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
    public partial class frmPretragaIB123456 : Form
    {
        DLWMSDbContext _db = new DLWMSDbContext();
        List<Student> lista = new List<Student>();
        public frmPretragaIB123456()
        {
            InitializeComponent();
            foreach (Student student in _db.Studenti)
            {
                student.GetProsjek();
            }
            cmbSpol.DataSource = _db.Spolovi.ToList();
        }

        private void frmPretragaIB123456_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        #region Ucitavanje
        private void UcitajPodatke()
        {
            var Od = dtpOd.Value;
            var Do = dtpDo.Value;

            lista = _db.Studenti.Where(x => x.DatumRodjenja >= Od && x.DatumRodjenja <= Do && x.Spol == cmbSpol.SelectedItem).ToList();
            dgvPodaci.DataSource = lista;

            if (lista.Count == 0)
            {
                MessageBox.Show($"U bazi podataka ne postoji evidencija o studentima {cmbSpol.SelectedItem} spola rođenih u periodu od {dtpOd.Value} – {dtpDo.Value} godine.");
            }
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        #endregion

        #region OtvaranjeFormi
        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var kolona = dgvPodaci.Columns[e.ColumnIndex];
            var red = dgvPodaci.Rows[e.RowIndex].DataBoundItem as Student;

            if (kolona is not DataGridViewButtonColumn)
            {
                Form forma = new frmStudentInfoIB123456(red);
                Hide();
                forma.ShowDialog();
                Show();
            }
            else
            {
                Form forma = new frmUvjerenjaIB123456(red);
                Hide();
                forma.ShowDialog();
                Show();
            }
        }
        #endregion
    }
}
