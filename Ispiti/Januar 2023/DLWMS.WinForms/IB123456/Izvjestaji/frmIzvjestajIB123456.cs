using DLWMS.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB123456.Izvjestaji
{
    public partial class frmIzvjestajIB123456 : Form
    {
        private StudentiUvjerenjaIB123456 _su;
        DLWMSDbContext _db = new DLWMSDbContext();

        public frmIzvjestajIB123456()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB123456(StudentiUvjerenjaIB123456 red):this()
        {
            this._su = red;

            // Oznaci uvjerenje kao printano i vrsi update u bazi podataka za trajnu pohranu
            _su.Printano = true;
            _db.Update(_su);
            _db.SaveChanges();
        }

        private void frmIzvjestajIB123456_Load(object sender, EventArgs e)
        {
            var lista = _db.Studenti.Where(x => x.Id == _su.StudentId).ToList();
            var rpc = new ReportParameterCollection();

            string imePrezime = $"{lista[0]}";
            rpc.Add(new ReportParameter("prmStudent", imePrezime));

            string brojIndeksa = $"{lista[0].BrojIndeksa}";
            rpc.Add(new ReportParameter("prmBrojIndeksa", brojIndeksa));

            string svrha = $"{_su.SvrhaUvjerenja}";
            rpc.Add(new ReportParameter("prmSvrha", svrha));

            string uvjerenje = $"{_su.VrstaUvjerenja}";
            rpc.Add(new ReportParameter("prmUvjerenje", uvjerenje));

            string datum = $"{DateTime.Now}";
            rpc.Add(new ReportParameter("prmDatum", datum));

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
