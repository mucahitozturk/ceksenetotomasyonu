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

namespace OtomasyonProjeOdevim.Fonksiyonlar
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SakaryaYazOtomasyon")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBL_CARIGRUPLARI(TBL_CARIGRUPLARI instance);
    partial void UpdateTBL_CARIGRUPLARI(TBL_CARIGRUPLARI instance);
    partial void DeleteTBL_CARIGRUPLARI(TBL_CARIGRUPLARI instance);
    partial void InsertTBL_CARILER(TBL_CARILER instance);
    partial void UpdateTBL_CARILER(TBL_CARILER instance);
    partial void DeleteTBL_CARILER(TBL_CARILER instance);
    partial void InsertTBL_BODROLAR(TBL_BODROLAR instance);
    partial void UpdateTBL_BODROLAR(TBL_BODROLAR instance);
    partial void DeleteTBL_BODROLAR(TBL_BODROLAR instance);
    partial void InsertTBL_CEKLER(TBL_CEKLER instance);
    partial void UpdateTBL_CEKLER(TBL_CEKLER instance);
    partial void DeleteTBL_CEKLER(TBL_CEKLER instance);
    #endregion
		
		public DatabaseDataContext() : 
				base(global::OtomasyonProjeOdevim.Properties.Settings.Default.SakaryaYazOtomasyonConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBL_CARIGRUPLARI> TBL_CARIGRUPLARIs
		{
			get
			{
				return this.GetTable<TBL_CARIGRUPLARI>();
			}
		}
		
		public System.Data.Linq.Table<TBL_CARILER> TBL_CARILERs
		{
			get
			{
				return this.GetTable<TBL_CARILER>();
			}
		}
		
		public System.Data.Linq.Table<TBL_BODROLAR> TBL_BODROLARs
		{
			get
			{
				return this.GetTable<TBL_BODROLAR>();
			}
		}
		
		public System.Data.Linq.Table<TBL_CEKLER> TBL_CEKLERs
		{
			get
			{
				return this.GetTable<TBL_CEKLER>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_CARIGRUPLARI")]
	public partial class TBL_CARIGRUPLARI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _GRUPADI;
		
		private string _GRUPKODU;
		
		private System.Nullable<System.DateTime> _SAVEDATE;
		
		private System.Nullable<int> _SAVEUSER;
		
		private System.Nullable<System.DateTime> _EDITDATE;
		
		private System.Nullable<int> _EDITUSER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnGRUPADIChanging(string value);
    partial void OnGRUPADIChanged();
    partial void OnGRUPKODUChanging(string value);
    partial void OnGRUPKODUChanged();
    partial void OnSAVEDATEChanging(System.Nullable<System.DateTime> value);
    partial void OnSAVEDATEChanged();
    partial void OnSAVEUSERChanging(System.Nullable<int> value);
    partial void OnSAVEUSERChanged();
    partial void OnEDITDATEChanging(System.Nullable<System.DateTime> value);
    partial void OnEDITDATEChanged();
    partial void OnEDITUSERChanging(System.Nullable<int> value);
    partial void OnEDITUSERChanged();
    #endregion
		
		public TBL_CARIGRUPLARI()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GRUPADI", DbType="NVarChar(30)")]
		public string GRUPADI
		{
			get
			{
				return this._GRUPADI;
			}
			set
			{
				if ((this._GRUPADI != value))
				{
					this.OnGRUPADIChanging(value);
					this.SendPropertyChanging();
					this._GRUPADI = value;
					this.SendPropertyChanged("GRUPADI");
					this.OnGRUPADIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GRUPKODU", DbType="NVarChar(30)")]
		public string GRUPKODU
		{
			get
			{
				return this._GRUPKODU;
			}
			set
			{
				if ((this._GRUPKODU != value))
				{
					this.OnGRUPKODUChanging(value);
					this.SendPropertyChanging();
					this._GRUPKODU = value;
					this.SendPropertyChanged("GRUPKODU");
					this.OnGRUPKODUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SAVEDATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> SAVEDATE
		{
			get
			{
				return this._SAVEDATE;
			}
			set
			{
				if ((this._SAVEDATE != value))
				{
					this.OnSAVEDATEChanging(value);
					this.SendPropertyChanging();
					this._SAVEDATE = value;
					this.SendPropertyChanged("SAVEDATE");
					this.OnSAVEDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SAVEUSER", DbType="Int")]
		public System.Nullable<int> SAVEUSER
		{
			get
			{
				return this._SAVEUSER;
			}
			set
			{
				if ((this._SAVEUSER != value))
				{
					this.OnSAVEUSERChanging(value);
					this.SendPropertyChanging();
					this._SAVEUSER = value;
					this.SendPropertyChanged("SAVEUSER");
					this.OnSAVEUSERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EDITDATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> EDITDATE
		{
			get
			{
				return this._EDITDATE;
			}
			set
			{
				if ((this._EDITDATE != value))
				{
					this.OnEDITDATEChanging(value);
					this.SendPropertyChanging();
					this._EDITDATE = value;
					this.SendPropertyChanged("EDITDATE");
					this.OnEDITDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EDITUSER", DbType="Int")]
		public System.Nullable<int> EDITUSER
		{
			get
			{
				return this._EDITUSER;
			}
			set
			{
				if ((this._EDITUSER != value))
				{
					this.OnEDITUSERChanging(value);
					this.SendPropertyChanging();
					this._EDITUSER = value;
					this.SendPropertyChanged("EDITUSER");
					this.OnEDITUSERChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_CARILER")]
	public partial class TBL_CARILER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _CARISINIFI;
		
		private string _CARIADI;
		
		private string _VERGIDAIRESI;
		
		private string _VERGINO;
		
		private System.Nullable<int> _GRUPID;
		
		private string _ULKE;
		
		private string _SEHIR;
		
		private string _ILCE;
		
		private string _ADRES;
		
		private string _YETKILITELEFON;
		
		private string _KURULUSFAX;
		
		private string _KURULUSADI;
		
		private string _KURULUSEMAIL;
		
		private string _YETKILIADI;
		
		private string _YETKILIEMAIL;
		
		private string _YETKILITC;
		
		private string _AYLIKALACAK;
		
		private string _TOPLAMBORC;
		
		private System.Nullable<System.DateTime> _SAVEDATE;
		
		private System.Nullable<int> _SAVEUSER;
		
		private System.Nullable<System.DateTime> _EDITDATE;
		
		private System.Nullable<int> _EDITUSER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCARISINIFIChanging(string value);
    partial void OnCARISINIFIChanged();
    partial void OnCARIADIChanging(string value);
    partial void OnCARIADIChanged();
    partial void OnVERGIDAIRESIChanging(string value);
    partial void OnVERGIDAIRESIChanged();
    partial void OnVERGINOChanging(string value);
    partial void OnVERGINOChanged();
    partial void OnGRUPIDChanging(System.Nullable<int> value);
    partial void OnGRUPIDChanged();
    partial void OnULKEChanging(string value);
    partial void OnULKEChanged();
    partial void OnSEHIRChanging(string value);
    partial void OnSEHIRChanged();
    partial void OnILCEChanging(string value);
    partial void OnILCEChanged();
    partial void OnADRESChanging(string value);
    partial void OnADRESChanged();
    partial void OnYETKILITELEFONChanging(string value);
    partial void OnYETKILITELEFONChanged();
    partial void OnKURULUSFAXChanging(string value);
    partial void OnKURULUSFAXChanged();
    partial void OnKURULUSADIChanging(string value);
    partial void OnKURULUSADIChanged();
    partial void OnKURULUSEMAILChanging(string value);
    partial void OnKURULUSEMAILChanged();
    partial void OnYETKILIADIChanging(string value);
    partial void OnYETKILIADIChanged();
    partial void OnYETKILIEMAILChanging(string value);
    partial void OnYETKILIEMAILChanged();
    partial void OnYETKILITCChanging(string value);
    partial void OnYETKILITCChanged();
    partial void OnAYLIKALACAKChanging(string value);
    partial void OnAYLIKALACAKChanged();
    partial void OnTOPLAMBORCChanging(string value);
    partial void OnTOPLAMBORCChanged();
    partial void OnSAVEDATEChanging(System.Nullable<System.DateTime> value);
    partial void OnSAVEDATEChanged();
    partial void OnSAVEUSERChanging(System.Nullable<int> value);
    partial void OnSAVEUSERChanged();
    partial void OnEDITDATEChanging(System.Nullable<System.DateTime> value);
    partial void OnEDITDATEChanged();
    partial void OnEDITUSERChanging(System.Nullable<int> value);
    partial void OnEDITUSERChanged();
    #endregion
		
		public TBL_CARILER()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CARISINIFI", DbType="NVarChar(30)")]
		public string CARISINIFI
		{
			get
			{
				return this._CARISINIFI;
			}
			set
			{
				if ((this._CARISINIFI != value))
				{
					this.OnCARISINIFIChanging(value);
					this.SendPropertyChanging();
					this._CARISINIFI = value;
					this.SendPropertyChanged("CARISINIFI");
					this.OnCARISINIFIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CARIADI", DbType="NVarChar(30)")]
		public string CARIADI
		{
			get
			{
				return this._CARIADI;
			}
			set
			{
				if ((this._CARIADI != value))
				{
					this.OnCARIADIChanging(value);
					this.SendPropertyChanging();
					this._CARIADI = value;
					this.SendPropertyChanged("CARIADI");
					this.OnCARIADIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VERGIDAIRESI", DbType="NVarChar(50)")]
		public string VERGIDAIRESI
		{
			get
			{
				return this._VERGIDAIRESI;
			}
			set
			{
				if ((this._VERGIDAIRESI != value))
				{
					this.OnVERGIDAIRESIChanging(value);
					this.SendPropertyChanging();
					this._VERGIDAIRESI = value;
					this.SendPropertyChanged("VERGIDAIRESI");
					this.OnVERGIDAIRESIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VERGINO", DbType="NVarChar(20)")]
		public string VERGINO
		{
			get
			{
				return this._VERGINO;
			}
			set
			{
				if ((this._VERGINO != value))
				{
					this.OnVERGINOChanging(value);
					this.SendPropertyChanging();
					this._VERGINO = value;
					this.SendPropertyChanged("VERGINO");
					this.OnVERGINOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GRUPID", DbType="Int")]
		public System.Nullable<int> GRUPID
		{
			get
			{
				return this._GRUPID;
			}
			set
			{
				if ((this._GRUPID != value))
				{
					this.OnGRUPIDChanging(value);
					this.SendPropertyChanging();
					this._GRUPID = value;
					this.SendPropertyChanged("GRUPID");
					this.OnGRUPIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ULKE", DbType="NVarChar(30)")]
		public string ULKE
		{
			get
			{
				return this._ULKE;
			}
			set
			{
				if ((this._ULKE != value))
				{
					this.OnULKEChanging(value);
					this.SendPropertyChanging();
					this._ULKE = value;
					this.SendPropertyChanged("ULKE");
					this.OnULKEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SEHIR", DbType="NVarChar(30)")]
		public string SEHIR
		{
			get
			{
				return this._SEHIR;
			}
			set
			{
				if ((this._SEHIR != value))
				{
					this.OnSEHIRChanging(value);
					this.SendPropertyChanging();
					this._SEHIR = value;
					this.SendPropertyChanged("SEHIR");
					this.OnSEHIRChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ILCE", DbType="NVarChar(30)")]
		public string ILCE
		{
			get
			{
				return this._ILCE;
			}
			set
			{
				if ((this._ILCE != value))
				{
					this.OnILCEChanging(value);
					this.SendPropertyChanging();
					this._ILCE = value;
					this.SendPropertyChanged("ILCE");
					this.OnILCEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ADRES", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string ADRES
		{
			get
			{
				return this._ADRES;
			}
			set
			{
				if ((this._ADRES != value))
				{
					this.OnADRESChanging(value);
					this.SendPropertyChanging();
					this._ADRES = value;
					this.SendPropertyChanged("ADRES");
					this.OnADRESChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YETKILITELEFON", DbType="NVarChar(16)")]
		public string YETKILITELEFON
		{
			get
			{
				return this._YETKILITELEFON;
			}
			set
			{
				if ((this._YETKILITELEFON != value))
				{
					this.OnYETKILITELEFONChanging(value);
					this.SendPropertyChanging();
					this._YETKILITELEFON = value;
					this.SendPropertyChanged("YETKILITELEFON");
					this.OnYETKILITELEFONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KURULUSFAX", DbType="NVarChar(16)")]
		public string KURULUSFAX
		{
			get
			{
				return this._KURULUSFAX;
			}
			set
			{
				if ((this._KURULUSFAX != value))
				{
					this.OnKURULUSFAXChanging(value);
					this.SendPropertyChanging();
					this._KURULUSFAX = value;
					this.SendPropertyChanged("KURULUSFAX");
					this.OnKURULUSFAXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KURULUSADI", DbType="NVarChar(30)")]
		public string KURULUSADI
		{
			get
			{
				return this._KURULUSADI;
			}
			set
			{
				if ((this._KURULUSADI != value))
				{
					this.OnKURULUSADIChanging(value);
					this.SendPropertyChanging();
					this._KURULUSADI = value;
					this.SendPropertyChanged("KURULUSADI");
					this.OnKURULUSADIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KURULUSEMAIL", DbType="NVarChar(250)")]
		public string KURULUSEMAIL
		{
			get
			{
				return this._KURULUSEMAIL;
			}
			set
			{
				if ((this._KURULUSEMAIL != value))
				{
					this.OnKURULUSEMAILChanging(value);
					this.SendPropertyChanging();
					this._KURULUSEMAIL = value;
					this.SendPropertyChanged("KURULUSEMAIL");
					this.OnKURULUSEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YETKILIADI", DbType="NVarChar(50)")]
		public string YETKILIADI
		{
			get
			{
				return this._YETKILIADI;
			}
			set
			{
				if ((this._YETKILIADI != value))
				{
					this.OnYETKILIADIChanging(value);
					this.SendPropertyChanging();
					this._YETKILIADI = value;
					this.SendPropertyChanged("YETKILIADI");
					this.OnYETKILIADIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YETKILIEMAIL", DbType="NVarChar(250)")]
		public string YETKILIEMAIL
		{
			get
			{
				return this._YETKILIEMAIL;
			}
			set
			{
				if ((this._YETKILIEMAIL != value))
				{
					this.OnYETKILIEMAILChanging(value);
					this.SendPropertyChanging();
					this._YETKILIEMAIL = value;
					this.SendPropertyChanged("YETKILIEMAIL");
					this.OnYETKILIEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YETKILITC", DbType="NVarChar(30)")]
		public string YETKILITC
		{
			get
			{
				return this._YETKILITC;
			}
			set
			{
				if ((this._YETKILITC != value))
				{
					this.OnYETKILITCChanging(value);
					this.SendPropertyChanging();
					this._YETKILITC = value;
					this.SendPropertyChanged("YETKILITC");
					this.OnYETKILITCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AYLIKALACAK", DbType="NVarChar(250)")]
		public string AYLIKALACAK
		{
			get
			{
				return this._AYLIKALACAK;
			}
			set
			{
				if ((this._AYLIKALACAK != value))
				{
					this.OnAYLIKALACAKChanging(value);
					this.SendPropertyChanging();
					this._AYLIKALACAK = value;
					this.SendPropertyChanged("AYLIKALACAK");
					this.OnAYLIKALACAKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TOPLAMBORC", DbType="NVarChar(250)")]
		public string TOPLAMBORC
		{
			get
			{
				return this._TOPLAMBORC;
			}
			set
			{
				if ((this._TOPLAMBORC != value))
				{
					this.OnTOPLAMBORCChanging(value);
					this.SendPropertyChanging();
					this._TOPLAMBORC = value;
					this.SendPropertyChanged("TOPLAMBORC");
					this.OnTOPLAMBORCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SAVEDATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> SAVEDATE
		{
			get
			{
				return this._SAVEDATE;
			}
			set
			{
				if ((this._SAVEDATE != value))
				{
					this.OnSAVEDATEChanging(value);
					this.SendPropertyChanging();
					this._SAVEDATE = value;
					this.SendPropertyChanged("SAVEDATE");
					this.OnSAVEDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SAVEUSER", DbType="Int")]
		public System.Nullable<int> SAVEUSER
		{
			get
			{
				return this._SAVEUSER;
			}
			set
			{
				if ((this._SAVEUSER != value))
				{
					this.OnSAVEUSERChanging(value);
					this.SendPropertyChanging();
					this._SAVEUSER = value;
					this.SendPropertyChanged("SAVEUSER");
					this.OnSAVEUSERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EDITDATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> EDITDATE
		{
			get
			{
				return this._EDITDATE;
			}
			set
			{
				if ((this._EDITDATE != value))
				{
					this.OnEDITDATEChanging(value);
					this.SendPropertyChanging();
					this._EDITDATE = value;
					this.SendPropertyChanged("EDITDATE");
					this.OnEDITDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EDITUSER", DbType="Int")]
		public System.Nullable<int> EDITUSER
		{
			get
			{
				return this._EDITUSER;
			}
			set
			{
				if ((this._EDITUSER != value))
				{
					this.OnEDITUSERChanging(value);
					this.SendPropertyChanging();
					this._EDITUSER = value;
					this.SendPropertyChanged("EDITUSER");
					this.OnEDITUSERChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_BODROLAR")]
	public partial class TBL_BODROLAR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _NUMARA;
		
		private System.Nullable<System.DateTime> _TARIH;
		
		private System.Nullable<int> _SAVEUSER;
		
		private System.Nullable<System.DateTime> _SAVEDATE;
		
		private System.Nullable<int> _EDITUSER;
		
		private System.Nullable<System.DateTime> _EDITDATE;
		
		private string _CARIID;
		
		private string _ACIKLAMA;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNUMARAChanging(string value);
    partial void OnNUMARAChanged();
    partial void OnTARIHChanging(System.Nullable<System.DateTime> value);
    partial void OnTARIHChanged();
    partial void OnSAVEUSERChanging(System.Nullable<int> value);
    partial void OnSAVEUSERChanged();
    partial void OnSAVEDATEChanging(System.Nullable<System.DateTime> value);
    partial void OnSAVEDATEChanged();
    partial void OnEDITUSERChanging(System.Nullable<int> value);
    partial void OnEDITUSERChanged();
    partial void OnEDITDATEChanging(System.Nullable<System.DateTime> value);
    partial void OnEDITDATEChanged();
    partial void OnCARIIDChanging(string value);
    partial void OnCARIIDChanged();
    partial void OnACIKLAMAChanging(string value);
    partial void OnACIKLAMAChanged();
    #endregion
		
		public TBL_BODROLAR()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUMARA", DbType="NVarChar(50)")]
		public string NUMARA
		{
			get
			{
				return this._NUMARA;
			}
			set
			{
				if ((this._NUMARA != value))
				{
					this.OnNUMARAChanging(value);
					this.SendPropertyChanging();
					this._NUMARA = value;
					this.SendPropertyChanged("NUMARA");
					this.OnNUMARAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TARIH", DbType="DateTime")]
		public System.Nullable<System.DateTime> TARIH
		{
			get
			{
				return this._TARIH;
			}
			set
			{
				if ((this._TARIH != value))
				{
					this.OnTARIHChanging(value);
					this.SendPropertyChanging();
					this._TARIH = value;
					this.SendPropertyChanged("TARIH");
					this.OnTARIHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SAVEUSER", DbType="Int")]
		public System.Nullable<int> SAVEUSER
		{
			get
			{
				return this._SAVEUSER;
			}
			set
			{
				if ((this._SAVEUSER != value))
				{
					this.OnSAVEUSERChanging(value);
					this.SendPropertyChanging();
					this._SAVEUSER = value;
					this.SendPropertyChanged("SAVEUSER");
					this.OnSAVEUSERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SAVEDATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> SAVEDATE
		{
			get
			{
				return this._SAVEDATE;
			}
			set
			{
				if ((this._SAVEDATE != value))
				{
					this.OnSAVEDATEChanging(value);
					this.SendPropertyChanging();
					this._SAVEDATE = value;
					this.SendPropertyChanged("SAVEDATE");
					this.OnSAVEDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EDITUSER", DbType="Int")]
		public System.Nullable<int> EDITUSER
		{
			get
			{
				return this._EDITUSER;
			}
			set
			{
				if ((this._EDITUSER != value))
				{
					this.OnEDITUSERChanging(value);
					this.SendPropertyChanging();
					this._EDITUSER = value;
					this.SendPropertyChanged("EDITUSER");
					this.OnEDITUSERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EDITDATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> EDITDATE
		{
			get
			{
				return this._EDITDATE;
			}
			set
			{
				if ((this._EDITDATE != value))
				{
					this.OnEDITDATEChanging(value);
					this.SendPropertyChanging();
					this._EDITDATE = value;
					this.SendPropertyChanged("EDITDATE");
					this.OnEDITDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CARIID", DbType="NVarChar(50)")]
		public string CARIID
		{
			get
			{
				return this._CARIID;
			}
			set
			{
				if ((this._CARIID != value))
				{
					this.OnCARIIDChanging(value);
					this.SendPropertyChanging();
					this._CARIID = value;
					this.SendPropertyChanged("CARIID");
					this.OnCARIIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ACIKLAMA", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string ACIKLAMA
		{
			get
			{
				return this._ACIKLAMA;
			}
			set
			{
				if ((this._ACIKLAMA != value))
				{
					this.OnACIKLAMAChanging(value);
					this.SendPropertyChanging();
					this._ACIKLAMA = value;
					this.SendPropertyChanged("ACIKLAMA");
					this.OnACIKLAMAChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_CEKLER")]
	public partial class TBL_CEKLER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _KURULUSAD;
		
		private string _CEKNO;
		
		private string _CEKTARIHIYIL;
		
		private System.Nullable<decimal> _TUTAR;
		
		private System.Nullable<System.DateTime> _VADETARIHI;
		
		private System.Nullable<int> _SAVEUSER;
		
		private System.Nullable<System.DateTime> _SAVEDATE;
		
		private System.Nullable<int> _EDITUSER;
		
		private System.Nullable<System.DateTime> _EDITDATE;
		
		private string _ACIKLAMA;
		
		private string _ALINANCARIID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnKURULUSADChanging(string value);
    partial void OnKURULUSADChanged();
    partial void OnCEKNOChanging(string value);
    partial void OnCEKNOChanged();
    partial void OnCEKTARIHIYILChanging(string value);
    partial void OnCEKTARIHIYILChanged();
    partial void OnTUTARChanging(System.Nullable<decimal> value);
    partial void OnTUTARChanged();
    partial void OnVADETARIHIChanging(System.Nullable<System.DateTime> value);
    partial void OnVADETARIHIChanged();
    partial void OnSAVEUSERChanging(System.Nullable<int> value);
    partial void OnSAVEUSERChanged();
    partial void OnSAVEDATEChanging(System.Nullable<System.DateTime> value);
    partial void OnSAVEDATEChanged();
    partial void OnEDITUSERChanging(System.Nullable<int> value);
    partial void OnEDITUSERChanged();
    partial void OnEDITDATEChanging(System.Nullable<System.DateTime> value);
    partial void OnEDITDATEChanged();
    partial void OnACIKLAMAChanging(string value);
    partial void OnACIKLAMAChanged();
    partial void OnALINANCARIIDChanging(string value);
    partial void OnALINANCARIIDChanged();
    #endregion
		
		public TBL_CEKLER()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KURULUSAD", DbType="NVarChar(50)")]
		public string KURULUSAD
		{
			get
			{
				return this._KURULUSAD;
			}
			set
			{
				if ((this._KURULUSAD != value))
				{
					this.OnKURULUSADChanging(value);
					this.SendPropertyChanging();
					this._KURULUSAD = value;
					this.SendPropertyChanged("KURULUSAD");
					this.OnKURULUSADChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CEKNO", DbType="NVarChar(50)")]
		public string CEKNO
		{
			get
			{
				return this._CEKNO;
			}
			set
			{
				if ((this._CEKNO != value))
				{
					this.OnCEKNOChanging(value);
					this.SendPropertyChanging();
					this._CEKNO = value;
					this.SendPropertyChanged("CEKNO");
					this.OnCEKNOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CEKTARIHIYIL", DbType="NVarChar(30)")]
		public string CEKTARIHIYIL
		{
			get
			{
				return this._CEKTARIHIYIL;
			}
			set
			{
				if ((this._CEKTARIHIYIL != value))
				{
					this.OnCEKTARIHIYILChanging(value);
					this.SendPropertyChanging();
					this._CEKTARIHIYIL = value;
					this.SendPropertyChanged("CEKTARIHIYIL");
					this.OnCEKTARIHIYILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TUTAR", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> TUTAR
		{
			get
			{
				return this._TUTAR;
			}
			set
			{
				if ((this._TUTAR != value))
				{
					this.OnTUTARChanging(value);
					this.SendPropertyChanging();
					this._TUTAR = value;
					this.SendPropertyChanged("TUTAR");
					this.OnTUTARChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VADETARIHI", DbType="DateTime")]
		public System.Nullable<System.DateTime> VADETARIHI
		{
			get
			{
				return this._VADETARIHI;
			}
			set
			{
				if ((this._VADETARIHI != value))
				{
					this.OnVADETARIHIChanging(value);
					this.SendPropertyChanging();
					this._VADETARIHI = value;
					this.SendPropertyChanged("VADETARIHI");
					this.OnVADETARIHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SAVEUSER", DbType="Int")]
		public System.Nullable<int> SAVEUSER
		{
			get
			{
				return this._SAVEUSER;
			}
			set
			{
				if ((this._SAVEUSER != value))
				{
					this.OnSAVEUSERChanging(value);
					this.SendPropertyChanging();
					this._SAVEUSER = value;
					this.SendPropertyChanged("SAVEUSER");
					this.OnSAVEUSERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SAVEDATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> SAVEDATE
		{
			get
			{
				return this._SAVEDATE;
			}
			set
			{
				if ((this._SAVEDATE != value))
				{
					this.OnSAVEDATEChanging(value);
					this.SendPropertyChanging();
					this._SAVEDATE = value;
					this.SendPropertyChanged("SAVEDATE");
					this.OnSAVEDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EDITUSER", DbType="Int")]
		public System.Nullable<int> EDITUSER
		{
			get
			{
				return this._EDITUSER;
			}
			set
			{
				if ((this._EDITUSER != value))
				{
					this.OnEDITUSERChanging(value);
					this.SendPropertyChanging();
					this._EDITUSER = value;
					this.SendPropertyChanged("EDITUSER");
					this.OnEDITUSERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EDITDATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> EDITDATE
		{
			get
			{
				return this._EDITDATE;
			}
			set
			{
				if ((this._EDITDATE != value))
				{
					this.OnEDITDATEChanging(value);
					this.SendPropertyChanging();
					this._EDITDATE = value;
					this.SendPropertyChanged("EDITDATE");
					this.OnEDITDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ACIKLAMA", DbType="NVarChar(250)")]
		public string ACIKLAMA
		{
			get
			{
				return this._ACIKLAMA;
			}
			set
			{
				if ((this._ACIKLAMA != value))
				{
					this.OnACIKLAMAChanging(value);
					this.SendPropertyChanging();
					this._ACIKLAMA = value;
					this.SendPropertyChanged("ACIKLAMA");
					this.OnACIKLAMAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ALINANCARIID", DbType="NVarChar(50)")]
		public string ALINANCARIID
		{
			get
			{
				return this._ALINANCARIID;
			}
			set
			{
				if ((this._ALINANCARIID != value))
				{
					this.OnALINANCARIIDChanging(value);
					this.SendPropertyChanging();
					this._ALINANCARIID = value;
					this.SendPropertyChanged("ALINANCARIID");
					this.OnALINANCARIIDChanged();
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
