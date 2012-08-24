namespace AGaugeApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.process1 = new System.Diagnostics.Process();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aGauge5 = new AGaugeApp.AGauge();
            this.aGauge3 = new AGaugeApp.AGauge();
            this.aGauge12 = new AGaugeApp.AGauge();
            this.aGauge7 = new AGaugeApp.AGauge();
            this.aGauge8 = new AGaugeApp.AGauge();
            this.aGauge11 = new AGaugeApp.AGauge();
            this.aGauge10 = new AGaugeApp.AGauge();
            this.aGauge9 = new AGaugeApp.AGauge();
            this.aGauge6 = new AGaugeApp.AGauge();
            this.aGauge2 = new AGaugeApp.AGauge();
            this.aGauge1 = new AGaugeApp.AGauge();
            this.aGauge4 = new AGaugeApp.AGauge();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 29);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 44);
            this.trackBar1.Maximum = 400;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 510);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "change needle types";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "Volt";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(302, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 86);
            this.label1.TabIndex = 20;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aGauge5
            // 
            this.aGauge5.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge5.BaseArcRadius = 40;
            this.aGauge5.BaseArcStart = 0;
            this.aGauge5.BaseArcSweep = -90;
            this.aGauge5.BaseArcWidth = 2;
            this.aGauge5.Cap_Idx = ((byte)(1));
            this.aGauge5.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge5.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge5.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge5.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge5.CapText = "";
            this.aGauge5.Center = new System.Drawing.Point(30, 70);
            this.aGauge5.Location = new System.Drawing.Point(695, 411);
            this.aGauge5.MaxValue = 50F;
            this.aGauge5.MinValue = 0F;
            this.aGauge5.Name = "aGauge5";
            this.aGauge5.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Violet;
            this.aGauge5.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge5.NeedleRadius = 40;
            this.aGauge5.NeedleType = 0;
            this.aGauge5.NeedleWidth = 4;
            this.aGauge5.Range_Idx = ((byte)(1));
            this.aGauge5.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge5.RangeEnabled = false;
            this.aGauge5.RangeEndValue = 400F;
            this.aGauge5.RangeInnerRadius = 10;
            this.aGauge5.RangeOuterRadius = 40;
            this.aGauge5.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge5.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge5.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge5.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge5.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge5.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge5.RangeStartValue = 300F;
            this.aGauge5.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleLinesInterInnerRadius = 42;
            this.aGauge5.ScaleLinesInterOuterRadius = 50;
            this.aGauge5.ScaleLinesInterWidth = 1;
            this.aGauge5.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleLinesMajorInnerRadius = 40;
            this.aGauge5.ScaleLinesMajorOuterRadius = 50;
            this.aGauge5.ScaleLinesMajorStepValue = 10F;
            this.aGauge5.ScaleLinesMajorWidth = 2;
            this.aGauge5.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge5.ScaleLinesMinorInnerRadius = 43;
            this.aGauge5.ScaleLinesMinorNumOf = 1;
            this.aGauge5.ScaleLinesMinorOuterRadius = 50;
            this.aGauge5.ScaleLinesMinorWidth = 1;
            this.aGauge5.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleNumbersFormat = null;
            this.aGauge5.ScaleNumbersRadius = 62;
            this.aGauge5.ScaleNumbersRotation = 90;
            this.aGauge5.ScaleNumbersStartScaleLine = 1;
            this.aGauge5.ScaleNumbersStepScaleLines = 2;
            this.aGauge5.Size = new System.Drawing.Size(106, 95);
            this.aGauge5.TabIndex = 8;
            this.aGauge5.Text = "aGauge5";
            this.aGauge5.Value = 0F;
            // 
            // aGauge3
            // 
            this.aGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge3.BaseArcRadius = 40;
            this.aGauge3.BaseArcStart = 180;
            this.aGauge3.BaseArcSweep = 180;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.Cap_Idx = ((byte)(1));
            this.aGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge3.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge3.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge3.CapText = "";
            this.aGauge3.Center = new System.Drawing.Point(70, 70);
            this.aGauge3.Location = new System.Drawing.Point(63, 401);
            this.aGauge3.MaxValue = 50F;
            this.aGauge3.MinValue = 0F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.White;
            this.aGauge3.NeedleRadius = 40;
            this.aGauge3.NeedleType = 0;
            this.aGauge3.NeedleWidth = 3;
            this.aGauge3.Range_Idx = ((byte)(1));
            this.aGauge3.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge3.RangeEnabled = false;
            this.aGauge3.RangeEndValue = 400F;
            this.aGauge3.RangeInnerRadius = 10;
            this.aGauge3.RangeOuterRadius = 40;
            this.aGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge3.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge3.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge3.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge3.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge3.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge3.RangeStartValue = 300F;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesInterInnerRadius = 42;
            this.aGauge3.ScaleLinesInterOuterRadius = 50;
            this.aGauge3.ScaleLinesInterWidth = 1;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMajorInnerRadius = 40;
            this.aGauge3.ScaleLinesMajorOuterRadius = 50;
            this.aGauge3.ScaleLinesMajorStepValue = 10F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge3.ScaleLinesMinorInnerRadius = 43;
            this.aGauge3.ScaleLinesMinorNumOf = 1;
            this.aGauge3.ScaleLinesMinorOuterRadius = 50;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 62;
            this.aGauge3.ScaleNumbersRotation = 90;
            this.aGauge3.ScaleNumbersStartScaleLine = 1;
            this.aGauge3.ScaleNumbersStepScaleLines = 2;
            this.aGauge3.Size = new System.Drawing.Size(143, 95);
            this.aGauge3.TabIndex = 6;
            this.aGauge3.Text = "aGauge3";
            this.aGauge3.Value = 0F;
            // 
            // aGauge12
            // 
            this.aGauge12.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge12.BaseArcRadius = 40;
            this.aGauge12.BaseArcStart = 180;
            this.aGauge12.BaseArcSweep = 330;
            this.aGauge12.BaseArcWidth = 2;
            this.aGauge12.Cap_Idx = ((byte)(1));
            this.aGauge12.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge12.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge12.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge12.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge12.CapText = "";
            this.aGauge12.Center = new System.Drawing.Point(70, 70);
            this.aGauge12.Location = new System.Drawing.Point(611, 266);
            this.aGauge12.MaxValue = 100F;
            this.aGauge12.MinValue = 0F;
            this.aGauge12.Name = "aGauge12";
            this.aGauge12.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge12.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge12.NeedleRadius = 45;
            this.aGauge12.NeedleType = 0;
            this.aGauge12.NeedleWidth = 3;
            this.aGauge12.Range_Idx = ((byte)(1));
            this.aGauge12.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge12.RangeEnabled = false;
            this.aGauge12.RangeEndValue = 400F;
            this.aGauge12.RangeInnerRadius = 10;
            this.aGauge12.RangeOuterRadius = 40;
            this.aGauge12.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge12.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge12.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge12.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge12.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge12.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge12.RangeStartValue = 300F;
            this.aGauge12.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge12.ScaleLinesInterInnerRadius = 42;
            this.aGauge12.ScaleLinesInterOuterRadius = 50;
            this.aGauge12.ScaleLinesInterWidth = 1;
            this.aGauge12.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge12.ScaleLinesMajorInnerRadius = 40;
            this.aGauge12.ScaleLinesMajorOuterRadius = 50;
            this.aGauge12.ScaleLinesMajorStepValue = 10F;
            this.aGauge12.ScaleLinesMajorWidth = 2;
            this.aGauge12.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge12.ScaleLinesMinorInnerRadius = 43;
            this.aGauge12.ScaleLinesMinorNumOf = 1;
            this.aGauge12.ScaleLinesMinorOuterRadius = 50;
            this.aGauge12.ScaleLinesMinorWidth = 1;
            this.aGauge12.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge12.ScaleNumbersFormat = null;
            this.aGauge12.ScaleNumbersRadius = 62;
            this.aGauge12.ScaleNumbersRotation = 0;
            this.aGauge12.ScaleNumbersStartScaleLine = 1;
            this.aGauge12.ScaleNumbersStepScaleLines = 2;
            this.aGauge12.Size = new System.Drawing.Size(150, 142);
            this.aGauge12.TabIndex = 18;
            this.aGauge12.Text = "aGauge12";
            this.aGauge12.Value = 0F;
            // 
            // aGauge7
            // 
            this.aGauge7.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge7.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge7.BaseArcRadius = 40;
            this.aGauge7.BaseArcStart = 180;
            this.aGauge7.BaseArcSweep = 180;
            this.aGauge7.BaseArcWidth = 2;
            this.aGauge7.Cap_Idx = ((byte)(1));
            this.aGauge7.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge7.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge7.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge7.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge7.CapText = "";
            this.aGauge7.Center = new System.Drawing.Point(70, 70);
            this.aGauge7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge7.Location = new System.Drawing.Point(547, 411);
            this.aGauge7.MaxValue = 50F;
            this.aGauge7.MinValue = 0F;
            this.aGauge7.Name = "aGauge7";
            this.aGauge7.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.aGauge7.NeedleColor2 = System.Drawing.Color.GreenYellow;
            this.aGauge7.NeedleRadius = 40;
            this.aGauge7.NeedleType = 0;
            this.aGauge7.NeedleWidth = 2;
            this.aGauge7.Range_Idx = ((byte)(0));
            this.aGauge7.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge7.RangeEnabled = false;
            this.aGauge7.RangeEndValue = 300F;
            this.aGauge7.RangeInnerRadius = 70;
            this.aGauge7.RangeOuterRadius = 80;
            this.aGauge7.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge7.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge7.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge7.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge7.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge7.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge7.RangeStartValue = -100F;
            this.aGauge7.ScaleLinesInterColor = System.Drawing.Color.Red;
            this.aGauge7.ScaleLinesInterInnerRadius = 42;
            this.aGauge7.ScaleLinesInterOuterRadius = 50;
            this.aGauge7.ScaleLinesInterWidth = 1;
            this.aGauge7.ScaleLinesMajorColor = System.Drawing.Color.Red;
            this.aGauge7.ScaleLinesMajorInnerRadius = 40;
            this.aGauge7.ScaleLinesMajorOuterRadius = 50;
            this.aGauge7.ScaleLinesMajorStepValue = 10F;
            this.aGauge7.ScaleLinesMajorWidth = 2;
            this.aGauge7.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.aGauge7.ScaleLinesMinorInnerRadius = 43;
            this.aGauge7.ScaleLinesMinorNumOf = 1;
            this.aGauge7.ScaleLinesMinorOuterRadius = 50;
            this.aGauge7.ScaleLinesMinorWidth = 1;
            this.aGauge7.ScaleNumbersColor = System.Drawing.Color.Red;
            this.aGauge7.ScaleNumbersFormat = null;
            this.aGauge7.ScaleNumbersRadius = 62;
            this.aGauge7.ScaleNumbersRotation = 90;
            this.aGauge7.ScaleNumbersStartScaleLine = 1;
            this.aGauge7.ScaleNumbersStepScaleLines = 2;
            this.aGauge7.Size = new System.Drawing.Size(142, 85);
            this.aGauge7.TabIndex = 11;
            this.aGauge7.Text = "aGauge7";
            this.aGauge7.Value = 0F;
            // 
            // aGauge8
            // 
            this.aGauge8.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge8.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge8.BaseArcRadius = 40;
            this.aGauge8.BaseArcStart = 180;
            this.aGauge8.BaseArcSweep = 90;
            this.aGauge8.BaseArcWidth = 2;
            this.aGauge8.Cap_Idx = ((byte)(1));
            this.aGauge8.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge8.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge8.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge8.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge8.CapText = "";
            this.aGauge8.Center = new System.Drawing.Point(70, 70);
            this.aGauge8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge8.Location = new System.Drawing.Point(509, 167);
            this.aGauge8.MaxValue = 50F;
            this.aGauge8.MinValue = 0F;
            this.aGauge8.Name = "aGauge8";
            this.aGauge8.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Blue;
            this.aGauge8.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aGauge8.NeedleRadius = 40;
            this.aGauge8.NeedleType = 0;
            this.aGauge8.NeedleWidth = 3;
            this.aGauge8.Range_Idx = ((byte)(0));
            this.aGauge8.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge8.RangeEnabled = false;
            this.aGauge8.RangeEndValue = 300F;
            this.aGauge8.RangeInnerRadius = 70;
            this.aGauge8.RangeOuterRadius = 80;
            this.aGauge8.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge8.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge8.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge8.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge8.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge8.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge8.RangeStartValue = -100F;
            this.aGauge8.ScaleLinesInterColor = System.Drawing.Color.RosyBrown;
            this.aGauge8.ScaleLinesInterInnerRadius = 42;
            this.aGauge8.ScaleLinesInterOuterRadius = 50;
            this.aGauge8.ScaleLinesInterWidth = 1;
            this.aGauge8.ScaleLinesMajorColor = System.Drawing.Color.RoyalBlue;
            this.aGauge8.ScaleLinesMajorInnerRadius = 40;
            this.aGauge8.ScaleLinesMajorOuterRadius = 50;
            this.aGauge8.ScaleLinesMajorStepValue = 10F;
            this.aGauge8.ScaleLinesMajorWidth = 2;
            this.aGauge8.ScaleLinesMinorColor = System.Drawing.Color.DarkSalmon;
            this.aGauge8.ScaleLinesMinorInnerRadius = 43;
            this.aGauge8.ScaleLinesMinorNumOf = 1;
            this.aGauge8.ScaleLinesMinorOuterRadius = 50;
            this.aGauge8.ScaleLinesMinorWidth = 1;
            this.aGauge8.ScaleNumbersColor = System.Drawing.Color.RoyalBlue;
            this.aGauge8.ScaleNumbersFormat = null;
            this.aGauge8.ScaleNumbersRadius = 62;
            this.aGauge8.ScaleNumbersRotation = 90;
            this.aGauge8.ScaleNumbersStartScaleLine = 1;
            this.aGauge8.ScaleNumbersStepScaleLines = 2;
            this.aGauge8.Size = new System.Drawing.Size(84, 85);
            this.aGauge8.TabIndex = 16;
            this.aGauge8.Text = "aGauge8";
            this.aGauge8.Value = 22F;
            // 
            // aGauge11
            // 
            this.aGauge11.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge11.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge11.BaseArcRadius = 40;
            this.aGauge11.BaseArcStart = -90;
            this.aGauge11.BaseArcSweep = 360;
            this.aGauge11.BaseArcWidth = 2;
            this.aGauge11.Cap_Idx = ((byte)(1));
            this.aGauge11.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge11.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge11.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge11.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge11.CapText = "";
            this.aGauge11.Center = new System.Drawing.Point(70, 70);
            this.aGauge11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge11.Location = new System.Drawing.Point(631, 9);
            this.aGauge11.MaxValue = 10F;
            this.aGauge11.MinValue = 0F;
            this.aGauge11.Name = "aGauge11";
            this.aGauge11.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.aGauge11.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge11.NeedleRadius = 40;
            this.aGauge11.NeedleType = 0;
            this.aGauge11.NeedleWidth = 10;
            this.aGauge11.Range_Idx = ((byte)(0));
            this.aGauge11.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge11.RangeEnabled = false;
            this.aGauge11.RangeEndValue = 300F;
            this.aGauge11.RangeInnerRadius = 70;
            this.aGauge11.RangeOuterRadius = 80;
            this.aGauge11.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge11.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge11.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge11.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge11.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge11.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge11.RangeStartValue = -100F;
            this.aGauge11.ScaleLinesInterColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aGauge11.ScaleLinesInterInnerRadius = 42;
            this.aGauge11.ScaleLinesInterOuterRadius = 50;
            this.aGauge11.ScaleLinesInterWidth = 1;
            this.aGauge11.ScaleLinesMajorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.aGauge11.ScaleLinesMajorInnerRadius = 40;
            this.aGauge11.ScaleLinesMajorOuterRadius = 50;
            this.aGauge11.ScaleLinesMajorStepValue = 1F;
            this.aGauge11.ScaleLinesMajorWidth = 2;
            this.aGauge11.ScaleLinesMinorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aGauge11.ScaleLinesMinorInnerRadius = 43;
            this.aGauge11.ScaleLinesMinorNumOf = 1;
            this.aGauge11.ScaleLinesMinorOuterRadius = 50;
            this.aGauge11.ScaleLinesMinorWidth = 1;
            this.aGauge11.ScaleNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.aGauge11.ScaleNumbersFormat = null;
            this.aGauge11.ScaleNumbersRadius = 62;
            this.aGauge11.ScaleNumbersRotation = 0;
            this.aGauge11.ScaleNumbersStartScaleLine = 2;
            this.aGauge11.ScaleNumbersStepScaleLines = 2;
            this.aGauge11.Size = new System.Drawing.Size(149, 148);
            this.aGauge11.TabIndex = 15;
            this.aGauge11.Text = "aGauge11";
            this.aGauge11.Value = 0F;
            // 
            // aGauge10
            // 
            this.aGauge10.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge10.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge10.BaseArcRadius = 40;
            this.aGauge10.BaseArcStart = 0;
            this.aGauge10.BaseArcSweep = -90;
            this.aGauge10.BaseArcWidth = 2;
            this.aGauge10.Cap_Idx = ((byte)(1));
            this.aGauge10.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge10.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge10.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge10.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge10.CapText = "";
            this.aGauge10.Center = new System.Drawing.Point(15, 70);
            this.aGauge10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge10.Location = new System.Drawing.Point(695, 167);
            this.aGauge10.MaxValue = 100F;
            this.aGauge10.MinValue = 0F;
            this.aGauge10.Name = "aGauge10";
            this.aGauge10.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Red;
            this.aGauge10.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge10.NeedleRadius = 40;
            this.aGauge10.NeedleType = 0;
            this.aGauge10.NeedleWidth = 2;
            this.aGauge10.Range_Idx = ((byte)(0));
            this.aGauge10.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge10.RangeEnabled = false;
            this.aGauge10.RangeEndValue = 300F;
            this.aGauge10.RangeInnerRadius = 70;
            this.aGauge10.RangeOuterRadius = 80;
            this.aGauge10.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge10.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge10.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge10.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge10.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge10.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge10.RangeStartValue = -100F;
            this.aGauge10.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGauge10.ScaleLinesInterInnerRadius = 45;
            this.aGauge10.ScaleLinesInterOuterRadius = 50;
            this.aGauge10.ScaleLinesInterWidth = 2;
            this.aGauge10.ScaleLinesMajorColor = System.Drawing.Color.SaddleBrown;
            this.aGauge10.ScaleLinesMajorInnerRadius = 40;
            this.aGauge10.ScaleLinesMajorOuterRadius = 50;
            this.aGauge10.ScaleLinesMajorStepValue = 50F;
            this.aGauge10.ScaleLinesMajorWidth = 2;
            this.aGauge10.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.aGauge10.ScaleLinesMinorInnerRadius = 45;
            this.aGauge10.ScaleLinesMinorNumOf = 9;
            this.aGauge10.ScaleLinesMinorOuterRadius = 50;
            this.aGauge10.ScaleLinesMinorWidth = 2;
            this.aGauge10.ScaleNumbersColor = System.Drawing.Color.Maroon;
            this.aGauge10.ScaleNumbersFormat = null;
            this.aGauge10.ScaleNumbersRadius = 62;
            this.aGauge10.ScaleNumbersRotation = 90;
            this.aGauge10.ScaleNumbersStartScaleLine = 1;
            this.aGauge10.ScaleNumbersStepScaleLines = 2;
            this.aGauge10.Size = new System.Drawing.Size(85, 93);
            this.aGauge10.TabIndex = 14;
            this.aGauge10.Text = "aGauge10";
            this.aGauge10.Value = 0F;
            // 
            // aGauge9
            // 
            this.aGauge9.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge9.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge9.BaseArcRadius = 40;
            this.aGauge9.BaseArcStart = 180;
            this.aGauge9.BaseArcSweep = 90;
            this.aGauge9.BaseArcWidth = 2;
            this.aGauge9.Cap_Idx = ((byte)(1));
            this.aGauge9.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge9.CapPosition = new System.Drawing.Point(20, 75);
            this.aGauge9.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 75),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge9.CapsText = new string[] {
        "",
        "% Fuel",
        "",
        "",
        ""};
            this.aGauge9.CapText = "% Fuel";
            this.aGauge9.Center = new System.Drawing.Point(70, 70);
            this.aGauge9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge9.Location = new System.Drawing.Point(611, 167);
            this.aGauge9.MaxValue = 100F;
            this.aGauge9.MinValue = 0F;
            this.aGauge9.Name = "aGauge9";
            this.aGauge9.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge9.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge9.NeedleRadius = 40;
            this.aGauge9.NeedleType = 0;
            this.aGauge9.NeedleWidth = 2;
            this.aGauge9.Range_Idx = ((byte)(0));
            this.aGauge9.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge9.RangeEnabled = false;
            this.aGauge9.RangeEndValue = 300F;
            this.aGauge9.RangeInnerRadius = 70;
            this.aGauge9.RangeOuterRadius = 80;
            this.aGauge9.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge9.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge9.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge9.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge9.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge9.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge9.RangeStartValue = -100F;
            this.aGauge9.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge9.ScaleLinesInterInnerRadius = 42;
            this.aGauge9.ScaleLinesInterOuterRadius = 50;
            this.aGauge9.ScaleLinesInterWidth = 2;
            this.aGauge9.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge9.ScaleLinesMajorInnerRadius = 40;
            this.aGauge9.ScaleLinesMajorOuterRadius = 50;
            this.aGauge9.ScaleLinesMajorStepValue = 50F;
            this.aGauge9.ScaleLinesMajorWidth = 2;
            this.aGauge9.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge9.ScaleLinesMinorInnerRadius = 43;
            this.aGauge9.ScaleLinesMinorNumOf = 9;
            this.aGauge9.ScaleLinesMinorOuterRadius = 50;
            this.aGauge9.ScaleLinesMinorWidth = 2;
            this.aGauge9.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge9.ScaleNumbersFormat = null;
            this.aGauge9.ScaleNumbersRadius = 62;
            this.aGauge9.ScaleNumbersRotation = 90;
            this.aGauge9.ScaleNumbersStartScaleLine = 1;
            this.aGauge9.ScaleNumbersStepScaleLines = 2;
            this.aGauge9.Size = new System.Drawing.Size(91, 108);
            this.aGauge9.TabIndex = 13;
            this.aGauge9.Text = "aGauge9";
            this.aGauge9.Value = 0F;
            // 
            // aGauge6
            // 
            this.aGauge6.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge6.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge6.BaseArcRadius = 500;
            this.aGauge6.BaseArcStart = 180;
            this.aGauge6.BaseArcSweep = 90;
            this.aGauge6.BaseArcWidth = 0;
            this.aGauge6.Cap_Idx = ((byte)(1));
            this.aGauge6.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge6.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge6.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge6.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge6.CapText = "";
            this.aGauge6.Center = new System.Drawing.Point(70, 70);
            this.aGauge6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge6.Location = new System.Drawing.Point(82, 266);
            this.aGauge6.MaxValue = 50F;
            this.aGauge6.MinValue = 0F;
            this.aGauge6.Name = "aGauge6";
            this.aGauge6.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Blue;
            this.aGauge6.NeedleColor2 = System.Drawing.Color.RoyalBlue;
            this.aGauge6.NeedleRadius = 48;
            this.aGauge6.NeedleType = 1;
            this.aGauge6.NeedleWidth = 3;
            this.aGauge6.Range_Idx = ((byte)(0));
            this.aGauge6.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge6.RangeEnabled = false;
            this.aGauge6.RangeEndValue = 300F;
            this.aGauge6.RangeInnerRadius = 70;
            this.aGauge6.RangeOuterRadius = 80;
            this.aGauge6.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge6.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge6.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge6.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge6.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge6.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge6.RangeStartValue = -100F;
            this.aGauge6.ScaleLinesInterColor = System.Drawing.Color.RosyBrown;
            this.aGauge6.ScaleLinesInterInnerRadius = 42;
            this.aGauge6.ScaleLinesInterOuterRadius = 55;
            this.aGauge6.ScaleLinesInterWidth = 1;
            this.aGauge6.ScaleLinesMajorColor = System.Drawing.Color.Gray;
            this.aGauge6.ScaleLinesMajorInnerRadius = 40;
            this.aGauge6.ScaleLinesMajorOuterRadius = 55;
            this.aGauge6.ScaleLinesMajorStepValue = 10F;
            this.aGauge6.ScaleLinesMajorWidth = 2;
            this.aGauge6.ScaleLinesMinorColor = System.Drawing.Color.DarkSalmon;
            this.aGauge6.ScaleLinesMinorInnerRadius = 43;
            this.aGauge6.ScaleLinesMinorNumOf = 1;
            this.aGauge6.ScaleLinesMinorOuterRadius = 50;
            this.aGauge6.ScaleLinesMinorWidth = 1;
            this.aGauge6.ScaleNumbersColor = System.Drawing.Color.RoyalBlue;
            this.aGauge6.ScaleNumbersFormat = null;
            this.aGauge6.ScaleNumbersRadius = 62;
            this.aGauge6.ScaleNumbersRotation = 90;
            this.aGauge6.ScaleNumbersStartScaleLine = 1;
            this.aGauge6.ScaleNumbersStepScaleLines = 2;
            this.aGauge6.Size = new System.Drawing.Size(84, 85);
            this.aGauge6.TabIndex = 12;
            this.aGauge6.Text = "aGauge6";
            this.aGauge6.Value = 22F;
            // 
            // aGauge2
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 130;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Cap_Idx = ((byte)(2));
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(102, 200);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(142, 100),
        new System.Drawing.Point(102, 200),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        "Speed",
        "x 1000000 [m/s]",
        "",
        ""};
            this.aGauge2.CapText = "x 1000000 [m/s]";
            this.aGauge2.Center = new System.Drawing.Point(170, 170);
            this.aGauge2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge2.Location = new System.Drawing.Point(199, 187);
            this.aGauge2.MaxValue = 400F;
            this.aGauge2.MinValue = -100F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Yellow;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge2.NeedleRadius = 130;
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 5;
            this.aGauge2.Range_Idx = ((byte)(1));
            this.aGauge2.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.aGauge2.RangeEnabled = true;
            this.aGauge2.RangeEndValue = 290F;
            this.aGauge2.RangeInnerRadius = 100;
            this.aGauge2.RangeOuterRadius = 130;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        100F,
        290F,
        400F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        100,
        100,
        100,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        130,
        130,
        130,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        -100F,
        100F,
        290F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 100F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 130;
            this.aGauge2.ScaleLinesInterOuterRadius = 140;
            this.aGauge2.ScaleLinesInterWidth = 2;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 130;
            this.aGauge2.ScaleLinesMajorOuterRadius = 142;
            this.aGauge2.ScaleLinesMajorStepValue = 50F;
            this.aGauge2.ScaleLinesMajorWidth = 3;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 130;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 140;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 160;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(378, 299);
            this.aGauge2.TabIndex = 3;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            this.aGauge2.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.aGauge2_ValueInRangeChanged);
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.SystemColors.Control;
            this.aGauge1.BaseArcColor = System.Drawing.Color.LightSlateGray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 1;
            this.aGauge1.Cap_Idx = ((byte)(1));
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "";
            this.aGauge1.Center = new System.Drawing.Point(100, 105);
            this.aGauge1.Location = new System.Drawing.Point(63, 21);
            this.aGauge1.MaxValue = 400F;
            this.aGauge1.MinValue = -100F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.Range_Idx = ((byte)(1));
            this.aGauge1.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 400F;
            this.aGauge1.RangeInnerRadius = 1;
            this.aGauge1.RangeOuterRadius = 75;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
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
        1,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        75,
        75,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 300F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 76;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 76;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(209, 186);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 50F;
            this.aGauge1.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.aGauge1_ValueInRangeChanged);
            // 
            // aGauge4
            // 
            this.aGauge4.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge4.BaseArcRadius = 150;
            this.aGauge4.BaseArcStart = 215;
            this.aGauge4.BaseArcSweep = 110;
            this.aGauge4.BaseArcWidth = 2;
            this.aGauge4.Cap_Idx = ((byte)(1));
            this.aGauge4.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge4.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge4.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge4.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge4.CapText = "";
            this.aGauge4.Center = new System.Drawing.Point(150, 180);
            this.aGauge4.Location = new System.Drawing.Point(315, 3);
            this.aGauge4.MaxValue = 300F;
            this.aGauge4.MinValue = -300F;
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.aGauge4.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge4.NeedleRadius = 150;
            this.aGauge4.NeedleType = 0;
            this.aGauge4.NeedleWidth = 2;
            this.aGauge4.Range_Idx = ((byte)(1));
            this.aGauge4.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge4.RangeEnabled = false;
            this.aGauge4.RangeEndValue = 400F;
            this.aGauge4.RangeInnerRadius = 10;
            this.aGauge4.RangeOuterRadius = 40;
            this.aGauge4.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge4.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge4.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge4.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge4.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge4.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge4.RangeStartValue = 300F;
            this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.Red;
            this.aGauge4.ScaleLinesInterInnerRadius = 145;
            this.aGauge4.ScaleLinesInterOuterRadius = 150;
            this.aGauge4.ScaleLinesInterWidth = 2;
            this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleLinesMajorInnerRadius = 140;
            this.aGauge4.ScaleLinesMajorOuterRadius = 150;
            this.aGauge4.ScaleLinesMajorStepValue = 100F;
            this.aGauge4.ScaleLinesMajorWidth = 2;
            this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge4.ScaleLinesMinorInnerRadius = 145;
            this.aGauge4.ScaleLinesMinorNumOf = 9;
            this.aGauge4.ScaleLinesMinorOuterRadius = 150;
            this.aGauge4.ScaleLinesMinorWidth = 1;
            this.aGauge4.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleNumbersFormat = null;
            this.aGauge4.ScaleNumbersRadius = 162;
            this.aGauge4.ScaleNumbersRotation = 90;
            this.aGauge4.ScaleNumbersStartScaleLine = 1;
            this.aGauge4.ScaleNumbersStepScaleLines = 2;
            this.aGauge4.Size = new System.Drawing.Size(297, 121);
            this.aGauge4.TabIndex = 7;
            this.aGauge4.Text = "aGauge4";
            this.aGauge4.Value = 0F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aGauge5);
            this.Controls.Add(this.aGauge3);
            this.Controls.Add(this.aGauge12);
            this.Controls.Add(this.aGauge7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.aGauge8);
            this.Controls.Add(this.aGauge11);
            this.Controls.Add(this.aGauge10);
            this.Controls.Add(this.aGauge9);
            this.Controls.Add(this.aGauge6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.aGauge4);
            this.Name = "Form1";
            this.Text = "AGauge Test Window";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AGauge aGauge1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private AGauge aGauge2;
        private System.Windows.Forms.Timer timer1;
        private AGauge aGauge3;
        private AGauge aGauge4;
        private AGauge aGauge5;
        private System.Windows.Forms.Button button1;
        private AGauge aGauge6;
        private AGauge aGauge7;
        private AGauge aGauge9;
        private AGauge aGauge10;
        private AGauge aGauge11;
        private AGauge aGauge8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Diagnostics.Process process1;
        private AGauge aGauge12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

