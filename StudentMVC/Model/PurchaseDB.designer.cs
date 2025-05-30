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

namespace StudentMVC.Model
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Purchasedb")]
	public partial class PurchaseDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_Customer(tbl_Customer instance);
    partial void Updatetbl_Customer(tbl_Customer instance);
    partial void Deletetbl_Customer(tbl_Customer instance);
    partial void Inserttbl_PurchaseDetail(tbl_PurchaseDetail instance);
    partial void Updatetbl_PurchaseDetail(tbl_PurchaseDetail instance);
    partial void Deletetbl_PurchaseDetail(tbl_PurchaseDetail instance);
    partial void Inserttbl_PurchaseHeader(tbl_PurchaseHeader instance);
    partial void Updatetbl_PurchaseHeader(tbl_PurchaseHeader instance);
    partial void Deletetbl_PurchaseHeader(tbl_PurchaseHeader instance);
    #endregion
		
		public PurchaseDBDataContext() : 
				base(global::StudentMVC.Properties.Settings.Default.PurchasedbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PurchaseDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PurchaseDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PurchaseDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PurchaseDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_Customer> tbl_Customers
		{
			get
			{
				return this.GetTable<tbl_Customer>();
			}
		}
		
		public System.Data.Linq.Table<tbl_PurchaseDetail> tbl_PurchaseDetails
		{
			get
			{
				return this.GetTable<tbl_PurchaseDetail>();
			}
		}
		
		public System.Data.Linq.Table<tbl_PurchaseHeader> tbl_PurchaseHeaders
		{
			get
			{
				return this.GetTable<tbl_PurchaseHeader>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Customer")]
	public partial class tbl_Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _CustomerID;
		
		private string _CustomerName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(System.Guid value);
    partial void OnCustomerIDChanged();
    partial void OnCustomerNameChanging(string value);
    partial void OnCustomerNameChanged();
    #endregion
		
		public tbl_Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this.OnCustomerNameChanging(value);
					this.SendPropertyChanging();
					this._CustomerName = value;
					this.SendPropertyChanged("CustomerName");
					this.OnCustomerNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_PurchaseDetail")]
	public partial class tbl_PurchaseDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _PurchaseDetailID;
		
		private System.Guid _PurchaseHeaderID;
		
		private string _Detail;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPurchaseDetailIDChanging(System.Guid value);
    partial void OnPurchaseDetailIDChanged();
    partial void OnPurchaseHeaderIDChanging(System.Guid value);
    partial void OnPurchaseHeaderIDChanged();
    partial void OnDetailChanging(string value);
    partial void OnDetailChanged();
    #endregion
		
		public tbl_PurchaseDetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseDetailID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid PurchaseDetailID
		{
			get
			{
				return this._PurchaseDetailID;
			}
			set
			{
				if ((this._PurchaseDetailID != value))
				{
					this.OnPurchaseDetailIDChanging(value);
					this.SendPropertyChanging();
					this._PurchaseDetailID = value;
					this.SendPropertyChanged("PurchaseDetailID");
					this.OnPurchaseDetailIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseHeaderID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid PurchaseHeaderID
		{
			get
			{
				return this._PurchaseHeaderID;
			}
			set
			{
				if ((this._PurchaseHeaderID != value))
				{
					this.OnPurchaseHeaderIDChanging(value);
					this.SendPropertyChanging();
					this._PurchaseHeaderID = value;
					this.SendPropertyChanged("PurchaseHeaderID");
					this.OnPurchaseHeaderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Detail", DbType="VarChar(300) NOT NULL", CanBeNull=false)]
		public string Detail
		{
			get
			{
				return this._Detail;
			}
			set
			{
				if ((this._Detail != value))
				{
					this.OnDetailChanging(value);
					this.SendPropertyChanging();
					this._Detail = value;
					this.SendPropertyChanged("Detail");
					this.OnDetailChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_PurchaseHeader")]
	public partial class tbl_PurchaseHeader : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _PurchaseHeaderID;
		
		private System.Guid _CustomerID;
		
		private string _Description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPurchaseHeaderIDChanging(System.Guid value);
    partial void OnPurchaseHeaderIDChanged();
    partial void OnCustomerIDChanging(System.Guid value);
    partial void OnCustomerIDChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public tbl_PurchaseHeader()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseHeaderID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid PurchaseHeaderID
		{
			get
			{
				return this._PurchaseHeaderID;
			}
			set
			{
				if ((this._PurchaseHeaderID != value))
				{
					this.OnPurchaseHeaderIDChanging(value);
					this.SendPropertyChanging();
					this._PurchaseHeaderID = value;
					this.SendPropertyChanged("PurchaseHeaderID");
					this.OnPurchaseHeaderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(300)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
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
