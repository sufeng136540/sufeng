using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Permissionstab:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Permissionstab
	{
		public Permissionstab()
		{}
		#region Model
		private int _id;
		private int? _operatorid;
		private int? _look;
		private int? _audit;
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
		public int? Operatorid
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Look
		{
			set{ _look=value;}
			get{return _look;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Audit
		{
			set{ _audit=value;}
			get{return _audit;}
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
		public decimal? by1
		{
			set{ _by1=value;}
			get{return _by1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? by2
		{
			set{ _by2=value;}
			get{return _by2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? by3
		{
			set{ _by3=value;}
			get{return _by3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string by4
		{
			set{ _by4=value;}
			get{return _by4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string by5
		{
			set{ _by5=value;}
			get{return _by5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string by6
		{
			set{ _by6=value;}
			get{return _by6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string by7
		{
			set{ _by7=value;}
			get{return _by7;}
		}
		#endregion Model

	}
}

