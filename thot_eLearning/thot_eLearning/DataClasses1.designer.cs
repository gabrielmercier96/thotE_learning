﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace thot_eLearning
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataBaseSchool")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertetudiant(etudiant instance);
    partial void Updateetudiant(etudiant instance);
    partial void Deleteetudiant(etudiant instance);
    partial void Insertconnection(connection instance);
    partial void Updateconnection(connection instance);
    partial void Deleteconnection(connection instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseSchoolConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<etudiant> etudiants
		{
			get
			{
				return this.GetTable<etudiant>();
			}
		}
		
		public System.Data.Linq.Table<connection> connections
		{
			get
			{
				return this.GetTable<connection>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.etudiant")]
	public partial class etudiant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _nom;
		
		private string _prenom;
		
		private string _email;
		
		private string _education;
		
		private EntityRef<connection> _connection;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    partial void OnprenomChanging(string value);
    partial void OnprenomChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OneducationChanging(string value);
    partial void OneducationChanged();
    #endregion
		
		public etudiant()
		{
			this._connection = default(EntityRef<connection>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="VarChar(50)")]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prenom", DbType="VarChar(50)")]
		public string prenom
		{
			get
			{
				return this._prenom;
			}
			set
			{
				if ((this._prenom != value))
				{
					this.OnprenomChanging(value);
					this.SendPropertyChanging();
					this._prenom = value;
					this.SendPropertyChanged("prenom");
					this.OnprenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_education", DbType="VarChar(50)")]
		public string education
		{
			get
			{
				return this._education;
			}
			set
			{
				if ((this._education != value))
				{
					this.OneducationChanging(value);
					this.SendPropertyChanging();
					this._education = value;
					this.SendPropertyChanged("education");
					this.OneducationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="etudiant_connection", Storage="_connection", ThisKey="Id", OtherKey="Idetudiant", IsUnique=true, IsForeignKey=false)]
		public connection connection
		{
			get
			{
				return this._connection.Entity;
			}
			set
			{
				connection previousValue = this._connection.Entity;
				if (((previousValue != value) 
							|| (this._connection.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._connection.Entity = null;
						previousValue.etudiant = null;
					}
					this._connection.Entity = value;
					if ((value != null))
					{
						value.etudiant = this;
					}
					this.SendPropertyChanged("connection");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.connections")]
	public partial class connection : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Idetudiant;
		
		private string _user;
		
		private string _password;
		
		private EntityRef<etudiant> _etudiant;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdetudiantChanging(string value);
    partial void OnIdetudiantChanged();
    partial void OnuserChanging(string value);
    partial void OnuserChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public connection()
		{
			this._etudiant = default(EntityRef<etudiant>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Idetudiant", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Idetudiant
		{
			get
			{
				return this._Idetudiant;
			}
			set
			{
				if ((this._Idetudiant != value))
				{
					if (this._etudiant.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdetudiantChanging(value);
					this.SendPropertyChanging();
					this._Idetudiant = value;
					this.SendPropertyChanged("Idetudiant");
					this.OnIdetudiantChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[user]", Storage="_user", DbType="VarChar(50)")]
		public string user
		{
			get
			{
				return this._user;
			}
			set
			{
				if ((this._user != value))
				{
					this.OnuserChanging(value);
					this.SendPropertyChanging();
					this._user = value;
					this.SendPropertyChanged("user");
					this.OnuserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="etudiant_connection", Storage="_etudiant", ThisKey="Idetudiant", OtherKey="Id", IsForeignKey=true)]
		public etudiant etudiant
		{
			get
			{
				return this._etudiant.Entity;
			}
			set
			{
				etudiant previousValue = this._etudiant.Entity;
				if (((previousValue != value) 
							|| (this._etudiant.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._etudiant.Entity = null;
						previousValue.connection = null;
					}
					this._etudiant.Entity = value;
					if ((value != null))
					{
						value.connection = this;
						this._Idetudiant = value.Id;
					}
					else
					{
						this._Idetudiant = default(string);
					}
					this.SendPropertyChanged("etudiant");
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
}
#pragma warning restore 1591
