using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Department:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Department
	{
		public Department()
		{}
		#region Model
		private int _id;
		private string _departmentname;
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
		public string departmentname
		{
			set{ _departmentname=value;}
			get{return _departmentname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Beizhu
		{
			set{ _beizhu=value;}
			get{return _beizhu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BY1
		{
			set{ _by1=value;}
			get{return _by1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BY2
		{
			set{ _by2=value;}
			get{return _by2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BY3
		{
			set{ _by3=value;}
			get{return _by3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BY4
		{
			set{ _by4=value;}
			get{return _by4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BY5
		{
			set{ _by5=value;}
			get{return _by5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BY6
		{
			set{ _by6=value;}
			get{return _by6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BY7
		{
			set{ _by7=value;}
			get{return _by7;}
		}
		#endregion Model

	}
}

