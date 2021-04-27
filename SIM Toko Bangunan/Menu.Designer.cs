namespace SIM_Toko_Bangunan
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Kasir = new System.Windows.Forms.Button();
            this.Pegawai = new System.Windows.Forms.Button();
            this.Stok = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kasir
            // 
            this.Kasir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Kasir.BackColor = System.Drawing.Color.Snow;
            this.Kasir.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kasir.Image = ((System.Drawing.Image)(resources.GetObject("Kasir.Image")));
            this.Kasir.Location = new System.Drawing.Point(428, 86);
            this.Kasir.Name = "Kasir";
            this.Kasir.Size = new System.Drawing.Size(495, 163);
            this.Kasir.TabIndex = 0;
            this.Kasir.Text = "Kasir";
            this.Kasir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Kasir.UseVisualStyleBackColor = false;
            this.Kasir.Click += new System.EventHandler(this.Kasir_Click);
            // 
            // Pegawai
            // 
            this.Pegawai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pegawai.BackColor = System.Drawing.Color.LightGreen;
            this.Pegawai.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pegawai.Image = ((System.Drawing.Image)(resources.GetObject("Pegawai.Image")));
            this.Pegawai.Location = new System.Drawing.Point(721, 256);
            this.Pegawai.Name = "Pegawai";
            this.Pegawai.Size = new System.Drawing.Size(202, 162);
            this.Pegawai.TabIndex = 1;
            this.Pegawai.Text = "Pegawai";
            this.Pegawai.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Pegawai.UseVisualStyleBackColor = false;
            this.Pegawai.Click += new System.EventHandler(this.Pegawai_Click);
            // 
            // Stok
            // 
            this.Stok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stok.BackColor = System.Drawing.Color.Linen;
            this.Stok.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stok.Image = ((System.Drawing.Image)(resources.GetObject("Stok.Image")));
            this.Stok.Location = new System.Drawing.Point(428, 255);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(287, 163);
            this.Stok.TabIndex = 2;
            this.Stok.Text = "Gudang";
            this.Stok.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Stok.UseVisualStyleBackColor = false;
            this.Stok.Click += new System.EventHandler(this.Stok_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(802, 424);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 113);
            this.Exit.TabIndex = 4;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.Aquamarine;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 100;
            this.iconButton1.Location = new System.Drawing.Point(428, 424);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(368, 113);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Informasi";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(342, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 92);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toko Bangunan Adi Jaya";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1313, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Pegawai);
            this.Controls.Add(this.Kasir);
            this.Controls.Add(this.Stok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kasir;
        private System.Windows.Forms.Button Pegawai;
        private System.Windows.Forms.Button Stok;
        private System.Windows.Forms.Button Exit;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
    }
}