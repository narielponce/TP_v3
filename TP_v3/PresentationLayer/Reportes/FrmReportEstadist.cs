using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_v3.PresentationLayer.Reportes
{
    public partial class dtpHasta : Form
    {
        public dtpHasta()
        {
            InitializeComponent();
        }

        private void FrmReportEstadist_Load(object sender, EventArgs e)
        {
            lblFechaActual.Text = "Hasta fecha actual (" + DateTime.Now.ToString("dd/MM/yyyy") + ")";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.StPr_CANT_POR_CURSO' Puede moverla o quitarla según sea necesario.
            this.StPr_CANT_POR_CURSOTableAdapter.Fill(this.DataSet2.StPr_CANT_POR_CURSO, dtpDesde.Value);

            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
