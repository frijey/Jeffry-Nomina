using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_3_CRUD
{
    public partial class VisorDeFormularios : Form
    {
        public VisorDeFormularios(string NombreReporte)
        {
            InitializeComponent();
            ReportDocument cryRpt = new ReportDocument();

            cryRpt.Load(NombreReporte);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
