using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.IO;


namespace Dominio
{
    public class PersonalLogic
    {

        ConexionLinqDataContext L_Database = new ConexionLinqDataContext();
        public List<Personal> EntrarLogin(string U, string C,int ID)
        {
            var Usuarios = from e in L_Database.EntrarLogin(U, C, ID)
                           select new Personal
                           {
                               L_Usuario = e.Nombre,
                               L_Contraseña = e.Contraseña,
                               L_Imagen = e.Fotografia.ToArray(),
                               L_Fecha = (DateTime)e.Fecha,
                               L_Puesto = e.Puesto
                               
                            };
            return Usuarios.ToList();
        }
        public List<Personal> SelectEmpleados()
        {
            var Empleados = from E in L_Database.SelectEmpleados() select new Personal
            {
                L_Usuario = E.Nombre,
                L_Contraseña = E.Contraseña,
                // L_Fecha = (DateTime)E.Fecha,
                L_ID = E.IdEmpleados,
                L_Puesto = E.Puesto,
                L_Imagen =  E.Fotografia.ToArray(),
                L_Telefono = E.Telefono,
                L_Direccion = E.Direccion,
                L_Correo = E.Correo,
                L_Fecha = (DateTime)E.Fecha

            };
            return Empleados.ToList();  
        }


        public void CrearEmpleados( string Nom, string Con, byte[] Foto, string Tel, string Dir, string Puesto, String Corr, DateTime Fecha)
        {
             L_Database.CrearEmpleado(Nom,Con,Foto,Tel,Dir,Puesto,Corr,Fecha);
             L_Database.SubmitChanges();
        }

       
        public List<Personal> TraerFrases()
        {
            var Consulta = from e in L_Database.TraeFrases()
                           select new Personal
                           {
                               L_Frase = e.Frase,
                               L_Autor = e.Autor
                           };
                            
            return Consulta.ToList();
        }

        public List<Articulos> TraerArticulos(string V_Articulo)
        {
            var Consulta = from e in L_Database.TraerArticulos(V_Articulo)
                           select new Articulos
                           {
                               NombreArticulo1 = e.Articulo,
                               Precio1 = e.Precio.ToString(),
                               Medida1 = e.Medida,
                               ClaveSat1 = e.ClaveSAT,
                               Imagen1 = e.Imagen.ToArray(),
                               Cantidad1 = e.Cantidad.ToString()
                               
                           };

            return Consulta.ToList();
        }
        public void CrearArticulos(string Art, decimal Pre,decimal imp, string med ,string claSAT,string alm,string ser, byte[] Foto,decimal cant)
        {
            L_Database.CrearArticulo(Art, Pre,imp , med, claSAT, alm, ser, Foto,cant);
            L_Database.SubmitChanges();
        }

    }

}
