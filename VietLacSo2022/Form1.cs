using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VietLacSo2022
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            dangKy1.Visible = false;
           
        }

        public static string sodienthoai2 = "";
        public static string matkhau2 = "";
        public string SoDienThoai
        {
            get => sodienthoai2;
            set => sodienthoai2 = value;

        }
        public string Matkhau
        {
            get => matkhau2;
            set => matkhau2 = value;

        }
        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
           

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textEdit2.Properties.PasswordChar = '*';
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {
            dangKy1.Visible = true;
            dangKy1.BringToFront();
        }

        private void dangKy1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            bool accept= true;
            string connectionstring = "Data Source=ADMIN;Initial Catalog=LacVietSo;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = @"select * from nguoidung";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                if(textEdit1.Text== r["sodienthoai"].ToString() && textEdit2.Text == r["matkhau"].ToString())
                {
                    accept = true;
                }
              
               
            }
            if (accept == true)
            {
                Screen sc = new Screen();
                sc.Show();
                this.Opacity = 0;
                this.ShowInTaskbar = false;
            }
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dangKy1.Visible = true;
            dangKy1.BringToFront();
        }

        private void dangKy1_Validating(object sender, CancelEventArgs e)
        {

        }
        
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            sodienthoai2 = textEdit1.Text;
        }

        private void textEdit2_TextChanged(object sender, EventArgs e)
        {
            matkhau2 = textEdit2.Text;
        }
    }
}
