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

namespace TP_v3.PresentationLayer
{
    public partial class FrmAvanceUser : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly CursoService _cursoService;
        public FrmAvanceUser()
        {
            InitializeComponent();
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
    }
} 
