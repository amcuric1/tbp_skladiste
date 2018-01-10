namespace TBP
{
    partial class frmPrikazDokumenataUlaza
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnDodajDokument = new System.Windows.Forms.Button();
            this.lblPopisDokumentaUlaza = new System.Windows.Forms.Label();
            this.dgvDokumentiUlaza = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumentiUlaza)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDetalji);
            this.panel1.Controls.Add(this.btnDodajDokument);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 79);
            this.panel1.TabIndex = 7;
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.Color.LightGray;
            this.btnDetalji.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetalji.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalji.ForeColor = System.Drawing.Color.Black;
            this.btnDetalji.Location = new System.Drawing.Point(218, 20);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(144, 35);
            this.btnDetalji.TabIndex = 31;
            this.btnDetalji.Text = "Prikaži detalje";
            this.btnDetalji.UseVisualStyleBackColor = false;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            this.btnDetalji.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnDetalji.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // btnDodajDokument
            // 
            this.btnDodajDokument.BackColor = System.Drawing.Color.LightGray;
            this.btnDodajDokument.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajDokument.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajDokument.ForeColor = System.Drawing.Color.Black;
            this.btnDodajDokument.Location = new System.Drawing.Point(388, 20);
            this.btnDodajDokument.Name = "btnDodajDokument";
            this.btnDodajDokument.Size = new System.Drawing.Size(144, 35);
            this.btnDodajDokument.TabIndex = 1;
            this.btnDodajDokument.Text = "Dodaj dokument";
            this.btnDodajDokument.UseVisualStyleBackColor = false;
            this.btnDodajDokument.Click += new System.EventHandler(this.btnDodajDokument_Click);
            this.btnDodajDokument.MouseEnter += new System.EventHandler(this.bojanje);
            this.btnDodajDokument.MouseLeave += new System.EventHandler(this.micanjeBoje);
            // 
            // lblPopisDokumentaUlaza
            // 
            this.lblPopisDokumentaUlaza.AutoSize = true;
            this.lblPopisDokumentaUlaza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisDokumentaUlaza.ForeColor = System.Drawing.Color.Black;
            this.lblPopisDokumentaUlaza.Location = new System.Drawing.Point(34, 38);
            this.lblPopisDokumentaUlaza.Name = "lblPopisDokumentaUlaza";
            this.lblPopisDokumentaUlaza.Size = new System.Drawing.Size(206, 21);
            this.lblPopisDokumentaUlaza.TabIndex = 6;
            this.lblPopisDokumentaUlaza.Text = "Popis dokumenata ulaza:";
            // 
            // dgvDokumentiUlaza
            // 
            this.dgvDokumentiUlaza.AllowUserToAddRows = false;
            this.dgvDokumentiUlaza.AllowUserToDeleteRows = false;
            this.dgvDokumentiUlaza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDokumentiUlaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDokumentiUlaza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.dgvDokumentiUlaza.Location = new System.Drawing.Point(38, 62);
            this.dgvDokumentiUlaza.MultiSelect = false;
            this.dgvDokumentiUlaza.Name = "dgvDokumentiUlaza";
            this.dgvDokumentiUlaza.ReadOnly = true;
            this.dgvDokumentiUlaza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDokumentiUlaza.Size = new System.Drawing.Size(679, 330);
            this.dgvDokumentiUlaza.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Naziv";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Datum";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 63;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "IdZaposlenik";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Zaposlenik";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "IdPartnera";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Poslovni partner";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // frmPrikazDokumenataUlaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPopisDokumentaUlaza);
            this.Controls.Add(this.dgvDokumentiUlaza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrikazDokumenataUlaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDokumentUlaza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrikazDokumenataUlaza_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumentiUlaza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDodajDokument;
        private System.Windows.Forms.Label lblPopisDokumentaUlaza;
        private System.Windows.Forms.DataGridView dgvDokumentiUlaza;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}