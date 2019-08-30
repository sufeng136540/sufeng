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
namespace Maticsoft.Web.ContractTab
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtOrderNumber.Text.Trim().Length==0)
			{
				strErr+="OrderNumber不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCommodityID.Text))
			{
				strErr+="CommodityID格式错误！\\n";	
			}
			if(this.txtbeizhu.Text.Trim().Length==0)
			{
				strErr+="beizhu不能为空！\\n";	
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
			string OrderNumber=this.txtOrderNumber.Text;
			int CommodityID=int.Parse(this.txtCommodityID.Text);
			string beizhu=this.txtbeizhu.Text;
			decimal By1=decimal.Parse(this.txtBy1.Text);
			decimal By2=decimal.Parse(this.txtBy2.Text);
			decimal By3=decimal.Parse(this.txtBy3.Text);
			string By4=this.txtBy4.Text;
			string By5=this.txtBy5.Text;
			string By6=this.txtBy6.Text;
			string By7=this.txtBy7.Text;

			Maticsoft.Model.ContractTab model=new Maticsoft.Model.ContractTab();
			model.OrderNumber=OrderNumber;
			model.CommodityID=CommodityID;
			model.beizhu=beizhu;
			model.By1=By1;
			model.By2=By2;
			model.By3=By3;
			model.By4=By4;
			model.By5=By5;
			model.By6=By6;
			model.By7=By7;

			Maticsoft.BLL.ContractTab bll=new Maticsoft.BLL.ContractTab();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
