using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_chi_tieu_sinh_vien
{
    internal class DatabaseProcessing
    {
        //kết nối sql
        private string connectString = @"Data Source=LAPTOP-Q2F68TEG\SQLEXPRESS;Database=QuanLyChiTieuSV;Integrated Security=true";
        private SqlConnection conn = null;

        private void OpenConnect()
        {
            conn = new SqlConnection(connectString);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        //đóng kết nối
        private void CloseConnect()
        {
            if (conn != null && conn.State != ConnectionState.Closed)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }

        }

        private void DatabaseProcessing_Load(object sender, EventArgs e)
        {
            // load-time logic (if any)
        }

        //Phương thức thực hiện lênh select trả về DataTable
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            using (System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(sqlSelect, conn))
            {
                adapter.Fill(dt);
            }
            CloseConnect();
            return dt;
        }

       
        public DataTable ReadData(System.Data.SqlClient.SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            cmd.Connection = conn;
            using (System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd))
            {
                adapter.Fill(dt);
            }
            CloseConnect();
            return dt;
        }

        //Phương thức thực thi lệnh insert, update hoặc delete
        public void ChangeData(string sql)
        {
            OpenConnect();
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.Connection = conn;
            sqlcomm.CommandText = sql;
            sqlcomm.ExecuteNonQuery();
            CloseConnect();
        }
    }
}
