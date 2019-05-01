namespace Air_pollution
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.worldsideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointsdataDataSet6 = new Air_pollution.pointsdataDataSet6();
            this.worldsideTableAdapter = new Air_pollution.pointsdataDataSet6TableAdapters.worldsideTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.probtestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointsdataDataSet1 = new Air_pollution.pointsdataDataSet1();
            this.probtestTableAdapter = new Air_pollution.pointsdataDataSet1TableAdapters.probtestTableAdapter();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.probtest2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointsdataDataSet4 = new Air_pollution.pointsdataDataSet4();
            this.probtest2TableAdapter = new Air_pollution.pointsdataDataSet4TableAdapters.probtest2TableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldsideBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probtestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probtest2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЗАДАНИЕ МАРШРУТА И ТОЧЕК ПРОБООТБОРА (ввод данных измерений): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Направление опорного маршрута пробоотбора (выбрать):";
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.worldsideBindingSource, "side", true));
            this.listBox1.DataSource = this.worldsideBindingSource;
            this.listBox1.DisplayMember = "side";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(252, 277);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "side";
            // 
            // worldsideBindingSource
            // 
            this.worldsideBindingSource.DataMember = "worldside";
            this.worldsideBindingSource.DataSource = this.pointsdataDataSet6;
            // 
            // pointsdataDataSet6
            // 
            this.pointsdataDataSet6.DataSetName = "pointsdataDataSet6";
            this.pointsdataDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worldsideTableAdapter
            // 
            this.worldsideTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Расстояние от источника до точки пробоотбора (км)";
            // 
            // listBox2
            // 
            this.listBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.probtestBindingSource, "value", true));
            this.listBox2.DataSource = this.probtestBindingSource;
            this.listBox2.DisplayMember = "value";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(100, 336);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 17);
            this.listBox2.TabIndex = 6;
            this.listBox2.ValueMember = "value";
            // 
            // probtestBindingSource
            // 
            this.probtestBindingSource.DataMember = "probtest";
            this.probtestBindingSource.DataSource = this.pointsdataDataSet1;
            // 
            // pointsdataDataSet1
            // 
            this.pointsdataDataSet1.DataSetName = "pointsdataDataSet1";
            this.pointsdataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // probtestTableAdapter
            // 
            this.probtestTableAdapter.ClearBeforeFill = true;
            // 
            // listBox3
            // 
            this.listBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.probtest2BindingSource, "value", true));
            this.listBox3.DataSource = this.probtest2BindingSource;
            this.listBox3.DisplayMember = "value";
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(100, 364);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 17);
            this.listBox3.TabIndex = 7;
            this.listBox3.ValueMember = "value";
            // 
            // probtest2BindingSource
            // 
            this.probtest2BindingSource.DataMember = "probtest2";
            this.probtest2BindingSource.DataSource = this.pointsdataDataSet4;
            // 
            // pointsdataDataSet4
            // 
            this.pointsdataDataSet4.DataSetName = "pointsdataDataSet4";
            this.pointsdataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // probtest2TableAdapter
            // 
            this.probtest2TableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Измеренные концентрации примеси в пробах (г/м2)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(417, 361);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "записать выбранные значения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "РЕКОМЕНДАЦИИ по выбору расстояний ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "от источника выброса до точек отбора снеговых проб :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(403, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(400, 147);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(294, 121);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(294, 147);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(294, 173);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(206, 20);
            this.textBox7.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "расчет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "1-ая точка пробоотбора (км) ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "2-ая точка пробоотбора (км) ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Расстояние между точками (км) ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(297, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Начало интервала";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(406, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Конец интервала";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(561, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Вы выбрали режим работы с данными за 2016 год , ниже уже проставлены нужные вам з" +
    "начения значения ";
            this.label15.Visible = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 409);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.Text = "ЭКСПЕРИМЕНТ (Монодисп.сл.)";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worldsideBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probtestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probtest2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private pointsdataDataSet6 pointsdataDataSet6;
        private System.Windows.Forms.BindingSource worldsideBindingSource;
        private pointsdataDataSet6TableAdapters.worldsideTableAdapter worldsideTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
        private pointsdataDataSet1 pointsdataDataSet1;
        private System.Windows.Forms.BindingSource probtestBindingSource;
        private pointsdataDataSet1TableAdapters.probtestTableAdapter probtestTableAdapter;
        private System.Windows.Forms.ListBox listBox3;
        private pointsdataDataSet4 pointsdataDataSet4;
        private System.Windows.Forms.BindingSource probtest2BindingSource;
        private pointsdataDataSet4TableAdapters.probtest2TableAdapter probtest2TableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}