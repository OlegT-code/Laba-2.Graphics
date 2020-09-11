namespace CompGraphics_Laba2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPixel = new System.Windows.Forms.Button();
            this.btnMills = new System.Windows.Forms.Button();
            this.Inches = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPixel
            // 
            this.btnPixel.Location = new System.Drawing.Point(88, 480);
            this.btnPixel.Name = "btnPixel";
            this.btnPixel.Size = new System.Drawing.Size(100, 50);
            this.btnPixel.TabIndex = 1;
            this.btnPixel.Text = "Pixels";
            this.btnPixel.UseVisualStyleBackColor = true;
            this.btnPixel.Click += new System.EventHandler(this.btnPixel_Click);
            // 
            // btnMills
            // 
            this.btnMills.Location = new System.Drawing.Point(288, 480);
            this.btnMills.Name = "btnMills";
            this.btnMills.Size = new System.Drawing.Size(100, 50);
            this.btnMills.TabIndex = 2;
            this.btnMills.Text = "Millimeters";
            this.btnMills.UseVisualStyleBackColor = true;
            this.btnMills.Click += new System.EventHandler(this.btnMills_Click);
            // 
            // Inches
            // 
            this.Inches.Location = new System.Drawing.Point(546, 480);
            this.Inches.Name = "Inches";
            this.Inches.Size = new System.Drawing.Size(100, 50);
            this.Inches.TabIndex = 3;
            this.Inches.Text = "Inches";
            this.Inches.UseVisualStyleBackColor = true;
            this.Inches.Click += new System.EventHandler(this.Inches_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(748, 480);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 50);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.Inches);
            this.Controls.Add(this.btnMills);
            this.Controls.Add(this.btnPixel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPixel;
        private System.Windows.Forms.Button btnMills;
        private System.Windows.Forms.Button Inches;
        private System.Windows.Forms.Button btnClear;
    }
}

