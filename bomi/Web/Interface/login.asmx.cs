using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Security;

namespace Maticsoft.Web.Interface
{
    /// <summary>
    /// login 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class login : System.Web.Services.WebService
    {
        Maticsoft.BLL.Operator lBLL = new BLL.Operator();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string entry(string name,string pwd)
        {
            string MM = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "MD5");
            Maticsoft.Model.Operator oauser = lBLL.GetModelS("name='" + name + "' and pwd='" + MM + "'");
            if (oauser != null)
            {
                string qqq = @"{""data"":{""ds"":""1"",""userid"":""" + oauser.id + "\"}}";
                return qqq;
            }
            else
            {
                return @"{""data"":{""ds"":""0""}}";
            }
        }
    }
}
