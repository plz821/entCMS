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
	/// 实体类cmsNewsHit 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class cmsNewsHit : Entity 
	{
		public cmsNewsHit():base("cmsNewsHit") {}

		#region Model
		private long _Id;
		private string _NewsId;
		private int? _Hits;
		private DateTime _HitDate;
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
		public string NewsId
		{
			get{ return _NewsId; }
			set
			{
				this.OnPropertyValueChange(_.NewsId,_NewsId,value);
				this._NewsId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Hits
		{
			get{ return _Hits; }
			set
			{
				this.OnPropertyValueChange(_.Hits,_Hits,value);
				this._Hits=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime HitDate
		{
			get{ return _HitDate; }
			set
			{
				this.OnPropertyValueChange(_.HitDate,_HitDate,value);
				this._HitDate=value;
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
				_.NewsId,
				_.Hits,
				_.HitDate};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._NewsId,
				this._Hits,
				this._HitDate};
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(IDataReader reader)
		{
			this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
			this._NewsId = DataUtils.ConvertValue<string>(reader["NewsId"]);
			this._Hits = DataUtils.ConvertValue<int?>(reader["Hits"]);
			this._HitDate = DataUtils.ConvertValue<DateTime>(reader["HitDate"]);
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(DataRow row)
		{
			this._Id = DataUtils.ConvertValue<long>(row["Id"]);
			this._NewsId = DataUtils.ConvertValue<string>(row["NewsId"]);
			this._Hits = DataUtils.ConvertValue<int?>(row["Hits"]);
			this._HitDate = DataUtils.ConvertValue<DateTime>(row["HitDate"]);
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
			public readonly static Field All = new Field("*","cmsNewsHit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","cmsNewsHit","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NewsId = new Field("NewsId","cmsNewsHit","NewsId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Hits = new Field("Hits","cmsNewsHit","Hits");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HitDate = new Field("HitDate","cmsNewsHit","HitDate");
		}
		#endregion


	}
}
