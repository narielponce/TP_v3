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
using TP_v3.Entities;

namespace TP_v3.PresentationLayer
{
    public partial class FrmUsuarioCurso : Form
    {
        private readonly CursoService _cursoService;
        private readonly UsuarioService _usuarioService;
        private readonly UsuariosCurso _usuarioCurso;
        private readonly UsuariosCursoService _usuariosCursoService;
        public FrmUsuarioCurso()
        {
            InitializeComponent();
            _cursoService = new CursoService();
            _usuarioService = new UsuarioService();
            _usuarioCurso = new UsuariosCurso();
            _usuariosCursoService = new UsuariosCursoService();
            
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
        #region EVENTOS
        private void FrmUsuarioCurso_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboCurso, _cursoService.ObtenerCursos(), "nombre", "IdCurso");
            LlenarCombo(cboUsuario, _usuarioService.ObtenerUsuarios(), "nombreUsuario", "idUsuario");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region METODOS PRIVADOS

        #endregion

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            GrabarUsuarioCurso();
            MessageBox.Show("Curso registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void GrabarUsuarioCurso()
        {
            //Creamos un objeto con los datos del Form
            _usuarioCurso.IdCurso = new Curso();
            _usuarioCurso.IdCurso.idCurso = Convert.ToInt32(cboCurso.SelectedValue.ToString());

            _usuarioCurso.IdUsuario = new Usuario();
            _usuarioCurso.IdUsuario.idUsuario = Convert.ToInt32(cboUsuario.SelectedValue.ToString());

            _usuarioCurso.Puntuacion = Convert.ToInt32(txtPuntuacion.Text.ToString());
            _usuarioCurso.Observacion = txtObserv.Text;
            _usuarioCurso.Inicio = Convert.ToDateTime(dtpInicio.Value);
            _usuarioCurso.Fin = Convert.ToDateTime(dtpFin.Value);

            _usuariosCursoService.InsertarUsuarioCurso(_usuarioCurso);
        }
    }
}
