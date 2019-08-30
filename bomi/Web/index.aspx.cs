using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web
{
    public partial class index : System.Web.UI.Page
    {
        private BLL.Staffmember sf = new BLL.Staffmember();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Maticsoft.Model.Operator oauser = (Maticsoft.Model.Operator)Session["user"];
                    if (oauser == null)
                    {
                        Response.Write(string.Format("<script>alert('登录超时！');window.top.location.href='login.aspx'</script>"));
                    }
                    else
                    {
                        Model.Staffmember st = sf.GetModel(Convert.ToInt32(oauser.StaffmemberID));
                        this.Label1.Text = st.Staffname;
                        this.Label2.Text = Convert.ToString(System.DateTime.Now.ToString("yyyy 年 MM 月 dd 日"));
                        ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
                    }
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('页面异常')</script>");
            }
        }
    }
}