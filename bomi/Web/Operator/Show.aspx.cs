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
namespace Maticsoft.Web.Operator
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
		Maticsoft.BLL.Operator bll=new Maticsoft.BLL.Operator();
		Maticsoft.Model.Operator model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblname.Text=model.name;
		this.lblpwd.Text=model.pwd;
		this.lblBranchID.Text=model.BranchID.ToString();
		this.lbldepartmentID.Text=model.departmentID.ToString();
		this.lblStaffmemberID.Text=model.StaffmemberID.ToString();
		this.lblJurisdictionID.Text=model.JurisdictionID.ToString();
		this.lblBeizhu.Text=model.Beizhu;
		this.lblBY1.Text=model.BY1.ToString();
		this.lblBY2.Text=model.BY2.ToString();
		this.lblBY3.Text=model.BY3.ToString();
		this.lblBY4.Text=model.BY4;
		this.lblBY5.Text=model.BY5;
		this.lblBY6.Text=model.BY6;
		this.lblBY7.Text=model.BY7;

	}


    }
}
