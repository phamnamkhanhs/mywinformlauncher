using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietLacSo2022
{
    public partial class HoTro : DevExpress.XtraEditors.XtraUserControl
    {
        public HoTro()
        {
            InitializeComponent();
           
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MyMessageBox2 newms2 = new MyMessageBox2();
            newms2.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Chat c = new Chat();
            // c.StartPosition = FormStartPosition.Manual;
            

            c.Show();

        }
    }
}
