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
	/// 实体类cmsUserPurview 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class cmsUserPurview : Entity 
	{
		public cmsUserPurview():base("cmsUserPurview") {}

		#region Model
		private long _Id;
		private long? _UserId;
		private string _NodeCode;
		private int? _Type;
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
		public string NodeCode
		{
			get{ return _NodeCode; }
			set
			{
				this.OnPropertyValueChange(_.NodeCode,_NodeCode,value);
				this._NodeCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Type
		{
			get{ return _Type; }
			set
			{
				this.OnPropertyValueChange(_.Type,_Type,value);
				this._Type=value;
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
				_.NodeCode,
				_.Type};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._UserId,
				this._NodeCode,
				this._Type};
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(IDataReader reader)
		{
			this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
			this._UserId = DataUtils.ConvertValue<long?>(reader["UserId"]);
			this._NodeCode = DataUtils.ConvertValue<string>(reader["NodeCode"]);
			this._Type = DataUtils.ConvertValue<int?>(reader["Type"]);
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(DataRow row)
		{
			this._Id = DataUtils.ConvertValue<long>(row["Id"]);
			this._UserId = DataUtils.ConvertValue<long?>(row["UserId"]);
			this._NodeCode = DataUtils.ConvertValue<string>(row["NodeCode"]);
			this._Type = DataUtils.ConvertValue<int?>(row["Type"]);
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
			public readonly static Field All = new Field("*","cmsUserPurview");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","cmsUserPurview","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserId = new Field("UserId","cmsUserPurview","UserId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NodeCode = new Field("NodeCode","cmsUserPurview","NodeCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Type = new Field("Type","cmsUserPurview","Type");
		}
		#endregion


	}
}

