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
    public partial class FrmUsuarioCursoAvance : Form
    {
        //private readonly CursoService _cursoService;
        //private readonly UsuariosCurso _usuariosCurso;
        private readonly UsuarioService _usuarioService;
        private readonly UsuariosCursoService _usuariosCursoService;
        public FrmUsuarioCursoAvance()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
            _usuariosCursoService = new UsuariosCursoService();
            //_usuariosCurso = new UsuariosCurso();
            InitializeDataGridView();

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
            LlenarCombo(cboUsuario, _usuarioService.ObtenerUsuarios(), "nombreUsuario", "idUsuario");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int IdUser = Convert.ToInt32(cboUsuario.SelectedValue.ToString());
            //ConsultarUsuarioCurso(user);
            //Dictionary<string, object> parametros = new Dictionary<string, object>();
            //if (!string.IsNullOrEmpty(cboUsuario.Text))
            //{
            //    var idUsuario = cboUsuario.SelectedValue.ToString();
            //    parametros.Add("idUsuario", idUsuario);
            //}
            IList<UsuariosCurso> listadoUsuariosCurso = _usuariosCursoService.ConsultarUsuarioCursoPorId(IdUser);
            dgvUsuarioCursos.DataSource = listadoUsuariosCurso;
            if(dgvUsuarioCursos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void InitializeDataGridView()
        {
            dgvUsuarioCursos.ColumnCount = 6;
            dgvUsuarioCursos.ColumnHeadersVisible = true;
            dgvUsuarioCursos.AutoGenerateColumns = false;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvUsuarioCursos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvUsuarioCursos.Columns[0].Name = "User";
            dgvUsuarioCursos.Columns[0].DataPropertyName = "IdUsuario";
            dgvUsuarioCursos.Columns[0].Width = 50;

            dgvUsuarioCursos.Columns[1].Name = "Curso";
            dgvUsuarioCursos.Columns[1].DataPropertyName = "IdCurso";

            dgvUsuarioCursos.Columns[2].Name = "Puntuación";
            dgvUsuarioCursos.Columns[2].DataPropertyName = "puntuacion";

            dgvUsuarioCursos.Columns[3].Name = "Observaciones";
            dgvUsuarioCursos.Columns[3].DataPropertyName = "observacion";

            dgvUsuarioCursos.Columns[4].Name = "Inicio";
            dgvUsuarioCursos.Columns[4].DataPropertyName = "Inicio";

            dgvUsuarioCursos.Columns[5].Name = "Fin";
            dgvUsuarioCursos.Columns[5].DataPropertyName = "Fin";

            dgvUsuarioCursos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvUsuarioCursos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }
    }
}
