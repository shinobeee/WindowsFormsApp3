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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lsb1.Items.Clear();
            int so = Convert.ToInt32(lsb1.Text);
            for(int i = 1;i<= so;i++)
            {
                if(so%i==0)
                {
                    lsb1.Items.Add(i.ToString());
                }      
            }
        }
    }
}
