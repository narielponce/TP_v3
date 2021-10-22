using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_v3.PresentationLayer;
using TP_v3.Entities;

namespace TP_v3
{
    public partial class FrmPrincipal : Form
    {
        //Usuario _usuario;
        public FrmPrincipal(string userName = null)
        {
            InitializeComponent();
            lblUser.Text = "Bienvenido: " + userName;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //FrmLogin login = new FrmLogin();
            //login.ShowDialog();
        }
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;
            //else this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FrmCurso frmCurso = new FrmCurso();
            frmCurso.Show();
        }
        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trabajo Práctico de Programación de Aplicaciones Visuales I - 3K5 - Grupo 2 - 2021", "Informacion");
        }

        private void objetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FrmObjetivo frmObjetivo = new FrmObjetivo();
            frmObjetivo.Show();
        }

        private void actualizaciónDeAvanceDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FrmAvanceUser frmAvanceUser = new FrmAvanceUser();
            frmAvanceUser.Show();
        }

        private void inscripciónACursadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FrmUsuarioCurso frmUsuarioCurso = new FrmUsuarioCurso();
            frmUsuarioCurso.Show();
        }

        private void registroDeAvanceCursadoPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FrmUsuarioCursoAvance frmUsuarioCursoAvance = new FrmUsuarioCursoAvance();
            frmUsuarioCursoAvance.Show();
        }
    }
}
