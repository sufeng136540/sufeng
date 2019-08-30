using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web
{
    public partial class xinceshi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Label1.Text = "111";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "测试" + TextBox1.Text;
        }
    }
}