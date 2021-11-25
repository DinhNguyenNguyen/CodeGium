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

namespace QuanLyThucAn
{
    public class connect
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DBNhaHang;Integrated Security=True");

        private void openConnect()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void closeConnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        //ExecuteData: Them sua xoa du lieu
        public Boolean exeData(string cmd)
        {
            openConnect();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeConnect();
            return check;
        }
        //
        public void Ex_vp(string str)
        {
            openConnect();
            try
            {
                SqlCommand sc = new SqlCommand(str, con);
                sc.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            closeConnect();

        }

        //ReadData: Doc du lieu tu bang ra DataTable
        public DataTable readData(string cmd)
        {
            openConnect();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter da = new SqlDataAdapter(sc);
                da.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            closeConnect();
            return dt;
        }

        //CreatID: tao ID moi theo tien to(preFix)
        public string creatId(string preFix, string sql)
        {
            string id = "";
            int countRow = -1;
            bool check = false; //Kiem tra ID khong dung thu tu: Flase
            DataTable dt = readData(sql);
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
        public  bool CheckEmail(string inputEmail)
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
        public  bool checkSDT(string sdt)
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
        public  bool checkName(string query, TextEdit textEdit, string column)
        {
            bool checkName = false;
            //connection con = new connection();
            DataTable dt = new DataTable();
            dt = readData(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (textEdit.EditValue.ToString().Trim().Equals(dr[column].ToString()))
                    {
                        checkName = true;
                        // return true;
                        break;
                    }
                }
            }
            return checkName;
        }

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


    }
}
