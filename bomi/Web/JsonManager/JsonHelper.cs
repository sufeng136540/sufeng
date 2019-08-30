using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Maticsoft.DBUtility
{
    public class JsonHelper
    {
        public static string DataSetToJson(DataTable dt)
        {
            string json = string.Empty;
            try
            {
                if (dt == null || dt.Rows.Count == 0)
                {
                    return "";
                }
                json = "{";
                json += "\"table" + 1 + "\":[";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    json += "{";
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        json += "\"" + dt.Columns[j].ColumnName + "\":\"" + dt.Rows[i][j].ToString() + "\"";
                        if (j != dt.Columns.Count - 1)
                        {
                            json += ",";
                        }
                    }
                    json += "}";
                    if (i != dt.Rows.Count - 1)
                    {
                        json += ",";
                    }
                }
                json += "]";
                json += "}";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return json;
        }
        public static string shenhezhuanhuan(DataTable dt,int a)
        {
            string json = string.Empty;
            try
            {
                if (dt == null || dt.Rows.Count == 0)
                {
                    return "";
                }
                json = "{";
                json += "\"table" + a + "\":[";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    json += "{";
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        json += "\"" + dt.Columns[j].ColumnName + "\":\"" + dt.Rows[i][j].ToString() + "\"";
                        if (j != dt.Columns.Count - 1)
                        {
                            json += ",";
                        }
                    }
                    json += "}";
                    if (i != dt.Rows.Count - 1)
                    {
                        json += ",";
                    }
                }
                json += "]";
                json += "}";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return json;
        }
    }
}
