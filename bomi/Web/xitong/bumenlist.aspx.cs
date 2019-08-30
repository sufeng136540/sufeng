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
    public partial class bumenlist : System.Web.UI.Page
    {
        Maticsoft.BLL.Department dep = new BLL.Department();
        Maticsoft.BLL.Staffmember st = new BLL.Staffmember();
        static string sql = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                sql = "";
                bind(sql);
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
                DataTable biao = DbHelperSQL.Query(" select ROW_NUMBER() over(order by id) as shu,id,departmentname,beizhu from Department where 1=1 " + sql).Tables[0];
                this.Repeater1.DataSource = biao;
                this.Repeater1.DataBind();//绑定  刷新
            }
            catch (Exception ee)
            {
                Response.Write("<script>alert('页面异常 " + ee.Message + "')</script>");
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
                if (TextBox1.Text.Trim() != "")
                {
                    Maticsoft.Model.Department bumen = new Model.Department();
                    bumen.departmentname = TextBox1.Text.Trim();
                    bumen.Beizhu = TextBox2.Text.Trim();
                    int a = dep.Add(bumen);
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
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('部门名称不能为空！');</script>");
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
                sql = sql + " departmentname like '%" + TextBox3.Text + "%' and ";
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
                Model.Department po = dep.GetModel(id);
                Label1.Text = po.id.ToString();
                TextBox4.Text = po.departmentname;
                TextBox5.Text = po.Beizhu;
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
                DataSet dwq = st.GetList(" departmentID like '" + id + "'");
                if (dwq.Tables[0].Rows.Count > 0)
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('该部门有职员！');</script>");
                }
                else
                {
                    bool a = dep.Delete(id);
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
                    Maticsoft.Model.Department bumen = dep.GetModel(Convert.ToInt32(Label1.Text));
                    bumen.departmentname = TextBox4.Text.Trim();
                    bumen.Beizhu = TextBox5.Text.Trim();
                    bool a = dep.Update(bumen);
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
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('职务名称不能为空！');</script>");
                    ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
                }

            }
            catch (Exception ee)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('确定异常 " + ee.Message + "');</script>");
            }
        }
    }
}