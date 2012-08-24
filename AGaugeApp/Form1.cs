using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGaugeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aGauge1_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {
            if (e.valueInRange == 0)
            {
                pictureBox1.BackColor = Color.Green;
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void aGauge2_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {
            if (e.valueInRange == 1)
            {
                label1.Text="WARNING!--OBJECTS IN MIRROR MAY APPEAR SLOWER THAN THEY USED TO.";
            }
            else if (e.valueInRange==2)
            {
                label1.Text="IF THIS GAUGE DISPLAYS YOUR CURRENT SPEED AND YOU STILL CAN SEE THIS THEN SOMTHING IS WRONG ;-)";
            }
            else
            {
                label1.Text = "";
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            aGauge1.Value = trackBar1.Value;
            aGauge2.Value = trackBar1.Value;

            textBox1.Text = aGauge1.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aGauge3.Value+=0.5f;
            aGauge4.Value += 10;

            if (aGauge3.Value >= 50)
            {
                aGauge3.Value = 0;
            }

            if (aGauge4.Value >= 300)
            {
                aGauge4.Value = -300;
            }

            aGauge5.Value = aGauge3.Value;
            aGauge6.Value = (Single)(((Int32)aGauge6.Value + 49) % 50);
            aGauge7.Value = (Single)(((Int32)aGauge7.Value + 49) % 50);
            aGauge8.Value = (Single)(((Int32)aGauge8.Value + 51) % 50);
            aGauge11.Value = (Single)(((Int32)aGauge11.Value + 9) % 10);
            aGauge9.Value = (Single)(((Int32)aGauge9.Value + 99) % 100);
            aGauge10.Value = (Single)(((Int32)aGauge10.Value + 99) % 100);
            aGauge12.Value = (Single)(((Int32)aGauge12.Value + 99) % 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (aGauge1.NeedleType == 0)
            {
                aGauge1.NeedleType = 1;
            }
            else
            {
                aGauge1.NeedleType = 0;
            }

            if (aGauge2.NeedleType == 0)
            {
                aGauge2.NeedleType = 1;
            }
            else
            {
                aGauge2.NeedleType = 0;
            }

            if (aGauge3.NeedleType == 0)
            {
                aGauge3.NeedleType = 1;
            }
            else
            {
                aGauge3.NeedleType = 0;
            }

            if (aGauge4.NeedleType == 0)
            {
                aGauge4.NeedleType = 1;
            }
            else
            {
                aGauge4.NeedleType = 0;
            }

            if (aGauge5.NeedleType == 0)
            {
                aGauge5.NeedleType = 1;
            }
            else
            {
                aGauge5.NeedleType = 0;
            }

        }




    }
}