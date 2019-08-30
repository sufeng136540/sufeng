using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Member:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Member
	{
		public Member()
		{}
		#region Model
		private int _id;
		private string _membername;
		private string _memberphone;
		private string _memberphone1;
		private string _integral;
		private string _address;
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
		public string MemberName
		{
			set{ _membername=value;}
			get{return _membername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MemberPhone
		{
			set{ _memberphone=value;}
			get{return _memberphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MemberPhone1
		{
			set{ _memberphone1=value;}
			get{return _memberphone1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
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

