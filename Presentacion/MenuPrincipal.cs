using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login Login_V = new Login();
            Login_V.Show();
        }





        private void PanelMenuLateralIzquierdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ModuloInventario_Click(object sender, EventArgs e)
        {

            MostrarSubMenus(PanelInventario);
        }
        private void PersonalizarDiseño()
        {
            PanelVentas.Visible = false;
            PanelInventario.Visible = false;
        }
        private void OcultarSubMenus()
        {
            if (PanelVentas.Visible == true)
            {
                PanelVentas.Visible = false;
            }
            if (PanelInventario.Visible == true)
            {
                PanelInventario.Visible = false;
            }
        }
        private void MostrarSubMenus(Panel SubMenus)
        {
            if (SubMenus.Visible == false) 
            {
                OcultarSubMenus();
                SubMenus.Visible = true;
            }
            else
            {
                SubMenus.Visible = false;
            }
        }

        private void ModuloVentas_Click(object sender, EventArgs e)
        {

            MostrarSubMenus(PanelVentas);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            FormulariosHijos(new Ventas());
            ///

            OcultarSubMenus();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            OcultarSubMenus();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            OcultarSubMenus();
        }

        private void button16_Click(object sender, EventArgs e)
        {

            OcultarSubMenus();
        }

        private void button15_Click(object sender, EventArgs e)
        {

            OcultarSubMenus();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            OcultarSubMenus();
        }

        private Form FormularioActivo = null;
        private void FormulariosHijos(Form FormularioHijo)
        {
            if (FormularioActivo != null) 
            {
                FormularioActivo.Close();
            }
            FormularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            PanelFormularios.Controls.Add(FormularioHijo);
            PanelFormularios.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
