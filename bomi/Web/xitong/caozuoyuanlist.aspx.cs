using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Maticsoft.DBUtility;
using System.Web.Security;

namespace Maticsoft.Web.xitong
{
    public partial class caozuoyuanlist : System.Web.UI.Page
    {
        Maticsoft.BLL.Staffmember st = new BLL.Staffmember();//职员
        Maticsoft.BLL.Operator op = new BLL.Operator();//操作员
        Maticsoft.BLL.OrderTab ot = new BLL.OrderTab();//订单
        Maticsoft.BLL.Permissionstab pe = new BLL.Permissionstab();
        static string sql = "";//查询主表条件
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                sql = "";
                bind(sql);
                xialakuang1();
                xialakuang2();
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
                DataTable biao = DbHelperSQL.Query(" select ROW_NUMBER() over(order by Operator.id) as shu,Operator.id,name,Staffname,Operator.beizhu from Operator left join Staffmember on Operator.StaffmemberID=Staffmember.id where Operator.BranchID=1 " + sql).Tables[0];
                this.Repeater1.DataSource = biao;
                this.Repeater1.DataBind();//绑定  刷新
            }
            catch (Exception ee)
            {
                Response.Write("<script>alert('页面异常 " + ee.Message + "')</script>");
            }
        }
        /// <summary>
        /// 职员下拉框（添加弹窗）
        /// </summary>
        private void xialakuang1()
        {
            this.DropDownList1.DataSourceID = null;
            DropDownList1.AppendDataBoundItems = true;
            ListItem s = new ListItem("选择职员", "0");
            DropDownList1.Items.Add(s);
            DataSet ds = st.GetList(" by1=1");
            this.DropDownList1.DataSource = ds.Tables[0].DefaultView;
            this.DropDownList1.DataTextField = "Staffname";
            this.DropDownList1.DataValueField = "id";
            this.DropDownList1.DataBind();//绑定数据
        }
        /// <summary>
        /// 职员下拉框（修改弹窗）
        /// </summary>
        private void xialakuang2()
        {
            this.DropDownList2.DataSourceID = null;
            DropDownList2.AppendDataBoundItems = true;
            ListItem s = new ListItem("选择职员", "0");
            DropDownList2.Items.Add(s);
            DataSet ds = st.GetList(" by1=1");
            this.DropDownList2.DataSource = ds.Tables[0].DefaultView;
            this.DropDownList2.DataTextField = "Staffname";
            this.DropDownList2.DataValueField = "id";
            this.DropDownList2.DataBind();//绑定数据
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
        /// 添加部门（确定按钮）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DropDownList1.Text != "0")
                {
                    if (TextBox1.Text.Trim() != "")
                    {
                        if (TextBox6.Text.Trim() != "")
                        {
                            if (TextBox6.Text.Trim() == TextBox7.Text.Trim())
                            {
                                DataSet dss = op.GetList(" name like '" + TextBox1.Text + "' and pwd like '" + FormsAuthentication.HashPasswordForStoringInConfigFile(this.TextBox6.Text.Trim(), "MD5") + "'");
                                if (dss.Tables[0].Rows.Count > 0)
                                {
                                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('账号密码以存在！');</script>");
                                    TextBox1.Text = "";
                                    TextBox6.Text = "";
                                    TextBox7.Text = "";
                                    ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
                                }
                                else
                                {
                                    Maticsoft.Model.Operator czy = new Model.Operator();
                                    czy.StaffmemberID = Convert.ToInt32(DropDownList1.Text);
                                    czy.name = TextBox1.Text;
                                    czy.pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(this.TextBox6.Text.Trim(), "MD5");
                                    czy.Beizhu = TextBox2.Text;
                                    czy.BranchID = 1;
                                    int a = op.Add(czy);
                                    if (a > 0)
                                    {
                                        DataSet er = op.GetList(" name like '" + TextBox1.Text + "' and pwd like '" + FormsAuthentication.HashPasswordForStoringInConfigFile(this.TextBox6.Text.Trim(), "MD5") + "' and StaffmemberID like '" + DropDownList1.Text + "' and BranchID like '1'");
                                        Model.Permissionstab per = new Model.Permissionstab();
                                        per.Operatorid = Convert.ToInt32(er.Tables[0].Rows[0]["id"]);
                                        per.Look = 0;
                                        per.Audit = 0;
                                        int aa = pe.Add(per);
                                        if (aa > 0)
                                        {
                                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('添加成功！');</script>");
                                            bind(sql);
                                        }
                                        else
                                        {
                                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('权限添加失败！');</script>");
                                            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
                                        }

                                    }
                                    else
                                    {
                                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('添加失败！');</script>");
                                        bind(sql);
                                    }
                                }
                            }
                            else
                            {
                                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('2次输入的密码不一致请重新输入！');</script>");
                                TextBox6.Text = "";
                                TextBox7.Text = "";
                                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
                            }
                        }
                        else
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('密码不能为空！');</script>");
                            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
                        }
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('账号不能为空！');</script>");
                        ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('没选职员！');</script>");
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
                sql = sql + " name like '%" + TextBox3.Text + "%' and ";
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
                //Maticsoft.Model.Operator oauser = (Maticsoft.Model.Operator)Session["user"];
                Model.Operator ope = op.GetModel(id);
                Label2.Text = ope.id.ToString();
                DropDownList2.Text = ope.StaffmemberID.ToString();
                TextBox4.Text = ope.name;
                TextBox5.Text = ope.Beizhu;
                TextBox10.Text = null;
                TextBox8.Text = null;
                TextBox9.Text = null;
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改弹窗异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 删除（该操作员有生成单据停用否则删除）
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
                    Model.Operator czy = op.GetModel(id);
                    czy.BranchID = 0;
                    bool a = op.Update(czy);
                    if (a == true)
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
                    bool a = op.Delete(id);
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
        /// 修改操作员（确定按钮）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox4.Text.Trim() != "")
                {
                    if (DropDownList2.Text != "0")
                    {
                        Maticsoft.Model.Operator czy = op.GetModel(Convert.ToInt32(Label2.Text));
                        czy.name = TextBox4.Text;
                        czy.StaffmemberID =Convert.ToInt32(DropDownList2.Text);
                        czy.Beizhu = TextBox5.Text;
                        if (TextBox8.Text.Trim() != "" || TextBox9.Text.Trim() != "" || TextBox10.Text.Trim() != "")
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
                                    if (TextBox9.Text == TextBox10.Text)
                                    {
                                        czy.pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(this.TextBox10.Text.Trim(), "MD5");
                                        bool a = op.Update(czy);
                                        if (a == true)
                                        {
                                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改成功！');</script>");
                                            bind(sql);
                                        }
                                        else
                                        {
                                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改失败！');</script>");
                                            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                                        }
                                    }
                                    else
                                    {
                                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('2次输入的密码不一致请重新输入！');</script>");
                                        TextBox9.Text = "";
                                        TextBox10.Text = "";
                                        ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                                    }
                                }
                                else
                                {
                                    if (FormsAuthentication.HashPasswordForStoringInConfigFile(this.TextBox8.Text.Trim(), "MD5") == czy.pwd)
                                    {
                                        if (TextBox9.Text == TextBox10.Text)
                                        {
                                            czy.pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(this.TextBox10.Text.Trim(), "MD5");
                                            bool a = op.Update(czy);
                                            if (a == true)
                                            {
                                                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改成功！');</script>");
                                                bind(sql);
                                            }
                                            else
                                            {
                                                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改失败！');</script>");
                                                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                                            }
                                        }
                                        else
                                        {
                                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('2次输入的密码不一致请重新输入！');</script>");
                                            TextBox9.Text = "";
                                            TextBox10.Text = "";
                                            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                                        }
                                    }
                                    else
                                    {
                                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('原密码输入有误！');</script>");
                                        TextBox8.Text = "";
                                        ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                                    }
                                }
                            }
                        }
                        else
                        {
                        
                            //bool a = op.Update(czy);
                            //if (a == true)
                            //{
                            //    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改成功！');</script>");
                            //    bind(sql);
                            //}
                            //else
                            //{
                            //    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改失败！');</script>");
                            //    ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                            //}
                        }
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('没选职员！');</script>");
                        ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('职务名称不能为空！');</script>");
                    ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                }

            }
            catch (Exception ee)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('确定异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 打开弹窗（权限）
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
                DataSet dw = pe.GetList(" Operatorid like '"+id+"'");
                Label1.Text = id.ToString();
                ListBox1.Text = dw.Tables[0].Rows[0]["look"].ToString();
                ListBox2.Text = dw.Tables[0].Rows[0]["Audit"].ToString();
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv3();</script>");
            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('弹窗异常 " + ee.Message + "');</script>");
            }

        }
        /// <summary>
        /// 修改权限确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton3_Click(object sender, EventArgs e)
        {
            try
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
                        DataSet da = pe.GetList(" Operatorid like '" + Label1.Text + "'");
                        Model.Permissionstab per = pe.GetModel(Convert.ToInt32(da.Tables[0].Rows[0]["id"]));
                        per.Look = Convert.ToInt32(ListBox1.Text);
                        per.Audit = Convert.ToInt32(ListBox2.Text);
                        bool aa = pe.Update(per);
                        if (aa == true)
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改成功！');</script>");
                        }
                        else
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改失败！');</script>");
                        }
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('没有权限修改！');</script>");
                    }
                }

            }
            catch (Exception ee)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('确定异常 " + ee.Message + "');</script>");
            }
        }
    }
}