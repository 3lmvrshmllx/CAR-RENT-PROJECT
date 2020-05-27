namespace CAR_RENT.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msDash = new System.Windows.Forms.MenuStrip();
            this.ItemCars = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemClients = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemWorkers = new System.Windows.Forms.ToolStripMenuItem();
            this.CarIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnExOrder = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvLastTenOrders = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReports = new System.Windows.Forms.Button();
            this.msDash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastTenOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // msDash
            // 
            this.msDash.BackColor = System.Drawing.Color.Black;
            this.msDash.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msDash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemCars,
            this.ItemClients,
            this.ItemWorkers});
            this.msDash.Location = new System.Drawing.Point(0, 0);
            this.msDash.Name = "msDash";
            this.msDash.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.msDash.Size = new System.Drawing.Size(1461, 106);
            this.msDash.TabIndex = 0;
            this.msDash.Text = "menuStrip1";
            // 
            // ItemCars
            // 
            this.ItemCars.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemCars.ForeColor = System.Drawing.Color.DarkOrange;
            this.ItemCars.Margin = new System.Windows.Forms.Padding(370, 10, 50, 20);
            this.ItemCars.Name = "ItemCars";
            this.ItemCars.Size = new System.Drawing.Size(88, 36);
            this.ItemCars.Text = "CARS";
            this.ItemCars.Click += new System.EventHandler(this.ItemCars_Click);
            // 
            // ItemClients
            // 
            this.ItemClients.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemClients.ForeColor = System.Drawing.Color.DarkOrange;
            this.ItemClients.Margin = new System.Windows.Forms.Padding(0, 10, 50, 20);
            this.ItemClients.Name = "ItemClients";
            this.ItemClients.Size = new System.Drawing.Size(119, 36);
            this.ItemClients.Text = "CLIENTS";
            this.ItemClients.Click += new System.EventHandler(this.ItemClients_Click);
            // 
            // ItemWorkers
            // 
            this.ItemWorkers.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemWorkers.ForeColor = System.Drawing.Color.DarkOrange;
            this.ItemWorkers.Margin = new System.Windows.Forms.Padding(0, 10, 50, 20);
            this.ItemWorkers.Name = "ItemWorkers";
            this.ItemWorkers.Size = new System.Drawing.Size(140, 36);
            this.ItemWorkers.Text = "WORKERS";
            this.ItemWorkers.Click += new System.EventHandler(this.ItemWorkers_Click);
            // 
            // CarIcon
            // 
            this.CarIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CarIcon.BackgroundImage")));
            this.CarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CarIcon.Location = new System.Drawing.Point(34, 17);
            this.CarIcon.Name = "CarIcon";
            this.CarIcon.Size = new System.Drawing.Size(91, 75);
            this.CarIcon.TabIndex = 2;
            this.CarIcon.TabStop = false;
            this.CarIcon.Click += new System.EventHandler(this.CarIcon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1461, 690);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(558, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "L A S T  1 0  O R D E R S";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNewOrder.FlatAppearance.BorderSize = 0;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.ForeColor = System.Drawing.Color.Black;
            this.btnNewOrder.Location = new System.Drawing.Point(958, 692);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(218, 39);
            this.btnNewOrder.TabIndex = 7;
            this.btnNewOrder.Text = "NEW ORDER";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnExOrder
            // 
            this.btnExOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExOrder.FlatAppearance.BorderSize = 0;
            this.btnExOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExOrder.ForeColor = System.Drawing.Color.Black;
            this.btnExOrder.Location = new System.Drawing.Point(1208, 692);
            this.btnExOrder.Name = "btnExOrder";
            this.btnExOrder.Size = new System.Drawing.Size(218, 39);
            this.btnExOrder.TabIndex = 7;
            this.btnExOrder.Text = "EXPIRED ORDERS";
            this.btnExOrder.UseVisualStyleBackColor = false;
            this.btnExOrder.Click += new System.EventHandler(this.btnExOrder_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Black;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblWelcome.Location = new System.Drawing.Point(628, 160);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(110, 28);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Welcome, ";
            // 
            // dgvLastTenOrders
            // 
            this.dgvLastTenOrders.AllowUserToAddRows = false;
            this.dgvLastTenOrders.AllowUserToDeleteRows = false;
            this.dgvLastTenOrders.AllowUserToResizeColumns = false;
            this.dgvLastTenOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLastTenOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLastTenOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLastTenOrders.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvLastTenOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLastTenOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLastTenOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLastTenOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLastTenOrders.ColumnHeadersHeight = 40;
            this.dgvLastTenOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLastTenOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column11,
            this.Column12});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLastTenOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLastTenOrders.EnableHeadersVisualStyles = false;
            this.dgvLastTenOrders.Location = new System.Drawing.Point(34, 291);
            this.dgvLastTenOrders.Name = "dgvLastTenOrders";
            this.dgvLastTenOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLastTenOrders.RowHeadersVisible = false;
            this.dgvLastTenOrders.RowHeadersWidth = 70;
            this.dgvLastTenOrders.RowTemplate.Height = 24;
            this.dgvLastTenOrders.Size = new System.Drawing.Size(1392, 345);
            this.dgvLastTenOrders.TabIndex = 130;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Id";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "FirstName";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "LastName";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Make";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Model";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Color";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "City";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Engine";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Year";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Price";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "PickUpDate";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "DropOffDate";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnReports.Location = new System.Drawing.Point(34, 692);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(218, 39);
            this.btnReports.TabIndex = 131;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 767);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.dgvLastTenOrders);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExOrder);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CarIcon);
            this.Controls.Add(this.msDash);
            this.MainMenuStrip = this.msDash;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.msDash.ResumeLayout(false);
            this.msDash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastTenOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msDash;
        private System.Windows.Forms.ToolStripMenuItem ItemCars;
        private System.Windows.Forms.ToolStripMenuItem ItemClients;
        private System.Windows.Forms.ToolStripMenuItem ItemWorkers;
        private System.Windows.Forms.PictureBox CarIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnExOrder;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvLastTenOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btnReports;
    }
}