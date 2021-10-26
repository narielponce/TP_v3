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
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            //object IdUsuario = null;
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.SP_SEL_UsuariosCurso' Puede moverla o quitarla según sea necesario.
            //SP_SEL_UsuariosCursoTableAdapter.Fill(DataSet1.SP_SEL_UsuariosCurso);
            //this.reportViewer2.RefreshReport();
            //this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
