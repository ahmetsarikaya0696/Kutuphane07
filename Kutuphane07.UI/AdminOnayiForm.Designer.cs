namespace Kutuphane07.UI
{
    partial class AdminOnayiForm
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
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.txtAdminKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOnayla
            // 
            this.btnOnayla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOnayla.Location = new System.Drawing.Point(22, 322);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(186, 23);
            this.btnOnayla.TabIndex = 11;
            this.btnOnayla.Text = "Onay";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdminSifre.Location = new System.Drawing.Point(22, 279);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.PasswordChar = '*';
            this.txtAdminSifre.Size = new System.Drawing.Size(186, 20);
            this.txtAdminSifre.TabIndex = 7;
            // 
            // txtAdminKullaniciAdi
            // 
            this.txtAdminKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdminKullaniciAdi.Location = new System.Drawing.Point(22, 236);
            this.txtAdminKullaniciAdi.Name = "txtAdminKullaniciAdi";
            this.txtAdminKullaniciAdi.Size = new System.Drawing.Size(186, 20);
            this.txtAdminKullaniciAdi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin Parola";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin Kullanıcı Adı";
            // 
            // pbUser
            // 
            this.pbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbUser.BackgroundImage = global::Kutuphane07.UI.Properties.Resources.admin;
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUser.Location = new System.Drawing.Point(25, 26);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(183, 178);
            this.pbUser.TabIndex = 9;
            this.pbUser.TabStop = false;
            // 
            // AdminOnayiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 357);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.txtAdminSifre);
            this.Controls.Add(this.txtAdminKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 396);
            this.MinimumSize = new System.Drawing.Size(250, 396);
            this.Name = "AdminOnayiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminOnayiForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.TextBox txtAdminKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}