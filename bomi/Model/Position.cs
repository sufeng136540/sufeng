﻿using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Position:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Position
	{
		public Position()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _beizhu;
		private decimal? _by1;
		private decimal? _by2;
		private decimal? _by3;
		private string _by4;
		private string _by5;
		private string _by6;
		private string _by7;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string beizhu
		{
			set{ _beizhu=value;}
			get{return _beizhu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? By1
		{
			set{ _by1=value;}
			get{return _by1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? By2
		{
			set{ _by2=value;}
			get{return _by2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? By3
		{
			set{ _by3=value;}
			get{return _by3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string By4
		{
			set{ _by4=value;}
			get{return _by4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string By5
		{
			set{ _by5=value;}
			get{return _by5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string By6
		{
			set{ _by6=value;}
			get{return _by6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string By7
		{
			set{ _by7=value;}
			get{return _by7;}
		}
		#endregion Model

	}
}

