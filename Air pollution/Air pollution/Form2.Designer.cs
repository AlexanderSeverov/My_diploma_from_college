namespace Air_pollution
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.probtestTableAdapter = new Air_pollution.pointsdataDataSet1TableAdapters.probtestTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.valueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probtest2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointsdataDataSet4 = new Air_pollution.pointsdataDataSet4();
            this.probtest2TableAdapter = new Air_pollution.pointsdataDataSet4TableAdapters.probtest2TableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.valueDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probtest3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointsdataDataSet5 = new Air_pollution.pointsdataDataSet5();
            this.probtest3TableAdapter = new Air_pollution.pointsdataDataSet5TableAdapters.probtest3TableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polarvalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointsdataDataSet3 = new Air_pollution.pointsdataDataSet3();
            this.polarvalueTableAdapter = new Air_pollution.pointsdataDataSet3TableAdapters.polarvalueTableAdapter();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worldsideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointsdataDataSet6 = new Air_pollution.pointsdataDataSet6();
            this.worldsideTableAdapter = new Air_pollution.pointsdataDataSet6TableAdapters.worldsideTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pointsdataDataSet1 = new Air_pollution.pointsdataDataSet1();
            this.probtestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probtest2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probtest3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polarvalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldsideBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probtestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить изменения ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // probtestTableAdapter
            // 
            this.probtestTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1 проба";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valueDataGridViewTextBoxColumn1,
            this.stepDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.probtest2BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 226);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 165);
            this.dataGridView3.TabIndex = 7;
            // 
            // valueDataGridViewTextBoxColumn1
            // 
            this.valueDataGridViewTextBoxColumn1.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn1.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn1.Name = "valueDataGridViewTextBoxColumn1";
            // 
            // stepDataGridViewTextBoxColumn1
            // 
            this.stepDataGridViewTextBoxColumn1.DataPropertyName = "step";
            this.stepDataGridViewTextBoxColumn1.HeaderText = "step";
            this.stepDataGridViewTextBoxColumn1.Name = "stepDataGridViewTextBoxColumn1";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "2 проба";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valueDataGridViewTextBoxColumn2,
            this.stepDataGridViewTextBoxColumn2});
            this.dataGridView4.DataSource = this.probtest3BindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(280, 226);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(231, 165);
            this.dataGridView4.TabIndex = 9;
            // 
            // valueDataGridViewTextBoxColumn2
            // 
            this.valueDataGridViewTextBoxColumn2.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn2.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn2.Name = "valueDataGridViewTextBoxColumn2";
            // 
            // stepDataGridViewTextBoxColumn2
            // 
            this.stepDataGridViewTextBoxColumn2.DataPropertyName = "step";
            this.stepDataGridViewTextBoxColumn2.HeaderText = "step";
            this.stepDataGridViewTextBoxColumn2.Name = "stepDataGridViewTextBoxColumn2";
            // 
            // probtest3BindingSource
            // 
            this.probtest3BindingSource.DataMember = "probtest3";
            this.probtest3BindingSource.DataSource = this.pointsdataDataSet5;
            // 
            // pointsdataDataSet5
            // 
            this.pointsdataDataSet5.DataSetName = "pointsdataDataSet5";
            this.pointsdataDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // probtest3TableAdapter
            // 
            this.probtest3TableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "3 проба";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Полярные значения розы";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn3});
            this.dataGridView5.DataSource = this.polarvalueBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(556, 30);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(240, 361);
            this.dataGridView5.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn3
            // 
            this.valueDataGridViewTextBoxColumn3.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn3.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn3.Name = "valueDataGridViewTextBoxColumn3";
            // 
            // polarvalueBindingSource
            // 
            this.polarvalueBindingSource.DataMember = "polarvalue";
            this.polarvalueBindingSource.DataSource = this.pointsdataDataSet3;
            // 
            // pointsdataDataSet3
            // 
            this.pointsdataDataSet3.DataSetName = "pointsdataDataSet3";
            this.pointsdataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // polarvalueTableAdapter
            // 
            this.polarvalueTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.sideDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.worldsideBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(12, 428);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(240, 240);
            this.dataGridView6.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // sideDataGridViewTextBoxColumn
            // 
            this.sideDataGridViewTextBoxColumn.DataPropertyName = "side";
            this.sideDataGridViewTextBoxColumn.HeaderText = "side";
            this.sideDataGridViewTextBoxColumn.Name = "sideDataGridViewTextBoxColumn";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Стороны света";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valueDataGridViewTextBoxColumn,
            this.stepDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.probtestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(300, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 176);
            this.dataGridView1.TabIndex = 15;
            // 
            // pointsdataDataSet1
            // 
            this.pointsdataDataSet1.DataSetName = "pointsdataDataSet1";
            this.pointsdataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // probtestBindingSource
            // 
            this.probtestBindingSource.DataMember = "probtest";
            this.probtestBindingSource.DataSource = this.pointsdataDataSet1;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // stepDataGridViewTextBoxColumn
            // 
            this.stepDataGridViewTextBoxColumn.DataPropertyName = "step";
            this.stepDataGridViewTextBoxColumn.HeaderText = "step";
            this.stepDataGridViewTextBoxColumn.Name = "stepDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 725);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Редактирование базы данных";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probtest2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probtest3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polarvalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldsideBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsdataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probtestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private pointsdataDataSet1TableAdapters.probtestTableAdapter probtestTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private pointsdataDataSet4 pointsdataDataSet4;
        private System.Windows.Forms.BindingSource probtest2BindingSource;
        private pointsdataDataSet4TableAdapters.probtest2TableAdapter probtest2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private pointsdataDataSet5 pointsdataDataSet5;
        private System.Windows.Forms.BindingSource probtest3BindingSource;
        private pointsdataDataSet5TableAdapters.probtest3TableAdapter probtest3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private pointsdataDataSet3 pointsdataDataSet3;
        private System.Windows.Forms.BindingSource polarvalueBindingSource;
        private pointsdataDataSet3TableAdapters.polarvalueTableAdapter polarvalueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView6;
        private pointsdataDataSet6 pointsdataDataSet6;
        private System.Windows.Forms.BindingSource worldsideBindingSource;
        private pointsdataDataSet6TableAdapters.worldsideTableAdapter worldsideTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sideDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private pointsdataDataSet1 pointsdataDataSet1;
        private System.Windows.Forms.BindingSource probtestBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepDataGridViewTextBoxColumn;
    }
}
