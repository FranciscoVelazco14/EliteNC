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
    }


}
