using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VietLacSo2022.Form1;
namespace VietLacSo2022
{
    public partial class DangKy : DevExpress.XtraEditors.XtraUserControl
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            panelControl1.BackColor = Color.Transparent;
            panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            textEdit4.Properties.PasswordChar = '*';
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool accept = true;
           // Regex phoneNumpattern = new Regex(@"\+[0-9]{3}\s+[0-9]{3}\s+[0-9]{5}\s+[0-9]{3}");
            if (string.IsNullOrWhiteSpace(textEdit1.Text))
            {

                MessageBox.Show("Tên không được để trống");
                accept = false;
            }
            else if (string.IsNullOrWhiteSpace(textEdit2.Text))
            {

                MessageBox.Show("Số điện thoại không được để trống");
                accept = false;
            }
            else if (string.IsNullOrWhiteSpace(textEdit3.Text))
            {

                MessageBox.Show("Địa chỉ không được để trống");
                accept = false;
            }
            else if (string.IsNullOrWhiteSpace(textEdit4.Text))
            {

                MessageBox.Show("Mật khẩu không được để trống");
                accept = false;
            }


           // else if (!phoneNumpattern.IsMatch(textEdit2.Text))

            
                try
                {
                    string connectionstring = "Data Source=ADMIN;Initial Catalog=LacVietSo;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connectionstring);
                    conn.Open();
                    string query = @"insert into nguoidung(hoten,sodienthoai,diachi,matkhau) VALUES (@hoten,@sodienthoai, @diachi, @matkhau) ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@hoten", textEdit1.Text);
                    cmd.Parameters.AddWithValue("@sodienthoai", textEdit2.Text);
                    cmd.Parameters.AddWithValue("@diachi", textEdit3.Text);
                    cmd.Parameters.AddWithValue("@matkhau", textEdit4.Text);
                    cmd.ExecuteNonQuery();
                    this.Hide();

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            
        }

        private void textEdit1_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
