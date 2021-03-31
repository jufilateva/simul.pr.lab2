namespace Flight1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.play = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.flStart = new System.Windows.Forms.Button();
            this.flUDSpeed = new System.Windows.Forms.NumericUpDown();
            this.flUDAngle = new System.Windows.Forms.NumericUpDown();
            this.flUDHeight = new System.Windows.Forms.NumericUpDown();
            this.flSpeed = new System.Windows.Forms.Label();
            this.flAngle = new System.Windows.Forms.Label();
            this.flHeight = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flUDSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flUDAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flUDHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.play);
            this.panel1.Controls.Add(this.pause);
            this.panel1.Controls.Add(this.flStart);
            this.panel1.Controls.Add(this.flUDSpeed);
            this.panel1.Controls.Add(this.flUDAngle);
            this.panel1.Controls.Add(this.flUDHeight);
            this.panel1.Controls.Add(this.flSpeed);
            this.panel1.Controls.Add(this.flAngle);
            this.panel1.Controls.Add(this.flHeight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 203);
            this.panel1.TabIndex = 0;
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(499, 54);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 8;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(499, 15);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 7;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // flStart
            // 
            this.flStart.Location = new System.Drawing.Point(275, 17);
            this.flStart.Name = "flStart";
            this.flStart.Size = new System.Drawing.Size(102, 40);
            this.flStart.TabIndex = 6;
            this.flStart.Text = "Старт";
            this.flStart.UseVisualStyleBackColor = true;
            this.flStart.Click += new System.EventHandler(this.flStart_Click);
            // 
            // flUDSpeed
            // 
            this.flUDSpeed.Location = new System.Drawing.Point(89, 103);
            this.flUDSpeed.Name = "flUDSpeed";
            this.flUDSpeed.Size = new System.Drawing.Size(120, 22);
            this.flUDSpeed.TabIndex = 5;
            this.flUDSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // flUDAngle
            // 
            this.flUDAngle.Location = new System.Drawing.Point(89, 60);
            this.flUDAngle.Name = "flUDAngle";
            this.flUDAngle.Size = new System.Drawing.Size(120, 22);
            this.flUDAngle.TabIndex = 4;
            this.flUDAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // flUDHeight
            // 
            this.flUDHeight.Location = new System.Drawing.Point(89, 17);
            this.flUDHeight.Name = "flUDHeight";
            this.flUDHeight.Size = new System.Drawing.Size(120, 22);
            this.flUDHeight.TabIndex = 3;
            // 
            // flSpeed
            // 
            this.flSpeed.AutoSize = true;
            this.flSpeed.Location = new System.Drawing.Point(3, 103);
            this.flSpeed.Name = "flSpeed";
            this.flSpeed.Size = new System.Drawing.Size(53, 17);
            this.flSpeed.TabIndex = 2;
            this.flSpeed.Text = "Speed:";
            // 
            // flAngle
            // 
            this.flAngle.AutoSize = true;
            this.flAngle.Location = new System.Drawing.Point(4, 60);
            this.flAngle.Name = "flAngle";
            this.flAngle.Size = new System.Drawing.Size(48, 17);
            this.flAngle.TabIndex = 1;
            this.flAngle.Text = "Angle:";
            // 
            // flHeight
            // 
            this.flHeight.AutoSize = true;
            this.flHeight.Location = new System.Drawing.Point(4, 17);
            this.flHeight.Name = "flHeight";
            this.flHeight.Size = new System.Drawing.Size(53, 17);
            this.flHeight.TabIndex = 0;
            this.flHeight.Text = "Height:";
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 20D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 5D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 203);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(800, 483);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(499, 107);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(39, 17);
            this.time.TabIndex = 9;
            this.time.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 686);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flUDSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flUDAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flUDHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button flStart;
        private System.Windows.Forms.NumericUpDown flUDSpeed;
        private System.Windows.Forms.NumericUpDown flUDAngle;
        private System.Windows.Forms.NumericUpDown flUDHeight;
        private System.Windows.Forms.Label flSpeed;
        private System.Windows.Forms.Label flAngle;
        private System.Windows.Forms.Label flHeight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Label time;
    }
}

