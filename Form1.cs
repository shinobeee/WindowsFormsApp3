using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txttdn.Text=="admin"&& txtmk.Text=="123")
            {
                FrmMain frmMain = new FrmMain ();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("sai tên đăng nhập hoặc mật khẩu", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
