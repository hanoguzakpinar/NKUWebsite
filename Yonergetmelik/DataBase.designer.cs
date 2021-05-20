﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yonergetmelik
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Yonergetmelik")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKullanici(Kullanici instance);
    partial void UpdateKullanici(Kullanici instance);
    partial void DeleteKullanici(Kullanici instance);
    partial void InsertKategori(Kategori instance);
    partial void UpdateKategori(Kategori instance);
    partial void DeleteKategori(Kategori instance);
    partial void InsertBelge(Belge instance);
    partial void UpdateBelge(Belge instance);
    partial void DeleteBelge(Belge instance);
    #endregion
		
		public DataBaseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["YonergetmelikConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Kullanici> Kullanici
		{
			get
			{
				return this.GetTable<Kullanici>();
			}
		}
		
		public System.Data.Linq.Table<Kategori> Kategori
		{
			get
			{
				return this.GetTable<Kategori>();
			}
		}
		
		public System.Data.Linq.Table<Belge> Belge
		{
			get
			{
				return this.GetTable<Belge>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Kullanici")]
	public partial class Kullanici : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _kullanici_id;
		
		private string _adsoyad;
		
		private string _email;
		
		private string _sifre;
		
		private string _gsorusu;
		
		private string _gcevap;
		
		private EntitySet<Belge> _Belge;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onkullanici_idChanging(int value);
    partial void Onkullanici_idChanged();
    partial void OnadsoyadChanging(string value);
    partial void OnadsoyadChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnsifreChanging(string value);
    partial void OnsifreChanged();
    partial void OngsorusuChanging(string value);
    partial void OngsorusuChanged();
    partial void OngcevapChanging(string value);
    partial void OngcevapChanged();
    #endregion
		
		public Kullanici()
		{
			this._Belge = new EntitySet<Belge>(new Action<Belge>(this.attach_Belge), new Action<Belge>(this.detach_Belge));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kullanici_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int kullanici_id
		{
			get
			{
				return this._kullanici_id;
			}
			set
			{
				if ((this._kullanici_id != value))
				{
					this.Onkullanici_idChanging(value);
					this.SendPropertyChanging();
					this._kullanici_id = value;
					this.SendPropertyChanged("kullanici_id");
					this.Onkullanici_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adsoyad", DbType="NVarChar(50)")]
		public string adsoyad
		{
			get
			{
				return this._adsoyad;
			}
			set
			{
				if ((this._adsoyad != value))
				{
					this.OnadsoyadChanging(value);
					this.SendPropertyChanging();
					this._adsoyad = value;
					this.SendPropertyChanged("adsoyad");
					this.OnadsoyadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifre", DbType="NVarChar(50)")]
		public string sifre
		{
			get
			{
				return this._sifre;
			}
			set
			{
				if ((this._sifre != value))
				{
					this.OnsifreChanging(value);
					this.SendPropertyChanging();
					this._sifre = value;
					this.SendPropertyChanged("sifre");
					this.OnsifreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gsorusu", DbType="NVarChar(50)")]
		public string gsorusu
		{
			get
			{
				return this._gsorusu;
			}
			set
			{
				if ((this._gsorusu != value))
				{
					this.OngsorusuChanging(value);
					this.SendPropertyChanging();
					this._gsorusu = value;
					this.SendPropertyChanged("gsorusu");
					this.OngsorusuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gcevap", DbType="NVarChar(50)")]
		public string gcevap
		{
			get
			{
				return this._gcevap;
			}
			set
			{
				if ((this._gcevap != value))
				{
					this.OngcevapChanging(value);
					this.SendPropertyChanging();
					this._gcevap = value;
					this.SendPropertyChanged("gcevap");
					this.OngcevapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Kullanici_Belge", Storage="_Belge", ThisKey="kullanici_id", OtherKey="kullanici_id")]
		public EntitySet<Belge> Belge
		{
			get
			{
				return this._Belge;
			}
			set
			{
				this._Belge.Assign(value);
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
		
		private void attach_Belge(Belge entity)
		{
			this.SendPropertyChanging();
			entity.Kullanici = this;
		}
		
		private void detach_Belge(Belge entity)
		{
			this.SendPropertyChanging();
			entity.Kullanici = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Kategori")]
	public partial class Kategori : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _kategori_id;
		
		private string _ad;
		
		private string _aciklama;
		
		private EntitySet<Belge> _Belge;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onkategori_idChanging(int value);
    partial void Onkategori_idChanged();
    partial void OnadChanging(string value);
    partial void OnadChanged();
    partial void OnaciklamaChanging(string value);
    partial void OnaciklamaChanged();
    #endregion
		
		public Kategori()
		{
			this._Belge = new EntitySet<Belge>(new Action<Belge>(this.attach_Belge), new Action<Belge>(this.detach_Belge));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kategori_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int kategori_id
		{
			get
			{
				return this._kategori_id;
			}
			set
			{
				if ((this._kategori_id != value))
				{
					this.Onkategori_idChanging(value);
					this.SendPropertyChanging();
					this._kategori_id = value;
					this.SendPropertyChanged("kategori_id");
					this.Onkategori_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ad", DbType="NVarChar(50)")]
		public string ad
		{
			get
			{
				return this._ad;
			}
			set
			{
				if ((this._ad != value))
				{
					this.OnadChanging(value);
					this.SendPropertyChanging();
					this._ad = value;
					this.SendPropertyChanged("ad");
					this.OnadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aciklama", DbType="NVarChar(50)")]
		public string aciklama
		{
			get
			{
				return this._aciklama;
			}
			set
			{
				if ((this._aciklama != value))
				{
					this.OnaciklamaChanging(value);
					this.SendPropertyChanging();
					this._aciklama = value;
					this.SendPropertyChanged("aciklama");
					this.OnaciklamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Kategori_Belge", Storage="_Belge", ThisKey="kategori_id", OtherKey="kategori_id")]
		public EntitySet<Belge> Belge
		{
			get
			{
				return this._Belge;
			}
			set
			{
				this._Belge.Assign(value);
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
		
		private void attach_Belge(Belge entity)
		{
			this.SendPropertyChanging();
			entity.Kategori = this;
		}
		
		private void detach_Belge(Belge entity)
		{
			this.SendPropertyChanging();
			entity.Kategori = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Belge")]
	public partial class Belge : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _belge_id;
		
		private string _baslik;
		
		private System.Nullable<int> _kullanici_id;
		
		private System.Nullable<int> _kategori_id;
		
		private System.Nullable<System.DateTime> _tarih;
		
		private string _icerik;
		
		private EntityRef<Kategori> _Kategori;
		
		private EntityRef<Kullanici> _Kullanici;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onbelge_idChanging(int value);
    partial void Onbelge_idChanged();
    partial void OnbaslikChanging(string value);
    partial void OnbaslikChanged();
    partial void Onkullanici_idChanging(System.Nullable<int> value);
    partial void Onkullanici_idChanged();
    partial void Onkategori_idChanging(System.Nullable<int> value);
    partial void Onkategori_idChanged();
    partial void OntarihChanging(System.Nullable<System.DateTime> value);
    partial void OntarihChanged();
    partial void OnicerikChanging(string value);
    partial void OnicerikChanged();
    #endregion
		
		public Belge()
		{
			this._Kategori = default(EntityRef<Kategori>);
			this._Kullanici = default(EntityRef<Kullanici>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_belge_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int belge_id
		{
			get
			{
				return this._belge_id;
			}
			set
			{
				if ((this._belge_id != value))
				{
					this.Onbelge_idChanging(value);
					this.SendPropertyChanging();
					this._belge_id = value;
					this.SendPropertyChanged("belge_id");
					this.Onbelge_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_baslik", DbType="NVarChar(500)")]
		public string baslik
		{
			get
			{
				return this._baslik;
			}
			set
			{
				if ((this._baslik != value))
				{
					this.OnbaslikChanging(value);
					this.SendPropertyChanging();
					this._baslik = value;
					this.SendPropertyChanged("baslik");
					this.OnbaslikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kullanici_id", DbType="Int")]
		public System.Nullable<int> kullanici_id
		{
			get
			{
				return this._kullanici_id;
			}
			set
			{
				if ((this._kullanici_id != value))
				{
					if (this._Kullanici.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onkullanici_idChanging(value);
					this.SendPropertyChanging();
					this._kullanici_id = value;
					this.SendPropertyChanged("kullanici_id");
					this.Onkullanici_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kategori_id", DbType="Int")]
		public System.Nullable<int> kategori_id
		{
			get
			{
				return this._kategori_id;
			}
			set
			{
				if ((this._kategori_id != value))
				{
					if (this._Kategori.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onkategori_idChanging(value);
					this.SendPropertyChanging();
					this._kategori_id = value;
					this.SendPropertyChanged("kategori_id");
					this.Onkategori_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tarih", DbType="Date")]
		public System.Nullable<System.DateTime> tarih
		{
			get
			{
				return this._tarih;
			}
			set
			{
				if ((this._tarih != value))
				{
					this.OntarihChanging(value);
					this.SendPropertyChanging();
					this._tarih = value;
					this.SendPropertyChanged("tarih");
					this.OntarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_icerik", DbType="NVarChar(MAX)")]
		public string icerik
		{
			get
			{
				return this._icerik;
			}
			set
			{
				if ((this._icerik != value))
				{
					this.OnicerikChanging(value);
					this.SendPropertyChanging();
					this._icerik = value;
					this.SendPropertyChanged("icerik");
					this.OnicerikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Kategori_Belge", Storage="_Kategori", ThisKey="kategori_id", OtherKey="kategori_id", IsForeignKey=true)]
		public Kategori Kategori
		{
			get
			{
				return this._Kategori.Entity;
			}
			set
			{
				Kategori previousValue = this._Kategori.Entity;
				if (((previousValue != value) 
							|| (this._Kategori.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Kategori.Entity = null;
						previousValue.Belge.Remove(this);
					}
					this._Kategori.Entity = value;
					if ((value != null))
					{
						value.Belge.Add(this);
						this._kategori_id = value.kategori_id;
					}
					else
					{
						this._kategori_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Kategori");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Kullanici_Belge", Storage="_Kullanici", ThisKey="kullanici_id", OtherKey="kullanici_id", IsForeignKey=true)]
		public Kullanici Kullanici
		{
			get
			{
				return this._Kullanici.Entity;
			}
			set
			{
				Kullanici previousValue = this._Kullanici.Entity;
				if (((previousValue != value) 
							|| (this._Kullanici.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Kullanici.Entity = null;
						previousValue.Belge.Remove(this);
					}
					this._Kullanici.Entity = value;
					if ((value != null))
					{
						value.Belge.Add(this);
						this._kullanici_id = value.kullanici_id;
					}
					else
					{
						this._kullanici_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Kullanici");
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
