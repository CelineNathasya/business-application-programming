using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {

        System.Timers.Timer timer = null;

        public Form1()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            btnReset.Enabled = false;
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;
        }

        readonly int countDownInitialValue = 30;
        int countdown;
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (countdown > 0)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblCount.Text = (--countdown).ToString();
                });
            }
            else
            {
                timer.Stop();
                btnStop.Enabled = false;
                btnReset.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            countdown = 30;
            lblCount.Text = countdown.ToString();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnReset.Enabled = false;
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnStop.Enabled = false;
            btnReset.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCount.Text = countDownInitialValue.ToString();
            btnStart.Enabled = true;
            btnReset.Enabled = false;
        }

    }
}
