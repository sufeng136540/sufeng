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
namespace Maticsoft.Web.Homemadetab
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
		Maticsoft.BLL.Homemadetab bll=new Maticsoft.BLL.Homemadetab();
		Maticsoft.Model.Homemadetab model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblName.Text=model.Name;
		this.lblPhotourl.Text=model.Photourl;
		this.lblComment.Text=model.Comment;
		this.lblBeizhu.Text=model.Beizhu;
		this.lblBY1.Text=model.BY1.ToString();
		this.lblBY2.Text=model.BY2.ToString();
		this.lblBY3.Text=model.BY3.ToString();
		this.lblBY4.Text=model.BY4.ToString();
		this.lblBY5.Text=model.BY5.ToString();
		this.lblBY6.Text=model.BY6.ToString();
		this.lblBY7.Text=model.BY7.ToString();

	}


    }
}
