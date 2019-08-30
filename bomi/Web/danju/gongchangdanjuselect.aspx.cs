using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.danju
{
    public partial class kufangdanjuselect : System.Web.UI.Page
    {
        Maticsoft.BLL.OrderTab ot = new BLL.OrderTab();
        Maticsoft.BLL.phototab pt = new BLL.phototab();
        Maticsoft.BLL.Homemadetab hot = new BLL.Homemadetab();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"].ToString());
                Model.OrderTab or=ot.GetModel(id);
                Label1.Text = or.OrderNumber;
                if (or.PhotoID1!=0)
                {
                    Model.phototab ph = pt.GetModel(Convert.ToInt32(or.PhotoID1));
                    ImageButton1.ImageUrl = ph.Photourl;
                }
                if (or.PhotoID2 != 0)
                {
                    Model.phototab ph = pt.GetModel(Convert.ToInt32(or.PhotoID2));
                    ImageButton2.ImageUrl = ph.Photourl;
                }
                if (or.PhotoID3 != 0)
                {
                    Model.phototab ph = pt.GetModel(Convert.ToInt32(or.PhotoID3));
                    ImageButton3.ImageUrl = ph.Photourl;
                }
                if (or.PhotoID4 != 0)
                {
                    Model.phototab ph = pt.GetModel(Convert.ToInt32(or.PhotoID4));
                    ImageButton4.ImageUrl = ph.Photourl;
                }
                Label3.Text = or.alllength.ToString();
                Label4.Text = or.Imperial.ToString();
                Label5.Text = or.QhWidth.ToString();
                Label6.Text = or.Beizhuzz;
                Label7.Text = or.Zengsong;
                Label8.Text = or.MemberName;
                Label9.Text = or.MemberPhone;
                Label10.Text = or.MemberPhone1;
                Label11.Text = or.MemberAdd;
                Label12.Text =Convert.ToDateTime(or.validity).ToString("yyyy-MM-dd");
                Label13.Text = or.AllMoney.ToString();
                Label14.Text = or.Deposit.ToString();
                Maticsoft.Model.Homemadetab ho = hot.GetModel(Convert.ToInt32(or.HomemadeID));
                ImageButton5.ImageUrl = ho.Photourl;
                if (or.Zhuangtai2 == 1)
                {
                    Label15.Text = "未付全款";
                }
                else if (or.Zhuangtai2 == 2)
                {
                    Label15.Text = "已付全款";
                }
                else
                {
                    Label15.Text = "状态异常";
                }
            }
        }
        /// <summary>
        /// 返回仓库单据列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("gongchangdanjulist.aspx");
        }
    }
}