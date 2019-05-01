namespace Air_pollution
{
    partial class Form34
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form34));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iondescpDataSet4 = new Air_pollution.iondescpDataSet4();
            this.fullionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullion_TableAdapter = new Air_pollution.iondescpDataSet4TableAdapters.fullion_TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сульфатымглDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фторидымглDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.хлоридымглDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нитратымглDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iondescpDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.сульфатымглDataGridViewTextBoxColumn,
            this.фторидымглDataGridViewTextBoxColumn,
            this.хлоридымглDataGridViewTextBoxColumn,
            this.нитратымглDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fullionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // iondescpDataSet4
            // 
            this.iondescpDataSet4.DataSetName = "iondescpDataSet4";
            this.iondescpDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fullionBindingSource
            // 
            this.fullionBindingSource.DataMember = "fullion ";
            this.fullionBindingSource.DataSource = this.iondescpDataSet4;
            // 
            // fullion_TableAdapter
            // 
            this.fullion_TableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // сульфатымглDataGridViewTextBoxColumn
            // 
            this.сульфатымглDataGridViewTextBoxColumn.DataPropertyName = "сульфаты (мг/л)";
            this.сульфатымглDataGridViewTextBoxColumn.HeaderText = "сульфаты (мг/л)";
            this.сульфатымглDataGridViewTextBoxColumn.Name = "сульфатымглDataGridViewTextBoxColumn";
            // 
            // фторидымглDataGridViewTextBoxColumn
            // 
            this.фторидымглDataGridViewTextBoxColumn.DataPropertyName = "фториды (мг/л)";
            this.фторидымглDataGridViewTextBoxColumn.HeaderText = "фториды (мг/л)";
            this.фторидымглDataGridViewTextBoxColumn.Name = "фторидымглDataGridViewTextBoxColumn";
            // 
            // хлоридымглDataGridViewTextBoxColumn
            // 
            this.хлоридымглDataGridViewTextBoxColumn.DataPropertyName = "хлориды (мг/л)";
            this.хлоридымглDataGridViewTextBoxColumn.HeaderText = "хлориды (мг/л)";
            this.хлоридымглDataGridViewTextBoxColumn.Name = "хлоридымглDataGridViewTextBoxColumn";
            // 
            // нитратымглDataGridViewTextBoxColumn
            // 
            this.нитратымглDataGridViewTextBoxColumn.DataPropertyName = "нитраты (мг/л)";
            this.нитратымглDataGridViewTextBoxColumn.HeaderText = "нитраты (мг/л)";
            this.нитратымглDataGridViewTextBoxColumn.Name = "нитратымглDataGridViewTextBoxColumn";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(356, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Вернуться к выбору";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(496, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Заврешить работу";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(103, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Вернуться к основному меню";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Печать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Данные";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form34
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 431);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form34";
            this.Text = "Form34";
            this.Load += new System.EventHandler(this.Form34_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iondescpDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private iondescpDataSet4 iondescpDataSet4;
        private System.Windows.Forms.BindingSource fullionBindingSource;
        private iondescpDataSet4TableAdapters.fullion_TableAdapter fullion_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сульфатымглDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фторидымглDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn хлоридымглDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn нитратымглDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}