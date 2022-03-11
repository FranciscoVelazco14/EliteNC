using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace Dominio
{
    public class PersonalLogic
    {

        ConexionLinqDataContext L_Database = new ConexionLinqDataContext();
        public List<Personal> EntrarLogin(string U, string C)
        {
            var Usuarios = from e in L_Database.EntrarLogin(U, C)
                           select new Personal
                           {
                               L_Usuario = e.usuario,
                               L_Contraseña = e.contraseña,
                               L_Fecha = (DateTime)e.fecha
                            };
            return Usuarios.ToList();
        }

        public List<Personal> SelectEmpleados()
        {
            var Empleados = from E in L_Database.SelectEmpleados() select new Personal
            {
                L_Usuario = E.usuario,
                L_Contraseña = E.contraseña,
                L_Fecha = (DateTime)E.fecha
            };
           
            return Empleados.ToList();  
        }
       
    }
    
}
