using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;


namespace QLKHOVATLIEU.Class
{
    public static  class Csdl_sys
    {
        public static SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection(
               @"Data Source=DESKTOP-JLQ0MT8\SQLEXPRESS;Initial Catalog=QuanLyKhoVatLieu;Integrated Security=True");// -- > chuỗi connect sql
            return conn;
        }
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        // ex dữ liệu
        public static DataTable ex_data(string str) // -> str là câu lệnh laf 
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = connect())
            {
                da = new SqlDataAdapter(str, conn);
                da.Fill(dt);
                return dt;
            }
        }
         public static  bool check_val(string str)
        {
            SqlConnection conn = connect();
            conn.Open();
            cmd = new SqlCommand(str, conn);
            if(cmd.ExecuteScalar() != null  )
            {
                return true;
            }
            return false;
        }
       public static string Creater_id(string table , string column , string id)
        {
            int i = 1;
            while( 1 + 1 == 2)
            {
                string term = id+i.ToString();
                if (check_val(string.Format("select * from {0} where {1} = '{2}'",table,column,(id+i).ToString())) == true)
                {
                    i++;
                }
                else
                {
                    return term;
                }
            }
           // return "";
        }
        public static string ex_data_tring(string str)
        {
            SqlConnection conn = connect();
            conn.Open();
            cmd = new SqlCommand(str, conn);
            return cmd.ExecuteScalar().ToString();
        }
        public static void ex_cmd(string str)
        {
            SqlConnection conn = connect();
            conn.Open();
            cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        // checlk gannd admin
        public static bool check_admin(string id)
        {
            if(ex_data_tring(string.Format("select nhanvien from taikhoan where matk = '{0}'", id)) == "0")
            {
                return true;
            }return false;
        }
    }
}
