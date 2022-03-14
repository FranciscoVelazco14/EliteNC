﻿using System;
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
                int.TryParse(txtUsuario.Text, out int txtId);
                var TraeUsuarios = Pers.EntrarLogin(txtUsuario.Text, txtContraseña.Text,txtId);
                if (TraeUsuarios.Count == 1)
                { 
                    MessageBox.Show("Inicio de sesion");
                    MenuPrincipal MenuPrincipal_V = new MenuPrincipal();
                    MenuPrincipal_V.InformacionUsuario.Text += TraeUsuarios[0].L_Usuario +"\nRegistro: "+TraeUsuarios[0].L_Fecha ;
                    this.Hide();
                    MenuPrincipal_V.Show();
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

        private void btnRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                PersonalLogic Pers = new PersonalLogic();
                int.TryParse(txtUsuario.Text, out int txtId);
                var TraeUsuarios = Pers.EntrarLogin(txtUsuario.Text, txtContraseña.Text,txtId);

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
    }
}
