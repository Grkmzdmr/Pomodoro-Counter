using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTechnic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int timeleft;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                
                var timespan = TimeSpan.FromSeconds(timeleft);
                label1.Text = timespan.ToString(@"mm\:ss");
                
            }
            else

            {
                timer1.Stop();
                timer2.Start();
                timeleft = 5 * 60;
                

            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel3.BackColor = Color.DarkGreen;
            timeleft = 25 * 60;
            button1.Enabled = false;
            panel10.BackColor = Color.Maroon;


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Maroon;
            panel7.BackColor = Color.DarkGreen;
            
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;

                var timespan = TimeSpan.FromSeconds(timeleft);
                label1.Text = timespan.ToString(@"mm\:ss");

            }
            else
            {
                timer2.Stop();
                timer3.Start();
                timeleft = 25 * 60;
                

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel7.BackColor = Color.Maroon;
            panel4.BackColor = Color.DarkGreen;

            if (timeleft > 0)
            {
                timeleft = timeleft - 1;

                var timespan = TimeSpan.FromSeconds(timeleft);
                label1.Text = timespan.ToString(@"mm\:ss");

            }
            else
            {
                timer3.Stop();
                timer4.Start();
                timeleft = 5 * 60;
                

            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Maroon;
            panel8.BackColor = Color.DarkGreen;

            if (timeleft > 0)
            {
                timeleft = timeleft - 1;

                var timespan = TimeSpan.FromSeconds(timeleft);
                label1.Text = timespan.ToString(@"mm\:ss");

            }
            else
            {
                timer4.Stop();
                timer5.Start();
                timeleft = 25 * 60;
                

            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            panel8.BackColor = Color.Maroon;
            panel5.BackColor = Color.DarkGreen;

            if (timeleft > 0)
            {
                timeleft = timeleft - 1;

                var timespan = TimeSpan.FromSeconds(timeleft);
                label1.Text = timespan.ToString(@"mm\:ss");

            }
            else
            {
                timer5.Stop();
                timer6.Start();
                timeleft = 5 * 60;
                

            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Maroon;
            panel9.BackColor = Color.DarkGreen;

            if (timeleft > 0)
            {
                timeleft = timeleft - 1;

                var timespan = TimeSpan.FromSeconds(timeleft);
                label1.Text = timespan.ToString(@"mm\:ss");

            }
            else
            {
                timer6.Stop();
                timer7.Start();
                timeleft = 25 * 60;
                

            }

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            panel9.BackColor = Color.Maroon;
            panel6.BackColor = Color.DarkGreen;

            if (timeleft > 0)
            {
                timeleft = timeleft - 1;

                var timespan = TimeSpan.FromSeconds(timeleft);
                label1.Text = timespan.ToString(@"mm\:ss");

            }
            else
            {
                timer7.Stop();
                panel6.BackColor = Color.Maroon;
                panel10.BackColor = Color.DarkGreen;
                MessageBox.Show("DİNLENME ZAMANI");
                button1.Enabled = true;
                


            }

        }
    }
}
