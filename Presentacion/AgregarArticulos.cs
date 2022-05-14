using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class AgregarArticulos : Form
    {
        public AgregarArticulos()
        {
            InitializeComponent();
        }

        private void AgregarArticulos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                PersonalLogic pers = new PersonalLogic();
            if (pictureBox1.Image != null && textBox1.Text != "" && textBox4.Text != "")
            {
                MessageBox.Show("Si entro");
                pers.CrearArticulos(textBox1.Text, numericUpDown1.Value, numericUpDown2.Value, textBox4.Text, textBox5.Text, "Si", "No", ConvertirImagen(pictureBox1.Image), numericUpDown3.Value);

            }
            else
            {
                MessageBox.Show("Te falto un campo obligtorio", "SISTEMA");
                MessageBox.Show((pictureBox1.Image != null).ToString());
            }            
        }
        
        byte[] ConvertirImagen(Image Imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog subirFoto = new OpenFileDialog();
                DialogResult Rs = subirFoto.ShowDialog();
                if (Rs == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(subirFoto.FileName);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
