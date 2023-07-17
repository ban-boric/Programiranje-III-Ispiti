using DLWMS.Data;
using DLWMS.WinForms.IB123456;
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

namespace DLWMS.WinForms.IB200155
{
    public partial class frmPretragaIB123456 : Form
    {
        public DLWMSDbContext _db = new DLWMSDbContext();
        public frmPretragaIB123456()
        {
            InitializeComponent();
        }

        private void frmPretragaIB200155_Load(object sender, EventArgs e)
        {
            dgvTabela.AutoGenerateColumns = false;
            PostaviCombo();
            AktivirajUslove();
            UcitajPodatke();
        }

        #region Uslovne komande
        private void PostaviCombo()
        {
            cmbOd.SelectedIndex = 0;
            cmbDo.SelectedIndex = 4;
        }

        //Uslovi prvo moraju biti Disabled. Kada se sve ucita onda se upale uslovi.
        private void AktivirajUslove()
        {
            cmbOd.Enabled = true;
            cmbDo.Enabled = true;
            dtpOd.Enabled = true;
            dtpDo.Enabled = true;
        }
        #endregion

        #region UcitajPodatke
        private void UcitajPodatke()
        {

            int OcjenaOd = int.Parse(cmbOd.SelectedItem.ToString());
            int OcjenaDo = int.Parse(cmbDo.SelectedItem.ToString());
            var dtmOd = dtpOd.Value;
            var dtmDo = dtpDo.Value;

            var lista = _db.StudentiPredmeti.Include(x => x.Student).Include(x => x.Predmet).Where(x => x.Ocjena >= OcjenaOd && x.Ocjena <= OcjenaDo && x.Datum >= dtmOd && x.Datum <= dtmDo).ToList();

            dgvTabela.DataSource = null;
            dgvTabela.DataSource = lista;

            if (lista.Count < 1)
            {
                MessageBox.Show($"U periodu od {dtmOd.ToString("dd.MM.yyyy")} – {dtmDo.ToString("dd.MM.yyyy")} godine ne postoje evidentirane ocjene u opsegu od {OcjenaOd} do {OcjenaDo} za bilo kojeg studenta.", "Prazna baza", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region ChangedElementi

        private void cmbOd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOd.Enabled != false)
                UcitajPodatke();
        }

        private void cmbDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDo.Enabled != false)
                UcitajPodatke();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpOd.Enabled != false)
                UcitajPodatke();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDo.Enabled != false)
                UcitajPodatke();
        }
        #endregion

        private void dgvTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var kolona = dgvTabela.Columns[e.ColumnIndex];

            if(kolona is DataGridViewButtonColumn)
            {
                var red = dgvTabela.Rows[e.RowIndex].DataBoundItem as StudentiPredmeti;
                Form poruke = new frmPorukeIB123456(red);
                Hide();
                poruke.ShowDialog();
                Show();
            }
        }
    }
}
