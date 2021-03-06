﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.5444
//     Support: http://www.cnblogs.com/huxj
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Hxj.Data;
using Hxj.Data.Common;

namespace entCMS.Models
{

	/// <summary>
	/// 实体类cmsUser 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class cmsUser : Entity 
	{
		public cmsUser():base("cmsUser") {}

		#region Model
		private long _Id;
		private string _UName;
		private string _UPwd;
		private string _Name;
		private int? _DeptId;
		private string _DeptName;
		private string _UpUsers;
		private int? _UserType;
		private int? _LoginCount;
		private string _LastIp;
		private DateTime? _LastTime;
		private int? _IsEnabled;
		private DateTime? _CreateTime;
		/// <summary>
		/// 
		/// </summary>
		public long Id
		{
			get{ return _Id; }
			set
			{
				this.OnPropertyValueChange(_.Id,_Id,value);
				this._Id=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UName
		{
			get{ return _UName; }
			set
			{
				this.OnPropertyValueChange(_.UName,_UName,value);
				this._UName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPwd
		{
			get{ return _UPwd; }
			set
			{
				this.OnPropertyValueChange(_.UPwd,_UPwd,value);
				this._UPwd=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			get{ return _Name; }
			set
			{
				this.OnPropertyValueChange(_.Name,_Name,value);
				this._Name=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DeptId
		{
			get{ return _DeptId; }
			set
			{
				this.OnPropertyValueChange(_.DeptId,_DeptId,value);
				this._DeptId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptName
		{
			get{ return _DeptName; }
			set
			{
				this.OnPropertyValueChange(_.DeptName,_DeptName,value);
				this._DeptName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpUsers
		{
			get{ return _UpUsers; }
			set
			{
				this.OnPropertyValueChange(_.UpUsers,_UpUsers,value);
				this._UpUsers=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserType
		{
			get{ return _UserType; }
			set
			{
				this.OnPropertyValueChange(_.UserType,_UserType,value);
				this._UserType=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LoginCount
		{
			get{ return _LoginCount; }
			set
			{
				this.OnPropertyValueChange(_.LoginCount,_LoginCount,value);
				this._LoginCount=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LastIp
		{
			get{ return _LastIp; }
			set
			{
				this.OnPropertyValueChange(_.LastIp,_LastIp,value);
				this._LastIp=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LastTime
		{
			get{ return _LastTime; }
			set
			{
				this.OnPropertyValueChange(_.LastTime,_LastTime,value);
				this._LastTime=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsEnabled
		{
			get{ return _IsEnabled; }
			set
			{
				this.OnPropertyValueChange(_.IsEnabled,_IsEnabled,value);
				this._IsEnabled=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			get{ return _CreateTime; }
			set
			{
				this.OnPropertyValueChange(_.CreateTime,_CreateTime,value);
				this._CreateTime=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.Id;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.Id};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.Id,
				_.UName,
				_.UPwd,
				_.Name,
				_.DeptId,
				_.DeptName,
				_.UpUsers,
				_.UserType,
				_.LoginCount,
				_.LastIp,
				_.LastTime,
				_.IsEnabled,
				_.CreateTime};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._UName,
				this._UPwd,
				this._Name,
				this._DeptId,
				this._DeptName,
				this._UpUsers,
				this._UserType,
				this._LoginCount,
				this._LastIp,
				this._LastTime,
				this._IsEnabled,
				this._CreateTime};
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(IDataReader reader)
		{
			this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
			this._UName = DataUtils.ConvertValue<string>(reader["UName"]);
			this._UPwd = DataUtils.ConvertValue<string>(reader["UPwd"]);
			this._Name = DataUtils.ConvertValue<string>(reader["Name"]);
			this._DeptId = DataUtils.ConvertValue<int?>(reader["DeptId"]);
			this._DeptName = DataUtils.ConvertValue<string>(reader["DeptName"]);
			this._UpUsers = DataUtils.ConvertValue<string>(reader["UpUsers"]);
			this._UserType = DataUtils.ConvertValue<int?>(reader["UserType"]);
			this._LoginCount = DataUtils.ConvertValue<int?>(reader["LoginCount"]);
			this._LastIp = DataUtils.ConvertValue<string>(reader["LastIp"]);
			this._LastTime = DataUtils.ConvertValue<DateTime?>(reader["LastTime"]);
			this._IsEnabled = DataUtils.ConvertValue<int?>(reader["IsEnabled"]);
			this._CreateTime = DataUtils.ConvertValue<DateTime?>(reader["CreateTime"]);
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(DataRow row)
		{
			this._Id = DataUtils.ConvertValue<long>(row["Id"]);
			this._UName = DataUtils.ConvertValue<string>(row["UName"]);
			this._UPwd = DataUtils.ConvertValue<string>(row["UPwd"]);
			this._Name = DataUtils.ConvertValue<string>(row["Name"]);
			this._DeptId = DataUtils.ConvertValue<int?>(row["DeptId"]);
			this._DeptName = DataUtils.ConvertValue<string>(row["DeptName"]);
			this._UpUsers = DataUtils.ConvertValue<string>(row["UpUsers"]);
			this._UserType = DataUtils.ConvertValue<int?>(row["UserType"]);
			this._LoginCount = DataUtils.ConvertValue<int?>(row["LoginCount"]);
			this._LastIp = DataUtils.ConvertValue<string>(row["LastIp"]);
			this._LastTime = DataUtils.ConvertValue<DateTime?>(row["LastTime"]);
			this._IsEnabled = DataUtils.ConvertValue<int?>(row["IsEnabled"]);
			this._CreateTime = DataUtils.ConvertValue<DateTime?>(row["CreateTime"]);
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","cmsUser");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","cmsUser","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UName = new Field("UName","cmsUser","UName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UPwd = new Field("UPwd","cmsUser","UPwd");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Name = new Field("Name","cmsUser","Name");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptId = new Field("DeptId","cmsUser","DeptId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","cmsUser","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UpUsers = new Field("UpUsers","cmsUser","UpUsers");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserType = new Field("UserType","cmsUser","UserType");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LoginCount = new Field("LoginCount","cmsUser","LoginCount");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LastIp = new Field("LastIp","cmsUser","LastIp");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LastTime = new Field("LastTime","cmsUser","LastTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsEnabled = new Field("IsEnabled","cmsUser","IsEnabled");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime","cmsUser","CreateTime");
		}
		#endregion


	}
}

