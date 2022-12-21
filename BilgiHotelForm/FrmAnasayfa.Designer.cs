namespace BilgiHotelForm
{
    partial class FrmAnasayfa
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
			System.Windows.Forms.ToolStrip toolStrip1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.müsteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
			this.misafirEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
			this.odaBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
			this.rezervasyonBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSplitButton5 = new System.Windows.Forms.ToolStripSplitButton();
			this.satışBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			toolStrip1 = new System.Windows.Forms.ToolStrip();
			toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.BackColor = System.Drawing.Color.Teal;
			toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
			toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripSplitButton4,
            this.toolStripSplitButton5});
			toolStrip1.Location = new System.Drawing.Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new System.Drawing.Size(133, 760);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müsteriEkleToolStripMenuItem});
			this.toolStripSplitButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.toolStripSplitButton1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
			this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(130, 84);
			this.toolStripSplitButton1.Text = "Müsteriler";
			this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// müsteriEkleToolStripMenuItem
			// 
			this.müsteriEkleToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
			this.müsteriEkleToolStripMenuItem.Name = "müsteriEkleToolStripMenuItem";
			this.müsteriEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.müsteriEkleToolStripMenuItem.Text = "Müsteri Ekle";
			this.müsteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müsteriEkleToolStripMenuItem_Click);
			// 
			// toolStripSplitButton2
			// 
			this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misafirEkleToolStripMenuItem});
			this.toolStripSplitButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
			this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton2.Name = "toolStripSplitButton2";
			this.toolStripSplitButton2.Size = new System.Drawing.Size(130, 70);
			this.toolStripSplitButton2.Text = "Misafirler";
			this.toolStripSplitButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// misafirEkleToolStripMenuItem
			// 
			this.misafirEkleToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
			this.misafirEkleToolStripMenuItem.Name = "misafirEkleToolStripMenuItem";
			this.misafirEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.misafirEkleToolStripMenuItem.Text = "Misafir Ekle";
			this.misafirEkleToolStripMenuItem.Click += new System.EventHandler(this.misafirEkleToolStripMenuItem_Click);
			// 
			// toolStripSplitButton3
			// 
			this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaBilgileriToolStripMenuItem});
			this.toolStripSplitButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
			this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton3.Name = "toolStripSplitButton3";
			this.toolStripSplitButton3.Size = new System.Drawing.Size(130, 70);
			this.toolStripSplitButton3.Text = "Odalar";
			this.toolStripSplitButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// odaBilgileriToolStripMenuItem
			// 
			this.odaBilgileriToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
			this.odaBilgileriToolStripMenuItem.Name = "odaBilgileriToolStripMenuItem";
			this.odaBilgileriToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.odaBilgileriToolStripMenuItem.Text = "Oda Bilgileri";
			this.odaBilgileriToolStripMenuItem.Click += new System.EventHandler(this.odaBilgileriToolStripMenuItem_Click);
			// 
			// toolStripSplitButton4
			// 
			this.toolStripSplitButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonBilgileriToolStripMenuItem});
			this.toolStripSplitButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
			this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton4.Name = "toolStripSplitButton4";
			this.toolStripSplitButton4.Size = new System.Drawing.Size(130, 70);
			this.toolStripSplitButton4.Text = "Rezervasyonlar";
			this.toolStripSplitButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// rezervasyonBilgileriToolStripMenuItem
			// 
			this.rezervasyonBilgileriToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
			this.rezervasyonBilgileriToolStripMenuItem.Name = "rezervasyonBilgileriToolStripMenuItem";
			this.rezervasyonBilgileriToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			this.rezervasyonBilgileriToolStripMenuItem.Text = "Rezervasyon Bilgileri";
			this.rezervasyonBilgileriToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonBilgileriToolStripMenuItem_Click);
			// 
			// toolStripSplitButton5
			// 
			this.toolStripSplitButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışBilgileriToolStripMenuItem});
			this.toolStripSplitButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.toolStripSplitButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton5.Image")));
			this.toolStripSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton5.Name = "toolStripSplitButton5";
			this.toolStripSplitButton5.Size = new System.Drawing.Size(130, 70);
			this.toolStripSplitButton5.Text = "Satışlar";
			this.toolStripSplitButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// satışBilgileriToolStripMenuItem
			// 
			this.satışBilgileriToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
			this.satışBilgileriToolStripMenuItem.Name = "satışBilgileriToolStripMenuItem";
			this.satışBilgileriToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.satışBilgileriToolStripMenuItem.Text = "Satış Bilgileri";
			// 
			// FrmAnasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1314, 760);
			this.Controls.Add(toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.IsMdiContainer = true;
			this.Name = "FrmAnasayfa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmAnasayfa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem müsteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem misafirEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem odaBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton5;
        private System.Windows.Forms.ToolStripMenuItem satışBilgileriToolStripMenuItem;
    }
}