using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Maticsoft.Web
{
    public partial class login : System.Web.UI.Page
    {
        Maticsoft.BLL.Operator lBLL = new BLL.Operator();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (this.uname.Value.Trim() == "'or'='or'" || this.pwd.Value.Trim() == "'or'='or'")
            {

                Response.Write("<script>alert('别开玩笑行不行!')</script>");
            }
            else
            {
                string MM = FormsAuthentication.HashPasswordForStoringInConfigFile(this.pwd.Value.Trim(), "MD5");

                Maticsoft.Model.Operator oauser = lBLL.GetModelS("name='" + this.uname.Value.Trim() + "' and pwd='" + MM + "'");
                if (oauser != null)
                {
                    Session["user"] = oauser;
                    Response.Redirect("~/index.aspx");
                }
                else
                {
                    Response.Write(string.Format("<script>alert('用户名或密码错误！');location='login.aspx'</script>"));
                }
            }
        }
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            uname.Value = "";
            pwd.Value = "";
        }
    }
}