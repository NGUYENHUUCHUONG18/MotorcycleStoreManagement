﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DemoDoAn
{
    class DatabaseService
    {
        static SqlConnection cnn;
        static SqlDataAdapter da;
        static DataSet ds;
        static SqlCommand cmd;
        static string source;

        public static void openConnection()
        {
            source = @"Data Source=" + "ADMINISTRATOR\\SQLEXPRESS" + ";Initial Catalog=QL_CuaHangXeMay;Integrated Security=True;";
            cnn = new SqlConnection(source);
            try
            {
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến CSDL!\nVui lòng kiểm tra lại SQL Server.", "Lỗi");
                return;
            }
        }

        public static void executeQuery(String sql)
        {
            cmd = new SqlCommand();
            openConnection();
            try
            {
                cmd.Connection = cnn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Không thể thực thi câu lệnh này!\nVui lòng kiểm tra lại dữ liệu vào.", "Lỗi");
                return;
            }

        }

        public static DataSet getDataSet(String sql)
        {

            openConnection();
            da = new SqlDataAdapter(sql, cnn);
            ds = new DataSet();
            da.Fill(ds);
            cnn.Close();
            return ds;
        }

        public static DataTable getDataTable(String sql)
        {
            openConnection();
            da = new SqlDataAdapter(sql, cnn);
            ds = new DataSet();
            da.Fill(ds);
            cnn.Close();
            return ds.Tables[0];
        }
    }
}
