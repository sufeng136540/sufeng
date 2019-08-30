using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:ContractTab
	/// </summary>
	public partial class ContractTab
	{
		public ContractTab()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "ContractTab"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ContractTab");
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
		public int Add(Maticsoft.Model.ContractTab model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ContractTab(");
			strSql.Append("OrderNumber,CommodityID,beizhu,By1,By2,By3,By4,By5,By6,By7)");
			strSql.Append(" values (");
			strSql.Append("@OrderNumber,@CommodityID,@beizhu,@By1,@By2,@By3,@By4,@By5,@By6,@By7)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OrderNumber", SqlDbType.VarChar,200),
					new SqlParameter("@CommodityID", SqlDbType.VarChar,4000),
					new SqlParameter("@beizhu", SqlDbType.VarChar,4000),
					new SqlParameter("@By1", SqlDbType.Decimal,9),
					new SqlParameter("@By2", SqlDbType.Decimal,9),
					new SqlParameter("@By3", SqlDbType.Decimal,9),
					new SqlParameter("@By4", SqlDbType.VarChar,4000),
					new SqlParameter("@By5", SqlDbType.VarChar,4000),
					new SqlParameter("@By6", SqlDbType.VarChar,4000),
					new SqlParameter("@By7", SqlDbType.VarChar,4000)};
			parameters[0].Value = model.OrderNumber;
			parameters[1].Value = model.CommodityID;
			parameters[2].Value = model.beizhu;
			parameters[3].Value = model.By1;
			parameters[4].Value = model.By2;
			parameters[5].Value = model.By3;
			parameters[6].Value = model.By4;
			parameters[7].Value = model.By5;
			parameters[8].Value = model.By6;
			parameters[9].Value = model.By7;

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
		public bool Update(Maticsoft.Model.ContractTab model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ContractTab set ");
			strSql.Append("OrderNumber=@OrderNumber,");
			strSql.Append("CommodityID=@CommodityID,");
			strSql.Append("beizhu=@beizhu,");
			strSql.Append("By1=@By1,");
			strSql.Append("By2=@By2,");
			strSql.Append("By3=@By3,");
			strSql.Append("By4=@By4,");
			strSql.Append("By5=@By5,");
			strSql.Append("By6=@By6,");
			strSql.Append("By7=@By7");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@OrderNumber", SqlDbType.VarChar,200),
					new SqlParameter("@CommodityID", SqlDbType.VarChar,4000),
					new SqlParameter("@beizhu", SqlDbType.VarChar,4000),
					new SqlParameter("@By1", SqlDbType.Decimal,9),
					new SqlParameter("@By2", SqlDbType.Decimal,9),
					new SqlParameter("@By3", SqlDbType.Decimal,9),
					new SqlParameter("@By4", SqlDbType.VarChar,4000),
					new SqlParameter("@By5", SqlDbType.VarChar,4000),
					new SqlParameter("@By6", SqlDbType.VarChar,4000),
					new SqlParameter("@By7", SqlDbType.VarChar,4000),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.OrderNumber;
			parameters[1].Value = model.CommodityID;
			parameters[2].Value = model.beizhu;
			parameters[3].Value = model.By1;
			parameters[4].Value = model.By2;
			parameters[5].Value = model.By3;
			parameters[6].Value = model.By4;
			parameters[7].Value = model.By5;
			parameters[8].Value = model.By6;
			parameters[9].Value = model.By7;
			parameters[10].Value = model.id;

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
			strSql.Append("delete from ContractTab ");
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
			strSql.Append("delete from ContractTab ");
			strSql.Append(" where "+idlist);
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
		public Maticsoft.Model.ContractTab GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,OrderNumber,CommodityID,beizhu,By1,By2,By3,By4,By5,By6,By7 from ContractTab ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.ContractTab model=new Maticsoft.Model.ContractTab();
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
		public Maticsoft.Model.ContractTab DataRowToModel(DataRow row)
		{
			Maticsoft.Model.ContractTab model=new Maticsoft.Model.ContractTab();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["OrderNumber"]!=null)
				{
					model.OrderNumber=row["OrderNumber"].ToString();
				}
				if(row["CommodityID"]!=null)
				{
					model.CommodityID=row["CommodityID"].ToString();
				}
				if(row["beizhu"]!=null)
				{
					model.beizhu=row["beizhu"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,OrderNumber,CommodityID,beizhu,By1,By2,By3,By4,By5,By6,By7 ");
			strSql.Append(" FROM ContractTab ");
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
			strSql.Append(" id,OrderNumber,CommodityID,beizhu,By1,By2,By3,By4,By5,By6,By7 ");
			strSql.Append(" FROM ContractTab ");
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
			strSql.Append("select count(1) FROM ContractTab ");
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
			strSql.Append(")AS Row, T.*  from ContractTab T ");
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
			parameters[0].Value = "ContractTab";
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

