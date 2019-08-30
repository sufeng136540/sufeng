using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThoughtWorks.QRCode.Codec;
using System.Data;
using Maticsoft.DBUtility;

namespace Maticsoft.Web.danju
{
    public partial class danjuupdate : System.Web.UI.Page
    {
        Maticsoft.BLL.Commoditytab com = new BLL.Commoditytab();//外购商品
        Maticsoft.BLL.phototab pt = new BLL.phototab();//图片
        Maticsoft.BLL.OrderTab ot = new BLL.OrderTab();//单据
        Maticsoft.BLL.ContractTab ct = new BLL.ContractTab();//外购商品明细
        Maticsoft.BLL.Homemadetab ht = new BLL.Homemadetab();
        static int tp1 = 0;
        static int tp2 = 0;
        static int tp3 = 0;
        static int tp4 = 0;
        static int czy = 0;//操作员ID
        static int id;//接单据ID
        static int zzspid = 0;//自制商品ID
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = Convert.ToInt32(Request.QueryString["id"].ToString());
                bind();
                bind1();
                Model.OrderTab ord = ot.GetModel(id);
                Label1.Text = ord.OrderNumber;
                if (ord.PhotoID1 != 0)
                {
                    Model.phototab ph = pt.GetModel(Convert.ToInt32(ord.PhotoID1));
                    ImageButton1.ImageUrl = ph.Photourl;
                    tp1 = ph.id;
                }
                if (ord.PhotoID2 != 0)
                {
                    Model.phototab ph = pt.GetModel(Convert.ToInt32(ord.PhotoID2));
                    ImageButton2.ImageUrl = ph.Photourl;
                    tp2 = ph.id;
                }
                if (ord.PhotoID3 != 0)
                {
                    Model.phototab ph = pt.GetModel(Convert.ToInt32(ord.PhotoID3));
                    ImageButton3.ImageUrl = ph.Photourl;
                    tp3 = ph.id;
                }
                if (ord.PhotoID4 != 0)
                {
                    Model.phototab ph = pt.GetModel(Convert.ToInt32(ord.PhotoID4));
                    ImageButton4.ImageUrl = ph.Photourl;
                    tp4 = ph.id;
                }
                TextBox1.Text = ord.alllength.ToString();
                TextBox2.Text = ord.Imperial.ToString();
                TextBox3.Text = ord.QhWidth.ToString();
                TextBox4.Text = ord.Beizhuzz;
                TextBox5.Text = ord.Beizhuwg;
                TextBox6.Text = ord.Zengsong;
                TextBox7.Text = ord.MemberName;
                TextBox8.Text = ord.MemberPhone;
                TextBox9.Text = ord.MemberPhone1;
                TextBox10.Text = ord.MemberAdd;
                TextBox11.Text = Convert.ToDateTime(ord.validity).ToString("yyyy-MM-dd");
                TextBox12.Text = ord.AllMoney.ToString();
                Label4.Text = ord.Deposit.ToString();
                Model.Homemadetab hom = ht.GetModel(Convert.ToInt32(ord.HomemadeID));
                zzspid = hom.id;
                ImageButton5.ImageUrl = hom.Photourl;
                DataSet ds = ct.GetList(" OrderNumber like '" + Label1.Text + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        Model.ContractTab con = ct.GetModel(Convert.ToInt32(ds.Tables[0].Rows[i]["id"]));
                        if (con.By1 == 1)
                        {
                            TextBox14.Text = con.CommodityID;
                            
                        }
                        else if (con.By1 == 2)
                        {
                            TextBox15.Text = con.CommodityID;
                        }
                        else if (con.By1 == 3)
                        {
                            TextBox16.Text = con.CommodityID;
                        }
                        else if (con.By1 == 4)
                        {
                            TextBox17.Text = con.CommodityID;
                        }
                        else if (con.By1 == 5)
                        {
                            TextBox18.Text = con.CommodityID;
                        }
                        else if (con.By1 == 6)
                        {
                            TextBox19.Text = con.CommodityID;
                        }
                        else if (con.By1 == 7)
                        {
                            TextBox20.Text = con.CommodityID;
                        }
                        else
                        {

                        }
                    }
                }
            }
        }
        private void bind()
        {
            try
            {
                DataTable biao = DbHelperSQL.Query(" select id,Photourl from phototab where beizhu like '1' ").Tables[0];
                this.Repeater1.DataSource = biao;
                this.Repeater1.DataBind();//绑定  刷新
            }
            catch (Exception ee)
            {
                Response.Write("<script>alert('页面异常 " + ee.Message + "')</script>");
            }
        }
        private void bind1()
        {
            try
            {
                DataTable biao = DbHelperSQL.Query(" select id,Photourl,Name from Homemadetab where by1=1 ").Tables[0];
                this.Repeater2.DataSource = biao;
                this.Repeater2.DataBind();//绑定  刷新
            }
            catch (Exception ee)
            {
                Response.Write("<script>alert('页面异常 " + ee.Message + "')</script>");
            }
        }
        private void bind2(string lb)
        {
            try
            {
                DataTable biao = DbHelperSQL.Query(" select id,category,Name from Commoditytab where category=" + lb + " ").Tables[0];
                this.Repeater3.DataSource = biao;
                this.Repeater3.DataBind();//绑定  刷新
            }
            catch (Exception ee)
            {
                Response.Write("<script>alert('页面异常 " + ee.Message + "')</script>");
            }
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Label2.Text = "1";
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
        }
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Label2.Text = "2";
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
        }
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Label2.Text = "3";
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
        }
        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Label2.Text = "4";
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "add")
            {
                Model.phototab co = pt.GetModel(Convert.ToInt32(e.CommandArgument));
                if (Label2.Text == "1")
                {
                    ImageButton1.ImageUrl = co.Photourl;
                    tp1 = co.id;
                }
                else if (Label2.Text == "2")
                {
                    ImageButton2.ImageUrl = co.Photourl;
                    tp2 = co.id;
                }
                else if (Label2.Text == "3")
                {
                    ImageButton3.ImageUrl = co.Photourl;
                    tp3 = co.id;
                }
                else if (Label2.Text == "4")
                {
                    ImageButton4.ImageUrl = co.Photourl;
                    tp4 = co.id;
                }
                else
                {

                }
            }
        }
        /// <summary>
        /// 选择自制商品赋值
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "adds")
            {
                Model.Homemadetab hod = ht.GetModel(Convert.ToInt32(e.CommandArgument));
                ImageButton5.ImageUrl = hod.Photourl;
                zzspid = hod.id;

            }
        }
        /// <summary>
        /// 选择外购商品赋值（餐桌）
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void Repeater3_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "add")
            {
                Model.Commoditytab hod = com.GetModel(Convert.ToInt32(e.CommandArgument));
                if (Label3.Text == "1")
                {
                    if (TextBox14.Text.Trim() != "")
                    {
                        TextBox14.Text += " + " + hod.Name;
                    }
                    else
                    {
                        TextBox14.Text = hod.Name;
                    }
                }
                else if (Label3.Text == "2")
                {
                    if (TextBox15.Text.Trim() != "")
                    {
                        TextBox15.Text += " + " + hod.Name;
                    }
                    else
                    {
                        TextBox15.Text = hod.Name;
                    }
                }
                else if (Label3.Text == "3")
                {
                    if (TextBox16.Text.Trim() != "")
                    {
                        TextBox16.Text += " + " + hod.Name;
                    }
                    else
                    {
                        TextBox16.Text = hod.Name;
                    }
                }
                else if (Label3.Text == "4")
                {
                    if (TextBox17.Text.Trim() != "")
                    {
                        TextBox17.Text += " + " + hod.Name;
                    }
                    else
                    {
                        TextBox17.Text = hod.Name;
                    }
                }
                else if (Label3.Text == "5")
                {
                    if (TextBox18.Text.Trim() != "")
                    {
                        TextBox18.Text += " + " + hod.Name;
                    }
                    else
                    {
                        TextBox18.Text = hod.Name;
                    }
                }
                else if (Label3.Text == "6")
                {
                    if (TextBox19.Text.Trim() != "")
                    {
                        TextBox19.Text += " + " + hod.Name;
                    }
                    else
                    {
                        TextBox19.Text = hod.Name;
                    }
                }
                else if (Label3.Text == "7")
                {
                    if (TextBox20.Text.Trim() != "")
                    {
                        TextBox20.Text += " + " + hod.Name;
                    }
                    else
                    {
                        TextBox20.Text = hod.Name;
                    }
                }
                else
                {

                }
            }
        }
        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (zzspid == 0)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('请选择自制商品');</script>");

            }else
            {
                if (TextBox7.Text.Trim() == "")
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('请添客户名称');</script>");
                }
                else
                {
                    if (TextBox8.Text.Trim() == "" && TextBox9.Text.Trim() == "")
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('至少添加一个电话号');</script>");
                    }
                    else
                    {
                        if (TextBox10.Text.Trim() == "")
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('请添客户地址');</script>");
                        }
                        else
                        {
                            if (TextBox1.Text.Trim() == "")
                            {
                                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('请添总长');</script>");
                            }
                            else
                            {
                                if (TextBox2.Text.Trim() == "")
                                {
                                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('请添妃长');</script>");
                                }
                                else
                                {
                                    if (TextBox3.Text.Trim() == "")
                                    {
                                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('请添前后宽');</script>");
                                    }
                                    else
                                    {
                                        if (TextBox11.Text.Trim() == "")
                                        {
                                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('请选送货日期');</script>");
                                        }
                                        else
                                        {
                                            if (TextBox12.Text.Trim() == "")
                                            {
                                                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('请添单据总金额');</script>");
                                            }
                                            else
                                            {
                                                DataSet ds = ot.GetList(" validity='" + TextBox11.Text + "'");
                                                if (ds.Tables[0].Rows.Count > 15)
                                                {
                                                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('以达到送货上线');</script>");
                                                }
                                                else
                                                {
                                                    Model.OrderTab ort = ot.GetModel(id);
                                                    ort.MemberName = TextBox7.Text;
                                                    ort.MemberPhone = TextBox8.Text;
                                                    ort.MemberPhone1 = TextBox9.Text;
                                                    ort.MemberAdd = TextBox10.Text;
                                                    ort.OrderNumber = Label1.Text;
                                                    ort.PhotoID1 = tp1;
                                                    ort.PhotoID2 = tp2;
                                                    ort.PhotoID3 = tp3;
                                                    ort.PhotoID4 = tp4;
                                                    ort.validity = Convert.ToDateTime(TextBox11.Text);
                                                    ort.progress = 0;
                                                    ort.AllMoney = Convert.ToDecimal(TextBox12.Text);
                                                    ort.alllength = Convert.ToDecimal(TextBox1.Text);
                                                    ort.Imperial = Convert.ToDecimal(TextBox2.Text);
                                                    ort.QhWidth = Convert.ToDecimal(TextBox3.Text);
                                                    ort.Beizhuwg = TextBox5.Text;
                                                    ort.Beizhuzz = TextBox4.Text;
                                                    ort.Zengsong = TextBox6.Text;
                                                    ort.Zhuangtai1 = 0;//草稿
                                                    ort.HomemadeID = zzspid;
                                                    ct.DeleteList(" OrderNumber like '" + Label1.Text + "'");
                                                    if (TextBox14.Text.Trim() != "")
                                                    {
                                                        Model.ContractTab con = new Model.ContractTab();
                                                        con.OrderNumber = Label1.Text;
                                                        con.CommodityID = TextBox14.Text;
                                                        con.By1 = 1;
                                                        ct.Add(con);
                                                    }
                                                    if (TextBox15.Text.Trim() != "")
                                                    {
                                                        Model.ContractTab con = new Model.ContractTab();
                                                        con.OrderNumber = Label1.Text;
                                                        con.CommodityID = TextBox15.Text;
                                                        con.By1 = 2;
                                                        ct.Add(con);
                                                    }
                                                    if (TextBox16.Text.Trim() != "")
                                                    {
                                                        Model.ContractTab con = new Model.ContractTab();
                                                        con.OrderNumber = Label1.Text;
                                                        con.CommodityID = TextBox16.Text;
                                                        con.By1 = 3;
                                                        ct.Add(con);
                                                    }
                                                    if (TextBox17.Text.Trim() != "")
                                                    {
                                                        Model.ContractTab con = new Model.ContractTab();
                                                        con.OrderNumber = Label1.Text;
                                                        con.CommodityID = TextBox17.Text;
                                                        con.By1 = 4;
                                                        ct.Add(con);
                                                    }
                                                    if (TextBox18.Text.Trim() != "")
                                                    {
                                                        Model.ContractTab con = new Model.ContractTab();
                                                        con.OrderNumber = Label1.Text;
                                                        con.CommodityID = TextBox18.Text;
                                                        con.By1 = 5;
                                                        ct.Add(con);
                                                    }
                                                    if (TextBox19.Text.Trim() != "")
                                                    {
                                                        Model.ContractTab con = new Model.ContractTab();
                                                        con.OrderNumber = Label1.Text;
                                                        con.CommodityID = TextBox19.Text;
                                                        con.By1 = 6;
                                                        ct.Add(con);
                                                    }
                                                    if (TextBox20.Text.Trim() != "")
                                                    {
                                                        Model.ContractTab con = new Model.ContractTab();
                                                        con.OrderNumber = Label1.Text;
                                                        con.CommodityID = TextBox20.Text;
                                                        con.By1 = 7;
                                                        ct.Add(con);
                                                    }
                                                    bool a = ot.Update(ort);
                                                    if (a == true)
                                                    {

                                                        Response.Write(string.Format("<script>alert('修改成功！');location='zhiyuandanjulist.aspx'</script>"));
                                                    }
                                                    else
                                                    {
                                                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改失败！');</script>");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }
        /// <summary>
        /// 选择自制商品弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
        }
        /// <summary>
        /// 弹框赋值（餐桌）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Label3.Text = "1";
            bind2("1");
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv3();</script>");
        }
        /// <summary>
        /// 弹框赋值（餐椅）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Label3.Text = "2";
            bind2("2");
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv3();</script>");
        }
        /// <summary>
        /// 弹框赋值（茶几）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Label3.Text = "3";
            bind2("3");
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv3();</script>");
        }
        /// <summary>
        /// 弹框赋值（电视柜）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Label3.Text = "4";
            bind2("4");
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv3();</script>");
        }
        /// <summary>
        /// 弹框赋值（床）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Label3.Text = "5";
            bind2("5");
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv3();</script>");
        }
        /// <summary>
        /// 弹框赋值（床垫）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Label3.Text = "6";
            bind2("6");
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv3();</script>");
        }
        /// <summary>
        /// 弹框赋值（床头柜）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Label3.Text = "7";
            bind2("7");
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv3();</script>");
        }
    }
}