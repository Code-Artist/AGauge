namespace AGaugeDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AGauge.AGaugeCaption aGaugeCaption3 = new AGauge.AGaugeCaption();
            AGauge.AGaugeCaption aGaugeCaption4 = new AGauge.AGaugeCaption();
            AGauge.AGaugeRange aGaugeRange3 = new AGauge.AGaugeRange();
            AGauge.AGaugeRange aGaugeRange4 = new AGauge.AGaugeRange();
            this.aGauge1 = new AGauge.AGauge();
            this.SuspendLayout();
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 180;
            this.aGauge1.BaseArcSweep = 180;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.CaptionColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CaptionIndex = ((byte)(1));
            this.aGauge1.CaptionPosition = new System.Drawing.Point(10, 10);
            this.aGauge1.CaptionsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CaptionsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge1.CaptionText = "";
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            aGaugeCaption3.Color = System.Drawing.Color.Empty;
            aGaugeCaption3.Position = new System.Drawing.Point(0, 0);
            aGaugeCaption3.Text = "Test";
            aGaugeCaption4.Color = System.Drawing.Color.Empty;
            aGaugeCaption4.Position = new System.Drawing.Point(0, 0);
            aGaugeCaption4.Text = "Test2";
            this.aGauge1.GaugeCaptions.Add(aGaugeCaption3);
            this.aGauge1.GaugeCaptions.Add(aGaugeCaption4);
            aGaugeRange3.Color = System.Drawing.Color.Empty;
            aGaugeRange3.Enabled = false;
            aGaugeRange3.EndValue = 0F;
            aGaugeRange3.InnerRadius = 0;
            aGaugeRange3.OuterRadius = 0;
            aGaugeRange3.StartValue = 0F;
            aGaugeRange4.Color = System.Drawing.Color.Empty;
            aGaugeRange4.Enabled = true;
            aGaugeRange4.EndValue = 0F;
            aGaugeRange4.InnerRadius = 0;
            aGaugeRange4.OuterRadius = 0;
            aGaugeRange4.StartValue = 0F;
            this.aGauge1.GaugeRanges.Add(aGaugeRange3);
            this.aGauge1.GaugeRanges.Add(aGaugeRange4);
            this.aGauge1.Location = new System.Drawing.Point(12, 12);
            this.aGauge1.MaxValue = 400F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = AGauge.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 300F;
            this.aGauge1.RangeIndex = ((byte)(0));
            this.aGauge1.RangeInnerRadius = 70;
            this.aGauge1.RangeOuterRadius = 80;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = -100F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 80;
            this.aGauge1.ScaleLinesInterOuterRadius = 89;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 80;
            this.aGauge1.ScaleLinesMajorOuterRadius = 85;
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 80;
            this.aGauge1.ScaleLinesMinorOuterRadius = 85;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(212, 183);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.aGauge1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AGauge.AGauge aGauge1;

    }
}

