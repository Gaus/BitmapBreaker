namespace BitmapBreaker
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
            this.groupBoxSwapColumns = new System.Windows.Forms.GroupBox();
            this.numericColumnJ = new System.Windows.Forms.NumericUpDown();
            this.numericColumnI = new System.Windows.Forms.NumericUpDown();
            this.groupBoxSwapRows = new System.Windows.Forms.GroupBox();
            this.numericRowJ = new System.Windows.Forms.NumericUpDown();
            this.numericRowI = new System.Windows.Forms.NumericUpDown();
            this.groupBoxBitmap = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxSwapColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumnJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumnI)).BeginInit();
            this.groupBoxSwapRows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRowJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRowI)).BeginInit();
            this.groupBoxBitmap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSwapColumns
            // 
            this.groupBoxSwapColumns.Controls.Add(this.numericColumnJ);
            this.groupBoxSwapColumns.Controls.Add(this.numericColumnI);
            this.groupBoxSwapColumns.Location = new System.Drawing.Point(13, 5);
            this.groupBoxSwapColumns.Name = "groupBoxSwapColumns";
            this.groupBoxSwapColumns.Size = new System.Drawing.Size(161, 46);
            this.groupBoxSwapColumns.TabIndex = 1;
            this.groupBoxSwapColumns.TabStop = false;
            this.groupBoxSwapColumns.Text = "Столбцы";
            // 
            // numericColumnJ
            // 
            this.numericColumnJ.Location = new System.Drawing.Point(82, 19);
            this.numericColumnJ.Maximum = new decimal(new int[] {
            899,
            0,
            0,
            0});
            this.numericColumnJ.Name = "numericColumnJ";
            this.numericColumnJ.Size = new System.Drawing.Size(70, 20);
            this.numericColumnJ.TabIndex = 1;
            this.numericColumnJ.TabStop = false;
            this.numericColumnJ.ValueChanged += new System.EventHandler(this.numericColumnJ_ValueChanged);
            // 
            // numericColumnI
            // 
            this.numericColumnI.Location = new System.Drawing.Point(6, 19);
            this.numericColumnI.Maximum = new decimal(new int[] {
            899,
            0,
            0,
            0});
            this.numericColumnI.Name = "numericColumnI";
            this.numericColumnI.Size = new System.Drawing.Size(70, 20);
            this.numericColumnI.TabIndex = 0;
            this.numericColumnI.TabStop = false;
            this.numericColumnI.ValueChanged += new System.EventHandler(this.numericColumnI_ValueChanged);
            // 
            // groupBoxSwapRows
            // 
            this.groupBoxSwapRows.Controls.Add(this.numericRowJ);
            this.groupBoxSwapRows.Controls.Add(this.numericRowI);
            this.groupBoxSwapRows.Location = new System.Drawing.Point(180, 5);
            this.groupBoxSwapRows.Name = "groupBoxSwapRows";
            this.groupBoxSwapRows.Size = new System.Drawing.Size(160, 46);
            this.groupBoxSwapRows.TabIndex = 2;
            this.groupBoxSwapRows.TabStop = false;
            this.groupBoxSwapRows.Text = "Строки";
            // 
            // numericRowJ
            // 
            this.numericRowJ.Location = new System.Drawing.Point(82, 19);
            this.numericRowJ.Maximum = new decimal(new int[] {
            395,
            0,
            0,
            0});
            this.numericRowJ.Name = "numericRowJ";
            this.numericRowJ.Size = new System.Drawing.Size(70, 20);
            this.numericRowJ.TabIndex = 2;
            this.numericRowJ.TabStop = false;
            this.numericRowJ.ValueChanged += new System.EventHandler(this.numericRowJ_ValueChanged);
            // 
            // numericRowI
            // 
            this.numericRowI.Location = new System.Drawing.Point(6, 19);
            this.numericRowI.Maximum = new decimal(new int[] {
            395,
            0,
            0,
            0});
            this.numericRowI.Name = "numericRowI";
            this.numericRowI.Size = new System.Drawing.Size(70, 20);
            this.numericRowI.TabIndex = 1;
            this.numericRowI.TabStop = false;
            this.numericRowI.ValueChanged += new System.EventHandler(this.numericRowI_ValueChanged);
            // 
            // groupBoxBitmap
            // 
            this.groupBoxBitmap.Controls.Add(this.pictureBox);
            this.groupBoxBitmap.Location = new System.Drawing.Point(13, 58);
            this.groupBoxBitmap.Name = "groupBoxBitmap";
            this.groupBoxBitmap.Size = new System.Drawing.Size(913, 424);
            this.groupBoxBitmap.TabIndex = 3;
            this.groupBoxBitmap.TabStop = false;
            this.groupBoxBitmap.Text = "Изображение";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::BitmapBreaker.Properties.Resources.outfile900_2;
            this.pictureBox.Location = new System.Drawing.Point(6, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(900, 396);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 486);
            this.Controls.Add(this.groupBoxBitmap);
            this.Controls.Add(this.groupBoxSwapRows);
            this.Controls.Add(this.groupBoxSwapColumns);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BitmapBreaker";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.groupBoxSwapColumns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericColumnJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumnI)).EndInit();
            this.groupBoxSwapRows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericRowJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRowI)).EndInit();
            this.groupBoxBitmap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBoxSwapColumns;
        private System.Windows.Forms.NumericUpDown numericColumnJ;
        private System.Windows.Forms.NumericUpDown numericColumnI;
        private System.Windows.Forms.GroupBox groupBoxSwapRows;
        private System.Windows.Forms.NumericUpDown numericRowJ;
        private System.Windows.Forms.NumericUpDown numericRowI;
        private System.Windows.Forms.GroupBox groupBoxBitmap;
    }
}

