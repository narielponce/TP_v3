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
    public partial class FrmCategoria : Form
    {
        private CategoriaService _categoriaService;
        private Categoria _categoria;
        public FrmCategoria()
        {
            InitializeComponent();
            _categoriaService = new CategoriaService();
            _categoria = new Categoria();
        }
        #region EVENTOS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            FrmAltaCategoria frmAltaCategoria = new FrmAltaCategoria();
            frmAltaCategoria.ShowDialog(this);
        }
        #endregion

        #region METODOS PRIVADOS

        #endregion


        #region METODOS PUBLICOS
        public void PopulateCategoria(string searchText = null)
        {
            List<Categoria> categoria = _categoriaService.ObtenerCategorias(searchText);
            dataGridView1.DataSource = categoria;
        }
        #endregion

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            PopulateCategoria();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell celda = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            if(celda.Value.ToString() == "Editar")
            {
                FrmAltaCategoria frmAltaCategoria = new FrmAltaCategoria();
                frmAltaCategoria.CargarCategorias(new Categoria
                {
                    idCategoria = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    nombreCateg = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    descripcion = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                });
                frmAltaCategoria.ShowDialog(this);
            }
            else if(celda.Value.ToString() == "Eliminar")
            {
                DialogResult resp;
                resp = MessageBox.Show("¿Seguro que desea eliminar registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    EliminarCurso(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    PopulateCategoria();
                }
            }
        }
        private void EliminarCurso(int id)
        {
            _categoriaService.EliminarCategoria(id);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PopulateCategoria(txtCursoSearch.Text);
            txtCursoSearch.Text = string.Empty;
        }
    }
}
