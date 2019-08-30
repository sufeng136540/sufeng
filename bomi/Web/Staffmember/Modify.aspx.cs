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
namespace Maticsoft.Web.Staffmember
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		Maticsoft.BLL.Staffmember bll=new Maticsoft.BLL.Staffmember();
		Maticsoft.Model.Staffmember model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtStaffname.Text=model.Staffname;
		this.txtinformation.Text=model.information;
		this.txtdepartmentID.Text=model.departmentID.ToString();
		this.txtPositionid.Text=model.Positionid.ToString();
		this.txtBeizhu.Text=model.Beizhu;
		this.txtBY1.Text=model.BY1.ToString();
		this.txtBY2.Text=model.BY2.ToString();
		this.txtBY3.Text=model.BY3.ToString();
		this.txtBY4.Text=model.BY4;
		this.txtBY5.Text=model.BY5;
		this.txtBY6.Text=model.BY6;
		this.txtBY7.Text=model.BY7;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtStaffname.Text.Trim().Length==0)
			{
				strErr+="Staffname不能为空！\\n";	
			}
			if(this.txtinformation.Text.Trim().Length==0)
			{
				strErr+="information不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtdepartmentID.Text))
			{
				strErr+="departmentID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPositionid.Text))
			{
				strErr+="Positionid格式错误！\\n";	
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
			int id=int.Parse(this.lblid.Text);
			string Staffname=this.txtStaffname.Text;
			string information=this.txtinformation.Text;
			int departmentID=int.Parse(this.txtdepartmentID.Text);
			int Positionid=int.Parse(this.txtPositionid.Text);
			string Beizhu=this.txtBeizhu.Text;
			decimal BY1=decimal.Parse(this.txtBY1.Text);
			decimal BY2=decimal.Parse(this.txtBY2.Text);
			decimal BY3=decimal.Parse(this.txtBY3.Text);
			string BY4=this.txtBY4.Text;
			string BY5=this.txtBY5.Text;
			string BY6=this.txtBY6.Text;
			string BY7=this.txtBY7.Text;


			Maticsoft.Model.Staffmember model=new Maticsoft.Model.Staffmember();
			model.id=id;
			model.Staffname=Staffname;
			model.information=information;
			model.departmentID=departmentID;
			model.Positionid=Positionid;
			model.Beizhu=Beizhu;
			model.BY1=BY1;
			model.BY2=BY2;
			model.BY3=BY3;
			model.BY4=BY4;
			model.BY5=BY5;
			model.BY6=BY6;
			model.BY7=BY7;

			Maticsoft.BLL.Staffmember bll=new Maticsoft.BLL.Staffmember();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
