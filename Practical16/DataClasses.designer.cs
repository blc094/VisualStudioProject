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

namespace _19012011094_Practical16
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="crudrg")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMyData(MyData instance);
    partial void UpdateMyData(MyData instance);
    partial void DeleteMyData(MyData instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["crudrgConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MyData> MyDatas
		{
			get
			{
				return this.GetTable<MyData>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MyData")]
	public partial class MyData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RollNumber;
		
		private string _StudentName;
		
		private string _FatherName;
		
		private string _MotherName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRollNumberChanging(int value);
    partial void OnRollNumberChanged();
    partial void OnStudentNameChanging(string value);
    partial void OnStudentNameChanged();
    partial void OnFatherNameChanging(string value);
    partial void OnFatherNameChanged();
    partial void OnMotherNameChanging(string value);
    partial void OnMotherNameChanged();
    #endregion
		
		public MyData()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RollNumber", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RollNumber
		{
			get
			{
				return this._RollNumber;
			}
			set
			{
				if ((this._RollNumber != value))
				{
					this.OnRollNumberChanging(value);
					this.SendPropertyChanging();
					this._RollNumber = value;
					this.SendPropertyChanged("RollNumber");
					this.OnRollNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentName", DbType="NVarChar(50)")]
		public string StudentName
		{
			get
			{
				return this._StudentName;
			}
			set
			{
				if ((this._StudentName != value))
				{
					this.OnStudentNameChanging(value);
					this.SendPropertyChanging();
					this._StudentName = value;
					this.SendPropertyChanged("StudentName");
					this.OnStudentNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FatherName", DbType="NVarChar(50)")]
		public string FatherName
		{
			get
			{
				return this._FatherName;
			}
			set
			{
				if ((this._FatherName != value))
				{
					this.OnFatherNameChanging(value);
					this.SendPropertyChanging();
					this._FatherName = value;
					this.SendPropertyChanged("FatherName");
					this.OnFatherNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotherName", DbType="NVarChar(50)")]
		public string MotherName
		{
			get
			{
				return this._MotherName;
			}
			set
			{
				if ((this._MotherName != value))
				{
					this.OnMotherNameChanging(value);
					this.SendPropertyChanging();
					this._MotherName = value;
					this.SendPropertyChanged("MotherName");
					this.OnMotherNameChanged();
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
