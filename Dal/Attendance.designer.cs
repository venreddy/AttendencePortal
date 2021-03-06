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

namespace AttendancePortal.Dal
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AttendanceSystem")]
	public partial class AttendanceDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertUserCourse(UserCourse instance);
    partial void UpdateUserCourse(UserCourse instance);
    partial void DeleteUserCourse(UserCourse instance);
    partial void InsertCourseAttendance(CourseAttendance instance);
    partial void UpdateCourseAttendance(CourseAttendance instance);
    partial void DeleteCourseAttendance(CourseAttendance instance);
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    #endregion
		
		public AttendanceDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AttendanceSystemConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AttendanceDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AttendanceDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AttendanceDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AttendanceDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<UserCourse> UserCourses
		{
			get
			{
				return this.GetTable<UserCourse>();
			}
		}
		
		public System.Data.Linq.Table<CourseAttendance> CourseAttendances
		{
			get
			{
				return this.GetTable<CourseAttendance>();
			}
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Roles")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Role1;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRole1Changing(string value);
    partial void OnRole1Changed();
    #endregion
		
		public Role()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Role", Storage="_Role1", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Role1
		{
			get
			{
				return this._Role1;
			}
			set
			{
				if ((this._Role1 != value))
				{
					this.OnRole1Changing(value);
					this.SendPropertyChanging();
					this._Role1 = value;
					this.SendPropertyChanged("Role1");
					this.OnRole1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Users", ThisKey="Id", OtherKey="RoleId")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _RoleId;
		
		private string _UserName;
		
		private string _Password;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _EmailAddress;
		
		private EntitySet<UserCourse> _UserCourses;
		
		private EntitySet<CourseAttendance> _CourseAttendances;
		
		private EntityRef<Role> _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRoleIdChanging(int value);
    partial void OnRoleIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnEmailAddressChanging(string value);
    partial void OnEmailAddressChanged();
    #endregion
		
		public User()
		{
			this._UserCourses = new EntitySet<UserCourse>(new Action<UserCourse>(this.attach_UserCourses), new Action<UserCourse>(this.detach_UserCourses));
			this._CourseAttendances = new EntitySet<CourseAttendance>(new Action<CourseAttendance>(this.attach_CourseAttendances), new Action<CourseAttendance>(this.detach_CourseAttendances));
			this._Role = default(EntityRef<Role>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", DbType="Int NOT NULL")]
		public int RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAddress", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EmailAddress
		{
			get
			{
				return this._EmailAddress;
			}
			set
			{
				if ((this._EmailAddress != value))
				{
					this.OnEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._EmailAddress = value;
					this.SendPropertyChanged("EmailAddress");
					this.OnEmailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserCourse", Storage="_UserCourses", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<UserCourse> UserCourses
		{
			get
			{
				return this._UserCourses;
			}
			set
			{
				this._UserCourses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_CourseAttendance", Storage="_CourseAttendances", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<CourseAttendance> CourseAttendances
		{
			get
			{
				return this._CourseAttendances;
			}
			set
			{
				this._CourseAttendances.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Role", ThisKey="RoleId", OtherKey="Id", IsForeignKey=true)]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._RoleId = value.Id;
					}
					else
					{
						this._RoleId = default(int);
					}
					this.SendPropertyChanged("Role");
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
		
		private void attach_UserCourses(UserCourse entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_UserCourses(UserCourse entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_CourseAttendances(CourseAttendance entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_CourseAttendances(CourseAttendance entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserCourses")]
	public partial class UserCourse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _UserId;
		
		private int _CourseId;
		
		private System.DateTime _Created;
		
		private EntityRef<User> _User;
		
		private EntityRef<Course> _Course;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnCourseIdChanging(int value);
    partial void OnCourseIdChanged();
    partial void OnCreatedChanging(System.DateTime value);
    partial void OnCreatedChanged();
    #endregion
		
		public UserCourse()
		{
			this._User = default(EntityRef<User>);
			this._Course = default(EntityRef<Course>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseId", DbType="Int NOT NULL")]
		public int CourseId
		{
			get
			{
				return this._CourseId;
			}
			set
			{
				if ((this._CourseId != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCourseIdChanging(value);
					this.SendPropertyChanging();
					this._CourseId = value;
					this.SendPropertyChanged("CourseId");
					this.OnCourseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime NOT NULL")]
		public System.DateTime Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._Created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserCourse", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.UserCourses.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.UserCourses.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_UserCourse", Storage="_Course", ThisKey="CourseId", OtherKey="Id", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.UserCourses.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.UserCourses.Add(this);
						this._CourseId = value.Id;
					}
					else
					{
						this._CourseId = default(int);
					}
					this.SendPropertyChanged("Course");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CourseAttendance")]
	public partial class CourseAttendance : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _CourseId;
		
		private int _UserId;
		
		private string _Status;
		
		private System.DateTime _Created;
		
		private bool _Disputed;
		
		private string _DisputedReason;
		
		private System.Nullable<System.DateTime> _DisputedDate;
		
		private System.Nullable<int> _DisputeRespondedBy;
		
		private EntityRef<User> _User;
		
		private EntityRef<Course> _Course;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCourseIdChanging(int value);
    partial void OnCourseIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnCreatedChanging(System.DateTime value);
    partial void OnCreatedChanged();
    partial void OnDisputedChanging(bool value);
    partial void OnDisputedChanged();
    partial void OnDisputedReasonChanging(string value);
    partial void OnDisputedReasonChanged();
    partial void OnDisputedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDisputedDateChanged();
    partial void OnDisputeRespondedByChanging(System.Nullable<int> value);
    partial void OnDisputeRespondedByChanged();
    #endregion
		
		public CourseAttendance()
		{
			this._User = default(EntityRef<User>);
			this._Course = default(EntityRef<Course>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseId", DbType="Int NOT NULL")]
		public int CourseId
		{
			get
			{
				return this._CourseId;
			}
			set
			{
				if ((this._CourseId != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCourseIdChanging(value);
					this.SendPropertyChanging();
					this._CourseId = value;
					this.SendPropertyChanged("CourseId");
					this.OnCourseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime NOT NULL")]
		public System.DateTime Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._Created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Disputed", DbType="Bit NOT NULL")]
		public bool Disputed
		{
			get
			{
				return this._Disputed;
			}
			set
			{
				if ((this._Disputed != value))
				{
					this.OnDisputedChanging(value);
					this.SendPropertyChanging();
					this._Disputed = value;
					this.SendPropertyChanged("Disputed");
					this.OnDisputedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DisputedReason", DbType="NVarChar(MAX)")]
		public string DisputedReason
		{
			get
			{
				return this._DisputedReason;
			}
			set
			{
				if ((this._DisputedReason != value))
				{
					this.OnDisputedReasonChanging(value);
					this.SendPropertyChanging();
					this._DisputedReason = value;
					this.SendPropertyChanged("DisputedReason");
					this.OnDisputedReasonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DisputedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> DisputedDate
		{
			get
			{
				return this._DisputedDate;
			}
			set
			{
				if ((this._DisputedDate != value))
				{
					this.OnDisputedDateChanging(value);
					this.SendPropertyChanging();
					this._DisputedDate = value;
					this.SendPropertyChanged("DisputedDate");
					this.OnDisputedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DisputeRespondedBy", DbType="Int")]
		public System.Nullable<int> DisputeRespondedBy
		{
			get
			{
				return this._DisputeRespondedBy;
			}
			set
			{
				if ((this._DisputeRespondedBy != value))
				{
					this.OnDisputeRespondedByChanging(value);
					this.SendPropertyChanging();
					this._DisputeRespondedBy = value;
					this.SendPropertyChanged("DisputeRespondedBy");
					this.OnDisputeRespondedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_CourseAttendance", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.CourseAttendances.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.CourseAttendances.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_CourseAttendance", Storage="_Course", ThisKey="CourseId", OtherKey="Id", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.CourseAttendances.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.CourseAttendances.Add(this);
						this._CourseId = value.Id;
					}
					else
					{
						this._CourseId = default(int);
					}
					this.SendPropertyChanged("Course");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Course")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _CourseName;
		
		private System.Nullable<System.TimeSpan> _CourseStartTime;
		
		private System.Nullable<System.TimeSpan> _CourseEndTime;
		
		private string _CheckInStartTime;
		
		private string _CheckInEndTime;
		
		private System.Nullable<System.DateTime> _CourseStartDate;
		
		private System.Nullable<System.DateTime> _CourseEndDate;
		
		private EntitySet<UserCourse> _UserCourses;
		
		private EntitySet<CourseAttendance> _CourseAttendances;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCourseNameChanging(string value);
    partial void OnCourseNameChanged();
    partial void OnCourseStartTimeChanging(System.Nullable<System.TimeSpan> value);
    partial void OnCourseStartTimeChanged();
    partial void OnCourseEndTimeChanging(System.Nullable<System.TimeSpan> value);
    partial void OnCourseEndTimeChanged();
    partial void OnCheckInStartTimeChanging(string value);
    partial void OnCheckInStartTimeChanged();
    partial void OnCheckInEndTimeChanging(string value);
    partial void OnCheckInEndTimeChanged();
    partial void OnCourseStartDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCourseStartDateChanged();
    partial void OnCourseEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCourseEndDateChanged();
    #endregion
		
		public Course()
		{
			this._UserCourses = new EntitySet<UserCourse>(new Action<UserCourse>(this.attach_UserCourses), new Action<UserCourse>(this.detach_UserCourses));
			this._CourseAttendances = new EntitySet<CourseAttendance>(new Action<CourseAttendance>(this.attach_CourseAttendances), new Action<CourseAttendance>(this.detach_CourseAttendances));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CourseName
		{
			get
			{
				return this._CourseName;
			}
			set
			{
				if ((this._CourseName != value))
				{
					this.OnCourseNameChanging(value);
					this.SendPropertyChanging();
					this._CourseName = value;
					this.SendPropertyChanged("CourseName");
					this.OnCourseNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseStartTime", DbType="Time")]
		public System.Nullable<System.TimeSpan> CourseStartTime
		{
			get
			{
				return this._CourseStartTime;
			}
			set
			{
				if ((this._CourseStartTime != value))
				{
					this.OnCourseStartTimeChanging(value);
					this.SendPropertyChanging();
					this._CourseStartTime = value;
					this.SendPropertyChanged("CourseStartTime");
					this.OnCourseStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseEndTime", DbType="Time")]
		public System.Nullable<System.TimeSpan> CourseEndTime
		{
			get
			{
				return this._CourseEndTime;
			}
			set
			{
				if ((this._CourseEndTime != value))
				{
					this.OnCourseEndTimeChanging(value);
					this.SendPropertyChanging();
					this._CourseEndTime = value;
					this.SendPropertyChanged("CourseEndTime");
					this.OnCourseEndTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CheckInStartTime", DbType="NVarChar(50)")]
		public string CheckInStartTime
		{
			get
			{
				return this._CheckInStartTime;
			}
			set
			{
				if ((this._CheckInStartTime != value))
				{
					this.OnCheckInStartTimeChanging(value);
					this.SendPropertyChanging();
					this._CheckInStartTime = value;
					this.SendPropertyChanged("CheckInStartTime");
					this.OnCheckInStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CheckInEndTime", DbType="NVarChar(50)")]
		public string CheckInEndTime
		{
			get
			{
				return this._CheckInEndTime;
			}
			set
			{
				if ((this._CheckInEndTime != value))
				{
					this.OnCheckInEndTimeChanging(value);
					this.SendPropertyChanging();
					this._CheckInEndTime = value;
					this.SendPropertyChanged("CheckInEndTime");
					this.OnCheckInEndTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseStartDate", DbType="Date")]
		public System.Nullable<System.DateTime> CourseStartDate
		{
			get
			{
				return this._CourseStartDate;
			}
			set
			{
				if ((this._CourseStartDate != value))
				{
					this.OnCourseStartDateChanging(value);
					this.SendPropertyChanging();
					this._CourseStartDate = value;
					this.SendPropertyChanged("CourseStartDate");
					this.OnCourseStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseEndDate", DbType="Date")]
		public System.Nullable<System.DateTime> CourseEndDate
		{
			get
			{
				return this._CourseEndDate;
			}
			set
			{
				if ((this._CourseEndDate != value))
				{
					this.OnCourseEndDateChanging(value);
					this.SendPropertyChanging();
					this._CourseEndDate = value;
					this.SendPropertyChanged("CourseEndDate");
					this.OnCourseEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_UserCourse", Storage="_UserCourses", ThisKey="Id", OtherKey="CourseId")]
		public EntitySet<UserCourse> UserCourses
		{
			get
			{
				return this._UserCourses;
			}
			set
			{
				this._UserCourses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_CourseAttendance", Storage="_CourseAttendances", ThisKey="Id", OtherKey="CourseId")]
		public EntitySet<CourseAttendance> CourseAttendances
		{
			get
			{
				return this._CourseAttendances;
			}
			set
			{
				this._CourseAttendances.Assign(value);
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
		
		private void attach_UserCourses(UserCourse entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_UserCourses(UserCourse entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
		
		private void attach_CourseAttendances(CourseAttendance entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_CourseAttendances(CourseAttendance entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
	}
}
#pragma warning restore 1591
