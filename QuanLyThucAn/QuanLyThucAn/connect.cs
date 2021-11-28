using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid;

namespace QuanLyThucAn
{
    public class connect
    {
        public MySqlConnection connect_db()
        {
            MySqlConnection conn_term = new MySqlConnection(
             "Server=26.9.216.208;Database=db_NhaHang;User Id=admin;password=");
            return conn_term;
        }
        MySqlCommand cmd;
        MySqlDataAdapter da;
        // hihi haha

        public bool E_DaTa(string cmd_text)
        {
            bool check = false;
            MySqlConnection conn = connect_db();
            conn.Open();
            try
            {
                cmd = new MySqlCommand(cmd_text, conn);
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

            conn.Close();
            return check;
        }

        public void LoadDT (GridControl gridControl,string cmd)
        {
            DataTable dt = ex_data(cmd);
            //if (dt != null)
            //{
                gridControl.DataSource = dt;
            //}
        }


        public void ex_cmd(string cmd_text)
        {
            MySqlConnection conn = connect_db();
            conn.Open();
            try
            {
                cmd = new MySqlCommand(cmd_text, connect_db());
                cmd.ExecuteNonQuery();     
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
             
            conn.Close();
            
        }

        public DataTable ex_data(string cmd_text)
        {
            MySqlConnection conn = connect_db();
            DataTable dt = new DataTable();
            conn.Open();
            da = new MySqlDataAdapter(cmd_text, conn);
            da.Fill(dt);
            return dt;
        }
        public string ex_data_string(string cmd_text)
        {
            MySqlConnection conn = connect_db();
            conn.Open();
            cmd = new MySqlCommand(cmd_text, connect_db());
            return cmd.ExecuteScalar().ToString();
        }

        public string creatId(string preFix, string sql)
        {
            string id = "";
            int countRow = -1;
            bool check = false; //Kiem tra ID khong dung thu tu: Flase
            DataTable dt = ex_data(sql);
            countRow = dt.Rows.Count; //Dem so luong ban ghi co trong bang         
            if (countRow > 0) //Co nhieu hơn 1 ban ghi thi moi kiem tra
            {
                int count = 1; //ID ao chay song song voi ID trong bang
                foreach (DataRow row in dt.Rows) //Duyet cac dong trong bang
                {
                    string idRow = row[0].ToString(); //Lay chuoi chua ID
                    int i = Int32.Parse(idRow.Substring(idRow.Length - 8, 8)); //Cat chuoi lay ID
                    if (i != count) //Sai thu tu
                    {
                        count = i - 1; //Gan ID ao bang ID that -1
                        check = true; //Check sai thu tu
                        break;
                    }
                    else
                    {
                        count++; //Khong sai thu tu
                    }
                }
                if (check) //Gan ID bị thieu cho ID duoc creat
                {
                    countRow = count;
                }
            }
            if (!check) //Neu khong co ID sai thu tu thi tang len 1 như binh thuong
            {
                countRow += 1;
            }
            if (countRow < 10)
            {
                id = preFix + "0000000" + countRow; //U00009
            }
            else if (countRow < 100)
            {
                id = preFix + "000000" + countRow; //U00999
            }
            else if (countRow < 10000)
            {
                id = preFix + "00000" + countRow; //U09999
            }
            else if (countRow < 100000)
            {
                id = preFix + "0000" + countRow; //U09999
            }
            else if (countRow < 1000000)
            {
                id = preFix + "000" + countRow; //U09999
            }
            else if (countRow < 10000000)
            {
                id = preFix + "00" + countRow; //U09999
            }
            else if (countRow < 100000000)
            {
                id = preFix + "0" + countRow; //U09999
            }
            else if (countRow < 1000000000)
            {
                id = preFix + countRow; //U99999
            }
            return id;
        }

        //check email
        public static bool CheckEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        //chek sdt
        public static bool checkSDT(string sdt)
        {
            int lenght;
            lenght = sdt.Length;
            if (lenght == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //check cùng tên trong bảg

        public string CreateMD5(string str)
        {
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(str);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }


        public void  ThongBaoTC(string chuoi, TextEdit text)
        {
            XtraMessageBox.Show(chuoi + text.EditValue.ToString() + " thành công", "Thông báo");
        }
        public void ThongBaoTB(string chuoi, TextEdit text)
        {
            XtraMessageBox.Show(chuoi + text.EditValue.ToString() + " thất bại", "Thông báo");
        }
    }
}
