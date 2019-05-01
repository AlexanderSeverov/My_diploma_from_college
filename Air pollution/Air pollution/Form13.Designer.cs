namespace Air_pollution
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.button1 = new System.Windows.Forms.Button();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.isoSurface1 = new Steema.TeeChart.Styles.IsoSurface();
            this.dataSet11 = new Air_pollution.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Расчет поля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 100;
            this.tChart1.Aspect.ColorPaletteIndex = 20;
            // 
            // 
            // 
            this.tChart1.Axes.Automatic = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.DrawEvery = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            this.tChart1.Axes.Bottom.Labels.ShapePolygonBounds = null;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Empty;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Bottom.Title.Font.Size = 11;
            this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.tChart1.Axes.Bottom.Title.ShapePolygonBounds = null;
            this.tChart1.Axes.Bottom.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.ShapePolygonBounds = null;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.ShapePolygonBounds = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.ShapePolygonBounds = null;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.ShapePolygonBounds = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.DrawEvery = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
            this.tChart1.Axes.Left.Labels.Font.Size = 9;
            this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.tChart1.Axes.Left.Labels.ShapePolygonBounds = null;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Left.Title.Font.Size = 11;
            this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            this.tChart1.Axes.Left.Title.ShapePolygonBounds = null;
            this.tChart1.Axes.Left.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Right.Labels.Font.Size = 9;
            this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.tChart1.Axes.Right.Labels.ShapePolygonBounds = null;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.ShapePolygonBounds = null;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Top.Labels.Font.Size = 9;
            this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.tChart1.Axes.Top.Labels.ShapePolygonBounds = null;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.ShapePolygonBounds = null;
            this.tChart1.CurrentTheme = Steema.TeeChart.ThemeType.Report;
            this.tChart1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            this.tChart1.Footer.ShapePolygonBounds = null;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Gray;
            this.tChart1.Header.Font.Size = 12;
            this.tChart1.Header.Font.SizeFloat = 12F;
            this.tChart1.Header.Lines = new string[] {
        "Монодисп.сл."};
            this.tChart1.Header.ShapePolygonBounds = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.tChart1.Legend.Brush.Style = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Legend.Font.Size = 9;
            this.tChart1.Legend.Font.SizeFloat = 9F;
            this.tChart1.Legend.Image = ((System.Drawing.Image)(resources.GetObject("tChart1.Legend.Image")));
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Visible = false;
            this.tChart1.Legend.ShapePolygonBounds = null;
            // 
            // 
            // 
            this.tChart1.Legend.Title.ShapePolygonBounds = null;
            this.tChart1.Legend.Visible = false;
            this.tChart1.Location = new System.Drawing.Point(37, 34);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.Visible = false;
            // 
            // 
            // 
            this.tChart1.Panel.Pen.Color = System.Drawing.Color.Empty;
            this.tChart1.Panel.Pen.Visible = true;
            this.tChart1.Panel.ShapePolygonBounds = null;
            this.tChart1.Series.Add(this.isoSurface1);
            this.tChart1.Size = new System.Drawing.Size(813, 504);
            // 
            // 
            // 
            this.tChart1.SubFooter.ShapePolygonBounds = null;
            // 
            // 
            // 
            this.tChart1.SubHeader.ShapePolygonBounds = null;
            this.tChart1.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Visible = false;
            this.tChart1.Walls.Back.ShapePolygonBounds = null;
            this.tChart1.Walls.Back.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.Empty;
            this.tChart1.Walls.Bottom.ShapePolygonBounds = null;
            // 
            // 
            // 
            this.tChart1.Walls.Left.ShapePolygonBounds = null;
            // 
            // 
            // 
            this.tChart1.Walls.Right.ShapePolygonBounds = null;
            // 
            // 
            // 
            this.tChart1.Zoom.Animated = true;
            this.tChart1.Zoom.Direction = Steema.TeeChart.ZoomDirections.None;
            this.tChart1.Click += new System.EventHandler(this.tChart1_Click);
            // 
            // isoSurface1
            // 
            // 
            // 
            // 
            this.isoSurface1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.isoSurface1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.isoSurface1.ColorEach = false;
            // 
            // 
            // 
            this.isoSurface1.Legend.ShapePolygonBounds = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.isoSurface1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.isoSurface1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.isoSurface1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.isoSurface1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.isoSurface1.Marks.Brush.Gradient.UseMiddle = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.isoSurface1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            // 
            // 
            // 
            this.isoSurface1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            // 
            // 
            // 
            this.isoSurface1.Marks.Shadow.Visible = false;
            this.isoSurface1.Marks.ShapePolygonBounds = null;
            // 
            // 
            // 
            this.isoSurface1.Marks.Symbol.ShapePolygonBounds = null;
            // 
            // 
            // 
            this.isoSurface1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
            this.isoSurface1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.isoSurface1.Marks.TailParams.Margin = 0F;
            this.isoSurface1.Marks.TailParams.PointerHeight = 5D;
            this.isoSurface1.Marks.TailParams.PointerWidth = 8D;
            this.isoSurface1.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
            this.isoSurface1.OriginalCursor = System.Windows.Forms.Cursors.Default;
            this.isoSurface1.PaletteMin = 0D;
            this.isoSurface1.PaletteStep = 0D;
            this.isoSurface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
            this.isoSurface1.Title = "iso-Surface1";
            this.isoSurface1.UseColorRange = false;
            this.isoSurface1.UseExtendedNumRange = false;
            this.isoSurface1.UsePalette = true;
            this.isoSurface1.UseYPosition = false;
            // 
            // 
            // 
            this.isoSurface1.XValues.DataMember = "y";
            this.isoSurface1.YPosition = 0D;
            // 
            // 
            // 
            this.isoSurface1.YValues.DataMember = "x";
            // 
            // 
            // 
            this.isoSurface1.ZValues.DataMember = "z";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tChart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form13";
            this.Text = "РАСЧЁТ ПОЛЯ (Монодисп.сл.)";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private System.Windows.Forms.Button button1;
        private DataSet1 dataSet11;
        private Steema.TeeChart.Styles.IsoSurface isoSurface1;
    }
}