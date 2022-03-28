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
            PersonalLogic Pers = new PersonalLogic();
            try
            {
                var TraeUsuarios = Pers.SelectEmpleados();
                dataGridView1.DataSource = TraeUsuarios;

                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].HeaderText = "Nombre";
                dataGridView1.Columns[2].HeaderText = "Contraseña";
                dataGridView1.Columns[3].HeaderText = "Fotografia";
                dataGridView1.Columns[4].HeaderText = "Telefono";
                dataGridView1.Columns[5].HeaderText = "Direccion";
                dataGridView1.Columns[6].HeaderText = "Puesto";
                dataGridView1.Columns[7].HeaderText = "Correo";
                dataGridView1.Columns[8].HeaderText = "Fecha";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
