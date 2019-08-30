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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.OrderTab
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMemberID.Text))
			{
				strErr+="MemberID格式错误！\\n";	
			}
			if(this.txtMemberName.Text.Trim().Length==0)
			{
				strErr+="MemberName不能为空！\\n";	
			}
			if(this.txtMemberPhone.Text.Trim().Length==0)
			{
				strErr+="MemberPhone不能为空！\\n";	
			}
			if(this.txtMemberPhone1.Text.Trim().Length==0)
			{
				strErr+="MemberPhone1不能为空！\\n";	
			}
			if(this.txtMemberAdd.Text.Trim().Length==0)
			{
				strErr+="MemberAdd不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOrderdate.Text))
			{
				strErr+="Orderdate格式错误！\\n";	
			}
			if(this.txtOrderNumber.Text.Trim().Length==0)
			{
				strErr+="OrderNumber不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtStaffmemberID.Text))
			{
				strErr+="StaffmemberID格式错误！\\n";	
			}
			if(this.txtStaffmembername.Text.Trim().Length==0)
			{
				strErr+="Staffmembername不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserTabID.Text))
			{
				strErr+="UserTabID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPhotoID.Text))
			{
				strErr+="PhotoID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtvalidity.Text))
			{
				strErr+="validity格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtprogress.Text))
			{
				strErr+="progress格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtDeposit.Text))
			{
				strErr+="Deposit格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAllMoney.Text))
			{
				strErr+="AllMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtalllength.Text))
			{
				strErr+="alllength格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtImperial.Text))
			{
				strErr+="Imperial格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtQhWidth.Text))
			{
				strErr+="QhWidth格式错误！\\n";	
			}
			if(this.txtBeizhuwg.Text.Trim().Length==0)
			{
				strErr+="Beizhuwg不能为空！\\n";	
			}
			if(this.txtBeizhuzz.Text.Trim().Length==0)
			{
				strErr+="Beizhuzz不能为空！\\n";	
			}
			if(this.txtZengsong.Text.Trim().Length==0)
			{
				strErr+="Zengsong不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtZhuangtai1.Text))
			{
				strErr+="Zhuangtai1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtZhuangtai2.Text))
			{
				strErr+="Zhuangtai2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBy1.Text))
			{
				strErr+="By1格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBy2.Text))
			{
				strErr+="By2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBy3.Text))
			{
				strErr+="By3格式错误！\\n";	
			}
			if(this.txtBy4.Text.Trim().Length==0)
			{
				strErr+="By4不能为空！\\n";	
			}
			if(this.txtBy5.Text.Trim().Length==0)
			{
				strErr+="By5不能为空！\\n";	
			}
			if(this.txtBy6.Text.Trim().Length==0)
			{
				strErr+="By6不能为空！\\n";	
			}
			if(this.txtBy7.Text.Trim().Length==0)
			{
				strErr+="By7不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MemberID=int.Parse(this.txtMemberID.Text);
			string MemberName=this.txtMemberName.Text;
			string MemberPhone=this.txtMemberPhone.Text;
			string MemberPhone1=this.txtMemberPhone1.Text;
			string MemberAdd=this.txtMemberAdd.Text;
			DateTime Orderdate=DateTime.Parse(this.txtOrderdate.Text);
			string OrderNumber=this.txtOrderNumber.Text;
			int StaffmemberID=int.Parse(this.txtStaffmemberID.Text);
			string Staffmembername=this.txtStaffmembername.Text;
			int UserTabID=int.Parse(this.txtUserTabID.Text);
			int PhotoID=int.Parse(this.txtPhotoID.Text);
			DateTime validity=DateTime.Parse(this.txtvalidity.Text);
			int progress=int.Parse(this.txtprogress.Text);
			decimal Deposit=decimal.Parse(this.txtDeposit.Text);
			decimal AllMoney=decimal.Parse(this.txtAllMoney.Text);
			decimal alllength=decimal.Parse(this.txtalllength.Text);
			decimal Imperial=decimal.Parse(this.txtImperial.Text);
			decimal QhWidth=decimal.Parse(this.txtQhWidth.Text);
			string Beizhuwg=this.txtBeizhuwg.Text;
			string Beizhuzz=this.txtBeizhuzz.Text;
			string Zengsong=this.txtZengsong.Text;
			int Zhuangtai1=int.Parse(this.txtZhuangtai1.Text);
			int Zhuangtai2=int.Parse(this.txtZhuangtai2.Text);
			decimal By1=decimal.Parse(this.txtBy1.Text);
			decimal By2=decimal.Parse(this.txtBy2.Text);
			decimal By3=decimal.Parse(this.txtBy3.Text);
			string By4=this.txtBy4.Text;
			string By5=this.txtBy5.Text;
			string By6=this.txtBy6.Text;
			string By7=this.txtBy7.Text;

			Maticsoft.Model.OrderTab model=new Maticsoft.Model.OrderTab();
			model.MemberID=MemberID;
			model.MemberName=MemberName;
			model.MemberPhone=MemberPhone;
			model.MemberPhone1=MemberPhone1;
			model.MemberAdd=MemberAdd;
			model.Orderdate=Orderdate;
			model.OrderNumber=OrderNumber;
			model.StaffmemberID=StaffmemberID;
			model.Staffmembername=Staffmembername;
			model.UserTabID=UserTabID;
			model.PhotoID=PhotoID;
			model.validity=validity;
			model.progress=progress;
			model.Deposit=Deposit;
			model.AllMoney=AllMoney;
			model.alllength=alllength;
			model.Imperial=Imperial;
			model.QhWidth=QhWidth;
			model.Beizhuwg=Beizhuwg;
			model.Beizhuzz=Beizhuzz;
			model.Zengsong=Zengsong;
			model.Zhuangtai1=Zhuangtai1;
			model.Zhuangtai2=Zhuangtai2;
			model.By1=By1;
			model.By2=By2;
			model.By3=By3;
			model.By4=By4;
			model.By5=By5;
			model.By6=By6;
			model.By7=By7;

			Maticsoft.BLL.OrderTab bll=new Maticsoft.BLL.OrderTab();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
