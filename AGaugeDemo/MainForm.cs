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
    public partial class MainForm : Form
    {
        private AGauge.AGaugeLabel label;
        private AGauge.AGaugeRange alert;
        public MainForm()
        {
            InitializeComponent();
            label = aGauge1.GaugeLabels.FindByName("GaugeLabel1");
            alert = aGauge1.GaugeRanges.FindByName("AlertRange");
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            aGauge1.Value = trackBar1.Value;
        }

        private void aGauge1_ValueChanged(object sender, EventArgs e)
        {
            label.Text = aGauge1.Value.ToString();
        }

        private void aGauge1_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("InRange Event.");
            if (e.Range == alert)
            {
                panel1.BackColor = e.Range.InRange ? Color.Red : Color.FromKnownColor(KnownColor.Control);
            }
        }
    }
}
