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

namespace CovidPatientManager.DTO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CovidPatientManagerDTB")]
	public partial class CovidPatientManagerDTBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDiaDiemDieuTri(DiaDiemDieuTri instance);
    partial void UpdateDiaDiemDieuTri(DiaDiemDieuTri instance);
    partial void DeleteDiaDiemDieuTri(DiaDiemDieuTri instance);
    partial void InsertBenhNhan(BenhNhan instance);
    partial void UpdateBenhNhan(BenhNhan instance);
    partial void DeleteBenhNhan(BenhNhan instance);
    #endregion
		
		public CovidPatientManagerDTBDataContext() : 
				base(global::CovidPatientManager.Properties.Settings.Default.CovidPatientManagerDTBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CovidPatientManagerDTBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CovidPatientManagerDTBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CovidPatientManagerDTBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CovidPatientManagerDTBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DiaDiemDieuTri> DiaDiemDieuTris
		{
			get
			{
				return this.GetTable<DiaDiemDieuTri>();
			}
		}
		
		public System.Data.Linq.Table<BenhNhan> BenhNhans
		{
			get
			{
				return this.GetTable<BenhNhan>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DiaDiemDieuTri")]
	public partial class DiaDiemDieuTri : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDDiaDiemDieuTri;
		
		private string _TenDiemDieuTri;
		
		private string _SucChua;
		
		private string _HienTai;
		
		private EntitySet<BenhNhan> _BenhNhans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDDiaDiemDieuTriChanging(string value);
    partial void OnIDDiaDiemDieuTriChanged();
    partial void OnTenDiemDieuTriChanging(string value);
    partial void OnTenDiemDieuTriChanged();
    partial void OnSucChuaChanging(string value);
    partial void OnSucChuaChanged();
    partial void OnHienTaiChanging(string value);
    partial void OnHienTaiChanged();
    #endregion
		
		public DiaDiemDieuTri()
		{
			this._BenhNhans = new EntitySet<BenhNhan>(new Action<BenhNhan>(this.attach_BenhNhans), new Action<BenhNhan>(this.detach_BenhNhans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDiaDiemDieuTri", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDDiaDiemDieuTri
		{
			get
			{
				return this._IDDiaDiemDieuTri;
			}
			set
			{
				if ((this._IDDiaDiemDieuTri != value))
				{
					this.OnIDDiaDiemDieuTriChanging(value);
					this.SendPropertyChanging();
					this._IDDiaDiemDieuTri = value;
					this.SendPropertyChanged("IDDiaDiemDieuTri");
					this.OnIDDiaDiemDieuTriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDiemDieuTri", DbType="NVarChar(200)")]
		public string TenDiemDieuTri
		{
			get
			{
				return this._TenDiemDieuTri;
			}
			set
			{
				if ((this._TenDiemDieuTri != value))
				{
					this.OnTenDiemDieuTriChanging(value);
					this.SendPropertyChanging();
					this._TenDiemDieuTri = value;
					this.SendPropertyChanged("TenDiemDieuTri");
					this.OnTenDiemDieuTriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SucChua", DbType="NVarChar(10)")]
		public string SucChua
		{
			get
			{
				return this._SucChua;
			}
			set
			{
				if ((this._SucChua != value))
				{
					this.OnSucChuaChanging(value);
					this.SendPropertyChanging();
					this._SucChua = value;
					this.SendPropertyChanged("SucChua");
					this.OnSucChuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HienTai", DbType="NVarChar(10)")]
		public string HienTai
		{
			get
			{
				return this._HienTai;
			}
			set
			{
				if ((this._HienTai != value))
				{
					this.OnHienTaiChanging(value);
					this.SendPropertyChanging();
					this._HienTai = value;
					this.SendPropertyChanged("HienTai");
					this.OnHienTaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DiaDiemDieuTri_BenhNhan", Storage="_BenhNhans", ThisKey="IDDiaDiemDieuTri", OtherKey="IDDiaDiemDieuTri")]
		public EntitySet<BenhNhan> BenhNhans
		{
			get
			{
				return this._BenhNhans;
			}
			set
			{
				this._BenhNhans.Assign(value);
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
		
		private void attach_BenhNhans(BenhNhan entity)
		{
			this.SendPropertyChanging();
			entity.DiaDiemDieuTri = this;
		}
		
		private void detach_BenhNhans(BenhNhan entity)
		{
			this.SendPropertyChanging();
			entity.DiaDiemDieuTri = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BenhNhan")]
	public partial class BenhNhan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _HoTen;
		
		private string _CMND;
		
		private string _NamSinh;
		
		private string _DiaChi;
		
		private string _TrangThai;
		
		private string _IDDiaDiemDieuTri;
		
		private string _LienQuan;
		
		private string _LichSu;
		
		private EntityRef<DiaDiemDieuTri> _DiaDiemDieuTri;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnNamSinhChanging(string value);
    partial void OnNamSinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnTrangThaiChanging(string value);
    partial void OnTrangThaiChanged();
    partial void OnIDDiaDiemDieuTriChanging(string value);
    partial void OnIDDiaDiemDieuTriChanged();
    partial void OnLienQuanChanging(string value);
    partial void OnLienQuanChanged();
    partial void OnLichSuChanging(string value);
    partial void OnLichSuChanged();
    #endregion
		
		public BenhNhan()
		{
			this._DiaDiemDieuTri = default(EntityRef<DiaDiemDieuTri>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamSinh", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string NamSinh
		{
			get
			{
				return this._NamSinh;
			}
			set
			{
				if ((this._NamSinh != value))
				{
					this.OnNamSinhChanging(value);
					this.SendPropertyChanging();
					this._NamSinh = value;
					this.SendPropertyChanged("NamSinh");
					this.OnNamSinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrangThai", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string TrangThai
		{
			get
			{
				return this._TrangThai;
			}
			set
			{
				if ((this._TrangThai != value))
				{
					this.OnTrangThaiChanging(value);
					this.SendPropertyChanging();
					this._TrangThai = value;
					this.SendPropertyChanged("TrangThai");
					this.OnTrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDiaDiemDieuTri", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string IDDiaDiemDieuTri
		{
			get
			{
				return this._IDDiaDiemDieuTri;
			}
			set
			{
				if ((this._IDDiaDiemDieuTri != value))
				{
					if (this._DiaDiemDieuTri.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDDiaDiemDieuTriChanging(value);
					this.SendPropertyChanging();
					this._IDDiaDiemDieuTri = value;
					this.SendPropertyChanged("IDDiaDiemDieuTri");
					this.OnIDDiaDiemDieuTriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LienQuan", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string LienQuan
		{
			get
			{
				return this._LienQuan;
			}
			set
			{
				if ((this._LienQuan != value))
				{
					this.OnLienQuanChanging(value);
					this.SendPropertyChanging();
					this._LienQuan = value;
					this.SendPropertyChanged("LienQuan");
					this.OnLienQuanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LichSu", DbType="NVarChar(MAX)")]
		public string LichSu
		{
			get
			{
				return this._LichSu;
			}
			set
			{
				if ((this._LichSu != value))
				{
					this.OnLichSuChanging(value);
					this.SendPropertyChanging();
					this._LichSu = value;
					this.SendPropertyChanged("LichSu");
					this.OnLichSuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DiaDiemDieuTri_BenhNhan", Storage="_DiaDiemDieuTri", ThisKey="IDDiaDiemDieuTri", OtherKey="IDDiaDiemDieuTri", IsForeignKey=true)]
		public DiaDiemDieuTri DiaDiemDieuTri
		{
			get
			{
				return this._DiaDiemDieuTri.Entity;
			}
			set
			{
				DiaDiemDieuTri previousValue = this._DiaDiemDieuTri.Entity;
				if (((previousValue != value) 
							|| (this._DiaDiemDieuTri.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DiaDiemDieuTri.Entity = null;
						previousValue.BenhNhans.Remove(this);
					}
					this._DiaDiemDieuTri.Entity = value;
					if ((value != null))
					{
						value.BenhNhans.Add(this);
						this._IDDiaDiemDieuTri = value.IDDiaDiemDieuTri;
					}
					else
					{
						this._IDDiaDiemDieuTri = default(string);
					}
					this.SendPropertyChanged("DiaDiemDieuTri");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan
	{
		
		private string _TaiKhoan1;
		
		private string _MatKhau;
		
		private string _Quyen;
		
		public TaiKhoan()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="TaiKhoan", Storage="_TaiKhoan1", DbType="NChar(30)")]
		public string TaiKhoan1
		{
			get
			{
				return this._TaiKhoan1;
			}
			set
			{
				if ((this._TaiKhoan1 != value))
				{
					this._TaiKhoan1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NChar(30)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this._MatKhau = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quyen", DbType="NChar(10)")]
		public string Quyen
		{
			get
			{
				return this._Quyen;
			}
			set
			{
				if ((this._Quyen != value))
				{
					this._Quyen = value;
				}
			}
		}
	}
}
#pragma warning restore 1591