using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Ventas
    {
        private string VV_Producto;
        private float VV_Precio;
        public string V_Producto
        {
            get { return this.VV_Producto; }
            set { this.VV_Producto = value; }
        }
        public float V_Precio
        {
            get { return this.VV_Precio; }
            set { this.VV_Precio = value; }
        }
    }
}
