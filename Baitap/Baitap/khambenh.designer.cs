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

namespace Baitap
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="baitap")]
	public partial class khambenhDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBacsi(Bacsi instance);
    partial void UpdateBacsi(Bacsi instance);
    partial void DeleteBacsi(Bacsi instance);
    partial void Insertkhambenh(khambenh instance);
    partial void Updatekhambenh(khambenh instance);
    partial void Deletekhambenh(khambenh instance);
    partial void Insertbenhnhan(benhnhan instance);
    partial void Updatebenhnhan(benhnhan instance);
    partial void Deletebenhnhan(benhnhan instance);
    #endregion
		
		public khambenhDataContext() : 
				base(global::Baitap.Properties.Settings.Default.baitapConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public khambenhDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public khambenhDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public khambenhDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public khambenhDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Bacsi> Bacsis
		{
			get
			{
				return this.GetTable<Bacsi>();
			}
		}
		
		public System.Data.Linq.Table<khambenh> khambenhs
		{
			get
			{
				return this.GetTable<khambenh>();
			}
		}
		
		public System.Data.Linq.Table<benhnhan> benhnhans
		{
			get
			{
				return this.GetTable<benhnhan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bacsi")]
	public partial class Bacsi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Mabs;
		
		private string _hotenbacsi;
		
		private EntitySet<khambenh> _khambenhs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMabsChanging(string value);
    partial void OnMabsChanged();
    partial void OnhotenbacsiChanging(string value);
    partial void OnhotenbacsiChanged();
    #endregion
		
		public Bacsi()
		{
			this._khambenhs = new EntitySet<khambenh>(new Action<khambenh>(this.attach_khambenhs), new Action<khambenh>(this.detach_khambenhs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mabs", DbType="VarChar(25) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Mabs
		{
			get
			{
				return this._Mabs;
			}
			set
			{
				if ((this._Mabs != value))
				{
					this.OnMabsChanging(value);
					this.SendPropertyChanging();
					this._Mabs = value;
					this.SendPropertyChanged("Mabs");
					this.OnMabsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hotenbacsi", DbType="VarChar(150)")]
		public string hotenbacsi
		{
			get
			{
				return this._hotenbacsi;
			}
			set
			{
				if ((this._hotenbacsi != value))
				{
					this.OnhotenbacsiChanging(value);
					this.SendPropertyChanging();
					this._hotenbacsi = value;
					this.SendPropertyChanged("hotenbacsi");
					this.OnhotenbacsiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bacsi_khambenh", Storage="_khambenhs", ThisKey="Mabs", OtherKey="Mabs")]
		public EntitySet<khambenh> khambenhs
		{
			get
			{
				return this._khambenhs;
			}
			set
			{
				this._khambenhs.Assign(value);
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
		
		private void attach_khambenhs(khambenh entity)
		{
			this.SendPropertyChanging();
			entity.Bacsi = this;
		}
		
		private void detach_khambenhs(khambenh entity)
		{
			this.SendPropertyChanging();
			entity.Bacsi = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.khambenh")]
	public partial class khambenh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MSBN;
		
		private string _Mabs;
		
		private System.Nullable<System.DateTime> _ngaykham;
		
		private string _ghichu;
		
		private EntityRef<Bacsi> _Bacsi;
		
		private EntityRef<benhnhan> _benhnhan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMSBNChanging(string value);
    partial void OnMSBNChanged();
    partial void OnMabsChanging(string value);
    partial void OnMabsChanged();
    partial void OnngaykhamChanging(System.Nullable<System.DateTime> value);
    partial void OnngaykhamChanged();
    partial void OnghichuChanging(string value);
    partial void OnghichuChanged();
    #endregion
		
		public khambenh()
		{
			this._Bacsi = default(EntityRef<Bacsi>);
			this._benhnhan = default(EntityRef<benhnhan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MSBN", DbType="VarChar(15) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MSBN
		{
			get
			{
				return this._MSBN;
			}
			set
			{
				if ((this._MSBN != value))
				{
					if (this._benhnhan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMSBNChanging(value);
					this.SendPropertyChanging();
					this._MSBN = value;
					this.SendPropertyChanged("MSBN");
					this.OnMSBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mabs", DbType="VarChar(25)")]
		public string Mabs
		{
			get
			{
				return this._Mabs;
			}
			set
			{
				if ((this._Mabs != value))
				{
					if (this._Bacsi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMabsChanging(value);
					this.SendPropertyChanging();
					this._Mabs = value;
					this.SendPropertyChanged("Mabs");
					this.OnMabsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaykham", DbType="Date")]
		public System.Nullable<System.DateTime> ngaykham
		{
			get
			{
				return this._ngaykham;
			}
			set
			{
				if ((this._ngaykham != value))
				{
					this.OnngaykhamChanging(value);
					this.SendPropertyChanging();
					this._ngaykham = value;
					this.SendPropertyChanged("ngaykham");
					this.OnngaykhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ghichu", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string ghichu
		{
			get
			{
				return this._ghichu;
			}
			set
			{
				if ((this._ghichu != value))
				{
					this.OnghichuChanging(value);
					this.SendPropertyChanging();
					this._ghichu = value;
					this.SendPropertyChanged("ghichu");
					this.OnghichuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bacsi_khambenh", Storage="_Bacsi", ThisKey="Mabs", OtherKey="Mabs", IsForeignKey=true)]
		public Bacsi Bacsi
		{
			get
			{
				return this._Bacsi.Entity;
			}
			set
			{
				Bacsi previousValue = this._Bacsi.Entity;
				if (((previousValue != value) 
							|| (this._Bacsi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Bacsi.Entity = null;
						previousValue.khambenhs.Remove(this);
					}
					this._Bacsi.Entity = value;
					if ((value != null))
					{
						value.khambenhs.Add(this);
						this._Mabs = value.Mabs;
					}
					else
					{
						this._Mabs = default(string);
					}
					this.SendPropertyChanged("Bacsi");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="benhnhan_khambenh", Storage="_benhnhan", ThisKey="MSBN", OtherKey="MSBN", IsForeignKey=true)]
		public benhnhan benhnhan
		{
			get
			{
				return this._benhnhan.Entity;
			}
			set
			{
				benhnhan previousValue = this._benhnhan.Entity;
				if (((previousValue != value) 
							|| (this._benhnhan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._benhnhan.Entity = null;
						previousValue.khambenh = null;
					}
					this._benhnhan.Entity = value;
					if ((value != null))
					{
						value.khambenh = this;
						this._MSBN = value.MSBN;
					}
					else
					{
						this._MSBN = default(string);
					}
					this.SendPropertyChanged("benhnhan");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.benhnhan")]
	public partial class benhnhan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MSBN;
		
		private string _SoCmnd;
		
		private string _Hoten;
		
		private string _Diachi;
		
		private EntityRef<khambenh> _khambenh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMSBNChanging(string value);
    partial void OnMSBNChanged();
    partial void OnSoCmndChanging(string value);
    partial void OnSoCmndChanged();
    partial void OnHotenChanging(string value);
    partial void OnHotenChanged();
    partial void OnDiachiChanging(string value);
    partial void OnDiachiChanged();
    #endregion
		
		public benhnhan()
		{
			this._khambenh = default(EntityRef<khambenh>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MSBN", DbType="VarChar(15) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MSBN
		{
			get
			{
				return this._MSBN;
			}
			set
			{
				if ((this._MSBN != value))
				{
					this.OnMSBNChanging(value);
					this.SendPropertyChanging();
					this._MSBN = value;
					this.SendPropertyChanged("MSBN");
					this.OnMSBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoCmnd", DbType="VarChar(25)")]
		public string SoCmnd
		{
			get
			{
				return this._SoCmnd;
			}
			set
			{
				if ((this._SoCmnd != value))
				{
					this.OnSoCmndChanging(value);
					this.SendPropertyChanging();
					this._SoCmnd = value;
					this.SendPropertyChanged("SoCmnd");
					this.OnSoCmndChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hoten", DbType="VarChar(150)")]
		public string Hoten
		{
			get
			{
				return this._Hoten;
			}
			set
			{
				if ((this._Hoten != value))
				{
					this.OnHotenChanging(value);
					this.SendPropertyChanging();
					this._Hoten = value;
					this.SendPropertyChanged("Hoten");
					this.OnHotenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diachi", DbType="VarChar(250)")]
		public string Diachi
		{
			get
			{
				return this._Diachi;
			}
			set
			{
				if ((this._Diachi != value))
				{
					this.OnDiachiChanging(value);
					this.SendPropertyChanging();
					this._Diachi = value;
					this.SendPropertyChanged("Diachi");
					this.OnDiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="benhnhan_khambenh", Storage="_khambenh", ThisKey="MSBN", OtherKey="MSBN", IsUnique=true, IsForeignKey=false)]
		public khambenh khambenh
		{
			get
			{
				return this._khambenh.Entity;
			}
			set
			{
				khambenh previousValue = this._khambenh.Entity;
				if (((previousValue != value) 
							|| (this._khambenh.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._khambenh.Entity = null;
						previousValue.benhnhan = null;
					}
					this._khambenh.Entity = value;
					if ((value != null))
					{
						value.benhnhan = this;
					}
					this.SendPropertyChanged("khambenh");
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
