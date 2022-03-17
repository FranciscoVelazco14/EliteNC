﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class Personal
    {
        private string Usuario;
        private string Contraseña;
        private System.Data.Linq.Binary Imagen;
        private int ID;
        private string Tel;
        private string Direccion;
        private string Puesto;
        private string Correo;
        private DateTime Fecha;

        public int L_ID
        {
            get { return this.ID; }
            set { this.ID = value; }
        }
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

        public System.Data.Linq.Binary L_Imagen
        {
            get { return this.Imagen; }
            set { this.Imagen = value; }
        }
        public string L_Telefono
        {
            get { return this.Tel; }
            set { this.Tel = value; }
        }

        public string L_Direccion
        {
            get { return this.Direccion; }
            set { this.Direccion = value; }
        }
        public string L_Puesto
        {
            get { return this.Puesto; }
            set { this.Puesto = value; }
        }
        public string L_Correo
        {
            get { return this.Correo; }
            set { this.Correo = value; }
        }
        public DateTime L_Fecha
        {
            get { return this.Fecha; }
            set { this.Fecha = value; }
        }
        
        
    }


}
