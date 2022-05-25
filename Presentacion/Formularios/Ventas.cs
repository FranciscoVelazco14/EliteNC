using Dominio;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        Dominio.PersonalLogic D = new Dominio.PersonalLogic();
        RegistrarNuevoUsuario regs = new RegistrarNuevoUsuario();
        PersonalLogic pers = new PersonalLogic();
        double suma, multi, iva, total;
        private void Ventas_Load(object sender, EventArgs e)
        {
            try
            {
            var traerEmpleados = D.TraerArticulos(textBox1.Text);
            CargarInfo();
            pictureBox1.Image = regs.ConvertirByte(traerEmpleados[dataGridView1.CurrentRow.Index].Imagen1);
            label3.Text = dataGridView1.CurrentRow.Cells["Cantidad1"].Value.ToString();
            dataGridView1.Columns[0].HeaderText = "Nombre del articulo";
            dataGridView1.Columns[1].HeaderText = "Precio";
            dataGridView1.Columns[2].HeaderText = "Medida";
            dataGridView1.Columns[3].HeaderText = "Clave SAT";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "Cantidad";
            dataGridView1.Columns[6].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen datos por mostrar, porfavor agregar articulos en la seccion de agregar Articulos / Sistema", "SISTEMA", MessageBoxButtons.OK);
            }
          

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
            dataGridView1.DataSource = pers.TraerArticulos(textBox1.Text);
            dataGridView1.Columns[0].HeaderText = "Nombre del articulo";
            dataGridView1.Columns[1].HeaderText = "Precio";
            Lblsubtotal.Text = "";
            Lbliva.Text = "";
            Lbltotal.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var traerEmpleados = D.TraerArticulos(textBox1.Text);
            pictureBox1.Image = regs.ConvertirByte(traerEmpleados[dataGridView1.CurrentRow.Index].Imagen1);
            label3.Text = dataGridView1.CurrentRow.Cells["Cantidad1"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Verificar que no sobrepase el stock y pasarlo al carrito 
                if (double.Parse(txtCantidad.Text) > double.Parse(label3.Text))
                {
                    if (label3.Text == 0.ToString())
                    {
                       MessageBox.Show("El stock del producto es igual a cero, porfavor agregue más productos!","SISTEMA");
                    
                    }
                    else
                    {
                        
                        MessageBox.Show("Excede el limite de stock, debe ser inferior a " + label3.Text, "SISTEMA");
                    }                  
                }
                else
                {
                    string nom = dataGridView1.CurrentRow.Cells["Nombrearticulo1"].Value.ToString();
                    string prec = dataGridView1.CurrentRow.Cells["Precio1"].Value.ToString();
                    string med = dataGridView1.CurrentRow.Cells["Medida1"].Value.ToString();
                    string ClavSat = dataGridView1.CurrentRow.Cells["ClaveSat1"].Value.ToString();
                    string cant = txtCantidad.Text;
                    string id = dataGridView1.CurrentRow.Cells["Id1"].Value.ToString();
                    dataGridView2.Rows.Add(new[] { id,nom, prec, med, ClavSat, cant });
                    multi = double.Parse(prec) * double.Parse(cant);
                    suma = suma + multi;
                    iva = suma * .16;
                    total = suma + iva;
                    Lblsubtotal.Text = "$" + suma.ToString();
                    Lbliva.Text = "$" + iva.ToString();
                    Lbltotal.Text = "$" + total.ToString();
                    string cant2 = dataGridView1.CurrentRow.Cells["Cantidad1"].Value.ToString();
                    dataGridView1.CurrentRow.Cells["Cantidad1"].Value = double.Parse(cant2) - double.Parse(cant);
                    label3.Text = dataGridView1.CurrentRow.Cells["Cantidad1"].Value.ToString();
                    Lblsubtotal.Visible = true;
                    Lbliva.Visible = true;
                    Lbltotal.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No especifico cantidad ", ex.Message);

            }

        }

        private void Txtiva_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView2.Rows)
            {
                   string id;
                  string cant;
                  cant = row.Cells["Cantidad"].Value.ToString();
                  id = row.Cells["Id"].Value.ToString();
                  MessageBox.Show(cant + id);
                  pers.Actualiza_cantidad(int.Parse(id), decimal.Parse(cant));

            }
            CargarInfo();
            dataGridView2.Rows.Clear();
           MessageBox.Show("Venta realizada");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
