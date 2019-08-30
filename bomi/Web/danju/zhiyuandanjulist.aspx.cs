using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Maticsoft.DBUtility;

namespace Maticsoft.Web.danju
{
    public partial class zhiyuandanju : System.Web.UI.Page
    {
        Maticsoft.BLL.Commoditytab hot = new BLL.Commoditytab();//自制商品
        Maticsoft.BLL.OrderTab ot = new BLL.OrderTab();
        Maticsoft.BLL.Staffmember st = new BLL.Staffmember();
        Maticsoft.BLL.Permissionstab pt = new BLL.Permissionstab();
        Maticsoft.BLL.Currentaccount cur = new BLL.Currentaccount();
        static string sql = "";//主表查询条件
        static string quanxian = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Maticsoft.Model.Operator oauser = (Maticsoft.Model.Operator)Session["user"];
                if (oauser == null)
                {
                    Response.Write(string.Format("<script>alert('登录超时！');window.top.location.href='../login.aspx'</script>"));
                }
                else
                {
                    if (oauser.name == "admin")
                    {
                        sql = "";
                        quanxian = "";
                        bind(sql,quanxian);
                        xialakuang1();
                    }
                    else
                    {
                        DataSet dw = pt.GetList(" Operatorid like '" + oauser.id + "'");
                        if (dw.Tables[0].Rows[0]["look"].Equals(1))
                        {
                            sql = "";
                            bind(sql,quanxian);
                            xialakuang1();
                        }
                        else
                        {
                            quanxian = " and  UserTabID like '"+oauser.id+"'";
                            bind(sql, quanxian);
                            xialakuang1();
                        }
                    }

                }
            }
        }
        /// <summary>
        /// 页面显示的主表
        /// </summary>
        /// <param name="sql">查询语句的条件</param>
        private void bind(string sql,string quanxian)
        {
            try
            {
                DataSet biao = DbHelperSQL.Query("select ordertab.id,OrderNumber,MemberName,MemberPhone,MemberPhone1,validity,Operator.StaffmemberID,Staffname,AllMoney,AllMoney-Deposit wfk,case when Zhuangtai1=0 then '草稿' when Zhuangtai1=1 then '下单' end Zhuangtai1,case when progress=0 then '生成草稿' when progress=1 then '确认下单' when progress=2 then '排产' when progress=3 then '生产中' when progress=4 then '入库' when progress=5 then '可送货' else '完成' end progress from ordertab left join Operator on UserTabID=Operator.id left join Staffmember on Operator.StaffmemberID=Staffmember.id where progress<6 " + sql + quanxian + " order by validity desc,allmoney desc ");
                PagedDataSource pd = new PagedDataSource();
                pd.DataSource = biao.Tables[0].DefaultView;
                this.AspNetPager1.RecordCount = Convert.ToInt32(biao.Tables[0].DefaultView.Count);
                pd.AllowPaging = true;
                pd.PageSize = this.AspNetPager1.PageSize;
                pd.CurrentPageIndex = this.AspNetPager1.CurrentPageIndex - 1;
                this.Repeater1.DataSource = pd;
                this.Repeater1.DataBind();//绑定  刷新
            }
            catch (Exception ee)
            {
                Response.Write("<script>alert('页面异常 " + ee.Message + "')</script>");
            }
        }
        /// <summary>
        /// 职员下拉框
        /// </summary>
        private void xialakuang1()
        {
            this.DropDownList1.DataSourceID = null;
            DropDownList1.AppendDataBoundItems = true;
            ListItem s = new ListItem("选择销售员", "0");
            DropDownList1.Items.Add(s);
            DataSet ds = st.GetList(" by1=1");
            this.DropDownList1.DataSource = ds.Tables[0].DefaultView;
            this.DropDownList1.DataTextField = "Staffname";
            this.DropDownList1.DataValueField = "id";
            this.DropDownList1.DataBind();//绑定数据
        }
        /// <summary>
        /// 主表查询功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            sql = "";
            if (TextBox3.Text.Trim() != "")
            {
                sql = sql + " OrderNumber like '%" + TextBox3.Text + "%' and ";
            }
            if (DropDownList1.Text != "0")
            {
                sql = sql + " Operator.StaffmemberID like '" + DropDownList1.Text + "' and ";
            }
            if (TextBox11.Text.Trim() != "")
            {
                sql = sql + " validity>='" + TextBox11.Text + "' and ";
            }
            if (TextBox12.Text.Trim() != "")
            {
                sql = sql + " validity<='" + TextBox12.Text + "' and ";
            }
            if (sql != "")
            {
                sql = " and " + sql;
                sql = sql.Substring(0, sql.Length - 5);
            }
            Maticsoft.Model.Operator oauser = (Maticsoft.Model.Operator)Session["user"];
            if (oauser == null)
            {
                Response.Write(string.Format("<script>alert('登录超时！');window.top.location.href='../login.aspx'</script>"));
            }
            else
            {
                if (oauser.name == "admin")
                {
                    bind(sql,quanxian);
                }
                else
                {
                    DataSet dw = pt.GetList(" Operatorid like '" + oauser.id + "'");
                    if (dw.Tables[0].Rows[0]["look"].Equals(1))
                    {
                        bind(sql,quanxian);
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('你没有权限');</script>");
                    }
                }

            }
        }
        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //获取button 控件
                LinkButton lb = (LinkButton)sender;
                //获取传过来的commwntid   
                int id = Convert.ToInt32(lb.CommandArgument);
                Response.Redirect("zhiyuandanjuselect.aspx?id=" + id + "&uid=0");
            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('跳转详情异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 修改 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //获取button 控件
                LinkButton lb = (LinkButton)sender;
                //获取传过来的commwntid   
                int id = Convert.ToInt32(lb.CommandArgument);
                Model.OrderTab er = ot.GetModel(id);
                if (er.Zhuangtai1 != 1)
                {
                    Response.Redirect("danjuupdate.aspx?id=" + id + "");
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('该单据已过审核无法修改');</script>");
                }
                
            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('跳转修改异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 删除提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDelete_Init(object sender, EventArgs e)
        {
            (sender as LinkButton).Attributes.Add("onclick", string.Format("javascript:return confirm('{0}');", "确定要删除吗?"));
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            try
            {
                //获取button 控件
                LinkButton lb = (LinkButton)sender;
                //获取传过来的commwntid   
                int id = Convert.ToInt32(lb.CommandArgument);
                Model.OrderTab er = ot.GetModel(id);
                if (er.Zhuangtai1 != 1)
                {
                    bool a=ot.Delete(id);
                    if (a == true)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('删除成功');</script>");
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('删除失败');</script>");
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('该单据已过审核无法修改');</script>");
                }

            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('删除异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        ///  二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            try
            {
                //获取button 控件
                LinkButton lb = (LinkButton)sender;
                //获取传过来的commwntid   
                int id = Convert.ToInt32(lb.CommandArgument);
                Model.OrderTab er = ot.GetModel(id);
                Image2.ImageUrl = er.qrcode;
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('打开二维码异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        ///  收款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            try
            {
                //获取button 控件
                LinkButton lb = (LinkButton)sender;
                //获取传过来的commwntid   
                int id = Convert.ToInt32(lb.CommandArgument);
                Model.OrderTab er = ot.GetModel(id);
                Label1.Text = er.id.ToString();
                Label3.Text = er.OrderNumber;
                Label4.Text = er.AllMoney.ToString();
                Label5.Text = er.Deposit.ToString();
                DropDownList8.Text = er.Zhuangtai2.ToString();
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('打开收款异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 收款确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            int id = Convert.ToInt32(Label1.Text);
            Model.OrderTab er = ot.GetModel(id);
            if (DropDownList8.Text == "0")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('没选择收款状况！');</script>");
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
            }
            else
            {
                er.Zhuangtai2 = Convert.ToInt32(DropDownList8.Text);
                er.Deposit = er.Deposit + Convert.ToDecimal(TextBox1.Text);
                Model.Currentaccount cu = new Model.Currentaccount();
                cu.billnumber = er.OrderNumber;
                cu.type = 2;
                cu.receipt = DateTime.Now;
                cu.money =Convert.ToDecimal(TextBox1.Text);
                int b=cur.Add(cu);
                bool a = ot.Update(er);
                if (a == true&&b>0)
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('收款成功');</script>");
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('收款失败');</script>");
                    ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                }
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            bind(sql, quanxian);
        }
    }
}