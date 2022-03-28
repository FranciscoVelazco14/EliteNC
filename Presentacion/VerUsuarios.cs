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
            pictureBox1.Image = regs.ConvertirByte(traerEmpleados[1].L_Imagen);
        }
    }
}
