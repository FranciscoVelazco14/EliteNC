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
        }
        private void cargarinfo()
        {
            PersonalLogic pers = new PersonalLogic();
            dataGridView1.DataSource = pers.TraerArticulos(textBox1.Text);
            dataGridView1.Columns[0].HeaderText = "Nombre del articulo";
            dataGridView1.Columns[1].HeaderText = "Precio";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargarinfo();
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            EditarArticulos et = new EditarArticulos();
            et.Show();
        }
    }
}
