using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Maticsoft.DBUtility;
using ThoughtWorks.QRCode.Codec;
using System.Drawing;

namespace Maticsoft.Web.danju
{
    public partial class danjuluru : System.Web.UI.Page
    {
        Maticsoft.BLL.Commoditytab com = new BLL.Commoditytab();//外购商品
        Maticsoft.BLL.phototab pt = new BLL.phototab();//图片
        Maticsoft.BLL.OrderTab ot = new BLL.OrderTab();//单据
        Maticsoft.BLL.ContractTab ct = new BLL.ContractTab();
        Maticsoft.BLL.Homemadetab ht = new BLL.Homemadetab();
        Maticsoft.BLL.Currentaccount cur = new BLL.Currentaccount();
        static int tp1 = 0;
        static int tp2 = 0;
        static int tp3 = 0;
        static int tp4 = 0;
        static int czy = 0;//操作员ID
        static int zzspid=0;//自制商品ID
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Label1.Text = "BM" + DateTime.Now.ToString("yyyyMMddHHmmss");
                bind();
                bind1();
                Maticsoft.Model.Operator oauser = (Maticsoft.Model.Operator)Session["user"];
                czy = oauser.id;
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
                DataTable biao = DbHelperSQL.Query(" select id,category,Name from Commoditytab where category="+lb+" ").Tables[0];
                this.Repeater3.DataSource = biao;
                this.Repeater3.DataBind();//绑定  刷新
            }
            catch (Exception ee)
            {
                Response.Write("<script>alert('页面异常 " + ee.Message + "')</script>");
            }
        }
        /// <summary>
        /// 第一张图片弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Label2.Text = "1";
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
        }
        /// <summary>
        /// 第二张图片弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Label2.Text = "2";
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
        }
        /// <summary>
        /// 第三张图片弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Label2.Text = "3";
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
        }
        /// <summary>
        /// 第四张图片弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Label2.Text = "4";
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
        }
        /// <summary>
        /// 样式图选择
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "add")
            {
                Model.phototab co = pt.GetModel(Convert.ToInt32( e.CommandArgument));
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
                if(Label3.Text=="1")
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
        /// 生成单据方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (zzspid == 0)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('请选择自制商品');</script>");
            }
            else
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
                                                if (ds.Tables[0].Rows.Count >= 15)
                                                {
                                                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('以达到送货上线');</script>");
                                                }
                                                else
                                                {
                                                    if (DropDownList8.Text == "0")
                                                    {
                                                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('请选择付款状况');</script>");
                                                    }
                                                    else
                                                    {
                                                        string qrEncoding = "BYTE"; string level = "M"; int version = 8; int scale = 3;
                                                        QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
                                                        string encoding = qrEncoding;
                                                        switch (encoding)
                                                        {
                                                            case "Byte":
                                                                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                                                                break;
                                                            case "AlphaNumeric":
                                                                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                                                                break;
                                                            case "Numeric":
                                                                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
                                                                break;
                                                            default:
                                                                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                                                                break;
                                                        }

                                                        qrCodeEncoder.QRCodeScale = scale;
                                                        qrCodeEncoder.QRCodeVersion = version;
                                                        switch (level)
                                                        {
                                                            case "L":
                                                                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                                                                break;
                                                            case "M":
                                                                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                                                                break;
                                                            case "Q":
                                                                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                                                                break;
                                                            default:
                                                                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                                                                break;
                                                        }
                                                        string serial = @"http://192.168.1.150:8585/xianshi.asmx/jiekou?id=" + Label1.Text;
                                                        System.Drawing.Image image = qrCodeEncoder.Encode(serial);

                                                        string filename = Label1.Text + ".jpg";
                                                        string filepath = Server.MapPath(@"~\qrcode111") + "\\" + filename;
                                                        //如果文件夹不存在，则创建
                                                        //if (!Directory.Exists(filepath))
                                                        //    Directory.CreateDirectory(filepath);
                                                        System.IO.FileStream fs = new System.IO.FileStream(filepath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
                                                        image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                                                        fs.Close();
                                                        image.Dispose();
                                                        Model.OrderTab ort = new Model.OrderTab();
                                                        ort.MemberName = TextBox7.Text;
                                                        ort.MemberPhone = TextBox8.Text;
                                                        ort.MemberPhone1 = TextBox9.Text;
                                                        ort.MemberAdd = TextBox10.Text;
                                                        ort.Orderdate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                                                        ort.OrderNumber = Label1.Text;
                                                        ort.UserTabID = czy;
                                                        ort.PhotoID1 = tp1;
                                                        ort.PhotoID2 = tp2;
                                                        ort.PhotoID3 = tp3;
                                                        ort.PhotoID4 = tp4;
                                                        ort.qrcode = "../qrcode111/" + filename;
                                                        ort.validity = Convert.ToDateTime(TextBox11.Text);
                                                        ort.progress = 0;
                                                        ort.AllMoney = Convert.ToDecimal(TextBox12.Text);
                                                        if (TextBox13.Text.Trim() == "")
                                                        {
                                                            ort.Deposit = 0;
                                                        }
                                                        else
                                                        {
                                                            ort.Deposit = Convert.ToDecimal(TextBox13.Text);
                                                        }
                                                        ort.alllength = Convert.ToDecimal(TextBox1.Text);
                                                        ort.Imperial = Convert.ToDecimal(TextBox2.Text);
                                                        ort.QhWidth = Convert.ToDecimal(TextBox3.Text);
                                                        ort.Beizhuwg = TextBox5.Text;
                                                        ort.Beizhuzz = TextBox4.Text;
                                                        ort.Zengsong = TextBox6.Text;
                                                        ort.Zhuangtai1 = 0;//草稿
                                                        ort.Zhuangtai2 = Convert.ToInt32(DropDownList8.Text);
                                                        ort.StaffmemberID = Convert.ToInt32(DropDownList9.Text);
                                                        ort.HomemadeID = zzspid;
                                                        if ( TextBox14.Text.Trim() != "")
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
                                                        Model.Currentaccount cu = new Model.Currentaccount();
                                                        cu.billnumber = Label1.Text;
                                                        cu.type = 1;
                                                        cu.receipt = DateTime.Now;
                                                        if (TextBox13.Text.Trim() == "")
                                                        {
                                                            cu.money = 0;
                                                        }
                                                        else
                                                        {
                                                            cu.money = Convert.ToDecimal(TextBox13.Text);
                                                        }
                                                        int b = cur.Add(cu);
                                                        int a = ot.Add(ort);
                                                        if (a > 0 && b > 0)
                                                        {

                                                            Response.Write(string.Format("<script>alert('添加成功！');location='danjuluru.aspx'</script>"));
                                                        }
                                                        else
                                                        {
                                                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('添加失败！');</script>");
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