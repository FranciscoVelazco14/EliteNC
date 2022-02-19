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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.FromArgb(0, 120, 204);
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text=="Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.FromArgb(0, 120, 204);
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            try
            {
                PersonalLogic Pers = new PersonalLogic();
                var TraeUsuarios = Pers.EntrarLogin(txtUsuario.Text, txtContraseña.Text);

                if (TraeUsuarios.Count == 1)
                {
                    MessageBox.Show("Inicio de sesion");
                }
                else
                {
                    MessageBox.Show("No inicio");
                }
            }
            catch
            {

            }

        }
            
    }
}
