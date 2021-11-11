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
    public partial class FrmAltaObjetivo : Form
    {
        private ObjetivoService _objetivoService;
        private Objetivo _objetivo;
        public FrmAltaObjetivo()
        {
            InitializeComponent();
            _objetivoService = new ObjetivoService();
        }
        #region EVENTOS
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            GrabarObjetivo();
            MessageBox.Show("Actualización correcta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            ((FrmObjetivo)this.Owner).PopulateObjetivo();
        }
        #endregion

        #region METODOS PRIVADOS
        private void GrabarObjetivo()
        {
            //Creamos un nuevo objeto "Objetivo" con los datos que estan cargado en el Form
            Objetivo objetivo = new Objetivo();
            objetivo.nombreCorto = txtNombObjCorto.Text;
            objetivo.nombreLargo = txtNombObjLargo.Text;

            objetivo.idObjetivo = _objetivo != null ? _objetivo.idObjetivo : 0;
            //Ahora llamamos a la capa de negocio
            _objetivoService.GrabarObjetivo(objetivo);
        }
        private void LimpiarForm()
        {
            txtNombObjCorto.Text = string.Empty;
            txtNombObjLargo.Text = string.Empty;
        }
        #endregion

        #region METODOS PUBLICOS
        public void CargarObjetivos(Objetivo objetivo)
        {
            _objetivo = objetivo;
            if (objetivo != null)
            {
                LimpiarForm();

                txtNombObjCorto.Text = objetivo.nombreCorto;
                txtNombObjLargo.Text = objetivo.nombreLargo;
            }
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
