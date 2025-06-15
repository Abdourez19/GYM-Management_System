using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMS_Project1
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private bool ExpandSideBar = false;
        
        private void tmSideBar_Tick(object sender, EventArgs e)
        {
            if (ExpandSideBar == false)
            {
                flpSideBar.Width -= 19;
                if (flpSideBar.Width == flpSideBar.MinimumSize.Width)
                {
                    ExpandSideBar = true;
                    tmSideBar.Stop();
                }
            }
            else
            {
                flpSideBar.Width += 19;
                if (flpSideBar.Width == flpSideBar.MaximumSize.Width)
                {
                    ExpandSideBar = false;
                    tmSideBar.Stop();
                }
            }
        }

        private void pbExpandManu_Click(object sender, EventArgs e)
        {
            tmSideBar.Start();
        }


        
        private void tsmiAdmin_Click(object sender, EventArgs e)
        {

        }

        
    }
}
