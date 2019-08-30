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
namespace Maticsoft.Web.Currentaccount
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txttype.Text))
			{
				strErr+="type格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMemberID.Text))
			{
				strErr+="MemberID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOrderTabday.Text))
			{
				strErr+="OrderTabday格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOrderTabmoney.Text))
			{
				strErr+="OrderTabmoney格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtreceipt.Text))
			{
				strErr+="receipt格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtmoney.Text))
			{
				strErr+="money格式错误！\\n";	
			}
			if(this.txtBeizhu.Text.Trim().Length==0)
			{
				strErr+="Beizhu不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBY1.Text))
			{
				strErr+="BY1格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBY2.Text))
			{
				strErr+="BY2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBY3.Text))
			{
				strErr+="BY3格式错误！\\n";	
			}
			if(this.txtBY4.Text.Trim().Length==0)
			{
				strErr+="BY4不能为空！\\n";	
			}
			if(this.txtBY5.Text.Trim().Length==0)
			{
				strErr+="BY5不能为空！\\n";	
			}
			if(this.txtBY6.Text.Trim().Length==0)
			{
				strErr+="BY6不能为空！\\n";	
			}
			if(this.txtBY7.Text.Trim().Length==0)
			{
				strErr+="BY7不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int type=int.Parse(this.txttype.Text);
			int MemberID=int.Parse(this.txtMemberID.Text);
			DateTime OrderTabday=DateTime.Parse(this.txtOrderTabday.Text);
			decimal OrderTabmoney=decimal.Parse(this.txtOrderTabmoney.Text);
			DateTime receipt=DateTime.Parse(this.txtreceipt.Text);
			decimal money=decimal.Parse(this.txtmoney.Text);
			string Beizhu=this.txtBeizhu.Text;
			decimal BY1=decimal.Parse(this.txtBY1.Text);
			decimal BY2=decimal.Parse(this.txtBY2.Text);
			decimal BY3=decimal.Parse(this.txtBY3.Text);
			string BY4=this.txtBY4.Text;
			string BY5=this.txtBY5.Text;
			string BY6=this.txtBY6.Text;
			string BY7=this.txtBY7.Text;

			Maticsoft.Model.Currentaccount model=new Maticsoft.Model.Currentaccount();
			model.type=type;
			model.MemberID=MemberID;
			model.OrderTabday=OrderTabday;
			model.OrderTabmoney=OrderTabmoney;
			model.receipt=receipt;
			model.money=money;
			model.Beizhu=Beizhu;
			model.BY1=BY1;
			model.BY2=BY2;
			model.BY3=BY3;
			model.BY4=BY4;
			model.BY5=BY5;
			model.BY6=BY6;
			model.BY7=BY7;

			Maticsoft.BLL.Currentaccount bll=new Maticsoft.BLL.Currentaccount();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
