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
    public partial class wanglaizhang : System.Web.UI.Page
    {
        static string sql;
        Maticsoft.BLL.Staffmember st = new BLL.Staffmember();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                sql = "";
                bind(sql);
                xialakuang1();
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
                DataSet biao = DbHelperSQL.Query("select billnumber,membername,MemberPhone,MemberPhone1,Staffname,Operator.StaffmemberID,validity,AllMoney, case when type=1 then '订单收款' when type=2 then '收款单收款' end sk,receipt,money from Currentaccount left join OrderTab on billnumber=ordernumber left join Operator on UserTabID=Operator.id left join Staffmember on Operator.StaffmemberID=Staffmember.id where 1=1"+sql);
                this.Repeater1.DataSource = biao;
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
                sql = sql + " billnumber like '%" + TextBox3.Text + "%' and ";
            }
            if(TextBox13.Text.Trim()!="")
            {
                sql = sql + " membername like '%"+TextBox13.Text+"%' and ";
            }
            if (DropDownList1.Text != "0")
            {
                sql = sql + " Operator.StaffmemberID like '" + DropDownList1.Text + "' and ";
            }
            if (TextBox11.Text.Trim() != "")
            {
                sql = sql + " receipt>='" + TextBox11.Text + "' and ";
            }
            if (TextBox12.Text.Trim() != "")
            {
                string sj = Convert.ToDateTime(TextBox12.Text).AddDays(1).ToString("yyyy-MM-dd");
                sql = sql + " receipt<='" + sj + "' and ";
            }
            if (sql != "")
            {
                sql = " and " + sql;
                sql = sql.Substring(0, sql.Length - 5);
            }
            bind(sql);

        }
    }
}