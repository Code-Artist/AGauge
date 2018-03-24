using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AGaugeDemo
{
    public partial class MainFormTest : Form
    {
        private System.Windows.Forms.AGaugeLabel label;
        private System.Windows.Forms.AGaugeRange alert;
        public MainFormTest()
        {
            InitializeComponent();

            label = aGauge1.GaugeLabels.FindByName("GaugeLabel1");
            alert = aGauge1.GaugeRanges.FindByName("AlertRange");
            //aGauge1.AutoSize = true;
            aGauge1.ValueInRangeChanged += AGauge1_ValueInRangeChanged;
        }

        private void AGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            aGauge1.Value = trackBar1.Value;
        }

        private void aGauge1_ValueChanged(object sender, EventArgs e)
        {
            label.Text = aGauge1.Value.ToString();
        }

        private void aGauge1_ValueInRangeChanged(object sender, System.Windows.Forms.ValueInRangeChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("InRange Event.");
            if (e.Range == alert)
            {
                panel1.BackColor = e.InRange ? Color.Red : Color.FromKnownColor(KnownColor.Control);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aGauge1.GaugeRanges.RemoveAt(0);
            aGauge1.GaugeRanges.Add(new AGaugeRange(Color.Blue, 40, 60));
        }
    }
}
