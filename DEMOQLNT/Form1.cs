using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMOQLNT
{
    public partial class FormMain : Form
    {
        bool sidebarExpand;
        public FormMain()
        {
            InitializeComponent();
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                slidebar.Width -= 10;
                if(slidebar.Width == slidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SlideTimer.Stop();

                }   
                else
                {
                    slidebar.Width += 10;
                    if(slidebar.Width == slidebar.MaximumSize.Width)
                    {
                        sidebarExpand = true;
                        SlideTimer.Stop();
                    }    
                }    
            }    
        }

        private void menubutton_Click(object sender, EventArgs e)
        {
            SlideTimer.Start();
        }
    }
}
