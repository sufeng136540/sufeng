using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Maticsoft.DBUtility;

namespace Maticsoft.Web.chanpin
{
    public partial class waigouchanpin : System.Web.UI.Page
    {
        Maticsoft.BLL.Commoditytab hot = new BLL.Commoditytab();//自制商品
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
                DataTable biao = DbHelperSQL.Query(" select ROW_NUMBER() over(order by id) as shu,id,case when category=1 then '餐  桌' when category=2 then '餐  椅' when category=3 then '茶  几' when category=4 then '电视柜' when category=5 then '床' when category=6 then '床  垫' when category=7 then '床头柜' end category,name,beizhu from Commoditytab where 1=1 " + sql).Tables[0];
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
        /// 打开弹窗(添加)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            ListBox1.Text = "0";
            TextBox1.Text = "";
            TextBox2.Text = "";
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
        }
        /// <summary>
        /// 添加外购商品（确定按钮）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text.Trim() != "")
                {
                    //string t = Convert.ToString("ZZSP" + DateTime.Now.ToString("yyyyMMddhhmmss"));
                    Model.Commoditytab ho = new Model.Commoditytab();
                    //if (FileUpload1.FileName != "")
                    //{
                    //    string name1 = FileUpload1.FileName;//上传文件名字
                    //    string type1 = FileUpload1.PostedFile.ContentType;
                    //    string type11 = name1.Substring(name1.LastIndexOf(".") + 1);
                    //    //string path1 = HttpContext.Current.Request.MapPath("~/") + "picture\\" + FileUpload1.FileName;
                    //    if (type11 == "jpg" || type11 == "gif" || type11 == "bmp" || type11 == "png")
                    //    {
                    //        string ming1 = name1.Substring(name1.Length - 4, 4);
                    //        string wj1 = "D1" + t + ming1;
                    //        string path = HttpContext.Current.Request.MapPath("~/") + "picture\\";
                    //        FileUpload1.SaveAs(path + wj1);
                    //        ho.Photourl = "../picture/" + wj1;
                    //        ho.Name = TextBox1.Text;
                    //        ho.Comment = TextBox6.Text;
                    //        ho.Beizhu = TextBox2.Text;
                    //        int a = hot.Add(ho);
                    //        if (a > 0)
                    //        {
                    //            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('添加成功！');</script>");
                    //            bind(sql);
                    //        }
                    //        else
                    //        {
                    //            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('添加失败！');</script>");
                    //            bind(sql);
                    //        }
                    //    }
                    //    else
                    //    {
                    //        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('图片格式不正确请传（.jpg/.gif/.bmp/.png）！');</script>");
                    //    }
                    //}
                    //else
                    //{
                        ho.category =Convert.ToInt32(ListBox1.Text);
                        ho.Name = TextBox1.Text;
                        ho.Beizhu = TextBox2.Text;
                        int a = hot.Add(ho);
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
                //    }


                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('自制商品名称不能为空！');</script>");
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
        /// 打开弹窗（修改）
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
                Model.Commoditytab hom = hot.GetModel(id);
                Label1.Text = hom.id.ToString();
                ListBox2.Text = hom.category.ToString();
                TextBox4.Text = hom.Name;
                TextBox7.Text = hom.Beizhu;
                ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv2();</script>");
            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改弹窗异常 " + ee.Message + "');</script>");
            }
        }
        /// <summary>
        /// 删除
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
                bool aa = hot.Delete(id);
                if (aa == true)
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
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('删除异常 " + ee.Message + "');</script>");
            }

        }
        /// <summary>
        /// 修改外购商品（确定按钮）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox4.Text.Trim() != "")
                {
                    //string t = Convert.ToString("ZZSP" + DateTime.Now.ToString("yyyyMMddhhmmss"));
                    Model.Commoditytab ho = hot.GetModel(Convert.ToInt32(Label1.Text));
                    //if (FileUpload2.FileName != "")
                    //{
                    //    string name2 = FileUpload2.FileName;//上传文件名字
                    //    string type2 = FileUpload2.PostedFile.ContentType;
                    //    string type12 = name2.Substring(name2.LastIndexOf(".") + 1);
                    //    //string path1 = HttpContext.Current.Request.MapPath("~/") + "picture\\" + FileUpload1.FileName;
                    //    if (type12 == "jpg" || type12 == "gif" || type12 == "bmp" || type12 == "png")
                    //    {
                    //        string ming1 = name2.Substring(name2.Length - 4, 4);
                    //        string wj1 = "D1" + t + ming1;
                    //        string path = HttpContext.Current.Request.MapPath("~/") + "picture\\";
                    //        FileUpload2.SaveAs(path + wj1);
                    //        ho.Photourl = "../picture/" + wj1;
                    //        ho.Name = TextBox4.Text;
                    //        ho.Comment = TextBox5.Text;
                    //        ho.Beizhu = TextBox7.Text;
                    //        bool a = hot.Update(ho);
                    //        if (a == true)
                    //        {
                    //            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改成功！');</script>");
                    //            bind(sql);
                    //        }
                    //        else
                    //        {
                    //            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改失败！');</script>");
                    //            bind(sql);
                    //        }
                    //    }
                    //    else
                    //    {
                    //        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('图片格式不正确请传（.jpg/.gif/.bmp/.png）！');</script>");
                    //    }
                    //}
                    //else
                    //{
                        ho.category =Convert.ToInt32(ListBox2.Text);
                        ho.Name = TextBox4.Text;
                        ho.Beizhu = TextBox7.Text;
                        bool a = hot.Update(ho);
                        if (a == true)
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改成功！');</script>");
                            bind(sql);
                        }
                        else
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('修改失败！');</script>");
                            bind(sql);
                        }
                    //}

                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('外购商品名称不能为空！');</script>");
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