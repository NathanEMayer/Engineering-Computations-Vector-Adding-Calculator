namespace Vector_Adder_Final
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vecmagBox = new System.Windows.Forms.TextBox();
            this.vecangBox = new System.Windows.Forms.TextBox();
            this.vecnumBox = new System.Windows.Forms.TextBox();
            this.resultmagBox = new System.Windows.Forms.TextBox();
            this.resultangBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.computeButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.graphButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(498, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vector Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(93, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vector Magnitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(111, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vector Angle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(390, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "# Of Vector\r\nBeing Enetered";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(903, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resultant Magnitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(933, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resultant Angle";
            // 
            // vecmagBox
            // 
            this.vecmagBox.Location = new System.Drawing.Point(98, 215);
            this.vecmagBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vecmagBox.Name = "vecmagBox";
            this.vecmagBox.Size = new System.Drawing.Size(172, 26);
            this.vecmagBox.TabIndex = 6;
            this.vecmagBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vecmagBox.TextChanged += new System.EventHandler(this.vecmagBox_TextChanged);
            // 
            // vecangBox
            // 
            this.vecangBox.Location = new System.Drawing.Point(98, 412);
            this.vecangBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vecangBox.Name = "vecangBox";
            this.vecangBox.Size = new System.Drawing.Size(172, 26);
            this.vecangBox.TabIndex = 7;
            this.vecangBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vecangBox.TextChanged += new System.EventHandler(this.vecangBox_TextChanged);
            // 
            // vecnumBox
            // 
            this.vecnumBox.Location = new System.Drawing.Point(380, 215);
            this.vecnumBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vecnumBox.Name = "vecnumBox";
            this.vecnumBox.Size = new System.Drawing.Size(172, 26);
            this.vecnumBox.TabIndex = 8;
            this.vecnumBox.TextChanged += new System.EventHandler(this.vecnumBox_TextChanged);
            // 
            // resultmagBox
            // 
            this.resultmagBox.Location = new System.Drawing.Point(921, 215);
            this.resultmagBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultmagBox.Name = "resultmagBox";
            this.resultmagBox.Size = new System.Drawing.Size(172, 26);
            this.resultmagBox.TabIndex = 9;
            this.resultmagBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultmagBox.TextChanged += new System.EventHandler(this.resultmagBox_TextChanged);
            // 
            // resultangBox
            // 
            this.resultangBox.Location = new System.Drawing.Point(921, 412);
            this.resultangBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultangBox.Name = "resultangBox";
            this.resultangBox.Size = new System.Drawing.Size(172, 26);
            this.resultangBox.TabIndex = 10;
            this.resultangBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultangBox.TextChanged += new System.EventHandler(this.resultangBox_TextChanged);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enterButton.Location = new System.Drawing.Point(380, 348);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(156, 95);
            this.enterButton.TabIndex = 11;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(670, 348);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(156, 95);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // computeButton
            // 
            this.computeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.computeButton.Location = new System.Drawing.Point(670, 500);
            this.computeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(156, 95);
            this.computeButton.TabIndex = 13;
            this.computeButton.Text = "Compute";
            this.computeButton.UseVisualStyleBackColor = false;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quitButton.Location = new System.Drawing.Point(938, 500);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(156, 95);
            this.quitButton.TabIndex = 14;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // graphButton
            // 
            this.graphButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.graphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.graphButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.graphButton.Location = new System.Drawing.Point(380, 498);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(156, 95);
            this.graphButton.TabIndex = 16;
            this.graphButton.Text = "Show Graph";
            this.graphButton.UseVisualStyleBackColor = false;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1135, 166);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Resultant Vector Graph";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Vector 1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Vector 2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Vector 3";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Vector 4";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Vector 5";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(623, 300);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "Resultant Graph";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 636);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.resultangBox);
            this.Controls.Add(this.resultmagBox);
            this.Controls.Add(this.vecnumBox);
            this.Controls.Add(this.vecangBox);
            this.Controls.Add(this.vecmagBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vecmagBox;
        private System.Windows.Forms.TextBox vecangBox;
        private System.Windows.Forms.TextBox vecnumBox;
        private System.Windows.Forms.TextBox resultmagBox;
        private System.Windows.Forms.TextBox resultangBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

