using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_v3.BussinesLayer;

namespace TP_v3.PresentationLayer.Reportes
{
    public partial class FrmReporte : Form
    {
        CursoService _cursoService;
        public FrmReporte()
        {
            InitializeComponent();
            _cursoService = new CursoService();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.SP_SEL_UsuariosCurso' Puede moverla o quitarla según sea necesario.
            //this.SP_SEL_UsuariosCursoTableAdapter.Fill(this.DataSet1.SP_SEL_UsuariosCurso);
            LlenarCombo(cboCurso, _cursoService.ObtenerCursos(), "nombre", "IdCurso");
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = 0;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                SP_SEL_UsuariosCursoTableAdapter.Fill(DataSet1.SP_SEL_UsuariosCurso, 0);
            }
            else
            {
                SP_SEL_UsuariosCursoTableAdapter.Fill(DataSet1.SP_SEL_UsuariosCurso, int.Parse(cboCurso.SelectedValue.ToString()));
            }
            
            this.reportViewer1.RefreshReport();
        }
    }
}
