using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class VerUsuarios : Form
    {
        public VerUsuarios()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void VerUsuarios_Load(object sender, EventArgs e)
        {


            PersonalLogic Pers = new PersonalLogic();

            var TraeUsuarios = Pers.SelectEmpleados();
            dataGridView1.DataSource = TraeUsuarios;
            //dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Contraseña";
            dataGridView1.Columns[3].HeaderText = "Fotografia";
            dataGridView1.Columns[4].HeaderText = "Telefono";
            dataGridView1.Columns[5].HeaderText = "Direccion";
            dataGridView1.Columns[6].HeaderText = "Puesto";
            dataGridView1.Columns[7].HeaderText = "Correo";
            dataGridView1.Columns[8].HeaderText = "Fecha";


            Dominio.PersonalLogic D = new Dominio.PersonalLogic();
            RegistrarNuevoUsuario regs = new RegistrarNuevoUsuario();
            var traerEmpleados = D.SelectEmpleados();

            foreach (var elemento in traerEmpleados)
            {
                comboBox1.Items.Add(elemento.L_Usuario);
            }
            //comboBox1.Items.Add(traerEmpleados[1].L_Usuario);
            
            switch (comboBox1.SelectedIndex)
            {
                case  1:
                    MessageBox.Show("Sasd");
                    
                    break;

            }
            var b = dataGridView1.SelectedRows;
            MessageBox.Show(b.ToString());
           // pictureBox1.Image = regs.ConvertirByte(traerEmpleados[2].L_Imagen);
        }

        private void VerUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistrarNuevoUsuario regs = new RegistrarNuevoUsuario();
            regs.Show();

        }
    }
}
