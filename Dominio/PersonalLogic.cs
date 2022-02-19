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
        public List<Personal> EntrarLogin(string U, String C)
        {
            ConexionLinqDataContext L_Database = new ConexionLinqDataContext();
            var Usuarios = from e in L_Database.EntrarLogin(U, C)
                           select new Personal
                           {
                               L_Usuario = e.usuario,
                               L_Contraseña = e.contraseña
                            };
            return Usuarios.ToList();
        }
       
    }
    
}
