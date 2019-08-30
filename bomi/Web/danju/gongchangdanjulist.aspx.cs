using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Maticsoft.DBUtility;
using System.Web.UI.HtmlControls;

namespace Maticsoft.Web.danju
{
    public partial class danjulist : System.Web.UI.Page
    {
        Maticsoft.BLL.Commoditytab hot = new BLL.Commoditytab();//自制商品
        Maticsoft.BLL.OrderTab ot = new BLL.OrderTab();//单据
        Maticsoft.BLL.Staffmember st = new BLL.Staffmember();//职员
        Maticsoft.BLL.Permissionstab pt = new BLL.Permissionstab();//权限
        static string sql = "";//主表查询条件
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
                        bind(sql);
                        xialakuang1();
                    }
                    else
                    {
                        DataSet dw = pt.GetList(" Operatorid like '" + oauser.id + "'");
                        if (dw.Tables[0].Rows[0]["Audit"].Equals(1))
                        {
                            sql = "";
                            bind(sql);
                            xialakuang1();
                        }
                        else
                        {
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
        private void bind(string sql)
        {
            try
            {
                DataSet biao = DbHelperSQL.Query("select ordertab.id,OrderNumber,MemberName,MemberPhone,MemberPhone1,validity,Operator.StaffmemberID,Staffname,AllMoney,AllMoney-Deposit wfk,case when Zhuangtai1=0 then '草稿' when Zhuangtai1=1 then '下单' end Zhuangtai1,case when progress=0 then '生成草稿' when progress=1 then '确认下单' when progress=2 then '排产' when progress=3 then '生产中' when progress=4 then '入库' when progress=5 then '可送货' else '完成' end progress from ordertab left join Operator on UserTabID=Operator.id left join Staffmember on Operator.StaffmemberID=Staffmember.id where progress<6 " + sql + " order by validity desc,allmoney desc ");
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
        /// 下单判断提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDelete_Init3(object sender, EventArgs e)
        {
            (sender as LinkButton).Attributes.Add("onclick", string.Format("javascript:return confirm('{0}');", "请确认是否下单?"));
        }
        /// <summary>
        /// 排产判断提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDelete_Init4(object sender, EventArgs e)
        {
            (sender as LinkButton).Attributes.Add("onclick", string.Format("javascript:return confirm('{0}');", "请确认是否排产?"));
        }
        /// <summary>
        /// 生产中判断提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDelete_Init5(object sender, EventArgs e)
        {
            (sender as LinkButton).Attributes.Add("onclick", string.Format("javascript:return confirm('{0}');", "请确认是否开始生产?"));
        }
        /// <summary>
        /// 入库判断提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDelete_Init6(object sender, EventArgs e)
        {
            (sender as LinkButton).Attributes.Add("onclick", string.Format("javascript:return confirm('{0}');", "请确认是否入库?"));
        }
        /// <summary>
        /// 可送货判断提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDelete_Init7(object sender, EventArgs e)
        {
            (sender as LinkButton).Attributes.Add("onclick", string.Format("javascript:return confirm('{0}');", "请确认是否可以送货?"));
        }
        /// <summary>
        /// 完成判断提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDelete_Init8(object sender, EventArgs e)
        {
            (sender as LinkButton).Attributes.Add("onclick", string.Format("javascript:return confirm('{0}');", "请确认是否完成?"));
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
                    bind(sql);
                }
                else
                {
                      DataSet dw = pt.GetList(" Operatorid like '" + oauser.id + "'");
                      if (dw.Tables[0].Rows[0]["Audit"].Equals(1))
                      {
                          bind(sql);
                      }
                      else
                      {
                          ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('你没有权限');</script>");
                      }
                }
               
            }
        }
        /// <summary>
        /// 下单
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
                Model.OrderTab or = ot.GetModel(id);
                if (or.progress <= 1)
                {
                    or.Zhuangtai1 = 1;
                    or.progress = 1;
                    bool a = ot.Update(or);
                    if (a == true)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('下单成功');</script>");
                        bind(sql);
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('下单失败');</script>");
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('该步奏已经执行过了');</script>");
                }
               
            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('下单异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 排产
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
                Model.OrderTab or = ot.GetModel(id);
                if (or.progress <= 2)
                {
                    or.Zhuangtai1 = 1;
                    or.progress = 2;
                    bool a = ot.Update(or);
                    if (a == true)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('排产成功');</script>");
                        bind(sql);
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('排产失败');</script>");
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('该步奏已经执行过了');</script>");
                }
              
            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('排产异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 生产中
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
                Model.OrderTab or = ot.GetModel(id);
                if (or.progress <= 3)
                {
                    or.Zhuangtai1 = 1;
                    or.progress = 3;
                    bool a = ot.Update(or);
                    if (a == true)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('生产中成功');</script>");
                        bind(sql);
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('生产中失败');</script>");
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('该步奏已经执行过了');</script>");
                }

            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('生产中异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            try
            {
                //获取button 控件
                LinkButton lb = (LinkButton)sender;
                //获取传过来的commwntid   
                int id = Convert.ToInt32(lb.CommandArgument);
                Model.OrderTab or = ot.GetModel(id);
                if (or.progress <= 4)
                {
                    or.Zhuangtai1 = 1;
                    or.progress = 4;
                    bool a = ot.Update(or);
                    if (a == true)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('入库成功');</script>");
                        bind(sql);
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('入库失败');</script>");
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('该步奏已经执行过了');</script>");
                }

            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('入库异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 可送货
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            try
            {
                //获取button 控件
                LinkButton lb = (LinkButton)sender;
                //获取传过来的commwntid   
                int id = Convert.ToInt32(lb.CommandArgument);
                Model.OrderTab or = ot.GetModel(id);
                if (or.progress <= 5)
                {
                    or.Zhuangtai1 = 1;
                    or.progress = 5;
                    bool a = ot.Update(or);
                    if (a == true)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('可送货成功');</script>");
                        bind(sql);
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('可送货失败');</script>");
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('该步奏已经执行过了');</script>");
                }

            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('可送货异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            try
            {
                //获取button 控件
                LinkButton lb = (LinkButton)sender;
                //获取传过来的commwntid   
                int id = Convert.ToInt32(lb.CommandArgument);
                Model.OrderTab or = ot.GetModel(id);
                if (or.progress <= 6)
                {
                    or.Zhuangtai1 = 1;
                    or.progress = 6;
                    bool a = ot.Update(or);
                    if (a == true)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('该单据以完成');</script>");
                        bind(sql);
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('完成失败');</script>");
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('该步奏已经执行过了');</script>");
                }

            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('完成异常 " + ee.Message + "');</script>");
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
                Response.Redirect("gongchangdanjuselect.aspx?id="+id+"");
            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('跳转详情异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 判断更换背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            try
            {
                if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
                {
                    //获取总金额
                    Decimal zje =Convert.ToDecimal(((DataRowView)(e.Item.DataItem)).Row[8]);
                    //总金额大于20000时更换背景色
                    if (zje>=20000)
                    {
                        ((HtmlTableRow)e.Item.FindControl("trbs")).BgColor = "#FA8072";
                    }
                    else
                    {

                    }
                 
                }
            }
            catch (Exception ee)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('更改背景色错误 " + ee.Message + "');</script>");
            }
        }
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            bind(sql);//显示表中内容
        }
    }
}