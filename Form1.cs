using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureandfiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
   
            InitializeComponent();
        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            if(ofd.FileName!="")
            {
                dp.ImageLocation = ofd.FileName;
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            sfd.ShowDialog();
            if(sfd.FileName !="")
            {
                dp.Image.Save(sfd.FileName);
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            
        }
       
        private void timer_tick(object sender, EventArgs e)
        {
            DateTime curr_time = DateTime.Now;
            timer.Text = curr_time.ToString();

        }
    }
}
