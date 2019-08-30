using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Currentaccount:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Currentaccount
	{
		public Currentaccount()
		{}
		#region Model
		private int _id;
		private int? _type;
		private string _billnumber;
		private DateTime? _ordertabday;
		private decimal? _ordertabmoney;
		private DateTime? _receipt;
		private decimal? _money;
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
		public int? type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string billnumber
		{
			set{ _billnumber=value;}
			get{return _billnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OrderTabday
		{
			set{ _ordertabday=value;}
			get{return _ordertabday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OrderTabmoney
		{
			set{ _ordertabmoney=value;}
			get{return _ordertabmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? receipt
		{
			set{ _receipt=value;}
			get{return _receipt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? money
		{
			set{ _money=value;}
			get{return _money;}
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

