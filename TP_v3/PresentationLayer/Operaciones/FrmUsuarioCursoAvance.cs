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
        private readonly UsuariosCurso _usuariosCurso;
        private readonly UsuarioService _usuarioService;
        private readonly UsuariosCursoService _usuariosCursoService;
        private readonly UsuarioCursoAvanceService _usuarioCursoAvanceService;
        private readonly UsuariosCursoAvance _usuariosCursoAvance;
        public FrmUsuarioCursoAvance()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
            _usuariosCursoService = new UsuariosCursoService();
            _usuarioCursoAvanceService = new UsuarioCursoAvanceService();
            _usuariosCursoAvance = new UsuariosCursoAvance();
            //_usuariosCurso = new UsuariosCurso();
            InitializeDataGridView();
            //LlenarCboAvance();
            txtUsuario.Enabled = false;
            txtCurso.Enabled = false;
            txtPuntuacion.Enabled = false;
            dateTimePicker1.Enabled = false;
            dtpInicio.Enabled = false;
            chkAllCourses.Checked = false;
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = 0;
        }
        //private void LlenarCboAvance()
        //{
        //    cboPorcAvan.Items.Add(10);
        //    cboPorcAvan.Items.Add(20);
        //    cboPorcAvan.Items.Add(30);
        //    cboPorcAvan.Items.Add(40);
        //    cboPorcAvan.Items.Add(50);
        //    cboPorcAvan.Items.Add(60);
        //    cboPorcAvan.Items.Add(70);
        //    cboPorcAvan.Items.Add(80);
        //    cboPorcAvan.Items.Add(90);
        //    cboPorcAvan.Items.Add(100);
       //}
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
            IList<UsuariosCurso> listadoUsuariosCurso = _usuariosCursoService.ConsultarUsuarioCursoPorId(IdUser);
            dgvUsuarioCursos.DataSource = listadoUsuariosCurso;
            if(dgvUsuarioCursos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void InitializeDataGridView()
        {
            dgvUsuarioCursos.ColumnCount = 7;
            dgvUsuarioCursos.ColumnHeadersVisible = true;
            dgvUsuarioCursos.AutoGenerateColumns = false;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvUsuarioCursos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvUsuarioCursos.Columns[0].Name = "Usuario";
            dgvUsuarioCursos.Columns[0].DataPropertyName = "IdUsuario";
            dgvUsuarioCursos.Columns[0].Width = 120;

            dgvUsuarioCursos.Columns[1].Name = "Curso";
            dgvUsuarioCursos.Columns[1].DataPropertyName = "IdCurso";
            dgvUsuarioCursos.Columns[1].Width = 140;

            dgvUsuarioCursos.Columns[2].Name = "Punt.";
            dgvUsuarioCursos.Columns[2].DataPropertyName = "puntuacion";
            dgvUsuarioCursos.Columns[2].Width = 50;

            dgvUsuarioCursos.Columns[3].Name = "Observaciones";
            dgvUsuarioCursos.Columns[3].DataPropertyName = "observacion";
            dgvUsuarioCursos.Columns[3].Width = 100;

            dgvUsuarioCursos.Columns[4].Name = "Inicio";
            dgvUsuarioCursos.Columns[4].DataPropertyName = "Inicio";
            dgvUsuarioCursos.Columns[4].Width = 80;

            dgvUsuarioCursos.Columns[5].Name = "Fin";
            dgvUsuarioCursos.Columns[5].DataPropertyName = "Fin";
            dgvUsuarioCursos.Columns[5].Width = 80;

            dgvUsuarioCursos.Columns[6].Name = "Avance";
            dgvUsuarioCursos.Columns[6].DataPropertyName = "Avance";
            dgvUsuarioCursos.Columns[6].Width = 60;

            dgvUsuarioCursos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvUsuarioCursos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            var cursoSel = (UsuariosCurso)dgvUsuarioCursos.CurrentRow.DataBoundItem;
            txtUsuario.Text = cursoSel.IdUsuario.nombreUsuario;
            txtCurso.Text = cursoSel.IdCurso.nombre;
            txtPuntuacion.Text = cursoSel.Puntuacion.ToString();
            dateTimePicker1.Value = cursoSel.Inicio;
            dtpInicio.Value = cursoSel.Fin;
            txtAvance.Text = cursoSel.Avance.ToString();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (chkAllCourses.Checked == true)
            {
                var cursoSel2 = (UsuariosCurso)dgvUsuarioCursos.CurrentRow.DataBoundItem;
                //Creamos un nuevo objeto "usuarioCursoAvance" con los datos que estan cargado en el Form
                _usuariosCursoAvance.idUsuario = new Usuario();
                _usuariosCursoAvance.idUsuario.idUsuario = cursoSel2.IdUsuario.idUsuario;
                _usuariosCursoAvance.idCurso = new Curso();
                _usuariosCursoAvance.idCurso.idCurso = cursoSel2.IdCurso.idCurso;
                _usuariosCursoAvance.inicio = cursoSel2.Inicio;
                _usuariosCursoAvance.fin = cursoSel2.Fin;
                _usuariosCursoAvance.porcAvance = int.Parse(txtAvance.Text);

                //Ahora llamamos a la capa de negocio
                _usuarioCursoAvanceService.GrabarAvance(_usuariosCursoAvance, 1);
            }
            else
            {
                var cursoSel2 = (UsuariosCurso)dgvUsuarioCursos.CurrentRow.DataBoundItem;
                //Creamos un nuevo objeto "usuarioCursoAvance" con los datos que estan cargado en el Form
                _usuariosCursoAvance.idUsuario = new Usuario();
                _usuariosCursoAvance.idUsuario.idUsuario = cursoSel2.IdUsuario.idUsuario;
                _usuariosCursoAvance.idCurso = new Curso();
                _usuariosCursoAvance.idCurso.idCurso = cursoSel2.IdCurso.idCurso;
                _usuariosCursoAvance.inicio = cursoSel2.Inicio;
                _usuariosCursoAvance.fin = cursoSel2.Fin;
                _usuariosCursoAvance.porcAvance = int.Parse(txtAvance.Text);

                //Ahora llamamos a la capa de negocio
                _usuarioCursoAvanceService.GrabarAvance(_usuariosCursoAvance, 0);
            }
            MessageBox.Show("Actualización correcta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void chkAllCourses_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
