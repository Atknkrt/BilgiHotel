namespace BilgiHotelForm
{
    partial class FrmErkenRezervasyonİndirimi
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.erkrezGünSayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnerkreztemizle = new System.Windows.Forms.Button();
            this.btnerkrezgüncelle = new System.Windows.Forms.Button();
            this.btnerkrezekle = new System.Windows.Forms.Button();
            this.btnerkrezhepsinigetir = new System.Windows.Forms.Button();
            this.lverkenrez = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.erkrezIndirimOrani = new System.Windows.Forms.TextBox();
            this.erkrezTanim = new System.Windows.Forms.TextBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cberkenrezaktifmi = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.31462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.3237F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.90091F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.3782F));
            this.tableLayoutPanel1.Controls.Add(this.erkrezTanim, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.erkrezIndirimOrani, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.erkrezGünSayisi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnerkreztemizle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnerkrezgüncelle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnerkrezekle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnerkrezhepsinigetir, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cberkenrezaktifmi, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1211, 236);
            this.tableLayoutPanel1.TabIndex = 70;
            // 
            // erkrezGünSayisi
            // 
            this.erkrezGünSayisi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.erkrezGünSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkrezGünSayisi.Location = new System.Drawing.Point(4, 122);
            this.erkrezGünSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.erkrezGünSayisi.Name = "erkrezGünSayisi";
            this.erkrezGünSayisi.Size = new System.Drawing.Size(347, 30);
            this.erkrezGünSayisi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(702, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 23);
            this.label3.TabIndex = 77;
            this.label3.Text = "ErkenRezervasyon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(359, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 23);
            this.label2.TabIndex = 76;
            this.label2.Text = "ErkenRezervasyonIndirimOrani";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "ErkenRezervasyonGünSayisi";
            // 
            // btnerkreztemizle
            // 
            this.btnerkreztemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnerkreztemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnerkreztemizle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnerkreztemizle.Location = new System.Drawing.Point(702, 160);
            this.btnerkreztemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnerkreztemizle.Name = "btnerkreztemizle";
            this.btnerkreztemizle.Size = new System.Drawing.Size(233, 72);
            this.btnerkreztemizle.TabIndex = 73;
            this.btnerkreztemizle.Text = "TEMİZLE";
            this.btnerkreztemizle.UseVisualStyleBackColor = false;
            this.btnerkreztemizle.Click += new System.EventHandler(this.btnerkreztemizle_Click);
            // 
            // btnerkrezgüncelle
            // 
            this.btnerkrezgüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnerkrezgüncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnerkrezgüncelle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnerkrezgüncelle.Location = new System.Drawing.Point(359, 160);
            this.btnerkrezgüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnerkrezgüncelle.Name = "btnerkrezgüncelle";
            this.btnerkrezgüncelle.Size = new System.Drawing.Size(335, 72);
            this.btnerkrezgüncelle.TabIndex = 72;
            this.btnerkrezgüncelle.Text = "GÜNCELLE";
            this.btnerkrezgüncelle.UseVisualStyleBackColor = false;
            this.btnerkrezgüncelle.Click += new System.EventHandler(this.btnerkrezgüncelle_Click);
            // 
            // btnerkrezekle
            // 
            this.btnerkrezekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnerkrezekle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnerkrezekle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnerkrezekle.Location = new System.Drawing.Point(943, 160);
            this.btnerkrezekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnerkrezekle.Name = "btnerkrezekle";
            this.btnerkrezekle.Size = new System.Drawing.Size(264, 72);
            this.btnerkrezekle.TabIndex = 71;
            this.btnerkrezekle.Text = "EKLE";
            this.btnerkrezekle.UseVisualStyleBackColor = false;
            this.btnerkrezekle.Click += new System.EventHandler(this.btnerkrezekle_Click);
            // 
            // btnerkrezhepsinigetir
            // 
            this.btnerkrezhepsinigetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnerkrezhepsinigetir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnerkrezhepsinigetir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnerkrezhepsinigetir.Location = new System.Drawing.Point(4, 160);
            this.btnerkrezhepsinigetir.Margin = new System.Windows.Forms.Padding(4);
            this.btnerkrezhepsinigetir.Name = "btnerkrezhepsinigetir";
            this.btnerkrezhepsinigetir.Size = new System.Drawing.Size(347, 72);
            this.btnerkrezhepsinigetir.TabIndex = 70;
            this.btnerkrezhepsinigetir.Text = "HEPSİNİ GETİR";
            this.btnerkrezhepsinigetir.UseVisualStyleBackColor = false;
            this.btnerkrezhepsinigetir.Click += new System.EventHandler(this.btnerkrezhepsinigetir_Click);
            // 
            // lverkenrez
            // 
            this.lverkenrez.BackColor = System.Drawing.Color.Gray;
            this.lverkenrez.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lverkenrez.HideSelection = false;
            this.lverkenrez.Location = new System.Drawing.Point(12, 364);
            this.lverkenrez.Margin = new System.Windows.Forms.Padding(4);
            this.lverkenrez.Name = "lverkenrez";
            this.lverkenrez.Size = new System.Drawing.Size(1018, 345);
            this.lverkenrez.TabIndex = 69;
            this.lverkenrez.UseCompatibleStateImageBehavior = false;
            this.lverkenrez.View = System.Windows.Forms.View.Details;
            this.lverkenrez.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lverkenrez_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ErkenRezervasyonGünSayisi";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ErkenRezervasyonIndirimOrani";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Erken Rezervasyon";
            this.columnHeader4.Width = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(943, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 23);
            this.label4.TabIndex = 80;
            this.label4.Text = "ErkenRezervasyonAktifMi";
            // 
            // erkrezIndirimOrani
            // 
            this.erkrezIndirimOrani.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.erkrezIndirimOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkrezIndirimOrani.Location = new System.Drawing.Point(359, 122);
            this.erkrezIndirimOrani.Margin = new System.Windows.Forms.Padding(4);
            this.erkrezIndirimOrani.Name = "erkrezIndirimOrani";
            this.erkrezIndirimOrani.Size = new System.Drawing.Size(335, 30);
            this.erkrezIndirimOrani.TabIndex = 2;
            // 
            // erkrezTanim
            // 
            this.erkrezTanim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.erkrezTanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkrezTanim.Location = new System.Drawing.Point(702, 122);
            this.erkrezTanim.Margin = new System.Windows.Forms.Padding(4);
            this.erkrezTanim.Name = "erkrezTanim";
            this.erkrezTanim.Size = new System.Drawing.Size(233, 30);
            this.erkrezTanim.TabIndex = 3;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Erken Rezervasyon Aktif Mi";
            this.columnHeader5.Width = 200;
            // 
            // cberkenrezaktifmi
            // 
            this.cberkenrezaktifmi.AutoSize = true;
            this.cberkenrezaktifmi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cberkenrezaktifmi.Location = new System.Drawing.Point(942, 133);
            this.cberkenrezaktifmi.Name = "cberkenrezaktifmi";
            this.cberkenrezaktifmi.Size = new System.Drawing.Size(266, 20);
            this.cberkenrezaktifmi.TabIndex = 4;
            this.cberkenrezaktifmi.Text = "Aktif";
            this.cberkenrezaktifmi.UseVisualStyleBackColor = true;
            // 
            // FrmErkenRezervasyonİndirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 716);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lverkenrez);
            this.Name = "FrmErkenRezervasyonİndirimi";
            this.Text = "FrmErkenRezervasyonİndirimi";
            this.Load += new System.EventHandler(this.FrmErkenRezervasyonİndirimi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox erkrezTanim;
        private System.Windows.Forms.TextBox erkrezIndirimOrani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox erkrezGünSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnerkreztemizle;
        private System.Windows.Forms.Button btnerkrezgüncelle;
        private System.Windows.Forms.Button btnerkrezekle;
        private System.Windows.Forms.Button btnerkrezhepsinigetir;
        private System.Windows.Forms.ListView lverkenrez;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.CheckBox cberkenrezaktifmi;
    }
}