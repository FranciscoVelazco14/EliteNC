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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            CargarInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarInfo();
        }

        public void CargarInfo()
        {

            PersonalLogic pers = new PersonalLogic();
            DataTable tabla = new DataTable();
            dataGridView1.DataSource = pers.TraerArticulos(textBox1.Text);


            dataGridView1.Columns[0].HeaderText = "Nombre del articulo";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Dominio.PersonalLogic D = new Dominio.PersonalLogic();
            RegistrarNuevoUsuario regs = new RegistrarNuevoUsuario();
            var traerEmpleados = D.TraerArticulos(textBox1.Text);
            pictureBox1.Image = regs.ConvertirByte(traerEmpleados[dataGridView1.CurrentRow.Index].Imagen1);
            label3.Text = dataGridView1.CurrentRow.Cells["Cantidad1"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           if (Convert.ToInt32(label3.Text) > Convert.ToInt32(txtCantidad.Text))
            {
                MessageBox.Show("No hay tantos");
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
