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
    public partial class FrmCurso : Form
    {
        private CursoService _cursoService;
        private CategoriaService _categoriaService;
        private Curso _curso;

        public FrmCurso()
        {
            InitializeComponent();
            _cursoService = new CursoService();
            _categoriaService = new CategoriaService();
            _curso = new Curso();
        }
        private void FrmCurso_Load(object sender, EventArgs e)
        {
            PopulateCursos();
            LlenarCombo(cboCateg, _categoriaService.ObtenerCategorias(), "nombreCateg", "IdCategoria");
        }
        #region EVENTOS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            FrmAltaCurso consProductos = new FrmAltaCurso();
            consProductos.ShowDialog(this);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell celda = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (celda.Value.ToString() == "Editar")
            {
                FrmAltaCurso frmAltaCurso = new FrmAltaCurso();
                frmAltaCurso.CargarCursos(new Curso
                {
                    idCurso = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    nombre = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    descripcion = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    fechaVigencia = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()),
                    idCategoria = new Categoria()
                    {
                        //idCategoria = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()),
                        nombreCateg = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    }
                    //idCategoria = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()),
                    //borrado = bool.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()),
                });
                frmAltaCurso.ShowDialog(this);
            }
            else if (celda.Value.ToString() == "Eliminar")
            {
                DialogResult resp;
                resp = MessageBox.Show("¿Seguro que desea eliminar registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    //EliminarCurso(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    BajaLogicaCurso(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    PopulateCursos();
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCursoSearch.Text))
            {
                PopulateCursosSearch(txtCursoSearch.Text);
                txtCursoSearch.Text = string.Empty;
            }
            else
            {
                PopulateCursos();
                txtCursoSearch.Text = string.Empty;
            }
            
        }
        private void btnLimpBusq_Click(object sender, EventArgs e)
        {
            PopulateCursos();
        }
        private void btnBusqFiltro_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(cboCateg.Text))
            {
                var idCategoria = cboCateg.SelectedValue.ToString();
                parametros.Add("idCategoria", idCategoria);
            }
            IList<Curso> listadoCursos = _cursoService.ConsultarCursosConFiltros(parametros);
            dataGridView1.DataSource = listadoCursos;
        }
        #endregion

        #region METODOS PRIVADOS
        private void BajaLogicaCurso(int id)
        {
            _cursoService.BajaLogicaCurso(id);
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;

            cbo.DisplayMember = display;

            cbo.ValueMember = value;

            cbo.SelectedIndex = -1;
        }
        private void EliminarCurso(int id)
        {
            _cursoService.EliminarCurso(id);
        }
        #endregion

        #region METODOS PUBLICOS
        public void PopulateCursosSearch(string searchText)
        {
            List<Curso> cursos = _cursoService.ObtenerCursosSearch(searchText);
            dataGridView1.DataSource = cursos;
        }
        public void PopulateCursos()
        {
            List<Curso> cursos = _cursoService.ObtenerCursos();
            dataGridView1.DataSource = cursos;
        }
        #endregion








    }
}
