using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace Maticsoft.Web
{
    /// <summary>
    /// xiansyhi 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class xiansyhi : System.Web.Services.WebService
    {
        Maticsoft.BLL.OrderTab or = new BLL.OrderTab();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string jiekou(string id)
        {
            DataSet ds = or.GetList("OrderNumber like '"+id+"'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                int a = Convert.ToInt32(ds.Tables[0].Rows[0]["progress"]);
                if (a == 0)
                {
                    return "单据生成草稿";
                }
                else if (a == 1)
                {
                    return "工厂确认，下单成功";
                }
                else if (a == 2)
                {
                    return "开始排产，进材料";
                }
                else if (a == 3)
                {
                    return "正在生产中";
                }
                else if (a == 4)
                {
                    return "以入库";
                }
                else if (a == 5)
                {
                    return "以付全款，准备送货";
                }
                else
                {
                    return "完成";
                }
            }
            else
            {
                return "没有该单据";
            }
          

            
        }
    }
}
