using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace dbcommfc7
{
    public class SQLiteHelper
    {
        private string connectionString;

        public SQLiteHelper(string dbPath)
        {
            connectionString = $"Data Source={dbPath};Version=3;";
        }

        public DataTable ExecuteQuery(string sql)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"查询执行失败：{ex.Message}");
            }
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"非查询执行失败：{ex.Message}");
            }
        }

        public object ExecuteScalar(string sql)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"标量查询失败：{ex.Message}");
            }
        }

        public List<string> GetTableNames()
        {
            try
            {
                string sql = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";
                DataTable dt = ExecuteQuery(sql);
                List<string> tableNames = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    tableNames.Add(row[0].ToString());
                }
                return tableNames;
            }
            catch (Exception ex)
            {
                throw new Exception($"获取表名失败：{ex.Message}");
            }
        }

        public DataTable GetTableSchema(string tableName)
        {
            try
            {
                string sql = $"PRAGMA table_info({tableName});";
                return ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"获取表结构失败：{ex.Message}");
            }
        }

        public bool TestConnection()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    return conn.State == ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"数据库连接测试失败：{ex.Message}\r\n连接字符串：{connectionString}\r\n详细错误：{ex.ToString()}");
            }
        }
    }
}
