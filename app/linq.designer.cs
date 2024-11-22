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

namespace Hoang_Duc_Hung___Do_an_ki_thuat_lap_trinh
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLTP")]
	public partial class QLTPDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDichvu(Dichvu instance);
    partial void UpdateDichvu(Dichvu instance);
    partial void DeleteDichvu(Dichvu instance);
    partial void InsertKhach(Khach instance);
    partial void UpdateKhach(Khach instance);
    partial void DeleteKhach(Khach instance);
    partial void InsertPhong(Phong instance);
    partial void UpdatePhong(Phong instance);
    partial void DeletePhong(Phong instance);
    partial void InsertSDDV(SDDV instance);
    partial void UpdateSDDV(SDDV instance);
    partial void DeleteSDDV(SDDV instance);
    partial void InsertTaikhoan(Taikhoan instance);
    partial void UpdateTaikhoan(Taikhoan instance);
    partial void DeleteTaikhoan(Taikhoan instance);
    partial void InsertThueP(ThueP instance);
    partial void UpdateThueP(ThueP instance);
    partial void DeleteThueP(ThueP instance);
    #endregion
		
		public QLTPDataContext() : 
				base(global::Hoang_Duc_Hung___Do_an_ki_thuat_lap_trinh.Properties.Settings.Default.QLTPConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public QLTPDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLTPDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLTPDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLTPDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Dichvu> Dichvus
		{
			get
			{
				return this.GetTable<Dichvu>();
			}
		}
		
		public System.Data.Linq.Table<Khach> Khaches
		{
			get
			{
				return this.GetTable<Khach>();
			}
		}
		
		public System.Data.Linq.Table<Phong> Phongs
		{
			get
			{
				return this.GetTable<Phong>();
			}
		}
		
		public System.Data.Linq.Table<SDDV> SDDVs
		{
			get
			{
				return this.GetTable<SDDV>();
			}
		}
		
		public System.Data.Linq.Table<Taikhoan> Taikhoans
		{
			get
			{
				return this.GetTable<Taikhoan>();
			}
		}
		
		public System.Data.Linq.Table<ThueP> ThuePs
		{
			get
			{
				return this.GetTable<ThueP>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Dichvu")]
	public partial class Dichvu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDV;
		
		private string _TenDV;
		
		private double _GiaDV;
		
		private string _DVT;
		
		private EntitySet<SDDV> _SDDVs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDVChanging(string value);
    partial void OnMaDVChanged();
    partial void OnTenDVChanging(string value);
    partial void OnTenDVChanged();
    partial void OnGiaDVChanging(double value);
    partial void OnGiaDVChanged();
    partial void OnDVTChanging(string value);
    partial void OnDVTChanged();
    #endregion
		
		public Dichvu()
		{
			this._SDDVs = new EntitySet<SDDV>(new Action<SDDV>(this.attach_SDDVs), new Action<SDDV>(this.detach_SDDVs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDV", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDV
		{
			get
			{
				return this._MaDV;
			}
			set
			{
				if ((this._MaDV != value))
				{
					this.OnMaDVChanging(value);
					this.SendPropertyChanging();
					this._MaDV = value;
					this.SendPropertyChanged("MaDV");
					this.OnMaDVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDV", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenDV
		{
			get
			{
				return this._TenDV;
			}
			set
			{
				if ((this._TenDV != value))
				{
					this.OnTenDVChanging(value);
					this.SendPropertyChanging();
					this._TenDV = value;
					this.SendPropertyChanged("TenDV");
					this.OnTenDVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaDV", DbType="Float NOT NULL")]
		public double GiaDV
		{
			get
			{
				return this._GiaDV;
			}
			set
			{
				if ((this._GiaDV != value))
				{
					this.OnGiaDVChanging(value);
					this.SendPropertyChanging();
					this._GiaDV = value;
					this.SendPropertyChanged("GiaDV");
					this.OnGiaDVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DVT", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DVT
		{
			get
			{
				return this._DVT;
			}
			set
			{
				if ((this._DVT != value))
				{
					this.OnDVTChanging(value);
					this.SendPropertyChanging();
					this._DVT = value;
					this.SendPropertyChanged("DVT");
					this.OnDVTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dichvu_SDDV", Storage="_SDDVs", ThisKey="MaDV", OtherKey="MaDV")]
		public EntitySet<SDDV> SDDVs
		{
			get
			{
				return this._SDDVs;
			}
			set
			{
				this._SDDVs.Assign(value);
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
		
		private void attach_SDDVs(SDDV entity)
		{
			this.SendPropertyChanging();
			entity.Dichvu = this;
		}
		
		private void detach_SDDVs(SDDV entity)
		{
			this.SendPropertyChanging();
			entity.Dichvu = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Khach")]
	public partial class Khach : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CMT;
		
		private string _Hoten;
		
		private string _Diachi;
		
		private string _GT;
		
		private string _SDT;
		
		private EntitySet<SDDV> _SDDVs;
		
		private EntitySet<ThueP> _ThuePs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCMTChanging(string value);
    partial void OnCMTChanged();
    partial void OnHotenChanging(string value);
    partial void OnHotenChanged();
    partial void OnDiachiChanging(string value);
    partial void OnDiachiChanged();
    partial void OnGTChanging(string value);
    partial void OnGTChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    #endregion
		
		public Khach()
		{
			this._SDDVs = new EntitySet<SDDV>(new Action<SDDV>(this.attach_SDDVs), new Action<SDDV>(this.detach_SDDVs));
			this._ThuePs = new EntitySet<ThueP>(new Action<ThueP>(this.attach_ThuePs), new Action<ThueP>(this.detach_ThuePs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMT", DbType="NVarChar(12) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CMT
		{
			get
			{
				return this._CMT;
			}
			set
			{
				if ((this._CMT != value))
				{
					this.OnCMTChanging(value);
					this.SendPropertyChanging();
					this._CMT = value;
					this.SendPropertyChanged("CMT");
					this.OnCMTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hoten", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diachi", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GT", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string GT
		{
			get
			{
				return this._GT;
			}
			set
			{
				if ((this._GT != value))
				{
					this.OnGTChanging(value);
					this.SendPropertyChanging();
					this._GT = value;
					this.SendPropertyChanged("GT");
					this.OnGTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NVarChar(15)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Khach_SDDV", Storage="_SDDVs", ThisKey="CMT", OtherKey="CMT")]
		public EntitySet<SDDV> SDDVs
		{
			get
			{
				return this._SDDVs;
			}
			set
			{
				this._SDDVs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Khach_ThueP", Storage="_ThuePs", ThisKey="CMT", OtherKey="CMT")]
		public EntitySet<ThueP> ThuePs
		{
			get
			{
				return this._ThuePs;
			}
			set
			{
				this._ThuePs.Assign(value);
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
		
		private void attach_SDDVs(SDDV entity)
		{
			this.SendPropertyChanging();
			entity.Khach = this;
		}
		
		private void detach_SDDVs(SDDV entity)
		{
			this.SendPropertyChanging();
			entity.Khach = null;
		}
		
		private void attach_ThuePs(ThueP entity)
		{
			this.SendPropertyChanging();
			entity.Khach = this;
		}
		
		private void detach_ThuePs(ThueP entity)
		{
			this.SendPropertyChanging();
			entity.Khach = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Phong")]
	public partial class Phong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaP;
		
		private string _TenP;
		
		private string _LoaiP;
		
		private int _GiaP;
		
		private string _Tinhtrang;
		
		private EntitySet<SDDV> _SDDVs;
		
		private EntitySet<ThueP> _ThuePs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaPChanging(string value);
    partial void OnMaPChanged();
    partial void OnTenPChanging(string value);
    partial void OnTenPChanged();
    partial void OnLoaiPChanging(string value);
    partial void OnLoaiPChanged();
    partial void OnGiaPChanging(int value);
    partial void OnGiaPChanged();
    partial void OnTinhtrangChanging(string value);
    partial void OnTinhtrangChanged();
    #endregion
		
		public Phong()
		{
			this._SDDVs = new EntitySet<SDDV>(new Action<SDDV>(this.attach_SDDVs), new Action<SDDV>(this.detach_SDDVs));
			this._ThuePs = new EntitySet<ThueP>(new Action<ThueP>(this.attach_ThuePs), new Action<ThueP>(this.detach_ThuePs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaP", DbType="NVarChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaP
		{
			get
			{
				return this._MaP;
			}
			set
			{
				if ((this._MaP != value))
				{
					this.OnMaPChanging(value);
					this.SendPropertyChanging();
					this._MaP = value;
					this.SendPropertyChanged("MaP");
					this.OnMaPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenP", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string TenP
		{
			get
			{
				return this._TenP;
			}
			set
			{
				if ((this._TenP != value))
				{
					this.OnTenPChanging(value);
					this.SendPropertyChanging();
					this._TenP = value;
					this.SendPropertyChanged("TenP");
					this.OnTenPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiP", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string LoaiP
		{
			get
			{
				return this._LoaiP;
			}
			set
			{
				if ((this._LoaiP != value))
				{
					this.OnLoaiPChanging(value);
					this.SendPropertyChanging();
					this._LoaiP = value;
					this.SendPropertyChanged("LoaiP");
					this.OnLoaiPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaP", DbType="Int NOT NULL")]
		public int GiaP
		{
			get
			{
				return this._GiaP;
			}
			set
			{
				if ((this._GiaP != value))
				{
					this.OnGiaPChanging(value);
					this.SendPropertyChanging();
					this._GiaP = value;
					this.SendPropertyChanged("GiaP");
					this.OnGiaPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tinhtrang", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string Tinhtrang
		{
			get
			{
				return this._Tinhtrang;
			}
			set
			{
				if ((this._Tinhtrang != value))
				{
					this.OnTinhtrangChanging(value);
					this.SendPropertyChanging();
					this._Tinhtrang = value;
					this.SendPropertyChanged("Tinhtrang");
					this.OnTinhtrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_SDDV", Storage="_SDDVs", ThisKey="MaP", OtherKey="MaP")]
		public EntitySet<SDDV> SDDVs
		{
			get
			{
				return this._SDDVs;
			}
			set
			{
				this._SDDVs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_ThueP", Storage="_ThuePs", ThisKey="MaP", OtherKey="MaP")]
		public EntitySet<ThueP> ThuePs
		{
			get
			{
				return this._ThuePs;
			}
			set
			{
				this._ThuePs.Assign(value);
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
		
		private void attach_SDDVs(SDDV entity)
		{
			this.SendPropertyChanging();
			entity.Phong = this;
		}
		
		private void detach_SDDVs(SDDV entity)
		{
			this.SendPropertyChanging();
			entity.Phong = null;
		}
		
		private void attach_ThuePs(ThueP entity)
		{
			this.SendPropertyChanging();
			entity.Phong = this;
		}
		
		private void detach_ThuePs(ThueP entity)
		{
			this.SendPropertyChanging();
			entity.Phong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SDDV")]
	public partial class SDDV : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHDDV;
		
		private string _CMT;
		
		private string _MaDV;
		
		private int _Soluong;
		
		private System.DateTime _NgaySD;
		
		private string _MaP;
		
		private EntityRef<Dichvu> _Dichvu;
		
		private EntityRef<Khach> _Khach;
		
		private EntityRef<Phong> _Phong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDDVChanging(int value);
    partial void OnMaHDDVChanged();
    partial void OnCMTChanging(string value);
    partial void OnCMTChanged();
    partial void OnMaDVChanging(string value);
    partial void OnMaDVChanged();
    partial void OnSoluongChanging(int value);
    partial void OnSoluongChanged();
    partial void OnNgaySDChanging(System.DateTime value);
    partial void OnNgaySDChanged();
    partial void OnMaPChanging(string value);
    partial void OnMaPChanged();
    #endregion
		
		public SDDV()
		{
			this._Dichvu = default(EntityRef<Dichvu>);
			this._Khach = default(EntityRef<Khach>);
			this._Phong = default(EntityRef<Phong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHDDV", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHDDV
		{
			get
			{
				return this._MaHDDV;
			}
			set
			{
				if ((this._MaHDDV != value))
				{
					this.OnMaHDDVChanging(value);
					this.SendPropertyChanging();
					this._MaHDDV = value;
					this.SendPropertyChanged("MaHDDV");
					this.OnMaHDDVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMT", DbType="NVarChar(12) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CMT
		{
			get
			{
				return this._CMT;
			}
			set
			{
				if ((this._CMT != value))
				{
					if (this._Khach.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCMTChanging(value);
					this.SendPropertyChanging();
					this._CMT = value;
					this.SendPropertyChanged("CMT");
					this.OnCMTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDV", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDV
		{
			get
			{
				return this._MaDV;
			}
			set
			{
				if ((this._MaDV != value))
				{
					if (this._Dichvu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDVChanging(value);
					this.SendPropertyChanging();
					this._MaDV = value;
					this.SendPropertyChanged("MaDV");
					this.OnMaDVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluong", DbType="Int NOT NULL")]
		public int Soluong
		{
			get
			{
				return this._Soluong;
			}
			set
			{
				if ((this._Soluong != value))
				{
					this.OnSoluongChanging(value);
					this.SendPropertyChanging();
					this._Soluong = value;
					this.SendPropertyChanged("Soluong");
					this.OnSoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySD", DbType="Date NOT NULL")]
		public System.DateTime NgaySD
		{
			get
			{
				return this._NgaySD;
			}
			set
			{
				if ((this._NgaySD != value))
				{
					this.OnNgaySDChanging(value);
					this.SendPropertyChanging();
					this._NgaySD = value;
					this.SendPropertyChanged("NgaySD");
					this.OnNgaySDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaP", DbType="NVarChar(5)")]
		public string MaP
		{
			get
			{
				return this._MaP;
			}
			set
			{
				if ((this._MaP != value))
				{
					if (this._Phong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPChanging(value);
					this.SendPropertyChanging();
					this._MaP = value;
					this.SendPropertyChanged("MaP");
					this.OnMaPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dichvu_SDDV", Storage="_Dichvu", ThisKey="MaDV", OtherKey="MaDV", IsForeignKey=true)]
		public Dichvu Dichvu
		{
			get
			{
				return this._Dichvu.Entity;
			}
			set
			{
				Dichvu previousValue = this._Dichvu.Entity;
				if (((previousValue != value) 
							|| (this._Dichvu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Dichvu.Entity = null;
						previousValue.SDDVs.Remove(this);
					}
					this._Dichvu.Entity = value;
					if ((value != null))
					{
						value.SDDVs.Add(this);
						this._MaDV = value.MaDV;
					}
					else
					{
						this._MaDV = default(string);
					}
					this.SendPropertyChanged("Dichvu");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Khach_SDDV", Storage="_Khach", ThisKey="CMT", OtherKey="CMT", IsForeignKey=true)]
		public Khach Khach
		{
			get
			{
				return this._Khach.Entity;
			}
			set
			{
				Khach previousValue = this._Khach.Entity;
				if (((previousValue != value) 
							|| (this._Khach.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Khach.Entity = null;
						previousValue.SDDVs.Remove(this);
					}
					this._Khach.Entity = value;
					if ((value != null))
					{
						value.SDDVs.Add(this);
						this._CMT = value.CMT;
					}
					else
					{
						this._CMT = default(string);
					}
					this.SendPropertyChanged("Khach");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_SDDV", Storage="_Phong", ThisKey="MaP", OtherKey="MaP", IsForeignKey=true)]
		public Phong Phong
		{
			get
			{
				return this._Phong.Entity;
			}
			set
			{
				Phong previousValue = this._Phong.Entity;
				if (((previousValue != value) 
							|| (this._Phong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Phong.Entity = null;
						previousValue.SDDVs.Remove(this);
					}
					this._Phong.Entity = value;
					if ((value != null))
					{
						value.SDDVs.Add(this);
						this._MaP = value.MaP;
					}
					else
					{
						this._MaP = default(string);
					}
					this.SendPropertyChanged("Phong");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Taikhoan")]
	public partial class Taikhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Acc;
		
		private string _Pass;
		
		private string _TenND;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAccChanging(string value);
    partial void OnAccChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    partial void OnTenNDChanging(string value);
    partial void OnTenNDChanged();
    #endregion
		
		public Taikhoan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Acc", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Acc
		{
			get
			{
				return this._Acc;
			}
			set
			{
				if ((this._Acc != value))
				{
					this.OnAccChanging(value);
					this.SendPropertyChanging();
					this._Acc = value;
					this.SendPropertyChanged("Acc");
					this.OnAccChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenND", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenND
		{
			get
			{
				return this._TenND;
			}
			set
			{
				if ((this._TenND != value))
				{
					this.OnTenNDChanging(value);
					this.SendPropertyChanging();
					this._TenND = value;
					this.SendPropertyChanged("TenND");
					this.OnTenNDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ThueP")]
	public partial class ThueP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private string _CMT;
		
		private string _MaP;
		
		private System.DateTime _Ngayden;
		
		private System.Nullable<System.DateTime> _Ngaydi;
		
		private string _TenNV;
		
		private EntityRef<Khach> _Khach;
		
		private EntityRef<Phong> _Phong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnCMTChanging(string value);
    partial void OnCMTChanged();
    partial void OnMaPChanging(string value);
    partial void OnMaPChanged();
    partial void OnNgaydenChanging(System.DateTime value);
    partial void OnNgaydenChanged();
    partial void OnNgaydiChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaydiChanged();
    partial void OnTenNVChanging(string value);
    partial void OnTenNVChanged();
    #endregion
		
		public ThueP()
		{
			this._Khach = default(EntityRef<Khach>);
			this._Phong = default(EntityRef<Phong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMT", DbType="NVarChar(12) NOT NULL", CanBeNull=false)]
		public string CMT
		{
			get
			{
				return this._CMT;
			}
			set
			{
				if ((this._CMT != value))
				{
					if (this._Khach.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCMTChanging(value);
					this.SendPropertyChanging();
					this._CMT = value;
					this.SendPropertyChanged("CMT");
					this.OnCMTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaP", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string MaP
		{
			get
			{
				return this._MaP;
			}
			set
			{
				if ((this._MaP != value))
				{
					if (this._Phong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPChanging(value);
					this.SendPropertyChanging();
					this._MaP = value;
					this.SendPropertyChanged("MaP");
					this.OnMaPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngayden", DbType="Date NOT NULL")]
		public System.DateTime Ngayden
		{
			get
			{
				return this._Ngayden;
			}
			set
			{
				if ((this._Ngayden != value))
				{
					this.OnNgaydenChanging(value);
					this.SendPropertyChanging();
					this._Ngayden = value;
					this.SendPropertyChanged("Ngayden");
					this.OnNgaydenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaydi", DbType="Date")]
		public System.Nullable<System.DateTime> Ngaydi
		{
			get
			{
				return this._Ngaydi;
			}
			set
			{
				if ((this._Ngaydi != value))
				{
					this.OnNgaydiChanging(value);
					this.SendPropertyChanging();
					this._Ngaydi = value;
					this.SendPropertyChanged("Ngaydi");
					this.OnNgaydiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNV", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenNV
		{
			get
			{
				return this._TenNV;
			}
			set
			{
				if ((this._TenNV != value))
				{
					this.OnTenNVChanging(value);
					this.SendPropertyChanging();
					this._TenNV = value;
					this.SendPropertyChanged("TenNV");
					this.OnTenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Khach_ThueP", Storage="_Khach", ThisKey="CMT", OtherKey="CMT", IsForeignKey=true)]
		public Khach Khach
		{
			get
			{
				return this._Khach.Entity;
			}
			set
			{
				Khach previousValue = this._Khach.Entity;
				if (((previousValue != value) 
							|| (this._Khach.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Khach.Entity = null;
						previousValue.ThuePs.Remove(this);
					}
					this._Khach.Entity = value;
					if ((value != null))
					{
						value.ThuePs.Add(this);
						this._CMT = value.CMT;
					}
					else
					{
						this._CMT = default(string);
					}
					this.SendPropertyChanged("Khach");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_ThueP", Storage="_Phong", ThisKey="MaP", OtherKey="MaP", IsForeignKey=true)]
		public Phong Phong
		{
			get
			{
				return this._Phong.Entity;
			}
			set
			{
				Phong previousValue = this._Phong.Entity;
				if (((previousValue != value) 
							|| (this._Phong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Phong.Entity = null;
						previousValue.ThuePs.Remove(this);
					}
					this._Phong.Entity = value;
					if ((value != null))
					{
						value.ThuePs.Add(this);
						this._MaP = value.MaP;
					}
					else
					{
						this._MaP = default(string);
					}
					this.SendPropertyChanged("Phong");
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
