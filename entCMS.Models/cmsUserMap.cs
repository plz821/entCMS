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
	/// 实体类cmsUserMap 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class cmsUserMap : Entity 
	{
		public cmsUserMap():base("cmsUserMap") {}

		#region Model
		private long _Id;
		private long? _UserId;
		private long? _UpUserId;
		private string _UpUser;
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
		public long? UserId
		{
			get{ return _UserId; }
			set
			{
				this.OnPropertyValueChange(_.UserId,_UserId,value);
				this._UserId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? UpUserId
		{
			get{ return _UpUserId; }
			set
			{
				this.OnPropertyValueChange(_.UpUserId,_UpUserId,value);
				this._UpUserId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpUser
		{
			get{ return _UpUser; }
			set
			{
				this.OnPropertyValueChange(_.UpUser,_UpUser,value);
				this._UpUser=value;
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
				_.UserId,
				_.UpUserId,
				_.UpUser};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._UserId,
				this._UpUserId,
				this._UpUser};
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(IDataReader reader)
		{
			this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
			this._UserId = DataUtils.ConvertValue<long?>(reader["UserId"]);
			this._UpUserId = DataUtils.ConvertValue<long?>(reader["UpUserId"]);
			this._UpUser = DataUtils.ConvertValue<string>(reader["UpUser"]);
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(DataRow row)
		{
			this._Id = DataUtils.ConvertValue<long>(row["Id"]);
			this._UserId = DataUtils.ConvertValue<long?>(row["UserId"]);
			this._UpUserId = DataUtils.ConvertValue<long?>(row["UpUserId"]);
			this._UpUser = DataUtils.ConvertValue<string>(row["UpUser"]);
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
			public readonly static Field All = new Field("*","cmsUserMap");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","cmsUserMap","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserId = new Field("UserId","cmsUserMap","UserId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UpUserId = new Field("UpUserId","cmsUserMap","UpUserId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UpUser = new Field("UpUser","cmsUserMap","UpUser");
		}
		#endregion


	}
}

