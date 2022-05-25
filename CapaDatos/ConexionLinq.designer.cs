﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Club")]
	public partial class ConexionLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertEmpleados(Empleados instance);
    partial void UpdateEmpleados(Empleados instance);
    partial void DeleteEmpleados(Empleados instance);
    #endregion
		
		public ConexionLinqDataContext() : 
				base(global::CapaDatos.Properties.Settings.Default.ClubConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Empleados> Empleados
		{
			get
			{
				return this.GetTable<Empleados>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EntrarLogin")]
		public ISingleResult<EntrarLoginResult> EntrarLogin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Usuario", DbType="VarChar(50)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Contraseña", DbType="VarChar(50)")] string contraseña, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, contraseña, id);
			return ((ISingleResult<EntrarLoginResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectEmpleados")]
		public ISingleResult<SelectEmpleadosResult> SelectEmpleados()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SelectEmpleadosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CrearEmpleado")]
		public int CrearEmpleado([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Contraseña", DbType="VarChar(50)")] string contraseña, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Foto", DbType="Image")] System.Data.Linq.Binary foto, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Tel", DbType="VarChar(50)")] string tel, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Direccion", DbType="VarChar(50)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Puesto", DbType="VarChar(50)")] string puesto, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Correo", DbType="VarChar(50)")] string correo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fecha", DbType="DateTime")] System.Nullable<System.DateTime> fecha)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, contraseña, foto, tel, direccion, puesto, correo, fecha);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CrearEmpleadoFacil")]
		public int CrearEmpleadoFacil([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Contraseña", DbType="VarChar(50)")] string contraseña)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, contraseña);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.TraeFrases")]
		public ISingleResult<TraeFrasesResult> TraeFrases()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<TraeFrasesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CrearArticulo")]
		public int CrearArticulo([global::System.Data.Linq.Mapping.ParameterAttribute(Name="V_Articulo", DbType="VarChar(50)")] string v_Articulo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="V_Precio", DbType="Decimal(18,2)")] System.Nullable<decimal> v_Precio, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="V_Impuesto", DbType="Decimal(18,2)")] System.Nullable<decimal> v_Impuesto, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="V_Medida", DbType="VarChar(50)")] string v_Medida, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="V_ClaveSAT", DbType="VarChar(50)")] string v_ClaveSAT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="V_Almacenable", DbType="VarChar(50)")] string v_Almacenable, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="V_Servicio", DbType="VarChar(50)")] string v_Servicio, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="V_Imagen", DbType="Image")] System.Data.Linq.Binary v_Imagen, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="V_Cantidad", DbType="Decimal(18,2)")] System.Nullable<decimal> v_Cantidad)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), v_Articulo, v_Precio, v_Impuesto, v_Medida, v_ClaveSAT, v_Almacenable, v_Servicio, v_Imagen, v_Cantidad);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.TraerArticulos")]
		public ISingleResult<TraerArticulosResult> TraerArticulos([global::System.Data.Linq.Mapping.ParameterAttribute(Name="V_Articulo", DbType="VarChar(50)")] string v_Articulo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), v_Articulo);
			return ((ISingleResult<TraerArticulosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Edita_articulos")]
		public int Edita_articulos([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_Articulo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Articulo", DbType="VarChar(50)")] string articulo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Precio", DbType="Decimal(18,2)")] System.Nullable<decimal> precio, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Medida", DbType="VarChar(50)")] string medida, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ClaveSAT", DbType="VarChar(50)")] string claveSAT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cantidad", DbType="Decimal(18,2)")] System.Nullable<decimal> cantidad)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_Articulo, articulo, precio, medida, claveSAT, cantidad);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminaArticulo")]
		public int EliminaArticulo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_Articulo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_Articulo);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Empleados")]
	public partial class Empleados : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdEmpleados;
		
		private string _Nombre;
		
		private string _Contraseña;
		
		private System.Data.Linq.Binary _Fotografia;
		
		private string _Telefono;
		
		private string _Direccion;
		
		private string _Puesto;
		
		private string _Correo;
		
		private System.Nullable<System.DateTime> _Fecha;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdEmpleadosChanging(int value);
    partial void OnIdEmpleadosChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnContraseñaChanging(string value);
    partial void OnContraseñaChanged();
    partial void OnFotografiaChanging(System.Data.Linq.Binary value);
    partial void OnFotografiaChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnPuestoChanging(string value);
    partial void OnPuestoChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    partial void OnFechaChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaChanged();
    #endregion
		
		public Empleados()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEmpleados", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdEmpleados
		{
			get
			{
				return this._IdEmpleados;
			}
			set
			{
				if ((this._IdEmpleados != value))
				{
					this.OnIdEmpleadosChanging(value);
					this.SendPropertyChanging();
					this._IdEmpleados = value;
					this.SendPropertyChanged("IdEmpleados");
					this.OnIdEmpleadosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Contraseña
		{
			get
			{
				return this._Contraseña;
			}
			set
			{
				if ((this._Contraseña != value))
				{
					this.OnContraseñaChanging(value);
					this.SendPropertyChanging();
					this._Contraseña = value;
					this.SendPropertyChanged("Contraseña");
					this.OnContraseñaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fotografia", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Fotografia
		{
			get
			{
				return this._Fotografia;
			}
			set
			{
				if ((this._Fotografia != value))
				{
					this.OnFotografiaChanging(value);
					this.SendPropertyChanging();
					this._Fotografia = value;
					this.SendPropertyChanged("Fotografia");
					this.OnFotografiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(50)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Puesto", DbType="VarChar(50)")]
		public string Puesto
		{
			get
			{
				return this._Puesto;
			}
			set
			{
				if ((this._Puesto != value))
				{
					this.OnPuestoChanging(value);
					this.SendPropertyChanging();
					this._Puesto = value;
					this.SendPropertyChanged("Puesto");
					this.OnPuestoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="VarChar(50)")]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this.OnFechaChanging(value);
					this.SendPropertyChanging();
					this._Fecha = value;
					this.SendPropertyChanged("Fecha");
					this.OnFechaChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class EntrarLoginResult
	{
		
		private int _IdEmpleados;
		
		private string _Nombre;
		
		private string _Contraseña;
		
		private System.Data.Linq.Binary _Fotografia;
		
		private string _Telefono;
		
		private string _Direccion;
		
		private string _Puesto;
		
		private string _Correo;
		
		private System.Nullable<System.DateTime> _Fecha;
		
		public EntrarLoginResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEmpleados", DbType="Int NOT NULL")]
		public int IdEmpleados
		{
			get
			{
				return this._IdEmpleados;
			}
			set
			{
				if ((this._IdEmpleados != value))
				{
					this._IdEmpleados = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Contraseña
		{
			get
			{
				return this._Contraseña;
			}
			set
			{
				if ((this._Contraseña != value))
				{
					this._Contraseña = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fotografia", DbType="Image")]
		public System.Data.Linq.Binary Fotografia
		{
			get
			{
				return this._Fotografia;
			}
			set
			{
				if ((this._Fotografia != value))
				{
					this._Fotografia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(50)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this._Telefono = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this._Direccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Puesto", DbType="VarChar(50)")]
		public string Puesto
		{
			get
			{
				return this._Puesto;
			}
			set
			{
				if ((this._Puesto != value))
				{
					this._Puesto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="VarChar(50)")]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this._Correo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this._Fecha = value;
				}
			}
		}
	}
	
	public partial class SelectEmpleadosResult
	{
		
		private int _IdEmpleados;
		
		private string _Nombre;
		
		private string _Contraseña;
		
		private System.Data.Linq.Binary _Fotografia;
		
		private string _Telefono;
		
		private string _Direccion;
		
		private string _Puesto;
		
		private string _Correo;
		
		private System.Nullable<System.DateTime> _Fecha;
		
		public SelectEmpleadosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEmpleados", DbType="Int NOT NULL")]
		public int IdEmpleados
		{
			get
			{
				return this._IdEmpleados;
			}
			set
			{
				if ((this._IdEmpleados != value))
				{
					this._IdEmpleados = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Contraseña
		{
			get
			{
				return this._Contraseña;
			}
			set
			{
				if ((this._Contraseña != value))
				{
					this._Contraseña = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fotografia", DbType="Image")]
		public System.Data.Linq.Binary Fotografia
		{
			get
			{
				return this._Fotografia;
			}
			set
			{
				if ((this._Fotografia != value))
				{
					this._Fotografia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(50)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this._Telefono = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this._Direccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Puesto", DbType="VarChar(50)")]
		public string Puesto
		{
			get
			{
				return this._Puesto;
			}
			set
			{
				if ((this._Puesto != value))
				{
					this._Puesto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="VarChar(50)")]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this._Correo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this._Fecha = value;
				}
			}
		}
	}
	
	public partial class TraeFrasesResult
	{
		
		private string _Frase;
		
		private string _Autor;
		
		public TraeFrasesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Frase", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Frase
		{
			get
			{
				return this._Frase;
			}
			set
			{
				if ((this._Frase != value))
				{
					this._Frase = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Autor", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Autor
		{
			get
			{
				return this._Autor;
			}
			set
			{
				if ((this._Autor != value))
				{
					this._Autor = value;
				}
			}
		}
	}
	
	public partial class TraerArticulosResult
	{
		
		private int _id_Articulo;
		
		private string _Articulo;
		
		private decimal _Precio;
		
		private decimal _Impuesto;
		
		private string _Medida;
		
		private string _ClaveSAT;
		
		private string _Almacenable;
		
		private string _Servicio;
		
		private System.Data.Linq.Binary _Imagen;
		
		private decimal _Cantidad;
		
		public TraerArticulosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_Articulo", DbType="Int NOT NULL")]
		public int id_Articulo
		{
			get
			{
				return this._id_Articulo;
			}
			set
			{
				if ((this._id_Articulo != value))
				{
					this._id_Articulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Articulo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Articulo
		{
			get
			{
				return this._Articulo;
			}
			set
			{
				if ((this._Articulo != value))
				{
					this._Articulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Decimal(18,2) NOT NULL")]
		public decimal Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this._Precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Impuesto", DbType="Decimal(18,2) NOT NULL")]
		public decimal Impuesto
		{
			get
			{
				return this._Impuesto;
			}
			set
			{
				if ((this._Impuesto != value))
				{
					this._Impuesto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Medida", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Medida
		{
			get
			{
				return this._Medida;
			}
			set
			{
				if ((this._Medida != value))
				{
					this._Medida = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClaveSAT", DbType="VarChar(50)")]
		public string ClaveSAT
		{
			get
			{
				return this._ClaveSAT;
			}
			set
			{
				if ((this._ClaveSAT != value))
				{
					this._ClaveSAT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Almacenable", DbType="VarChar(50)")]
		public string Almacenable
		{
			get
			{
				return this._Almacenable;
			}
			set
			{
				if ((this._Almacenable != value))
				{
					this._Almacenable = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Servicio", DbType="VarChar(50)")]
		public string Servicio
		{
			get
			{
				return this._Servicio;
			}
			set
			{
				if ((this._Servicio != value))
				{
					this._Servicio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imagen", DbType="Image")]
		public System.Data.Linq.Binary Imagen
		{
			get
			{
				return this._Imagen;
			}
			set
			{
				if ((this._Imagen != value))
				{
					this._Imagen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantidad", DbType="Decimal(18,2) NOT NULL")]
		public decimal Cantidad
		{
			get
			{
				return this._Cantidad;
			}
			set
			{
				if ((this._Cantidad != value))
				{
					this._Cantidad = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
