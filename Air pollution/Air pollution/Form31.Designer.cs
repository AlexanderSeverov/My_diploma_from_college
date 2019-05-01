namespace Air_pollution
{
    partial class Form31
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form31));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.osadkDataSet6 = new Air_pollution.osadkDataSet6();
            this.osadknezzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osadknezzTableAdapter = new Air_pollution.osadkDataSet6TableAdapters.osadknezzTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расстояниеОтЗаводаКмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.весСнеговойПробыКгDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.весОсадкаКгDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.удельноеСодержаниеОсадкаВСнегеМкгкгDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.распределениеОсадкаВСнегеГм2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osadkDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osadknezzBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.расстояниеОтЗаводаКмDataGridViewTextBoxColumn,
            this.весСнеговойПробыКгDataGridViewTextBoxColumn,
            this.весОсадкаКгDataGridViewTextBoxColumn,
            this.удельноеСодержаниеОсадкаВСнегеМкгкгDataGridViewTextBoxColumn,
            this.распределениеОсадкаВСнегеГм2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.osadknezzBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(829, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(409, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Вернуться к выбору";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(549, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Заврешить работу";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(156, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Вернуться к основному меню";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Печать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Данные";
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
            // osadkDataSet6
            // 
            this.osadkDataSet6.DataSetName = "osadkDataSet6";
            this.osadkDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // osadknezzBindingSource
            // 
            this.osadknezzBindingSource.DataMember = "osadknezz";
            this.osadknezzBindingSource.DataSource = this.osadkDataSet6;
            // 
            // osadknezzTableAdapter
            // 
            this.osadknezzTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // расстояниеОтЗаводаКмDataGridViewTextBoxColumn
            // 
            this.расстояниеОтЗаводаКмDataGridViewTextBoxColumn.DataPropertyName = "Расстояние от завода, км";
            this.расстояниеОтЗаводаКмDataGridViewTextBoxColumn.HeaderText = "Расстояние от завода, км";
            this.расстояниеОтЗаводаКмDataGridViewTextBoxColumn.Name = "расстояниеОтЗаводаКмDataGridViewTextBoxColumn";
            // 
            // весСнеговойПробыКгDataGridViewTextBoxColumn
            // 
            this.весСнеговойПробыКгDataGridViewTextBoxColumn.DataPropertyName = "Вес снеговой пробы, кг";
            this.весСнеговойПробыКгDataGridViewTextBoxColumn.HeaderText = "Вес снеговой пробы, кг";
            this.весСнеговойПробыКгDataGridViewTextBoxColumn.Name = "весСнеговойПробыКгDataGridViewTextBoxColumn";
            // 
            // весОсадкаКгDataGridViewTextBoxColumn
            // 
            this.весОсадкаКгDataGridViewTextBoxColumn.DataPropertyName = "Вес осадка, кг";
            this.весОсадкаКгDataGridViewTextBoxColumn.HeaderText = "Вес осадка, кг";
            this.весОсадкаКгDataGridViewTextBoxColumn.Name = "весОсадкаКгDataGridViewTextBoxColumn";
            // 
            // удельноеСодержаниеОсадкаВСнегеМкгкгDataGridViewTextBoxColumn
            // 
            this.удельноеСодержаниеОсадкаВСнегеМкгкгDataGridViewTextBoxColumn.DataPropertyName = "Удельное содержание осадка в снеге, мкг/кг";
            this.удельноеСодержаниеОсадкаВСнегеМкгкгDataGridViewTextBoxColumn.HeaderText = "Удельное содержание осадка в снеге, мкг/кг";
            this.удельноеСодержаниеОсадкаВСнегеМкгкгDataGridViewTextBoxColumn.Name = "удельноеСодержаниеОсадкаВСнегеМкгкгDataGridViewTextBoxColumn";
            // 
            // распределениеОсадкаВСнегеГм2DataGridViewTextBoxColumn
            // 
            this.распределениеОсадкаВСнегеГм2DataGridViewTextBoxColumn.DataPropertyName = "Распределение осадка в снеге, г/м2";
            this.распределениеОсадкаВСнегеГм2DataGridViewTextBoxColumn.HeaderText = "Распределение осадка в снеге, г/м2";
            this.распределениеОсадкаВСнегеГм2DataGridViewTextBoxColumn.Name = "распределениеОсадкаВСнегеГм2DataGridViewTextBoxColumn";
            // 
            // Form31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 447);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form31";
            this.Text = "Осадок НЭЗ";
            this.Load += new System.EventHandler(this.Form31_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osadkDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osadknezzBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private osadkDataSet6 osadkDataSet6;
        private System.Windows.Forms.BindingSource osadknezzBindingSource;
        private osadkDataSet6TableAdapters.osadknezzTableAdapter osadknezzTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расстояниеОтЗаводаКмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn весСнеговойПробыКгDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn весОсадкаКгDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn удельноеСодержаниеОсадкаВСнегеМкгкгDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn распределениеОсадкаВСнегеГм2DataGridViewTextBoxColumn;
    }
}