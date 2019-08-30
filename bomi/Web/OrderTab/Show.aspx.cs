using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace Maticsoft.Web.OrderTab
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		Maticsoft.BLL.OrderTab bll=new Maticsoft.BLL.OrderTab();
		Maticsoft.Model.OrderTab model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblMemberID.Text=model.MemberID.ToString();
		this.lblMemberName.Text=model.MemberName;
		this.lblMemberPhone.Text=model.MemberPhone;
		this.lblMemberPhone1.Text=model.MemberPhone1;
		this.lblMemberAdd.Text=model.MemberAdd;
		this.lblOrderdate.Text=model.Orderdate.ToString();
		this.lblOrderNumber.Text=model.OrderNumber;
		this.lblStaffmemberID.Text=model.StaffmemberID.ToString();
		this.lblStaffmembername.Text=model.Staffmembername;
		this.lblUserTabID.Text=model.UserTabID.ToString();
		this.lblPhotoID.Text=model.PhotoID.ToString();
		this.lblvalidity.Text=model.validity.ToString();
		this.lblprogress.Text=model.progress.ToString();
		this.lblDeposit.Text=model.Deposit.ToString();
		this.lblAllMoney.Text=model.AllMoney.ToString();
		this.lblalllength.Text=model.alllength.ToString();
		this.lblImperial.Text=model.Imperial.ToString();
		this.lblQhWidth.Text=model.QhWidth.ToString();
		this.lblBeizhuwg.Text=model.Beizhuwg;
		this.lblBeizhuzz.Text=model.Beizhuzz;
		this.lblZengsong.Text=model.Zengsong;
		this.lblZhuangtai1.Text=model.Zhuangtai1.ToString();
		this.lblZhuangtai2.Text=model.Zhuangtai2.ToString();
		this.lblBy1.Text=model.By1.ToString();
		this.lblBy2.Text=model.By2.ToString();
		this.lblBy3.Text=model.By3.ToString();
		this.lblBy4.Text=model.By4;
		this.lblBy5.Text=model.By5;
		this.lblBy6.Text=model.By6;
		this.lblBy7.Text=model.By7;

	}


    }
}
