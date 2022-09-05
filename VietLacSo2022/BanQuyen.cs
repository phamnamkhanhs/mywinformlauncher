using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietLacSo2022
{
    public partial class BanQuyen : DevExpress.XtraEditors.XtraUserControl
    {
        public BanQuyen()
        {
            InitializeComponent();
        }
        

        private void BanQuyen_Load(object sender, EventArgs e)
        {
            

            try
            {
                string connectionstring = "Data Source=ADMIN;Initial Catalog=LacVietSo;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                string query = @"select id, tenphanmem, anhphanmem, tinhtrang, key_khoa from phanmem";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader r = cmd.ExecuteReader();
                int x = 0, y = 0;
                while (r.Read())
                {
                    int id = Convert.ToInt32(r["id"]); ;
                    string tenphanmem = r["tenphanmem"].ToString();
                    Image anhphanmem = Image.FromFile(r["anhphanmem"].ToString());
                    string tinhtrang = r["tinhtrang"].ToString();
                    string key_khoa = r["key_khoa"].ToString();
                    BanQuyen_2 obj = new BanQuyen_2(id, tenphanmem, anhphanmem, tinhtrang, key_khoa);

                    tableLayoutPanel2.Controls.Add(obj, y, x);

                    y++;
                    if (y >=1)
                    {
                        y = 0;
                        x++;
                    }

                }
                r.Close();
                //cmd.Clone();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            panelControl1.BackColor = Color.FromArgb(241, 243, 250);
            panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl2.BackColor = Color.White;
            panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
           
               
        }

        private void simpleButton1_Paint(object sender, PaintEventArgs e)
        {
           // base.simpleButton1_Paint(sender,e);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MyMessageBox2 newms2 = new MyMessageBox2();
            newms2.Show();
        }
    }
}
