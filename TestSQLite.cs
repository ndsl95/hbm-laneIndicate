using System;
using System.Data.SQLite;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("开始测试 SQLite 数据库连接...");
        Console.WriteLine("数据库路径：D:\\Equipment.db");
        
        try
        {
            string connectionString = "Data Source=D:\\Equipment.db;Version=3;";
            Console.WriteLine($"连接字符串：{connectionString}");
            
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                Console.WriteLine("正在打开连接...");
                conn.Open();
                Console.WriteLine("连接状态：" + conn.State);
                
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("✓ 数据库连接成功！");
                    
                    string sql = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine("\n数据库中的表：");
                            while (reader.Read())
                            {
                                Console.WriteLine("  - " + reader[0].ToString());
                            }
                        }
                    }
                    
                    Console.WriteLine("\n尝试查询 Equipment 表...");
                    string equipmentSql = "SELECT * FROM Equipment LIMIT 5;";
                    using (SQLiteCommand cmd = new SQLiteCommand(equipmentSql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Console.WriteLine("✓ Equipment 表存在且有数据");
                                Console.WriteLine("前 5 行数据：");
                                while (reader.Read())
                                {
                                    Console.Write("  ");
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        Console.Write(reader[i].ToString() + " | ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("⚠ Equipment 表为空");
                            }
                        }
                    }
                }
                
                conn.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("\n✗ 连接失败！");
            Console.WriteLine("错误消息：" + ex.Message);
            Console.WriteLine("详细错误：" + ex.ToString());
        }
        
        Console.WriteLine("\n按任意键退出...");
        Console.ReadKey();
    }
}
