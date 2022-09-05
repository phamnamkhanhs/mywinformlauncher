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
    public partial class CongDong : DevExpress.XtraEditors.XtraUserControl
    {
        public CongDong()
        {
            InitializeComponent();
        }

        private void CongDong_Load(object sender, EventArgs e)
        {
            panelControl1.BackColor = Color.White;
            panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl2.BackColor = Color.White;
            panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl3.BackColor = Color.FromArgb(241, 243, 250);
            panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl4.BackColor = Color.FromArgb(241, 243, 250);
            panelControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl6.BackColor = Color.FromArgb(241, 243, 250);
            panelControl6.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl6.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl7.BackColor = Color.White;
            panelControl7.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl7.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl8.BackColor = Color.White;
            panelControl8.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl8.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl9.BackColor = Color.White;
            panelControl9.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl9.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl10.BackColor = Color.White;
            panelControl10.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl10.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            panelControl15.BackColor = Color.White;
            panelControl15.LookAndFeel.UseDefaultLookAndFeel = false;
            panelControl15.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            MyMessageBox2 newms2 = new MyMessageBox2();
            newms2.Show();
        }
    }
}
