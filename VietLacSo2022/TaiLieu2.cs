using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietLacSo2022
{
    public partial class TaiLieu2 : DevExpress.XtraEditors.XtraUserControl
    {
        public TaiLieu2()
        {
            InitializeComponent();
        }

        private void TaiLieu2_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=ADMIN;Initial Catalog=LacVietSo;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = @"select * from videophanmem, phanmem where phanmem.tenphanmem=N'" + TaiLieu.newac + "'" +"and phanmem.idphanmem = videophanmem.idphanmem";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                labelControl1.Text = r["tenvideo"].ToString();
                //string filename = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().FullName), r["huongdanvideo"].ToString());
                axWindowsMediaPlayer1.URL = r["huongdanvideo"].ToString();
                axWindowsMediaPlayer1.settings.autoStart = false;

            }
          
        }
    }
}
