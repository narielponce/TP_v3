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
    public partial class FrmAvanceUser : Form
    {
        private readonly UsuariosCursoService _usuariosCursoService;
        private readonly UsuariosCurso _usuariosCurso;
        private readonly UsuariosCursoAvance _usuariosCursoAvance;
        private readonly UsuarioService _usuarioService;
        private readonly CursoService _cursoService;
        //private readonly Curso _curso;
        public FrmAvanceUser()
        {
            InitializeComponent();
            _usuariosCursoService = new UsuariosCursoService();
            _usuariosCurso = new UsuariosCurso();
            _usuariosCursoAvance = new UsuariosCursoAvance();
            _usuarioService = new UsuarioService();
            _cursoService = new CursoService();
        }

        private void FrmAvanceUser_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, _usuarioService.ObtenerUsuarios(), "nombreUsuario", "IdUsuario");
            LlenarCombo(cboCurso, _cursoService.ObtenerCursos(), "nombre", "IdCurso");
            LlenarComboPorc();
            
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;

            cbo.DisplayMember = display;

            cbo.ValueMember = value;

            cbo.SelectedIndex = -1;
        }
        private void LlenarComboPorc()
        {
            cboPorc.Items.Add(10);
            cboPorc.Items.Add(20);
            cboPorc.Items.Add(30);
            cboPorc.Items.Add(40);
            cboPorc.Items.Add(50);
            cboPorc.Items.Add(60);
            cboPorc.Items.Add(70);
            cboPorc.Items.Add(80);
            cboPorc.Items.Add(90);
            cboPorc.Items.Add(100);
        }
        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvAlumno.ColumnCount = 5;
            dgvAlumno.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvAlumno.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.LightGray;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvAlumno.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvAlumno.Columns[0].Name = "IdUsuario";
            dgvAlumno.Columns[0].DataPropertyName = "id_usuario";
            // Definimos el ancho de la columna.
            dgvAlumno.Columns[0].Width = 50;

            dgvAlumno.Columns[1].Name = "IdCurso";
            dgvAlumno.Columns[1].DataPropertyName = "id_curso";

            dgvAlumno.Columns[2].Name = "Inicio";
            dgvAlumno.Columns[2].DataPropertyName = "inicio";

            dgvAlumno.Columns[3].Name = "Fin";
            dgvAlumno.Columns[3].DataPropertyName = "fin";

            dgvAlumno.Columns[4].Name = "PorcAvance";
            dgvAlumno.Columns[4].DataPropertyName = "porc_avance";

            // Cambia el tamaño de la altura de los encabezados de columna.

            dgvAlumno.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvAlumno.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UsuariosCurso usuariosCurso = new UsuariosCurso();
            usuariosCurso.IdCurso.idCurso = Convert.ToInt32(cboCurso.SelectedValue.ToString());
            usuariosCurso.IdUsuario.idUsuario = Convert.ToInt32(cboUsuario.SelectedValue.ToString());
            usuariosCurso.Puntuacion = Convert.ToInt32(txtPuntuacion.Text);
            usuariosCurso.Observacion = txtObs.Text;
            usuariosCurso.Inicio = Convert.ToDateTime(dtpInicio.Value);
            usuariosCurso.Inicio = Convert.ToDateTime(dtpFin.Value);

            UsuariosCursoAvance usuariosCursoAvance = new UsuariosCursoAvance();
            usuariosCursoAvance.idCurso.idCurso = Convert.ToInt32(cboCurso.SelectedValue.ToString());
            usuariosCursoAvance.idUsuario.idUsuario = Convert.ToInt32(cboUsuario.SelectedValue.ToString());
            usuariosCursoAvance.inicio = Convert.ToDateTime(dtpInicio.Value);
            usuariosCursoAvance.fin = Convert.ToDateTime(dtpFin.Value);
            usuariosCursoAvance.porcAvance = Convert.ToInt32(cboPorc.SelectedValue.ToString());

            RealizarTransaccion();
        }
        private void RealizarTransaccion()
        {
            //_usuariosCurso.CrearTransaccion(UsuariosCurso usuacurs);
        }
    }
} 
