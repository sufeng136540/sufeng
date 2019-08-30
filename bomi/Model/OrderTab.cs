using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// OrderTab:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderTab
	{
		public OrderTab()
		{}
		#region Model
		private int _id;
		private int? _memberid;
		private string _membername;
		private string _memberphone;
		private string _memberphone1;
		private string _memberadd;
		private DateTime? _orderdate;
		private string _ordernumber;
		private int? _staffmemberid;
		private string _staffmembername;
		private int? _usertabid;
		private int? _photoid1;
		private int? _photoid2;
		private int? _photoid3;
		private int? _photoid4;
		private string _qrcode;
		private DateTime? _validity;
		private int? _progress;
		private decimal? _deposit;
		private decimal? _allmoney;
		private decimal? _alllength;
		private decimal? _imperial;
		private decimal? _qhwidth;
		private string _beizhuwg;
		private string _beizhuzz;
		private string _zengsong;
		private int? _zhuangtai1;
		private int? _zhuangtai2;
		private decimal? _by1;
		private decimal? _by2;
		private decimal? _by3;
		private string _by4;
		private string _by5;
		private string _by6;
		private string _by7;
		private int? _homemadeid;
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
		public int? MemberID
		{
			set{ _memberid=value;}
			get{return _memberid;}
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
		public string MemberAdd
		{
			set{ _memberadd=value;}
			get{return _memberadd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Orderdate
		{
			set{ _orderdate=value;}
			get{return _orderdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderNumber
		{
			set{ _ordernumber=value;}
			get{return _ordernumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StaffmemberID
		{
			set{ _staffmemberid=value;}
			get{return _staffmemberid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Staffmembername
		{
			set{ _staffmembername=value;}
			get{return _staffmembername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserTabID
		{
			set{ _usertabid=value;}
			get{return _usertabid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PhotoID1
		{
			set{ _photoid1=value;}
			get{return _photoid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PhotoID2
		{
			set{ _photoid2=value;}
			get{return _photoid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PhotoID3
		{
			set{ _photoid3=value;}
			get{return _photoid3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PhotoID4
		{
			set{ _photoid4=value;}
			get{return _photoid4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qrcode
		{
			set{ _qrcode=value;}
			get{return _qrcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? validity
		{
			set{ _validity=value;}
			get{return _validity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? progress
		{
			set{ _progress=value;}
			get{return _progress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Deposit
		{
			set{ _deposit=value;}
			get{return _deposit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AllMoney
		{
			set{ _allmoney=value;}
			get{return _allmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? alllength
		{
			set{ _alllength=value;}
			get{return _alllength;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Imperial
		{
			set{ _imperial=value;}
			get{return _imperial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? QhWidth
		{
			set{ _qhwidth=value;}
			get{return _qhwidth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Beizhuwg
		{
			set{ _beizhuwg=value;}
			get{return _beizhuwg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Beizhuzz
		{
			set{ _beizhuzz=value;}
			get{return _beizhuzz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Zengsong
		{
			set{ _zengsong=value;}
			get{return _zengsong;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Zhuangtai1
		{
			set{ _zhuangtai1=value;}
			get{return _zhuangtai1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Zhuangtai2
		{
			set{ _zhuangtai2=value;}
			get{return _zhuangtai2;}
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
		/// <summary>
		/// 
		/// </summary>
		public int? HomemadeID
		{
			set{ _homemadeid=value;}
			get{return _homemadeid;}
		}
		#endregion Model

	}
}

