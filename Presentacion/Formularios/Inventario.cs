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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        Dominio.PersonalLogic D = new Dominio.PersonalLogic();
        RegistrarNuevoUsuario regs = new RegistrarNuevoUsuario();
        PersonalLogic pers = new PersonalLogic();
        private void Inventario_Load(object sender, EventArgs e)
        {
            cargarinfo();
            int indiceFila = dataGridView1.Rows.Count;
            if (indiceFila == -1) return;
            for (int i = 0; i != indiceFila; ++i)
            {
                string[] val = new string[100];
                val[i] = dataGridView1.Rows[i].Cells[5].Value.ToString();
                if (double.Parse(val[i]) <= 10.00)
                {
                    MessageBox.Show("El producto  " + "-" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "-" + "  Tiene su stock bajo!", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }
        private void cargarinfo()
        {
           
            dataGridView1.DataSource = pers.TraerArticulos(textBox1.Text);
            dataGridView1.Columns[0].HeaderText = "Nombre del articulo";
            dataGridView1.Columns[1].HeaderText = "Precio";
            dataGridView1.Columns[2].HeaderText = "Medida";
            dataGridView1.Columns[3].HeaderText = "Clave SAT";
            dataGridView1.Columns[4].HeaderText = "Imagen Articulo";
            dataGridView1.Columns[5].HeaderText = "Cantidad";
            dataGridView1.Columns[6].HeaderText = "Id Articulo";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargarinfo();
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            EditarArticulos et = new EditarArticulos();
            try
            {
               
                et.Show();
                var traerEmpleados = D.TraerArticulos(textBox1.Text);
                et.label6.Text = dataGridView1.CurrentRow.Cells["Id1"].Value.ToString();
                et.pictureBox1.Image = regs.ConvertirByte(traerEmpleados[dataGridView1.CurrentRow.Index].Imagen1);
                et.textBox1.Text = dataGridView1.CurrentRow.Cells["NombreArticulo1"].Value.ToString();
                et.textBox2.Text = dataGridView1.CurrentRow.Cells["Precio1"].Value.ToString();
                et.textBox3.Text = dataGridView1.CurrentRow.Cells["Medida1"].Value.ToString();
                et.textBox4.Text = dataGridView1.CurrentRow.Cells["ClaveSat1"].Value.ToString();
                et.textBox5.Text = dataGridView1.CurrentRow.Cells["Cantidad1"].Value.ToString();
            }
            catch (Exception ex)
            {
                et.Close();
                MessageBox.Show("Error al actualizar articulo, no existe ninguno por actualizar", "SISTEMA", MessageBoxButtons.OK);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var traerEmpleados = D.TraerArticulos(textBox1.Text);
            pictureBox1.Image = regs.ConvertirByte(traerEmpleados[dataGridView1.CurrentRow.Index].Imagen1);     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            DialogResult dialogResult =  MessageBox.Show("Seguro que desea eliminar el articulo con id = " + dataGridView1.CurrentRow.Cells["Id1"].Value.ToString(), "SISTEMA", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                string id;
                id = dataGridView1.CurrentRow.Cells["Id1"].Value.ToString();
                pers.Elimina_articulo(int.Parse(id));
                MessageBox.Show("Articulo eliminado", "SISTEMA");
                cargarinfo();
                pictureBox1.Image = null;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar articulo, no existe articulo que eliminar", "SISTEMA", MessageBoxButtons.OK);
            }
           
           
        }
    }
}
