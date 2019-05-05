//using System;
//using MySql.Data.MySqlClient;
//缺少了一步操作，添加


//namespace MySQL数据库操作
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // 数据库配置
//            string connStr = "Database=user;datasource=127.0.0.1;port=3306;user=root;pwd=123456;";
//            MySqlConnection conn = new MySqlConnection(connStr);

//            conn.Open();

//            #region 查询
//            //// 查询user表中所有条目
//            MySqlCommand cmd = new MySqlCommand("select * from user", conn);
//            //
//            MySqlDataReader reader = cmd.ExecuteReader();
//            //
//            // // 逐行读取数据
//            while (reader.Read()) {
//                string username = reader.GetString("username");
//                string password = reader.GetString("password");
//                Console.WriteLine(username + ":" + password);
//            }
//            //
//            reader.Close();
//            #endregion

//            #region 插入
//            //正常插入一条数据
//            // int username = 123456;int password = 6666;
//            // MySqlCommand cmd = new MySqlCommand("insert into user set username ='" + username + "'" + ",password='" + password + "'", conn);
//            // cmd.ExecuteNonQuery();

//            // // sql 注入，会删除数据库
//            // int username = 23456; int password = 66666; delete from user;";
//            // MySqlCommand cmd = new MySqlCommand("insert into user set username ='" + username + "'" + ",password='" + password + "'", conn);
//            // cmd.ExecuteNonQuery();

//            // // 防止注入,不会执行删除数据库语句
//            // string username = "lj"; string password = "6666'; delete from user;";
//            // MySqlCommand cmd = new MySqlCommand("insert into user set username=@uid , password = @pwd", conn);
//            // cmd.Parameters.AddWithValue("uid", username);
//            // cmd.Parameters.AddWithValue("pwd", password);
//            // cmd.ExecuteNonQuery();
//            #endregion

//            #region 删除
//            //删除 id 为 6 的条目
//            // MySqlCommand cmd = new MySqlCommand("delete from user where id = @id", conn);
//            // cmd.Parameters.AddWithValue("id", 2);
//            //  
//            //  cmd.ExecuteNonQuery();
//            #endregion

//            #region 更新
//            // 将 id 为 7 的条目 pwd 修改为 lll
//            //   MySqlCommand cmd = new MySqlCommand("update user set password = 3333 where id = 2", conn);
//            //   cmd.Parameters.AddWithValue("654321", "3333");

//            //    cmd.ExecuteNonQuery();
//            #endregion

//            conn.Close();

//            Console.ReadKey();
//        }
//    }
//}