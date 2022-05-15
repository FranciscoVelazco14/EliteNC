using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using Dominio;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario/Id")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.FromArgb(0, 120, 204);
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.FromArgb(0, 120, 204);
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        #region "Botones de ingresar, de registro y salida"
        //Boton Ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                PersonalLogic Pers = new PersonalLogic();
                int.TryParse(txtUsuario.Text, out int txtId);
                var TraeUsuarios = Pers.EntrarLogin(txtUsuario.Text, txtContraseña.Text, txtId);
                if (TraeUsuarios.Count == 1)
                {
                    //MessageBox.Show("Inicio de sesion");
                    MenuPrincipal MenuPrincipal_V = new MenuPrincipal();
                    RegistrarNuevoUsuario RegistrarNuevo_V = new RegistrarNuevoUsuario();
                    MenuPrincipal_V.InformacionUsuario.Text += TraeUsuarios[0].L_Usuario;
                    MenuPrincipal_V.Puesto.Text = TraeUsuarios[0].L_Puesto;


                    MenuPrincipal_V.ImagenUsuario.Image = RegistrarNuevo_V.ConvertirByte(TraeUsuarios[0].L_Imagen);
                    this.Hide();
                    MenuPrincipal_V.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                }
            }
            catch
            {

            }

        }
        //Boton Registrar
        private void btnRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                try
                {
                    PersonalLogic Pers = new PersonalLogic();
                    int.TryParse(txtUsuario.Text, out int txtId);
                    var TraeUsuarios = Pers.EntrarLogin(txtUsuario.Text, txtContraseña.Text, txtId);

                    foreach (var Elemento in TraeUsuarios)
                    {
                        if (Elemento.L_Usuario == "Francisco" && Elemento.L_Contraseña == "F123")
                        {
                            MessageBox.Show("Bienvenido usuario administrador");
                            RegistrarNuevoUsuario registrarNuevoUsuario_V = new RegistrarNuevoUsuario();
                            registrarNuevoUsuario_V.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Ingresa el usuario administrador");
                        }
                    }
                }
                catch
                {
                   
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar.PerformClick();
            }
        }
    }
}
