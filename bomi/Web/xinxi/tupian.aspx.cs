using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Maticsoft.DBUtility;

namespace Maticsoft.Web.xinxi
{
    public partial class tupian : System.Web.UI.Page
    {
        Maticsoft.BLL.phototab pt = new BLL.phototab();//图片表
        Maticsoft.BLL.OrderTab or = new BLL.OrderTab();//单据
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }
        /// <summary>
        /// 页面显示的主表
        /// </summary>
        /// <param name="sql">查询语句的条件</param>
        private void bind()
        {
            try
            {
                DataTable biao = DbHelperSQL.Query(" select ROW_NUMBER() over(order by id) as shu,id,Photourl from phototab where beizhu like '1' ").Tables[0];
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
        /// 打开弹窗（添加）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
        }
        /// <summary>
        /// 添加自制商品（确定按钮）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string t = Convert.ToString("TP" + DateTime.Now.ToString("yyyyMMddhhmmss"));
                Model.phototab ho = new Model.phototab();
                if (FileUpload1.FileName != "")
                {
                    string name1 = FileUpload1.FileName;//上传文件名字
                    string type1 = FileUpload1.PostedFile.ContentType;
                    string type11 = name1.Substring(name1.LastIndexOf(".") + 1);
                    //string path1 = HttpContext.Current.Request.MapPath("~/") + "picture\\" + FileUpload1.FileName;
                    if (type11 == "jpg" || type11 == "gif" || type11 == "bmp" || type11 == "png")
                    {
                        string ming1 = name1.Substring(name1.Length - 4, 4);
                        string wj1 =  t + ming1;
                        string path = HttpContext.Current.Request.MapPath("~/") + "tupian\\";
                        FileUpload1.SaveAs(path + wj1);
                        ho.Photourl = "../tupian/" + wj1;
                        ho.beizhu = "1";
                        int a = pt.Add(ho);
                        if (a > 0)
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('添加成功！');</script>");
                            bind();
                        }
                        else
                        {
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('添加失败！');</script>");
                            bind();
                        }
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('图片格式不正确请传（.jpg/.gif/.bmp/.png）！');</script>");
                        ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>javascript:showDiv1();</script>");
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('请选择图片！');</script>");
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
                DataSet de = or.GetList(" (PhotoID1 like '" + id + "' or PhotoID2 like '" + id + "' or PhotoID3 like '" + id + "' or PhotoID4 like '"+id+"' )");
                if (de.Tables[0].Rows.Count > 0)
                {
                    Model.phototab dd = pt.GetModel(id);
                    dd.beizhu = "0";
                    bool a=pt.Update(dd);
                    if (a == true)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('停用成功！');</script>");
                        bind();
                    }
                    else
                    {

                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('停用失败！');</script>");
                        bind();
                    }
                }
                else
                {
                    bool aa = pt.Delete(id);
                    if (aa == true)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('删除成功！');</script>");
                        bind();
                    }
                    else
                    {

                        ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('删除失败！');</script>");
                        bind();
                    }
                }


            }
            catch (Exception ee)
            {
                //Response.Write("<script>alert('确定异常 " + ee.Message + "')</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "this", "<script language=javascript>alert('删除异常 " + ee.Message + "');</script>");
            }

        }
    }
}