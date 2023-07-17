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

namespace DLWMS.WinForms.IB123456
{
    public partial class frmIzvjestajIB123456 : Form
    {
        DLWMSDbContext _db = new DLWMSDbContext();
        private List<StudentiPorukeIB123456> _poruke;

        public frmIzvjestajIB123456()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB123456(List<StudentiPorukeIB123456> poruke):this()
        {
            this._poruke = poruke;
        }

        private void frmIzvjestajIB123456_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();
            var rpc = new ReportParameterCollection();
            var tbl = new Izvjestaj.dsIB123456.InformacijeDataTable();
            var sumaZnakova = 0.0f;

            foreach (var p in _poruke)
            {
                var red = tbl.NewInformacijeRow();
                red.Rb = p.Id.ToString();
                red.Predmet = p.Predmet.ToString();
                red.Poruka = p.Sadrzaj.ToString();
                red.BrojZnakova = p.Sadrzaj.Count().ToString();
                red.Validnost = p.Validnost.ToString();
                sumaZnakova += p.Sadrzaj.Count();
                tbl.AddInformacijeRow(red);
            }
            rds.Name = "DataSet1";
            rds.Value = tbl;

            var brojPoruka = $"{_poruke.Count}";
            rpc.Add(new ReportParameter("prmBrojPoruka", brojPoruka));

            var prosjek = _poruke.Count() != 0 ? (sumaZnakova / _poruke.Count()).ToString("0.00") : sumaZnakova.ToString("0.00");
            var prosjekKaraktera = $"{prosjek}";
            rpc.Add(new ReportParameter("prmProsjekSlova", prosjekKaraktera));

            var imePrezime = $"{_poruke[0].Student}";
            rpc.Add(new ReportParameter("prmStudent", imePrezime));

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);

            reportViewer1.RefreshReport();
        }
    }
}
