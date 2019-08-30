using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Homemadetab
	/// </summary>
	public partial class Homemadetab
	{
		public Homemadetab()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Homemadetab"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Homemadetab");
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
		public int Add(Maticsoft.Model.Homemadetab model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Homemadetab(");
			strSql.Append("Name,Photourl,Comment,Beizhu,BY1,BY2,BY3,BY4,BY5,BY6,BY7)");
			strSql.Append(" values (");
			strSql.Append("@Name,@Photourl,@Comment,@Beizhu,@BY1,@BY2,@BY3,@BY4,@BY5,@BY6,@BY7)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,200),
					new SqlParameter("@Photourl", SqlDbType.VarChar,4000),
					new SqlParameter("@Comment", SqlDbType.VarChar,4000),
					new SqlParameter("@Beizhu", SqlDbType.VarChar,4000),
					new SqlParameter("@BY1", SqlDbType.Decimal,9),
					new SqlParameter("@BY2", SqlDbType.Decimal,9),
					new SqlParameter("@BY3", SqlDbType.Decimal,9),
					new SqlParameter("@BY4", SqlDbType.VarBinary,4000),
					new SqlParameter("@BY5", SqlDbType.VarBinary,4000),
					new SqlParameter("@BY6", SqlDbType.VarBinary,4000),
					new SqlParameter("@BY7", SqlDbType.VarBinary,4000)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.Photourl;
			parameters[2].Value = model.Comment;
			parameters[3].Value = model.Beizhu;
			parameters[4].Value = model.BY1;
			parameters[5].Value = model.BY2;
			parameters[6].Value = model.BY3;
			parameters[7].Value = model.BY4;
			parameters[8].Value = model.BY5;
			parameters[9].Value = model.BY6;
			parameters[10].Value = model.BY7;

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
		public bool Update(Maticsoft.Model.Homemadetab model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Homemadetab set ");
			strSql.Append("Name=@Name,");
			strSql.Append("Photourl=@Photourl,");
			strSql.Append("Comment=@Comment,");
			strSql.Append("Beizhu=@Beizhu,");
			strSql.Append("BY1=@BY1,");
			strSql.Append("BY2=@BY2,");
			strSql.Append("BY3=@BY3,");
			strSql.Append("BY4=@BY4,");
			strSql.Append("BY5=@BY5,");
			strSql.Append("BY6=@BY6,");
			strSql.Append("BY7=@BY7");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,200),
					new SqlParameter("@Photourl", SqlDbType.VarChar,4000),
					new SqlParameter("@Comment", SqlDbType.VarChar,4000),
					new SqlParameter("@Beizhu", SqlDbType.VarChar,4000),
					new SqlParameter("@BY1", SqlDbType.Decimal,9),
					new SqlParameter("@BY2", SqlDbType.Decimal,9),
					new SqlParameter("@BY3", SqlDbType.Decimal,9),
					new SqlParameter("@BY4", SqlDbType.VarBinary,4000),
					new SqlParameter("@BY5", SqlDbType.VarBinary,4000),
					new SqlParameter("@BY6", SqlDbType.VarBinary,4000),
					new SqlParameter("@BY7", SqlDbType.VarBinary,4000),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.Photourl;
			parameters[2].Value = model.Comment;
			parameters[3].Value = model.Beizhu;
			parameters[4].Value = model.BY1;
			parameters[5].Value = model.BY2;
			parameters[6].Value = model.BY3;
			parameters[7].Value = model.BY4;
			parameters[8].Value = model.BY5;
			parameters[9].Value = model.BY6;
			parameters[10].Value = model.BY7;
			parameters[11].Value = model.id;

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
			strSql.Append("delete from Homemadetab ");
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
			strSql.Append("delete from Homemadetab ");
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
		public Maticsoft.Model.Homemadetab GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,Name,Photourl,Comment,Beizhu,BY1,BY2,BY3,BY4,BY5,BY6,BY7 from Homemadetab ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.Homemadetab model=new Maticsoft.Model.Homemadetab();
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
		public Maticsoft.Model.Homemadetab DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Homemadetab model=new Maticsoft.Model.Homemadetab();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Photourl"]!=null)
				{
					model.Photourl=row["Photourl"].ToString();
				}
				if(row["Comment"]!=null)
				{
					model.Comment=row["Comment"].ToString();
				}
				if(row["Beizhu"]!=null)
				{
					model.Beizhu=row["Beizhu"].ToString();
				}
				if(row["BY1"]!=null && row["BY1"].ToString()!="")
				{
					model.BY1=decimal.Parse(row["BY1"].ToString());
				}
				if(row["BY2"]!=null && row["BY2"].ToString()!="")
				{
					model.BY2=decimal.Parse(row["BY2"].ToString());
				}
				if(row["BY3"]!=null && row["BY3"].ToString()!="")
				{
					model.BY3=decimal.Parse(row["BY3"].ToString());
				}
				if(row["BY4"]!=null && row["BY4"].ToString()!="")
				{
					model.BY4=(byte[])row["BY4"];
				}
				if(row["BY5"]!=null && row["BY5"].ToString()!="")
				{
					model.BY5=(byte[])row["BY5"];
				}
				if(row["BY6"]!=null && row["BY6"].ToString()!="")
				{
					model.BY6=(byte[])row["BY6"];
				}
				if(row["BY7"]!=null && row["BY7"].ToString()!="")
				{
					model.BY7=(byte[])row["BY7"];
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
			strSql.Append("select id,Name,Photourl,Comment,Beizhu,BY1,BY2,BY3,BY4,BY5,BY6,BY7 ");
			strSql.Append(" FROM Homemadetab ");
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
			strSql.Append(" id,Name,Photourl,Comment,Beizhu,BY1,BY2,BY3,BY4,BY5,BY6,BY7 ");
			strSql.Append(" FROM Homemadetab ");
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
			strSql.Append("select count(1) FROM Homemadetab ");
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
			strSql.Append(")AS Row, T.*  from Homemadetab T ");
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
			parameters[0].Value = "Homemadetab";
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

