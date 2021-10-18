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
    public partial class FrmAltaCategoria : Form
    {
        private CategoriaService _categoriaService;
        private Categoria _categoria;
        public FrmAltaCategoria()
        {
            InitializeComponent();
            _categoriaService = new CategoriaService();
        }
        #region EVENTOS
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            GrabarCategoria();
            MessageBox.Show("Actualización correcta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            ((FrmCategoria)this.Owner).PopulateCategoria();
        }
        #endregion

        #region METODOS PRIVADOS
        private void GrabarCategoria()
        {
            //Creamos un nuevo objeto "categoria" con los datos que estan cargado en el Form
            Categoria categoria = new Categoria();
            categoria.nombreCateg = txtNombreCateg.Text;
            categoria.descripcion = txtDescCateg.Text;

            categoria.idCategoria = _categoria != null ? _categoria.idCategoria : 0;
            //Ahora llamamos a la capa de negocio
            _categoriaService.GrabarCategoria(categoria);
        }
        private void LimpiarForm()
        {
            txtNombreCateg.Text = string.Empty;
            txtDescCateg.Text = string.Empty;
        }
        #endregion

        #region METODOS PUBLICOS
        public void CargarCategorias(Categoria categoria)
        {
            _categoria = categoria;
            if (categoria != null)
            {
                LimpiarForm();

                txtNombreCateg.Text = categoria.nombreCateg;
                txtDescCateg.Text = categoria.descripcion;
            }
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
