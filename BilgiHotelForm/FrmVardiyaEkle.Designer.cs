namespace BilgiHotelForm
{
    partial class FrmVardiyaEkle
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
            this.lvvardiya = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnvarhepsinigetir = new System.Windows.Forms.Button();
            this.btnvarekle = new System.Windows.Forms.Button();
            this.btnvargüncelle = new System.Windows.Forms.Button();
            this.btnvartemizle = new System.Windows.Forms.Button();
            this.btnvargetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvardiyataniminagöregetir = new System.Windows.Forms.TextBox();
            this.vardiyatipi = new System.Windows.Forms.TextBox();
            this.dtpbaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpbitis = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvvardiya
            // 
            this.lvvardiya.BackColor = System.Drawing.Color.Gray;
            this.lvvardiya.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvvardiya.HideSelection = false;
            this.lvvardiya.Location = new System.Drawing.Point(13, 364);
            this.lvvardiya.Margin = new System.Windows.Forms.Padding(4);
            this.lvvardiya.Name = "lvvardiya";
            this.lvvardiya.Size = new System.Drawing.Size(912, 228);
            this.lvvardiya.TabIndex = 67;
            this.lvvardiya.UseCompatibleStateImageBehavior = false;
            this.lvvardiya.View = System.Windows.Forms.View.Details;
            this.lvvardiya.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvvardiya_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vardiya Tipi";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vardiya Başlangıç Saati";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vardiya Bitiş Saati";
            this.columnHeader4.Width = 150;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.dtpbitis, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.vardiyatipi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtvardiyataniminagöregetir, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnvartemizle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnvargüncelle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnvarekle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnvarhepsinigetir, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnvargetir, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpbaslangic, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(892, 236);
            this.tableLayoutPanel1.TabIndex = 68;
            // 
            // btnvarhepsinigetir
            // 
            this.btnvarhepsinigetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnvarhepsinigetir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnvarhepsinigetir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvarhepsinigetir.Location = new System.Drawing.Point(227, 160);
            this.btnvarhepsinigetir.Margin = new System.Windows.Forms.Padding(4);
            this.btnvarhepsinigetir.Name = "btnvarhepsinigetir";
            this.btnvarhepsinigetir.Size = new System.Drawing.Size(215, 72);
            this.btnvarhepsinigetir.TabIndex = 70;
            this.btnvarhepsinigetir.Text = "HEPSİNİ GETİR";
            this.btnvarhepsinigetir.UseVisualStyleBackColor = false;
            this.btnvarhepsinigetir.Click += new System.EventHandler(this.btnvarhepsinigetir_Click);
            // 
            // btnvarekle
            // 
            this.btnvarekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnvarekle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnvarekle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvarekle.Location = new System.Drawing.Point(673, 160);
            this.btnvarekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnvarekle.Name = "btnvarekle";
            this.btnvarekle.Size = new System.Drawing.Size(215, 72);
            this.btnvarekle.TabIndex = 71;
            this.btnvarekle.Text = "EKLE";
            this.btnvarekle.UseVisualStyleBackColor = false;
            this.btnvarekle.Click += new System.EventHandler(this.btnvarekle_Click);
            // 
            // btnvargüncelle
            // 
            this.btnvargüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnvargüncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnvargüncelle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvargüncelle.Location = new System.Drawing.Point(450, 160);
            this.btnvargüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnvargüncelle.Name = "btnvargüncelle";
            this.btnvargüncelle.Size = new System.Drawing.Size(215, 72);
            this.btnvargüncelle.TabIndex = 72;
            this.btnvargüncelle.Text = "GÜNCELLE";
            this.btnvargüncelle.UseVisualStyleBackColor = false;
            this.btnvargüncelle.Click += new System.EventHandler(this.btnvargüncelle_Click);
            // 
            // btnvartemizle
            // 
            this.btnvartemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnvartemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnvartemizle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvartemizle.Location = new System.Drawing.Point(4, 160);
            this.btnvartemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnvartemizle.Name = "btnvartemizle";
            this.btnvartemizle.Size = new System.Drawing.Size(215, 72);
            this.btnvartemizle.TabIndex = 73;
            this.btnvartemizle.Text = "TEMİZLE";
            this.btnvartemizle.UseVisualStyleBackColor = false;
            this.btnvartemizle.Click += new System.EventHandler(this.btnvartemizle_Click);
            // 
            // btnvargetir
            // 
            this.btnvargetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnvargetir.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvargetir.Location = new System.Drawing.Point(672, 81);
            this.btnvargetir.Name = "btnvargetir";
            this.btnvargetir.Size = new System.Drawing.Size(217, 72);
            this.btnvargetir.TabIndex = 74;
            this.btnvargetir.Text = "GETİR";
            this.btnvargetir.UseVisualStyleBackColor = false;
            this.btnvargetir.Click += new System.EventHandler(this.btnvargetir_Click);
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
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "VardiyaTipi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(227, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 23);
            this.label2.TabIndex = 76;
            this.label2.Text = "VardiyaBaslangicSaati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(450, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 23);
            this.label3.TabIndex = 77;
            this.label3.Text = "VardiyaBitisSaati";
            // 
            // txtvardiyataniminagöregetir
            // 
            this.txtvardiyataniminagöregetir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtvardiyataniminagöregetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtvardiyataniminagöregetir.Location = new System.Drawing.Point(673, 44);
            this.txtvardiyataniminagöregetir.Margin = new System.Windows.Forms.Padding(4);
            this.txtvardiyataniminagöregetir.Name = "txtvardiyataniminagöregetir";
            this.txtvardiyataniminagöregetir.Size = new System.Drawing.Size(215, 30);
            this.txtvardiyataniminagöregetir.TabIndex = 1;
            // 
            // vardiyatipi
            // 
            this.vardiyatipi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vardiyatipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vardiyatipi.Location = new System.Drawing.Point(4, 122);
            this.vardiyatipi.Margin = new System.Windows.Forms.Padding(4);
            this.vardiyatipi.Name = "vardiyatipi";
            this.vardiyatipi.Size = new System.Drawing.Size(215, 30);
            this.vardiyatipi.TabIndex = 1;
            // 
            // dtpbaslangic
            // 
            this.dtpbaslangic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpbaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpbaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpbaslangic.Location = new System.Drawing.Point(226, 123);
            this.dtpbaslangic.Name = "dtpbaslangic";
            this.dtpbaslangic.Size = new System.Drawing.Size(217, 30);
            this.dtpbaslangic.TabIndex = 2;
            // 
            // dtpbitis
            // 
            this.dtpbitis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpbitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpbitis.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpbitis.Location = new System.Drawing.Point(449, 123);
            this.dtpbitis.Name = "dtpbitis";
            this.dtpbitis.Size = new System.Drawing.Size(217, 30);
            this.dtpbitis.TabIndex = 3;
            this.dtpbitis.Value = new System.DateTime(2022, 12, 24, 5, 16, 0, 0);
            // 
            // FrmVardiyaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lvvardiya);
            this.Name = "FrmVardiyaEkle";
            this.Text = "FrmVardiyaEkle";
            this.Load += new System.EventHandler(this.FrmVardiyaEkle_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvvardiya;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnvarhepsinigetir;
        private System.Windows.Forms.Button btnvarekle;
        private System.Windows.Forms.Button btnvargüncelle;
        private System.Windows.Forms.Button btnvartemizle;
        private System.Windows.Forms.Button btnvargetir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpbitis;
        private System.Windows.Forms.TextBox vardiyatipi;
        private System.Windows.Forms.TextBox txtvardiyataniminagöregetir;
        private System.Windows.Forms.DateTimePicker dtpbaslangic;
    }
}