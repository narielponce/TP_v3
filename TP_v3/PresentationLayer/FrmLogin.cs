using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_v3.BussinesLayer;
using TP_v3.DataAccessLayer;
using TP_v3.Entities;

namespace TP_v3.PresentationLayer
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly Usuario _usuario;
        public string UsuarioLogueado { get; internal set; }
        public FrmLogin()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
            _usuario = new Usuario();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario.
            if ((txtUser.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Validamos que se haya ingresado una password
            if ((txtPass.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Controlamos que las creadenciales sean las correctas. 

            //string userLog = "";
            if (ValidarCredenciales(txtUser.Text, txtPass.Text))
            {
                // Mostramos un mensaje afirmativo en caso de que el usuario sea valido.
                MessageBox.Show("Acceso correcto ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //userLog = txtUser.Text;
                this.Hide();
                FrmPrincipal frmPrincipal = new FrmPrincipal(txtUser.Text);
                frmPrincipal.ShowDialog();
            }
            else
            {
                //Limpiamos el campo password, para que el usuario intente ingresar un usuario distinto.
                txtPass.Text = "";
                // Enfocamos el cursor en el campo password para que el usuario complete sus datos.
                txtPass.Focus();
                //Mostramos un mensaje indicando que el usuario/password es invalido.
                MessageBox.Show("Usuario y/o contraseña inválidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public bool ValidarCredenciales(string pUsuario, string pPassword)
        {
            //Inicializamos la variable usuarioValido en false, para que solo si el usuario es valido retorne true
            bool usuarioValido = false;

            //La doble barra o */ nos permite escribir comentarios sobre nuestro codigo sin afectar su funcionamiento.

            //La sentencia try...catch nos permite "atrapar" excepciones (Errores) y dar al usuario un mensaje más amigable.
            try
            {

                //Construimos la consulta sql para buscar el usuario en la base de datos.
                String consultaSql = string.Concat(" SELECT * ",
                                                   "   FROM Usuarios ",
                                                   "  WHERE usuario =  '", pUsuario, "'");

                //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
                DataTable resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

                // Validamos que el resultado tenga al menos una fila.
                if (resultado.Rows.Count >= 1)
                {
                    //En caso de que exista el usuario, validamos que password corresponda al usuario
                    if (resultado.Rows[0]["password"].ToString() == pPassword)
                    {
                        usuarioValido = true;
                    }
                }

            }
            catch (SqlException ex)
            {
                //Mostramos un mensaje de error indicando que hubo un error en la base de datos.
                MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retornamos el valor de usuarioValido. 
            return usuarioValido;
        }
    }
}
