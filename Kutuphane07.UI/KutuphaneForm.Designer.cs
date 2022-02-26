namespace Kutuphane07.UI
{
    partial class KutuphaneForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiHesabim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBagisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTurler = new System.Windows.Forms.ComboBox();
            this.dgvKitapDetaylari = new System.Windows.Forms.DataGridView();
            this.btnSeciliKitabıOduncAl = new System.Windows.Forms.Button();
            this.btnSeciliKitabiSil = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapDetaylari)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHesabim,
            this.tsmiBagisYap,
            this.tsmiCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiHesabim
            // 
            this.tsmiHesabim.Name = "tsmiHesabim";
            this.tsmiHesabim.Size = new System.Drawing.Size(71, 21);
            this.tsmiHesabim.Text = "Hesabım";
            this.tsmiHesabim.Click += new System.EventHandler(this.tsmiHesabim_Click);
            // 
            // tsmiBagisYap
            // 
            this.tsmiBagisYap.Name = "tsmiBagisYap";
            this.tsmiBagisYap.Size = new System.Drawing.Size(76, 21);
            this.tsmiBagisYap.Text = "Bağış Yap";
            this.tsmiBagisYap.Click += new System.EventHandler(this.tsmiBagisYap_Click);
            // 
            // tsmiCikis
            // 
            this.tsmiCikis.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiCikis.Name = "tsmiCikis";
            this.tsmiCikis.Size = new System.Drawing.Size(71, 21);
            this.tsmiCikis.Text = "Çıkış Yap";
            this.tsmiCikis.Click += new System.EventHandler(this.tsmiCikis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(41, 28);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(165, 20);
            this.txtAra.TabIndex = 2;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Türler";
            // 
            // cboTurler
            // 
            this.cboTurler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTurler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurler.FormattingEnabled = true;
            this.cboTurler.Location = new System.Drawing.Point(495, 28);
            this.cboTurler.Name = "cboTurler";
            this.cboTurler.Size = new System.Drawing.Size(121, 21);
            this.cboTurler.TabIndex = 3;
            this.cboTurler.SelectedIndexChanged += new System.EventHandler(this.cboTurler_SelectedIndexChanged);
            // 
            // dgvKitapDetaylari
            // 
            this.dgvKitapDetaylari.AllowUserToAddRows = false;
            this.dgvKitapDetaylari.AllowUserToDeleteRows = false;
            this.dgvKitapDetaylari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKitapDetaylari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitapDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitapDetaylari.Location = new System.Drawing.Point(15, 55);
            this.dgvKitapDetaylari.MultiSelect = false;
            this.dgvKitapDetaylari.Name = "dgvKitapDetaylari";
            this.dgvKitapDetaylari.ReadOnly = true;
            this.dgvKitapDetaylari.RowHeadersVisible = false;
            this.dgvKitapDetaylari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitapDetaylari.Size = new System.Drawing.Size(601, 224);
            this.dgvKitapDetaylari.TabIndex = 4;
            // 
            // btnSeciliKitabıOduncAl
            // 
            this.btnSeciliKitabıOduncAl.Location = new System.Drawing.Point(213, 26);
            this.btnSeciliKitabıOduncAl.Name = "btnSeciliKitabıOduncAl";
            this.btnSeciliKitabıOduncAl.Size = new System.Drawing.Size(117, 23);
            this.btnSeciliKitabıOduncAl.TabIndex = 5;
            this.btnSeciliKitabıOduncAl.Text = "Seçili Kitabı Ödünç Al";
            this.btnSeciliKitabıOduncAl.UseVisualStyleBackColor = true;
            this.btnSeciliKitabıOduncAl.Click += new System.EventHandler(this.btnSeciliKitabıOduncAl_Click);
            // 
            // btnSeciliKitabiSil
            // 
            this.btnSeciliKitabiSil.Location = new System.Drawing.Point(336, 26);
            this.btnSeciliKitabiSil.Name = "btnSeciliKitabiSil";
            this.btnSeciliKitabiSil.Size = new System.Drawing.Size(96, 23);
            this.btnSeciliKitabiSil.TabIndex = 6;
            this.btnSeciliKitabiSil.Text = "Seçili Kitabı Sil";
            this.btnSeciliKitabiSil.UseVisualStyleBackColor = true;
            this.btnSeciliKitabiSil.Click += new System.EventHandler(this.btnSeciliKitabiSil_Click);
            // 
            // KutuphaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 291);
            this.Controls.Add(this.btnSeciliKitabiSil);
            this.Controls.Add(this.btnSeciliKitabıOduncAl);
            this.Controls.Add(this.dgvKitapDetaylari);
            this.Controls.Add(this.cboTurler);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KutuphaneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KutuphaneForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapDetaylari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHesabim;
        private System.Windows.Forms.ToolStripMenuItem tsmiBagisYap;
        private System.Windows.Forms.ToolStripMenuItem tsmiCikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTurler;
        private System.Windows.Forms.DataGridView dgvKitapDetaylari;
        private System.Windows.Forms.Button btnSeciliKitabıOduncAl;
        private System.Windows.Forms.Button btnSeciliKitabiSil;
    }
}