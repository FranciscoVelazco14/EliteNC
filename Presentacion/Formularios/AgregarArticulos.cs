using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
       Image Imagen;

        private void button1_Click(object sender, EventArgs e)
        {
            PersonalLogic pers = new PersonalLogic();
            if (textBox1.Text != "" && comboBox1.Text != "")
            {
                if (pictureBox1.Image == Imagen)
                {
                    MessageBox.Show("Articulo agregado correctamente");
                    pers.CrearArticulos(textBox1.Text, numericUpDown1.Value, numericUpDown2.Value, comboBox1.Text, textBox5.Text, "Si", "No", ConvertirImagen(pictureBox1.Image), numericUpDown3.Value);
                }
                else
                {
                    MessageBox.Show("Te falto un campo obligtorio", "SISTEMA");
                }
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
                subirFoto.Filter = "Image files (*.png) |  *.png";
                if (subirFoto.ShowDialog()==DialogResult.OK)
                {
                    List<String> listaExtensiones = new List<string>() { ".png" };
                    if (listaExtensiones.Contains(Path.GetExtension(subirFoto.FileName)))
                    {
                        pictureBox1.Image = Image.FromFile(subirFoto.FileName);
                        Imagen = pictureBox1.Image;
                    }
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
        #region "Checkbox"
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Si";
            }
            else
            {
                checkBox1.Text = "No";
            }
            
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Text = "Si";
            }
            else
            {
                checkBox2.Text = "No";
            }
        }
        #endregion
    }
}
