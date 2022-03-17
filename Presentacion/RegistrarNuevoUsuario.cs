﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class RegistrarNuevoUsuario : Form
    {
        public RegistrarNuevoUsuario()
        {
            InitializeComponent();
        }

        private void RegistrarNuevoUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void RegistrarNuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login Login_v = new Login();
            Login_v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog subirFoto = new OpenFileDialog();
                DialogResult Rs = subirFoto.ShowDialog();
                if (Rs == DialogResult.OK)
                {
                    PicFotoEmpleado.Image = Image.FromFile(subirFoto.FileName);
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Dominio.PersonalLogic V_PersonalLogic = new Dominio.PersonalLogic();
            System.IO.MemoryStream V_Imagen = new System.IO.MemoryStream();*/
            try
            {
                Dominio.PersonalLogic D = new Dominio.PersonalLogic();

                var traerEmpleados = D.SelectEmpleados();
                foreach (var elemento in traerEmpleados)
                {
                    if (elemento.L_Usuario == TxtNombre.Text)
                    {
                        MessageBox.Show("Ingresaste un usuario ya existente");
                        break;
                    }
                    else 
                    {
                        if (TxtContraseña.Text == TxtContraseñaConfirmar.Text)
                        {
                            D.CrearEmpleados(TxtNombre.Text, TxtContraseña.Text, null, TxtTelefono.Text, TxtDireccion.Text, TxtPuesto.Text, TxtCorreo.Text, DateTime.Now);
                            MessageBox.Show("Si jalo");
                            this.Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("La contraseña no es igual");
                        }


                    }
                }

                
            }
            catch
            {

            }
        }

        private void TxtContraseñaConfirmar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
