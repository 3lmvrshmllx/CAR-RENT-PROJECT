namespace CAR_RENT
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.btnLgnForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLgnForm
            // 
            this.btnLgnForm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLgnForm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLgnForm.FlatAppearance.BorderSize = 0;
            this.btnLgnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLgnForm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLgnForm.ForeColor = System.Drawing.Color.Black;
            this.btnLgnForm.Location = new System.Drawing.Point(271, 622);
            this.btnLgnForm.Name = "btnLgnForm";
            this.btnLgnForm.Size = new System.Drawing.Size(509, 62);
            this.btnLgnForm.TabIndex = 0;
            this.btnLgnForm.Text = "W E L C O M E";
            this.btnLgnForm.UseVisualStyleBackColor = false;
            this.btnLgnForm.Click += new System.EventHandler(this.btnLgnForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(242, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 524);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1049, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLgnForm);
            this.DoubleBuffered = true;
            this.Name = "Welcome";
            this.Text = "WELCOME";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Welcome_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLgnForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

