using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;
using System.Data;
using Maticsoft.DBUtility;
using System.Web.Script.Serialization;
using ThoughtWorks.QRCode.Codec;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Maticsoft.Web.Interface
{
    /// <summary>
    /// index 的摘要说明
    /// </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    //[System.Web.Script.Services.ScriptService]
    [WebService(Namespace = "")]
    public class index : System.Web.Services.WebService
    {
        Maticsoft.BLL.Operator op = new BLL.Operator();
        Maticsoft.BLL.Permissionstab pt = new BLL.Permissionstab();
        Maticsoft.BLL.OrderTab ot = new BLL.OrderTab();//主单据
        Maticsoft.BLL.ContractTab ct = new BLL.ContractTab();//外购商品明细
        Maticsoft.BLL.phototab ph = new BLL.phototab();//形状图片
        Maticsoft.BLL.Homemadetab ht = new BLL.Homemadetab();//自制商品
        Maticsoft.BLL.Currentaccount cur = new BLL.Currentaccount();//往来账
        static string sql;
        [WebMethod]
        public void HelloWorld()
        {
            Context.Response.Write(new JavaScriptSerializer().Serialize("HelloWorld"));
        }
        /// <summary>
        /// 职员列表
        /// </summary>
        /// <param name="userid">操作员ID</param>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        [WebMethod]
        public string zyselectlist(string userid, string condition)
        {
            try
            {
                if (condition != "")
                {
                   
                    sql = " and (MemberName like '%" + condition + "%' or MemberPhone like '%" + condition + "%' or MemberPhone1 like '%" + condition + "%') ";
                }
                else
                {
                    sql = "";
                }
                Model.Operator user = op.GetModel(Convert.ToInt32(userid));
                if (user.name == "admin")
                {
                   
                    DataTable biao = DbHelperSQL.Query("select ordertab.id,OrderNumber,MemberName,MemberPhone,MemberPhone1,validity,Operator.StaffmemberID,Staffname,AllMoney,AllMoney-Deposit wfk,case when Zhuangtai1=0 then '草稿' when Zhuangtai1=1 then '下单' end Zhuangtai1,case when progress=0 then '生成草稿' when progress=1 then '确认下单' when progress=2 then '排产' when progress=3 then '生产中' when progress=4 then '入库' when progress=5 then '可送货' else '完成' end progress from ordertab left join Operator on UserTabID=Operator.id left join Staffmember on Operator.StaffmemberID=Staffmember.id where progress<6 "+sql+"  order by validity desc,allmoney desc ").Tables[0];
                    if (biao.Rows.Count > 0)
                    {
                        string qq = JsonHelper.DataSetToJson(biao);
                        qq = qq.Substring(1, qq.Length - 2);
                        return @"{""data"":{""ds"":""1""," + qq + "}}";
                    }
                    else
                    {
                        return @"{""data"":{""ds"":""0""}}";
                    }
                }
                else
                {
                    DataSet dw = pt.GetList(" Operatorid like '" + user.id + "'");
                    if (dw.Tables[0].Rows[0]["look"].Equals(0))
                    {
                        DataTable biao = DbHelperSQL.Query("select ordertab.id,OrderNumber,MemberName,MemberPhone,MemberPhone1,validity,Operator.StaffmemberID,Staffname,AllMoney,AllMoney-Deposit wfk,case when Zhuangtai1=0 then '草稿' when Zhuangtai1=1 then '下单' end Zhuangtai1,case when progress=0 then '生成草稿' when progress=1 then '确认下单' when progress=2 then '排产' when progress=3 then '生产中' when progress=4 then '入库' when progress=5 then '可送货' else '完成' end progress from ordertab left join Operator on UserTabID=Operator.id left join Staffmember on Operator.StaffmemberID=Staffmember.id where progress<6 and UserTabID like '" + user.id + "' "+sql+"  order by validity desc,allmoney desc ").Tables[0];
                        if (biao.Rows.Count > 0)
                        {
                            string qq = JsonHelper.DataSetToJson(biao);
                            qq = qq.Substring(1, qq.Length - 2);
                            return @"{""data"":{""ds"":""1""," + qq + "}}";
                        }
                        else
                        {
                            return @"{""data"":{""ds"":""0""}}";
                        }
                    }
                    else
                    {
                        DataTable biao = DbHelperSQL.Query("select ordertab.id,OrderNumber,MemberName,MemberPhone,MemberPhone1,validity,Operator.StaffmemberID,Staffname,AllMoney,AllMoney-Deposit wfk,case when Zhuangtai1=0 then '草稿' when Zhuangtai1=1 then '下单' end Zhuangtai1,case when progress=0 then '生成草稿' when progress=1 then '确认下单' when progress=2 then '排产' when progress=3 then '生产中' when progress=4 then '入库' when progress=5 then '可送货' else '完成' end progress from ordertab left join Operator on UserTabID=Operator.id left join Staffmember on Operator.StaffmemberID=Staffmember.id where progress<6 "+sql+"  order by validity desc,allmoney desc ").Tables[0];
                        if (biao.Rows.Count > 0)
                        {
                            string qq = JsonHelper.DataSetToJson(biao);
                            qq = qq.Substring(1, qq.Length - 2);
                            return @"{""data"":{""ds"":""1""," + qq + "}}";
                        }
                        else
                        {
                            return @"{""data"":{""ds"":""0""}}";
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                return @"{""data"":{""ds"":""-1"",""sm"":""数据处理有误:" + ee.Message + "\"}}";
            }
        }
       /// <summary>
       /// 职员明细表详情
       /// </summary>
       /// <param name="orderid">单据ID</param>
       /// <returns></returns>
        [WebMethod]
        public string zyselect(string orderid)
        {
            DataSet dw = ot.GetList(" id like '" + orderid + "'");
            if (dw.Tables[0].Rows.Count > 0)
            {
                string qq = JsonHelper.DataSetToJson(dw.Tables[0]);
                qq = qq.Substring(1, qq.Length - 2);
                DataSet dww = ct.GetList(" OrderNumber like '" + dw.Tables[0].Rows[0]["OrderNumber"] + "'");
                if (dww.Tables[0].Rows.Count > 0)
                {
                    string qqs = JsonHelper.shenhezhuanhuan(dww.Tables[0],2);
                    qqs = qqs.Substring(1, qqs.Length - 2);
                    return @"{""data"":{""ds"":""1""," + qq + "," + qqs + "}}";
                }
                else
                {
                    return @"{""data"":{""ds"":""1""," + qq + "}}";
                }
            }
            else
            {
                return @"{""data"":{""ds"":""0""}}";
            }
        }
        /// <summary>
        /// 查询形状图片
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string photo()
        {
            try
            {
                DataSet ds = ph.GetList(" beizhu like '1'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string qq = JsonHelper.DataSetToJson(ds.Tables[0]);
                    qq = qq.Substring(1, qq.Length - 2);
                    return @"{""data"":{""ds"":""1""," + qq + "}}";
                }
                else
                {
                    return @"{""data"":{""ds"":""0""}}";
                }
            }
            catch (Exception ee)
            {
                return @"{""data"":{""ds"":""-1"",""sm"":""数据处理有误:" + ee.Message + "\"}}";
            }
           
        }
        /// <summary>
        /// 自制商品查询
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string Homemade()
        {
            try
            {
                DataSet ds = ht.GetList(" BY1=1");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string qq = JsonHelper.DataSetToJson(ds.Tables[0]);
                    qq = qq.Substring(1, qq.Length - 2);
                    return @"{""data"":{""ds"":""1""," + qq + "}}";
                }
                else
                {
                    return @"{""data"":{""ds"":""0""}}";
                }
            }
            catch (Exception ee)
            {
                return @"{""data"":{""ds"":""-1"",""sm"":""数据处理有误:" + ee.Message + "\"}}";
            }
        }
        [WebMethod]
        public string orderadd(string json)
        {
            try
            {
                json = @"{""OrderNumber"":""201812050001"",""MemberName"":""李四先生"",""MemberPhone"":""12356565656"",""MemberPhone1"":"""",""MemberAdd"":""铁西区南十路23号2-3-2"",""HomemadeID"":""2"",""StaffmemberID"":""2"",""UserTabID"":""3"",""PhotoID1"":""3"",""PhotoID2"":"""",""PhotoID3"":"""",""PhotoID4"":""5"",""validity"":""2018-12-06"",""Deposit"":""400.50"",""AllMoney"":""4500.50"",""alllength"":""33.22"",""Imperial"":""22.22"",""QhWidth"":""11.11"",""Beizhuwg"":""外购商品备注！！"",""Beizhuzz"":""自制商品备注！！"",""Zengsong"":""赠品备注"",""Zhuangtai2"":""1"",""table"": [{""CommodityID"": ""桌子卡门"",""by1"": ""1""}, {""CommodityID"": ""椅子卡门"",""by1"": ""2""}]}";

                JObject joo = (JObject)JsonConvert.DeserializeObject(json);
                string OrderNumber = joo["OrderNumber"].ToString();
                string MemberName = joo["MemberName"].ToString();
                string MemberPhone = joo["MemberPhone"].ToString();
                string MemberPhone1 = joo["MemberPhone1"].ToString();
                string MemberAdd = joo["MemberAdd"].ToString();
                string HomemadeID = joo["HomemadeID"].ToString();
                string StaffmemberID = joo["StaffmemberID"].ToString();
                string UserTabID = joo["UserTabID"].ToString();
                string PhotoID1 = joo["PhotoID1"].ToString();
                string PhotoID2 = joo["PhotoID2"].ToString();
                string PhotoID3 = joo["PhotoID3"].ToString();
                string PhotoID4 = joo["PhotoID4"].ToString();
                string validity = joo["validity"].ToString();
                string Deposit = joo["Deposit"].ToString();
                string AllMoney = joo["AllMoney"].ToString();
                string alllength = joo["alllength"].ToString();
                string Imperial = joo["Imperial"].ToString();
                string QhWidth = joo["QhWidth"].ToString();
                string Beizhuwg = joo["Beizhuwg"].ToString();
                string Beizhuzz = joo["Beizhuzz"].ToString();
                string Zengsong = joo["Zengsong"].ToString();
                string Zhuangtai2 = joo["Zhuangtai2"].ToString();
                string table = joo["table"].ToString();
                 DataSet ds = ot.GetList(" validity='" + validity + "'");
                 if (ds.Tables[0].Rows.Count >= 15)
                 {
                     return @"{""data"":{""ds"":""2""}}";
                 }
                 else
                 {
                     JArray je = (JArray)JsonConvert.DeserializeObject(table);
                     DataTable spb = new DataTable();
                     spb.Columns.Add("CommodityID");
                     spb.Columns.Add("by1");
                     foreach (JObject iom in je)
                     {
                         spb.Rows.Add(iom["CommodityID"].ToString(), iom["by1"].ToString());
                     }
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
                     string serial = @"http://192.168.1.150:8585/xianshi.asmx/jiekou?id=" + OrderNumber;
                     System.Drawing.Image image = qrCodeEncoder.Encode(serial);

                     string filename = OrderNumber + ".jpg";
                     string filepath = Server.MapPath(@"~\qrcode111") + "\\" + filename;
                     //如果文件夹不存在，则创建
                     //if (!Directory.Exists(filepath))
                     //    Directory.CreateDirectory(filepath);
                     System.IO.FileStream fs = new System.IO.FileStream(filepath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
                     image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                     fs.Close();
                     image.Dispose();
                     Model.OrderTab ort = new Model.OrderTab();
                     ort.MemberName = MemberName;
                     ort.MemberPhone = MemberPhone;
                     ort.MemberPhone1 = MemberPhone1;
                     ort.MemberAdd = MemberAdd;
                     ort.Orderdate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                     ort.OrderNumber = OrderNumber;
                     ort.UserTabID = Convert.ToInt32(UserTabID);
                     if (PhotoID1 != "")
                     {
                         ort.PhotoID1 = Convert.ToInt32(PhotoID1);
                     }
                     else
                     {
                         ort.PhotoID1 = 0;
                     }
                     if (PhotoID2 != "")
                     {
                         ort.PhotoID2 = Convert.ToInt32(PhotoID2);
                     }
                     else
                     {
                         ort.PhotoID2 = 0;
                     }
                     if (PhotoID3 != "")
                     {
                         ort.PhotoID3 = Convert.ToInt32(PhotoID3);
                     }
                     else
                     {
                         ort.PhotoID3 = 0;
                     }
                     if (PhotoID4 != "")
                     {
                         ort.PhotoID4 = Convert.ToInt32(PhotoID4);
                     }
                     else
                     {
                         ort.PhotoID4 = 0;
                     }
                     ort.qrcode = "../qrcode111/" + filename;
                     ort.validity = Convert.ToDateTime(validity);
                     ort.progress = 0;
                     ort.AllMoney = Convert.ToDecimal(AllMoney);
                     if (Deposit == "")
                     {
                         ort.Deposit = 0;
                     }
                     else
                     {
                         ort.Deposit = Convert.ToDecimal(Deposit);
                     }
                     ort.alllength = Convert.ToDecimal(alllength);
                     ort.Imperial = Convert.ToDecimal(Imperial);
                     ort.QhWidth = Convert.ToDecimal(QhWidth);
                     ort.Beizhuwg = Beizhuwg;
                     ort.Beizhuzz = Beizhuzz;
                     ort.Zengsong = Zengsong;
                     ort.Zhuangtai1 = 0;//草稿
                     ort.Zhuangtai2 = Convert.ToInt32(Zhuangtai2);
                     ort.StaffmemberID = Convert.ToInt32(StaffmemberID);
                     ort.HomemadeID = Convert.ToInt32(HomemadeID);
                     if (spb.Rows.Count > 0)
                     {
                         for (int i = 0; i < spb.Rows.Count; i++)
                         {
                             Model.ContractTab con = new Model.ContractTab();
                             con.OrderNumber = OrderNumber;
                             con.CommodityID = spb.Rows[i]["CommodityID"].ToString();
                             con.By1 = Convert.ToDecimal(spb.Rows[i]["By1"]);
                             ct.Add(con);
                         }
                     }
                     Model.Currentaccount cu = new Model.Currentaccount();
                     cu.billnumber = OrderNumber;
                     cu.type = 1;
                     cu.receipt = DateTime.Now;
                     if (Deposit == "")
                     {
                         cu.money = 0;
                     }
                     else
                     {
                         cu.money = Convert.ToDecimal(Deposit);
                     }
                     int b = cur.Add(cu);
                     int a = ot.Add(ort);
                     if (a > 0 && b > 0)
                     {
                         return @"{""data"":{""ds"":""1""}}";
                     }
                     else
                     {
                         return @"{""data"":{""ds"":""0""}}";
                     }
                 }
            }
            catch (Exception ee)
            {
                return @"{""data"":{""ds"":""-1"",""sm"":""数据处理有误:" + ee.Message + "\"}}";
            }
            
        }
    }

}
