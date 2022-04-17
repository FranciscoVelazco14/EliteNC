using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Articulos
    {
        private string NombreArticulo;
        private string Precio;
        private string Medida;
        private string ClaveSat;
        private byte[] Imagen;


        public string NombreArticulo1 { get => NombreArticulo; set => NombreArticulo = value; }
        public string Precio1 { get => Precio; set => Precio = value; }
        public string Medida1 { get => Medida; set => Medida = value; }
        public string ClaveSat1 { get => ClaveSat; set => ClaveSat = value; }
        public byte[] Imagen1 { get => Imagen; set => Imagen = value; }
    }
}
