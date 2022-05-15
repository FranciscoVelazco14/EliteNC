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

            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void VerUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistrarNuevoUsuario regs = new RegistrarNuevoUsuario();
            regs.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dominio.PersonalLogic D = new Dominio.PersonalLogic();
            RegistrarNuevoUsuario regs = new RegistrarNuevoUsuario();
            var traerEmpleados = D.SelectEmpleados();
            pictureBox1.Image = regs.ConvertirByte(traerEmpleados[dataGridView1.CurrentRow.Index].L_Imagen);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
