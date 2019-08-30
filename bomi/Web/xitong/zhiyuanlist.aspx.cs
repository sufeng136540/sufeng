using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Maticsoft.DBUtility;

namespace Maticsoft.Web.xitong
{
    public partial class zhiyuanlist : System.Web.UI.Page
    {
        Maticsoft.BLL.Department dep = new BLL.Department();
        Maticsoft.BLL.Position pos = new BLL.Position();
        Maticsoft.BLL.Staffmember st = new BLL.Staffmember();
        Maticsoft.BLL.OrderTab ot = new BLL.OrderTab();
        static string sql = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                sql = "";
                bind(sql);
                xialakuang1();
                xialakuang2();
                xialakuang3();
                xialakuang4();
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
                DataTable biao = DbHelperSQL.Query(" select ROW_NUMBER() over(order by Staffmember.id) as shu,Staffmember.id,Staffname,information,departmentname,name,Staffmember.beizhu from Staffmember left join Department on Staffmember.departmentID=Department.id left join Position on Staffmember.Positionid=Position.id where Staffmember.by1 like '1'" + sql).Tables[0];
                this.Repeater1.DataSource = biao;
                this.Repeater1.DataBind();//绑定  刷新
            }
            catch (Exception ee)
            {
                Response.Write("<script>alert('页面异常 " + ee.Message + "')</script>");
            }
        }
        /// <summary>
        /// 部门下拉框（添加弹窗）
        /// </summary>
        private void xialakuang1()
        {
            this.DropDownList1.DataSourceID = null;
            DropDownList1.AppendDataBoundItems = true;
            ListItem s = new ListItem("选择部门", "0");
            DropDownList1.Items.Add(s);
            DataSet ds = dep.GetAllList();
            this.DropDownList1.DataSource = ds.Tables[0].DefaultView;
            this.DropDownList1.DataTextField = "departmentname";
            this.DropDownList1.DataValueField = "id";
            this.DropDownList1.DataBind();//绑定数据
        }
        /// <summary>
        /// 职位下拉框（添加弹窗）
        /// </summary>
        private void xialakuang2()
        {
            this.DropDownList2.DataSourceID = null;
            DropDownList2.AppendDataBoundItems = true;
            ListItem s = new ListItem("选择职位", "0");
            DropDownList2.Items.Add(s);
            DataSet ds = pos.GetAllList();
            this.DropDownList2.DataSource = ds.Tables[0].DefaultView;
            this.DropDownList2.DataTextField = "name";
            this.DropDownList2.DataValueField = "id";
            this.DropDownList2.DataBind();//绑定数据
        }
        /// <summary>
        /// 部门下拉框（修改弹窗）
        /// </summary>
        private void xialakuang3()
        {
            this.DropDownList3.DataSourceID = null;
            DropDownList3.AppendDataBoundItems = true;
            ListItem s = new ListItem("选择部门", "0");
            DropDownList3.Items.Add(s);
            DataSet ds = dep.GetAllList();
            this.DropDownList3.DataSource = ds.Tables[0].DefaultView;
            this.DropDownList3.DataTextField = "departmentname";
            this.DropDownList3.DataValueField = "id";
            this.DropDownList3.DataBind();//绑定数据
        }
        /// <summary>
        /// 职位下拉框（修改弹窗）
        /// </summary>
        private void xialakuang4()
        {
            this.DropDownList4.DataSourceID = null;
            DropDownList4.AppendDataBoundItems = true;
            ListItem s = new ListItem("选择职位", "0");
            DropDownList4.Items.Add(s);
            DataSet ds = pos.GetAllList();
            this.DropDownList4.DataSource = ds.Tables[0].DefaultView;
            this.DropDownList4.DataTextField = "name";
            this.DropDownList4.DataValueField = "id";
            this.DropDownList4.DataBind();//绑定数据
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
        /// 打开弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
        }
        /// <summary>
        /// 添加职员（确定按钮）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text.Trim() != "")
                {
                    if (DropDownList1.Text != "0")
                    {
                        if (DropDownList2.Text != "0")
                        {
                            Maticsoft.Model.Staffmember zhiyuan = new Model.Staffmember();
                            zhiyuan.Staffname = TextBox1.Text;
                            zhiyuan.information = TextBox6.Text;
                            zhiyuan.departmentID = Convert.ToInt32(DropDownList1.Text);
                            zhiyuan.Positionid = Convert.ToInt32(DropDownList2.Text);
                            zhiyuan.BY1 = 1;
                            zhiyuan.Beizhu = TextBox2.Text;
                            
                            int a = st.Add(zhiyuan);
                            if (a > 0)
                            {
                                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('添加成功！');</script>");
                                bind(sql);
                            }
                            else
                            {
                                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('添加失败！');</script>");
                                bind(sql);
                            }
                        }
                        else
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('没选择职务！');</script>");
                            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
                        }
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('没选择部门！');</script>");
                        ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
                    }

                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('职员名称不能为空！');</script>");
                    ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
                }

            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('确定异常 " + ee.Message + "');</script>");
            }
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
                sql = sql + " Staffname like '%" + TextBox3.Text + "%' and ";
            }
            if (sql != "")
            {
                sql = " and " + sql;
                sql = sql.Substring(0, sql.Length - 5);
            }
            bind(sql);
        }
        /// <summary>
        /// 修改弹窗赋值
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
                Model.Staffmember po = st.GetModel(id);
                Label1.Text = po.id.ToString();
                TextBox4.Text = po.Staffname;
                TextBox5.Text = po.information;
                DropDownList3.Text = po.departmentID.ToString();
                DropDownList4.Text = po.Positionid.ToString();
                TextBox7.Text = po.Beizhu;
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改弹窗异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 删除（验证该部门有职员绑定无法删除）
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
                DataSet dwq = ot.GetList(" StaffmemberID like '" + id + "' or UserTabID like '"+id+"'");
                if (dwq.Tables[0].Rows.Count > 0)
                {
                    Model.Staffmember zhiyuan=st.GetModel(id);
                    zhiyuan.BY1=0;
                    bool b=st.Update(zhiyuan);
                    if (b == true)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('停用成功！');</script>");
                        bind(sql);
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('停用失败！');</script>");
                        bind(sql);
                    }
                }
                else
                {
                    bool a = st.Delete(id);
                    if (a == true)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('删除成功！');</script>");
                        bind(sql);
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('删除失败！');</script>");
                        bind(sql);
                    }
                }
            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('删除异常 " + ee.Message + "');</script>");
            }

        }
        /// <summary>
        /// 修改部门（确定按钮）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox4.Text.Trim() != "")
                {
                    if (DropDownList3.Text != "0")
                    {
                        if (DropDownList4.Text != "0")
                        {
                            Maticsoft.Model.Staffmember zhiyuan = st.GetModel(Convert.ToInt32(Label1.Text));
                            zhiyuan.Staffname = TextBox4.Text;
                            zhiyuan.information = TextBox5.Text;
                            zhiyuan.departmentID = Convert.ToInt32(DropDownList3.Text);
                            zhiyuan.Positionid = Convert.ToInt32(DropDownList4.Text);
                            zhiyuan.Beizhu = TextBox7.Text;

                           bool a = st.Update(zhiyuan);
                            if (a ==true)
                            {
                                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改成功！');</script>");
                                bind(sql);
                            }
                            else
                            {
                                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改失败！');</script>");
                                bind(sql);
                            }
                        }
                        else
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('没选择职务！');</script>");
                            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                        }
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('没选择部门！');</script>");
                        ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                    }

                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('职员名称不能为空！');</script>");
                    ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                }

            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('确定异常 " + ee.Message + "');</script>");
            }
        }
    }
}