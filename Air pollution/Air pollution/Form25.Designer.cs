﻿namespace Air_pollution
{
    partial class Form25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form25));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.paunezDataSet = new Air_pollution.paunezDataSet();
            this.paunezDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sodpauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sodpauTableAdapter = new Air_pollution.paunezDataSetTableAdapters.sodpauTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paunezDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paunezDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sodpauBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.sodpauBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Нафталин";
            series1.XValueMember = "Id";
            series1.YValueMembers = "Нафталин";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Аценафтилен";
            series2.XValueMember = "Id";
            series2.YValueMembers = "Аценафтилен";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Аценафтен";
            series3.XValueMember = "Id";
            series3.YValueMembers = "Аценафтен";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(635, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // paunezDataSet
            // 
            this.paunezDataSet.DataSetName = "paunezDataSet";
            this.paunezDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paunezDataSetBindingSource
            // 
            this.paunezDataSetBindingSource.DataSource = this.paunezDataSet;
            this.paunezDataSetBindingSource.Position = 0;
            // 
            // sodpauBindingSource
            // 
            this.sodpauBindingSource.DataMember = "sodpau";
            this.sodpauBindingSource.DataSource = this.paunezDataSetBindingSource;
            // 
            // sodpauTableAdapter
            // 
            this.sodpauTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Вернуться к выбору";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(62, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Вернуться к основному меню";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(486, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Заврешить работу";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form25";
            this.Text = "Нафталин,Аценафтилен,Аценафтен";
            this.Load += new System.EventHandler(this.Form25_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paunezDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paunezDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sodpauBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource paunezDataSetBindingSource;
        private paunezDataSet paunezDataSet;
        private System.Windows.Forms.BindingSource sodpauBindingSource;
        private paunezDataSetTableAdapters.sodpauTableAdapter sodpauTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}