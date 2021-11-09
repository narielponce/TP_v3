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
    public partial class FrmReportEstadist : Form
    {
        public FrmReportEstadist()
        {
            InitializeComponent();
        }

        private void FrmReportEstadist_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.StPr_CANT_POR_CURSO' Puede moverla o quitarla según sea necesario.
            this.StPr_CANT_POR_CURSOTableAdapter.Fill(this.DataSet2.StPr_CANT_POR_CURSO);

            this.reportViewer1.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }
    }
}
