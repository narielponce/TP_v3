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
    public partial class FrmObjetivo : Form
    {
        private ObjetivoService _objetivoService;
        public FrmObjetivo()
        {
            InitializeComponent();
            _objetivoService = new ObjetivoService();
        }
        #region EVENTOS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            FrmAltaObjetivo frmAltaObjetivo = new FrmAltaObjetivo();
            frmAltaObjetivo.ShowDialog(this);
        }
        #endregion

        #region METODOS PRIVADOS

        #endregion


        #region METODOS PUBLICOS
        public void PopulateObjetivo(string searchText = null)
        {
            List<Objetivo> objetivo = _objetivoService.ObtenerObjetivos(searchText);
            dataGridView1.DataSource = objetivo;
        }
        #endregion

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            PopulateObjetivo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell celda = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            if(celda.Value.ToString() == "Editar")
            {
                FrmAltaObjetivo frmAltaObjetivo = new FrmAltaObjetivo();
                frmAltaObjetivo.CargarObjetivos(new Objetivo
                {
                    idObjetivo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    nombreCorto = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    nombreLargo = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                });
                frmAltaObjetivo.ShowDialog(this);
            }
            else if(celda.Value.ToString() == "Eliminar")
            {
                DialogResult resp;
                resp = MessageBox.Show("¿Seguro que desea eliminar registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    EliminarObjetivo(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    PopulateObjetivo();
                }
            }
        }
        private void EliminarObjetivo(int id)
        {
            _objetivoService.EliminarObjetivo(id);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PopulateObjetivo(txtCursoSearch.Text);
            txtCursoSearch.Text = string.Empty;
        }
    }
}
