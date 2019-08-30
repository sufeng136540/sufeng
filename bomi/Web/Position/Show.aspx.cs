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
namespace Maticsoft.Web.Position
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
		Maticsoft.BLL.Position bll=new Maticsoft.BLL.Position();
		Maticsoft.Model.Position model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblname.Text=model.name;
		this.lblbeizhu.Text=model.beizhu;
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
