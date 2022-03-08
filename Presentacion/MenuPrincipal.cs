using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            PersonalizarDiseño();
           /* this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;*/
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            PersonalLogic Pers = new PersonalLogic();
           // var TraeUsuarios = Pers.EntrarLogin("Cristian", "C123");
            //InformacionUsuario.Text += TraeUsuarios[0].L_Usuario;
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
            PanelConfiguracion.Visible = false;
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
            if (PanelConfiguracion.Visible==true)
            {
                PanelConfiguracion.Visible = false;
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
        public void FormulariosHijos(Form FormularioHijo)
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


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelInformacion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas segur@ que quieres cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Configuracion_Click(object sender, EventArgs e)
        {

            MostrarSubMenus(PanelConfiguracion);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
