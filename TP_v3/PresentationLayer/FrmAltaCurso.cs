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
    public partial class FrmAltaCurso : Form
    {
        private CursoService _cursoService;
        private CategoriaService _categoriaService;
        private Curso _curso;
        private Categoria _categoria;

        public FrmAltaCurso()
        {
            InitializeComponent();
            _cursoService = new CursoService();
            _categoriaService = new CategoriaService();
            _curso = new Curso();
            _categoria = new Categoria();
        }
        #region EVENTOS
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombreCurso.Text == "")
            {
                MessageBox.Show("Se debe ingresar Nombre Curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            GrabarCurso();
            MessageBox.Show("Actualización correcta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            ((FrmCurso)this.Owner).PopulateCursos();
        }
        #endregion

        #region METODOS PRIVADOS
        private void GrabarCurso()
        {
            //Creamos un nuevo objeto "curso" con los datos que estan cargado en el Form

            _curso.idCurso = _curso != null ? _curso.idCurso : 0;
            _curso.nombre = txtNombreCurso.Text;
            _curso.descripcion = txtDescCurso.Text;
            _curso.fechaVigencia = dtimeFechaVig.Value;
            _curso.idCategoria = new Categoria();
            _curso.idCategoria.idCategoria = (int)cboCateg.SelectedValue;

            //Ahora llamamos a la capa de negocio
            _cursoService.GrabarCurso(_curso);
        }
        private void LimpiarForm()
        {
            txtNombreCurso.Text = string.Empty;
            txtDescCurso.Text = string.Empty;
            dtimeFechaVig.Value = DateTime.Today;

        }
        #endregion

        #region METODOS PUBLICOS
        public void CargarCursos(Curso curso)
        {
            _curso = curso;
            if (curso != null)
            {
                LimpiarForm();

                txtNombreCurso.Text = curso.nombre;
                txtDescCurso.Text = curso.descripcion;
                dtimeFechaVig.Text = Convert.ToString(curso.fechaVigencia);
                cboCateg.ValueMember = Convert.ToString(curso.idCategoria);
            }
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaCurso_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboCateg, _categoriaService.ObtenerCategorias(), "nombreCateg", "idCategoria");
        }

        private void LlenarCombo(ComboBox cboCateg, Object source, string display, String value)
        {
            cboCateg.DataSource = source;
            cboCateg.DisplayMember = display;
            cboCateg.ValueMember = value;
            cboCateg.SelectedIndex = 0;
        }
    }
}
