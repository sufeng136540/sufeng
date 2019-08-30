using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Permissionstab
	/// </summary>
	public partial class Permissionstab
	{
		public Permissionstab()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Permissionstab"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Permissionstab");
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
		public int Add(Maticsoft.Model.Permissionstab model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Permissionstab(");
			strSql.Append("Operatorid,Look,Audit,beizhu,by1,by2,by3,by4,by5,by6,by7)");
			strSql.Append(" values (");
			strSql.Append("@Operatorid,@Look,@Audit,@beizhu,@by1,@by2,@by3,@by4,@by5,@by6,@by7)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Operatorid", SqlDbType.Int,4),
					new SqlParameter("@Look", SqlDbType.Int,4),
					new SqlParameter("@Audit", SqlDbType.Int,4),
					new SqlParameter("@beizhu", SqlDbType.VarChar,4000),
					new SqlParameter("@by1", SqlDbType.Decimal,9),
					new SqlParameter("@by2", SqlDbType.Decimal,9),
					new SqlParameter("@by3", SqlDbType.Decimal,9),
					new SqlParameter("@by4", SqlDbType.VarChar,4000),
					new SqlParameter("@by5", SqlDbType.VarChar,4000),
					new SqlParameter("@by6", SqlDbType.VarChar,4000),
					new SqlParameter("@by7", SqlDbType.VarChar,4000)};
			parameters[0].Value = model.Operatorid;
			parameters[1].Value = model.Look;
			parameters[2].Value = model.Audit;
			parameters[3].Value = model.beizhu;
			parameters[4].Value = model.by1;
			parameters[5].Value = model.by2;
			parameters[6].Value = model.by3;
			parameters[7].Value = model.by4;
			parameters[8].Value = model.by5;
			parameters[9].Value = model.by6;
			parameters[10].Value = model.by7;

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
		public bool Update(Maticsoft.Model.Permissionstab model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Permissionstab set ");
			strSql.Append("Operatorid=@Operatorid,");
			strSql.Append("Look=@Look,");
			strSql.Append("Audit=@Audit,");
			strSql.Append("beizhu=@beizhu,");
			strSql.Append("by1=@by1,");
			strSql.Append("by2=@by2,");
			strSql.Append("by3=@by3,");
			strSql.Append("by4=@by4,");
			strSql.Append("by5=@by5,");
			strSql.Append("by6=@by6,");
			strSql.Append("by7=@by7");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@Operatorid", SqlDbType.Int,4),
					new SqlParameter("@Look", SqlDbType.Int,4),
					new SqlParameter("@Audit", SqlDbType.Int,4),
					new SqlParameter("@beizhu", SqlDbType.VarChar,4000),
					new SqlParameter("@by1", SqlDbType.Decimal,9),
					new SqlParameter("@by2", SqlDbType.Decimal,9),
					new SqlParameter("@by3", SqlDbType.Decimal,9),
					new SqlParameter("@by4", SqlDbType.VarChar,4000),
					new SqlParameter("@by5", SqlDbType.VarChar,4000),
					new SqlParameter("@by6", SqlDbType.VarChar,4000),
					new SqlParameter("@by7", SqlDbType.VarChar,4000),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.Operatorid;
			parameters[1].Value = model.Look;
			parameters[2].Value = model.Audit;
			parameters[3].Value = model.beizhu;
			parameters[4].Value = model.by1;
			parameters[5].Value = model.by2;
			parameters[6].Value = model.by3;
			parameters[7].Value = model.by4;
			parameters[8].Value = model.by5;
			parameters[9].Value = model.by6;
			parameters[10].Value = model.by7;
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
			strSql.Append("delete from Permissionstab ");
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
			strSql.Append("delete from Permissionstab ");
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
		public Maticsoft.Model.Permissionstab GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,Operatorid,Look,Audit,beizhu,by1,by2,by3,by4,by5,by6,by7 from Permissionstab ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.Permissionstab model=new Maticsoft.Model.Permissionstab();
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
		public Maticsoft.Model.Permissionstab DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Permissionstab model=new Maticsoft.Model.Permissionstab();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["Operatorid"]!=null && row["Operatorid"].ToString()!="")
				{
					model.Operatorid=int.Parse(row["Operatorid"].ToString());
				}
				if(row["Look"]!=null && row["Look"].ToString()!="")
				{
					model.Look=int.Parse(row["Look"].ToString());
				}
				if(row["Audit"]!=null && row["Audit"].ToString()!="")
				{
					model.Audit=int.Parse(row["Audit"].ToString());
				}
				if(row["beizhu"]!=null)
				{
					model.beizhu=row["beizhu"].ToString();
				}
				if(row["by1"]!=null && row["by1"].ToString()!="")
				{
					model.by1=decimal.Parse(row["by1"].ToString());
				}
				if(row["by2"]!=null && row["by2"].ToString()!="")
				{
					model.by2=decimal.Parse(row["by2"].ToString());
				}
				if(row["by3"]!=null && row["by3"].ToString()!="")
				{
					model.by3=decimal.Parse(row["by3"].ToString());
				}
				if(row["by4"]!=null)
				{
					model.by4=row["by4"].ToString();
				}
				if(row["by5"]!=null)
				{
					model.by5=row["by5"].ToString();
				}
				if(row["by6"]!=null)
				{
					model.by6=row["by6"].ToString();
				}
				if(row["by7"]!=null)
				{
					model.by7=row["by7"].ToString();
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
			strSql.Append("select id,Operatorid,Look,Audit,beizhu,by1,by2,by3,by4,by5,by6,by7 ");
			strSql.Append(" FROM Permissionstab ");
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
			strSql.Append(" id,Operatorid,Look,Audit,beizhu,by1,by2,by3,by4,by5,by6,by7 ");
			strSql.Append(" FROM Permissionstab ");
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
			strSql.Append("select count(1) FROM Permissionstab ");
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
			strSql.Append(")AS Row, T.*  from Permissionstab T ");
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
			parameters[0].Value = "Permissionstab";
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

