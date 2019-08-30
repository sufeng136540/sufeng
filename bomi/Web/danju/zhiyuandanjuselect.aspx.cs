using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Maticsoft.Web.danju
{
    public partial class zhiyuandanjuselect : System.Web.UI.Page
    {
        Maticsoft.BLL.OrderTab ot = new BLL.OrderTab();//单据
        Maticsoft.BLL.phototab pt = new BLL.phototab();//图片表
        Maticsoft.BLL.ContractTab ct = new BLL.ContractTab();//单据外购明细表
        Maticsoft.BLL.Commoditytab com = new BLL.Commoditytab();//外购商品
        Maticsoft.BLL.Homemadetab hot = new BLL.Homemadetab();//自制商品
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"].ToString());
                Model.OrderTab or = ot.GetModel(id);
                Label1.Text = or.OrderNumber;
                if (or.PhotoID1 != 0)
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
                Label12.Text = Convert.ToDateTime(or.validity).ToString("yyyy-MM-dd");
                Label13.Text = or.AllMoney.ToString();
                Label14.Text = or.Deposit.ToString();
                Label15.Text = or.Beizhuwg;
                Maticsoft.Model.Homemadetab ho = hot.GetModel(Convert.ToInt32(or.HomemadeID));
                ImageButton5.ImageUrl = ho.Photourl;
                if(or.Zhuangtai2==1)
                {
                    Label23.Text = "未付全款";
                }
                else if (or.Zhuangtai2 == 2)
                {
                    Label23.Text = "已付全款";
                }
                else
                {
                    Label23.Text = "状态异常";
                }
                DataSet ds = ct.GetList(" OrderNumber like '"+Label1.Text+"'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count;i++ )
                    {
                        Model.ContractTab con = ct.GetModel(Convert.ToInt32(ds.Tables[0].Rows[i]["id"]));
                        if(con.By1==1)
                        {
                            Label16.Text = con.CommodityID;
                        }
                        else if (con.By1 == 2)
                        {
                            Label17.Text = con.CommodityID;
                        }
                        else if (con.By1 == 3)
                        {
                            Label18.Text = con.CommodityID;
                        }
                        else if (con.By1 == 4)
                        {
                            Label19.Text = con.CommodityID;
                        }
                        else if (con.By1 == 5)
                        {
                            Label20.Text = con.CommodityID;
                        }
                        else if (con.By1 == 6)
                        {
                            Label21.Text = con.CommodityID;
                        }
                        else if (con.By1 == 7)
                        {
                            Label22.Text = con.CommodityID;
                        }
                        else
                        {

                        }
                        if (i == ds.Tables[0].Rows.Count-1)
                        {
                            if (Label16.Text == "") { Label16.Text = "无"; } if (Label17.Text == "") { Label17.Text = "无"; } if (Label18.Text == "") { Label18.Text = "无"; }
                            if (Label19.Text == "") { Label19.Text = "无"; } if (Label20.Text == "") { Label20.Text = "无"; } if (Label21.Text == "") { Label21.Text = "无"; }
                            if (Label22.Text == "") { Label22.Text = "无"; }
                        }
                    }
                }
                else
                {
                    Label16.Text = "无";
                    Label17.Text = "无";
                    Label18.Text = "无";
                    Label19.Text = "无";
                    Label20.Text = "无";
                    Label21.Text = "无";
                    Label22.Text = "无";
                }

            }
        }
             /// <summary>
        /// 返回职员单据列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(Request.QueryString["uid"].ToString());
            if(uid==0)
            {
                Response.Redirect("zhiyuandanjulist.aspx");
            }else if(uid==1)
            {
                Response.Redirect("wanchengdanju.aspx");
            }
            
        }
       
    }
}