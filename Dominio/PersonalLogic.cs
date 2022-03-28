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
                               L_Contraseña = e.Contraseña
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
                L_Fecha = DateTime.Now

            };
           
            return Empleados.ToList();  
        }


        public void CrearEmpleados( string Nom, string Con, byte[] Foto, string Tel, string Dir, string Puesto, String Corr, DateTime Fecha)
        {
             L_Database.CrearEmpleado(Nom,Con,Foto,Tel,Dir,Puesto,Corr,Fecha);
             L_Database.SubmitChanges();
        }

        public void CrearEmpleadosFacilito()
        {
            L_Database.CrearEmpleadoFacil("Pruebas","F123123");
            L_Database.SubmitChanges();
        }
       
    }

}
