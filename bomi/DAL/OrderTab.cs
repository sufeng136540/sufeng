using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:OrderTab
	/// </summary>
	public partial class OrderTab
	{
		public OrderTab()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "OrderTab"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OrderTab");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.OrderTab model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OrderTab(");
			strSql.Append("MemberID,MemberName,MemberPhone,MemberPhone1,MemberAdd,Orderdate,OrderNumber,StaffmemberID,Staffmembername,UserTabID,PhotoID1,PhotoID2,PhotoID3,PhotoID4,qrcode,validity,progress,Deposit,AllMoney,alllength,Imperial,QhWidth,Beizhuwg,Beizhuzz,Zengsong,Zhuangtai1,Zhuangtai2,By1,By2,By3,By4,By5,By6,By7,HomemadeID)");
			strSql.Append(" values (");
			strSql.Append("@MemberID,@MemberName,@MemberPhone,@MemberPhone1,@MemberAdd,@Orderdate,@OrderNumber,@StaffmemberID,@Staffmembername,@UserTabID,@PhotoID1,@PhotoID2,@PhotoID3,@PhotoID4,@qrcode,@validity,@progress,@Deposit,@AllMoney,@alllength,@Imperial,@QhWidth,@Beizhuwg,@Beizhuzz,@Zengsong,@Zhuangtai1,@Zhuangtai2,@By1,@By2,@By3,@By4,@By5,@By6,@By7,@HomemadeID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberID", SqlDbType.Int,4),
					new SqlParameter("@MemberName", SqlDbType.VarChar,100),
					new SqlParameter("@MemberPhone", SqlDbType.VarChar,100),
					new SqlParameter("@MemberPhone1", SqlDbType.VarChar,100),
					new SqlParameter("@MemberAdd", SqlDbType.VarChar,4000),
					new SqlParameter("@Orderdate", SqlDbType.DateTime),
					new SqlParameter("@OrderNumber", SqlDbType.VarChar,100),
					new SqlParameter("@StaffmemberID", SqlDbType.Int,4),
					new SqlParameter("@Staffmembername", SqlDbType.VarChar,100),
					new SqlParameter("@UserTabID", SqlDbType.Int,4),
					new SqlParameter("@PhotoID1", SqlDbType.Int,4),
					new SqlParameter("@PhotoID2", SqlDbType.Int,4),
					new SqlParameter("@PhotoID3", SqlDbType.Int,4),
					new SqlParameter("@PhotoID4", SqlDbType.Int,4),
					new SqlParameter("@qrcode", SqlDbType.VarChar,4000),
					new SqlParameter("@validity", SqlDbType.DateTime),
					new SqlParameter("@progress", SqlDbType.Int,4),
					new SqlParameter("@Deposit", SqlDbType.Decimal,9),
					new SqlParameter("@AllMoney", SqlDbType.Decimal,9),
					new SqlParameter("@alllength", SqlDbType.Decimal,9),
					new SqlParameter("@Imperial", SqlDbType.Decimal,9),
					new SqlParameter("@QhWidth", SqlDbType.Decimal,9),
					new SqlParameter("@Beizhuwg", SqlDbType.VarChar,4000),
					new SqlParameter("@Beizhuzz", SqlDbType.VarChar,4000),
					new SqlParameter("@Zengsong", SqlDbType.VarChar,4000),
					new SqlParameter("@Zhuangtai1", SqlDbType.Int,4),
					new SqlParameter("@Zhuangtai2", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.Decimal,9),
					new SqlParameter("@By2", SqlDbType.Decimal,9),
					new SqlParameter("@By3", SqlDbType.Decimal,9),
					new SqlParameter("@By4", SqlDbType.VarChar,4000),
					new SqlParameter("@By5", SqlDbType.VarChar,4000),
					new SqlParameter("@By6", SqlDbType.VarChar,4000),
					new SqlParameter("@By7", SqlDbType.VarChar,4000),
					new SqlParameter("@HomemadeID", SqlDbType.Int,4)};
			parameters[0].Value = model.MemberID;
			parameters[1].Value = model.MemberName;
			parameters[2].Value = model.MemberPhone;
			parameters[3].Value = model.MemberPhone1;
			parameters[4].Value = model.MemberAdd;
			parameters[5].Value = model.Orderdate;
			parameters[6].Value = model.OrderNumber;
			parameters[7].Value = model.StaffmemberID;
			parameters[8].Value = model.Staffmembername;
			parameters[9].Value = model.UserTabID;
			parameters[10].Value = model.PhotoID1;
			parameters[11].Value = model.PhotoID2;
			parameters[12].Value = model.PhotoID3;
			parameters[13].Value = model.PhotoID4;
			parameters[14].Value = model.qrcode;
			parameters[15].Value = model.validity;
			parameters[16].Value = model.progress;
			parameters[17].Value = model.Deposit;
			parameters[18].Value = model.AllMoney;
			parameters[19].Value = model.alllength;
			parameters[20].Value = model.Imperial;
			parameters[21].Value = model.QhWidth;
			parameters[22].Value = model.Beizhuwg;
			parameters[23].Value = model.Beizhuzz;
			parameters[24].Value = model.Zengsong;
			parameters[25].Value = model.Zhuangtai1;
			parameters[26].Value = model.Zhuangtai2;
			parameters[27].Value = model.By1;
			parameters[28].Value = model.By2;
			parameters[29].Value = model.By3;
			parameters[30].Value = model.By4;
			parameters[31].Value = model.By5;
			parameters[32].Value = model.By6;
			parameters[33].Value = model.By7;
			parameters[34].Value = model.HomemadeID;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.OrderTab model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OrderTab set ");
			strSql.Append("MemberID=@MemberID,");
			strSql.Append("MemberName=@MemberName,");
			strSql.Append("MemberPhone=@MemberPhone,");
			strSql.Append("MemberPhone1=@MemberPhone1,");
			strSql.Append("MemberAdd=@MemberAdd,");
			strSql.Append("Orderdate=@Orderdate,");
			strSql.Append("OrderNumber=@OrderNumber,");
			strSql.Append("StaffmemberID=@StaffmemberID,");
			strSql.Append("Staffmembername=@Staffmembername,");
			strSql.Append("UserTabID=@UserTabID,");
			strSql.Append("PhotoID1=@PhotoID1,");
			strSql.Append("PhotoID2=@PhotoID2,");
			strSql.Append("PhotoID3=@PhotoID3,");
			strSql.Append("PhotoID4=@PhotoID4,");
			strSql.Append("qrcode=@qrcode,");
			strSql.Append("validity=@validity,");
			strSql.Append("progress=@progress,");
			strSql.Append("Deposit=@Deposit,");
			strSql.Append("AllMoney=@AllMoney,");
			strSql.Append("alllength=@alllength,");
			strSql.Append("Imperial=@Imperial,");
			strSql.Append("QhWidth=@QhWidth,");
			strSql.Append("Beizhuwg=@Beizhuwg,");
			strSql.Append("Beizhuzz=@Beizhuzz,");
			strSql.Append("Zengsong=@Zengsong,");
			strSql.Append("Zhuangtai1=@Zhuangtai1,");
			strSql.Append("Zhuangtai2=@Zhuangtai2,");
			strSql.Append("By1=@By1,");
			strSql.Append("By2=@By2,");
			strSql.Append("By3=@By3,");
			strSql.Append("By4=@By4,");
			strSql.Append("By5=@By5,");
			strSql.Append("By6=@By6,");
			strSql.Append("By7=@By7,");
			strSql.Append("HomemadeID=@HomemadeID");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberID", SqlDbType.Int,4),
					new SqlParameter("@MemberName", SqlDbType.VarChar,100),
					new SqlParameter("@MemberPhone", SqlDbType.VarChar,100),
					new SqlParameter("@MemberPhone1", SqlDbType.VarChar,100),
					new SqlParameter("@MemberAdd", SqlDbType.VarChar,4000),
					new SqlParameter("@Orderdate", SqlDbType.DateTime),
					new SqlParameter("@OrderNumber", SqlDbType.VarChar,100),
					new SqlParameter("@StaffmemberID", SqlDbType.Int,4),
					new SqlParameter("@Staffmembername", SqlDbType.VarChar,100),
					new SqlParameter("@UserTabID", SqlDbType.Int,4),
					new SqlParameter("@PhotoID1", SqlDbType.Int,4),
					new SqlParameter("@PhotoID2", SqlDbType.Int,4),
					new SqlParameter("@PhotoID3", SqlDbType.Int,4),
					new SqlParameter("@PhotoID4", SqlDbType.Int,4),
					new SqlParameter("@qrcode", SqlDbType.VarChar,4000),
					new SqlParameter("@validity", SqlDbType.DateTime),
					new SqlParameter("@progress", SqlDbType.Int,4),
					new SqlParameter("@Deposit", SqlDbType.Decimal,9),
					new SqlParameter("@AllMoney", SqlDbType.Decimal,9),
					new SqlParameter("@alllength", SqlDbType.Decimal,9),
					new SqlParameter("@Imperial", SqlDbType.Decimal,9),
					new SqlParameter("@QhWidth", SqlDbType.Decimal,9),
					new SqlParameter("@Beizhuwg", SqlDbType.VarChar,4000),
					new SqlParameter("@Beizhuzz", SqlDbType.VarChar,4000),
					new SqlParameter("@Zengsong", SqlDbType.VarChar,4000),
					new SqlParameter("@Zhuangtai1", SqlDbType.Int,4),
					new SqlParameter("@Zhuangtai2", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.Decimal,9),
					new SqlParameter("@By2", SqlDbType.Decimal,9),
					new SqlParameter("@By3", SqlDbType.Decimal,9),
					new SqlParameter("@By4", SqlDbType.VarChar,4000),
					new SqlParameter("@By5", SqlDbType.VarChar,4000),
					new SqlParameter("@By6", SqlDbType.VarChar,4000),
					new SqlParameter("@By7", SqlDbType.VarChar,4000),
					new SqlParameter("@HomemadeID", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.MemberID;
			parameters[1].Value = model.MemberName;
			parameters[2].Value = model.MemberPhone;
			parameters[3].Value = model.MemberPhone1;
			parameters[4].Value = model.MemberAdd;
			parameters[5].Value = model.Orderdate;
			parameters[6].Value = model.OrderNumber;
			parameters[7].Value = model.StaffmemberID;
			parameters[8].Value = model.Staffmembername;
			parameters[9].Value = model.UserTabID;
			parameters[10].Value = model.PhotoID1;
			parameters[11].Value = model.PhotoID2;
			parameters[12].Value = model.PhotoID3;
			parameters[13].Value = model.PhotoID4;
			parameters[14].Value = model.qrcode;
			parameters[15].Value = model.validity;
			parameters[16].Value = model.progress;
			parameters[17].Value = model.Deposit;
			parameters[18].Value = model.AllMoney;
			parameters[19].Value = model.alllength;
			parameters[20].Value = model.Imperial;
			parameters[21].Value = model.QhWidth;
			parameters[22].Value = model.Beizhuwg;
			parameters[23].Value = model.Beizhuzz;
			parameters[24].Value = model.Zengsong;
			parameters[25].Value = model.Zhuangtai1;
			parameters[26].Value = model.Zhuangtai2;
			parameters[27].Value = model.By1;
			parameters[28].Value = model.By2;
			parameters[29].Value = model.By3;
			parameters[30].Value = model.By4;
			parameters[31].Value = model.By5;
			parameters[32].Value = model.By6;
			parameters[33].Value = model.By7;
			parameters[34].Value = model.HomemadeID;
			parameters[35].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OrderTab ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OrderTab ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.OrderTab GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,MemberID,MemberName,MemberPhone,MemberPhone1,MemberAdd,Orderdate,OrderNumber,StaffmemberID,Staffmembername,UserTabID,PhotoID1,PhotoID2,PhotoID3,PhotoID4,qrcode,validity,progress,Deposit,AllMoney,alllength,Imperial,QhWidth,Beizhuwg,Beizhuzz,Zengsong,Zhuangtai1,Zhuangtai2,By1,By2,By3,By4,By5,By6,By7,HomemadeID from OrderTab ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.OrderTab model=new Maticsoft.Model.OrderTab();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.OrderTab DataRowToModel(DataRow row)
		{
			Maticsoft.Model.OrderTab model=new Maticsoft.Model.OrderTab();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["MemberID"]!=null && row["MemberID"].ToString()!="")
				{
					model.MemberID=int.Parse(row["MemberID"].ToString());
				}
				if(row["MemberName"]!=null)
				{
					model.MemberName=row["MemberName"].ToString();
				}
				if(row["MemberPhone"]!=null)
				{
					model.MemberPhone=row["MemberPhone"].ToString();
				}
				if(row["MemberPhone1"]!=null)
				{
					model.MemberPhone1=row["MemberPhone1"].ToString();
				}
				if(row["MemberAdd"]!=null)
				{
					model.MemberAdd=row["MemberAdd"].ToString();
				}
				if(row["Orderdate"]!=null && row["Orderdate"].ToString()!="")
				{
					model.Orderdate=DateTime.Parse(row["Orderdate"].ToString());
				}
				if(row["OrderNumber"]!=null)
				{
					model.OrderNumber=row["OrderNumber"].ToString();
				}
				if(row["StaffmemberID"]!=null && row["StaffmemberID"].ToString()!="")
				{
					model.StaffmemberID=int.Parse(row["StaffmemberID"].ToString());
				}
				if(row["Staffmembername"]!=null)
				{
					model.Staffmembername=row["Staffmembername"].ToString();
				}
				if(row["UserTabID"]!=null && row["UserTabID"].ToString()!="")
				{
					model.UserTabID=int.Parse(row["UserTabID"].ToString());
				}
				if(row["PhotoID1"]!=null && row["PhotoID1"].ToString()!="")
				{
					model.PhotoID1=int.Parse(row["PhotoID1"].ToString());
				}
				if(row["PhotoID2"]!=null && row["PhotoID2"].ToString()!="")
				{
					model.PhotoID2=int.Parse(row["PhotoID2"].ToString());
				}
				if(row["PhotoID3"]!=null && row["PhotoID3"].ToString()!="")
				{
					model.PhotoID3=int.Parse(row["PhotoID3"].ToString());
				}
				if(row["PhotoID4"]!=null && row["PhotoID4"].ToString()!="")
				{
					model.PhotoID4=int.Parse(row["PhotoID4"].ToString());
				}
				if(row["qrcode"]!=null)
				{
					model.qrcode=row["qrcode"].ToString();
				}
				if(row["validity"]!=null && row["validity"].ToString()!="")
				{
					model.validity=DateTime.Parse(row["validity"].ToString());
				}
				if(row["progress"]!=null && row["progress"].ToString()!="")
				{
					model.progress=int.Parse(row["progress"].ToString());
				}
				if(row["Deposit"]!=null && row["Deposit"].ToString()!="")
				{
					model.Deposit=decimal.Parse(row["Deposit"].ToString());
				}
				if(row["AllMoney"]!=null && row["AllMoney"].ToString()!="")
				{
					model.AllMoney=decimal.Parse(row["AllMoney"].ToString());
				}
				if(row["alllength"]!=null && row["alllength"].ToString()!="")
				{
					model.alllength=decimal.Parse(row["alllength"].ToString());
				}
				if(row["Imperial"]!=null && row["Imperial"].ToString()!="")
				{
					model.Imperial=decimal.Parse(row["Imperial"].ToString());
				}
				if(row["QhWidth"]!=null && row["QhWidth"].ToString()!="")
				{
					model.QhWidth=decimal.Parse(row["QhWidth"].ToString());
				}
				if(row["Beizhuwg"]!=null)
				{
					model.Beizhuwg=row["Beizhuwg"].ToString();
				}
				if(row["Beizhuzz"]!=null)
				{
					model.Beizhuzz=row["Beizhuzz"].ToString();
				}
				if(row["Zengsong"]!=null)
				{
					model.Zengsong=row["Zengsong"].ToString();
				}
				if(row["Zhuangtai1"]!=null && row["Zhuangtai1"].ToString()!="")
				{
					model.Zhuangtai1=int.Parse(row["Zhuangtai1"].ToString());
				}
				if(row["Zhuangtai2"]!=null && row["Zhuangtai2"].ToString()!="")
				{
					model.Zhuangtai2=int.Parse(row["Zhuangtai2"].ToString());
				}
				if(row["By1"]!=null && row["By1"].ToString()!="")
				{
					model.By1=decimal.Parse(row["By1"].ToString());
				}
				if(row["By2"]!=null && row["By2"].ToString()!="")
				{
					model.By2=decimal.Parse(row["By2"].ToString());
				}
				if(row["By3"]!=null && row["By3"].ToString()!="")
				{
					model.By3=decimal.Parse(row["By3"].ToString());
				}
				if(row["By4"]!=null)
				{
					model.By4=row["By4"].ToString();
				}
				if(row["By5"]!=null)
				{
					model.By5=row["By5"].ToString();
				}
				if(row["By6"]!=null)
				{
					model.By6=row["By6"].ToString();
				}
				if(row["By7"]!=null)
				{
					model.By7=row["By7"].ToString();
				}
				if(row["HomemadeID"]!=null && row["HomemadeID"].ToString()!="")
				{
					model.HomemadeID=int.Parse(row["HomemadeID"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,MemberID,MemberName,MemberPhone,MemberPhone1,MemberAdd,Orderdate,OrderNumber,StaffmemberID,Staffmembername,UserTabID,PhotoID1,PhotoID2,PhotoID3,PhotoID4,qrcode,validity,progress,Deposit,AllMoney,alllength,Imperial,QhWidth,Beizhuwg,Beizhuzz,Zengsong,Zhuangtai1,Zhuangtai2,By1,By2,By3,By4,By5,By6,By7,HomemadeID ");
			strSql.Append(" FROM OrderTab ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,MemberID,MemberName,MemberPhone,MemberPhone1,MemberAdd,Orderdate,OrderNumber,StaffmemberID,Staffmembername,UserTabID,PhotoID1,PhotoID2,PhotoID3,PhotoID4,qrcode,validity,progress,Deposit,AllMoney,alllength,Imperial,QhWidth,Beizhuwg,Beizhuzz,Zengsong,Zhuangtai1,Zhuangtai2,By1,By2,By3,By4,By5,By6,By7,HomemadeID ");
			strSql.Append(" FROM OrderTab ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM OrderTab ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from OrderTab T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "OrderTab";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

