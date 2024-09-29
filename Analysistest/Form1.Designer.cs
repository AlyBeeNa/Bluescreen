namespace Analysistest
{
    partial class menufrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menufrm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.overviewbtn = new System.Windows.Forms.Button();
            this.wrongansbtn = new System.Windows.Forms.Button();
            this.topicbtn = new System.Windows.Forms.Button();
            this.emotionbtn = new System.Windows.Forms.Button();
            this.overviewpnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.emotionspnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Trendspnl = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.topicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anomaliesDataSet = new Analysistest.anomaliesDataSet();
            this.topicTableAdapter = new Analysistest.anomaliesDataSetTableAdapters.topicTableAdapter();
            this.queriespnl = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.querieschrt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.overviewpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.emotionspnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.Trendspnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anomaliesDataSet)).BeginInit();
            this.queriespnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.querieschrt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-11, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 56);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(274, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 555);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(949, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.overviewbtn);
            this.panel2.Controls.Add(this.wrongansbtn);
            this.panel2.Controls.Add(this.topicbtn);
            this.panel2.Controls.Add(this.emotionbtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 610);
            this.panel2.TabIndex = 2;
            // 
            // overviewbtn
            // 
            this.overviewbtn.BackColor = System.Drawing.Color.AliceBlue;
            this.overviewbtn.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewbtn.Location = new System.Drawing.Point(1, 341);
            this.overviewbtn.Name = "overviewbtn";
            this.overviewbtn.Size = new System.Drawing.Size(265, 54);
            this.overviewbtn.TabIndex = 4;
            this.overviewbtn.Text = "Overview";
            this.overviewbtn.UseVisualStyleBackColor = false;
            this.overviewbtn.Click += new System.EventHandler(this.overviewbtn_Click);
            // 
            // wrongansbtn
            // 
            this.wrongansbtn.BackColor = System.Drawing.Color.AliceBlue;
            this.wrongansbtn.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongansbtn.Location = new System.Drawing.Point(2, 501);
            this.wrongansbtn.Name = "wrongansbtn";
            this.wrongansbtn.Size = new System.Drawing.Size(265, 54);
            this.wrongansbtn.TabIndex = 3;
            this.wrongansbtn.Text = "Wrong queries";
            this.wrongansbtn.UseVisualStyleBackColor = false;
            this.wrongansbtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // topicbtn
            // 
            this.topicbtn.BackColor = System.Drawing.Color.AliceBlue;
            this.topicbtn.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicbtn.Location = new System.Drawing.Point(1, 448);
            this.topicbtn.Name = "topicbtn";
            this.topicbtn.Size = new System.Drawing.Size(265, 54);
            this.topicbtn.TabIndex = 1;
            this.topicbtn.Text = "Topics";
            this.topicbtn.UseVisualStyleBackColor = false;
            this.topicbtn.Click += new System.EventHandler(this.topicbtn_Click);
            // 
            // emotionbtn
            // 
            this.emotionbtn.BackColor = System.Drawing.Color.AliceBlue;
            this.emotionbtn.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emotionbtn.Location = new System.Drawing.Point(1, 394);
            this.emotionbtn.Name = "emotionbtn";
            this.emotionbtn.Size = new System.Drawing.Size(265, 54);
            this.emotionbtn.TabIndex = 0;
            this.emotionbtn.Text = "User experience";
            this.emotionbtn.UseVisualStyleBackColor = false;
            this.emotionbtn.Click += new System.EventHandler(this.emotionbtn_Click);
            // 
            // overviewpnl
            // 
            this.overviewpnl.Controls.Add(this.label2);
            this.overviewpnl.Controls.Add(this.label1);
            this.overviewpnl.Controls.Add(this.chart1);
            this.overviewpnl.Location = new System.Drawing.Point(268, 67);
            this.overviewpnl.Name = "overviewpnl";
            this.overviewpnl.Size = new System.Drawing.Size(772, 557);
            this.overviewpnl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "_____________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total number of messages";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(77, 112);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "chat_session";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(633, 376);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // emotionspnl
            // 
            this.emotionspnl.Controls.Add(this.label4);
            this.emotionspnl.Controls.Add(this.label3);
            this.emotionspnl.Controls.Add(this.chart2);
            this.emotionspnl.Location = new System.Drawing.Point(266, 61);
            this.emotionspnl.Name = "emotionspnl";
            this.emotionspnl.Size = new System.Drawing.Size(772, 549);
            this.emotionspnl.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(641, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(641, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "%";
            // 
            // chart2
            // 
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisY.Interval = 1D;
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(100, 49);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "rating";
            series5.Points.Add(dataPoint2);
            series5.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(579, 426);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "emotionschrt";
            // 
            // Trendspnl
            // 
            this.Trendspnl.Controls.Add(this.label5);
            this.Trendspnl.Controls.Add(this.listBox1);
            this.Trendspnl.Location = new System.Drawing.Point(266, 57);
            this.Trendspnl.Name = "Trendspnl";
            this.Trendspnl.Size = new System.Drawing.Size(768, 563);
            this.Trendspnl.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Trending topics";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.topicBindingSource;
            this.listBox1.DisplayMember = "name_topic";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(288, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(383, 372);
            this.listBox1.TabIndex = 0;
            // 
            // topicBindingSource
            // 
            this.topicBindingSource.DataMember = "topic";
            this.topicBindingSource.DataSource = this.anomaliesDataSet;
            // 
            // anomaliesDataSet
            // 
            this.anomaliesDataSet.DataSetName = "anomaliesDataSet";
            this.anomaliesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // topicTableAdapter
            // 
            this.topicTableAdapter.ClearBeforeFill = true;
            // 
            // queriespnl
            // 
            this.queriespnl.Controls.Add(this.querieschrt);
            this.queriespnl.Controls.Add(this.label7);
            this.queriespnl.Controls.Add(this.label6);
            this.queriespnl.Location = new System.Drawing.Point(266, 57);
            this.queriespnl.Name = "queriespnl";
            this.queriespnl.Size = new System.Drawing.Size(765, 552);
            this.queriespnl.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total queries";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "_________";
            // 
            // querieschrt
            // 
            chartArea6.Name = "ChartArea1";
            this.querieschrt.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.querieschrt.Legends.Add(legend6);
            this.querieschrt.Location = new System.Drawing.Point(46, 122);
            this.querieschrt.Name = "querieschrt";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "queries";
            series6.YValuesPerPoint = 2;
            this.querieschrt.Series.Add(series6);
            this.querieschrt.Size = new System.Drawing.Size(665, 396);
            this.querieschrt.TabIndex = 2;
            this.querieschrt.Text = "qrieschrt";
            // 
            // menufrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1038, 608);
            this.Controls.Add(this.queriespnl);
            this.Controls.Add(this.Trendspnl);
            this.Controls.Add(this.emotionspnl);
            this.Controls.Add(this.overviewpnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menufrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.overviewpnl.ResumeLayout(false);
            this.overviewpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.emotionspnl.ResumeLayout(false);
            this.emotionspnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.Trendspnl.ResumeLayout(false);
            this.Trendspnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anomaliesDataSet)).EndInit();
            this.queriespnl.ResumeLayout(false);
            this.queriespnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.querieschrt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button overviewbtn;
        private System.Windows.Forms.Button wrongansbtn;
        private System.Windows.Forms.Button topicbtn;
        private System.Windows.Forms.Button emotionbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel overviewpnl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel emotionspnl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Trendspnl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private anomaliesDataSet anomaliesDataSet;
        private System.Windows.Forms.BindingSource topicBindingSource;
        private anomaliesDataSetTableAdapters.topicTableAdapter topicTableAdapter;
        private System.Windows.Forms.Panel queriespnl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart querieschrt;
        private System.Windows.Forms.Label label7;
    }
}

