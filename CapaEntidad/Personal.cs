using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class Personal
    {
        private string Usuario;
        private string Contraseña;
        private string Imagen;
        private DateTime Fecha;

        public string L_Usuario
        {
            get{ return this.Usuario; }
            set { this.Usuario = value; }
        }
        public string L_Contraseña
        {
            get { return this.Contraseña; }
            set { this.Contraseña = value; }
        }

        public string L_Imagen
        {
            get { return this.Imagen; }
            set { this.Imagen = value; }
        }

        public DateTime L_Fecha
        {
            get { return this.Fecha; }
            set { this.Fecha = value; }
        }
    }


}
