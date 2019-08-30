﻿using System;
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
namespace Maticsoft.Web.Commoditytab
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
		Maticsoft.BLL.Commoditytab bll=new Maticsoft.BLL.Commoditytab();
		Maticsoft.Model.Commoditytab model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblcategory.Text=model.category.ToString();
		this.lblName.Text=model.Name;
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