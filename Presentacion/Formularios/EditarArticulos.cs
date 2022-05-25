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
    public partial class EditarArticulos : Form
    {
        public EditarArticulos()
        {
            InitializeComponent();
        }
        PersonalLogic pers = new PersonalLogic();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Articulo actualizado correctamente", "SISTEMA");
                pers.Edita_articulos(int.Parse(label6.Text), textBox1.Text, decimal.Parse(textBox2.Text), textBox3.Text, textBox4.Text, decimal.Parse(textBox5.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en actualizacion de articulo, verificar" + ex.Message, "SISTEMA");
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            inv.Refresh();
            this.Close();
        }
    }
}
