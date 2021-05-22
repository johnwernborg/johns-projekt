
namespace johns_projekt
{
    partial class frm_skapaKonto
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
            this.btn_skapaKonto = new System.Windows.Forms.Button();
            this.tbx_losenord = new System.Windows.Forms.TextBox();
            this.lbl_losenord = new System.Windows.Forms.Label();
            this.tbx_epost = new System.Windows.Forms.TextBox();
            this.lbl_epost = new System.Windows.Forms.Label();
            this.tbx_efternamn = new System.Windows.Forms.TextBox();
            this.lbl_efternamn = new System.Windows.Forms.Label();
            this.tbx_fornamn = new System.Windows.Forms.TextBox();
            this.lbl_fornamn = new System.Windows.Forms.Label();
            this.btn_visa = new System.Windows.Forms.Button();
            this.rb_kund = new System.Windows.Forms.RadioButton();
            this.rb_personal = new System.Windows.Forms.RadioButton();
            this.lbl_skapaKonto = new System.Windows.Forms.Label();
            this.btn_avbryt = new System.Windows.Forms.Button();
            this.lbl_kontoInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_skapaKonto
            // 
            this.btn_skapaKonto.Location = new System.Drawing.Point(16, 245);
            this.btn_skapaKonto.Name = "btn_skapaKonto";
            this.btn_skapaKonto.Size = new System.Drawing.Size(138, 22);
            this.btn_skapaKonto.TabIndex = 9;
            this.btn_skapaKonto.Text = "Skapa konto";
            this.btn_skapaKonto.UseVisualStyleBackColor = true;
            this.btn_skapaKonto.Click += new System.EventHandler(this.btn_skapaKonto_Click);
            // 
            // tbx_losenord
            // 
            this.tbx_losenord.Location = new System.Drawing.Point(17, 196);
            this.tbx_losenord.Name = "tbx_losenord";
            this.tbx_losenord.Size = new System.Drawing.Size(137, 20);
            this.tbx_losenord.TabIndex = 8;
            // 
            // lbl_losenord
            // 
            this.lbl_losenord.AutoSize = true;
            this.lbl_losenord.Location = new System.Drawing.Point(14, 180);
            this.lbl_losenord.Name = "lbl_losenord";
            this.lbl_losenord.Size = new System.Drawing.Size(51, 13);
            this.lbl_losenord.TabIndex = 7;
            this.lbl_losenord.Text = "Lösenord";
            // 
            // tbx_epost
            // 
            this.tbx_epost.Location = new System.Drawing.Point(17, 157);
            this.tbx_epost.Name = "tbx_epost";
            this.tbx_epost.Size = new System.Drawing.Size(137, 20);
            this.tbx_epost.TabIndex = 6;
            // 
            // lbl_epost
            // 
            this.lbl_epost.AutoSize = true;
            this.lbl_epost.Location = new System.Drawing.Point(14, 141);
            this.lbl_epost.Name = "lbl_epost";
            this.lbl_epost.Size = new System.Drawing.Size(74, 13);
            this.lbl_epost.TabIndex = 5;
            this.lbl_epost.Text = "E-postaddress";
            // 
            // tbx_efternamn
            // 
            this.tbx_efternamn.Location = new System.Drawing.Point(17, 112);
            this.tbx_efternamn.Name = "tbx_efternamn";
            this.tbx_efternamn.Size = new System.Drawing.Size(137, 20);
            this.tbx_efternamn.TabIndex = 13;
            // 
            // lbl_efternamn
            // 
            this.lbl_efternamn.AutoSize = true;
            this.lbl_efternamn.Location = new System.Drawing.Point(14, 96);
            this.lbl_efternamn.Name = "lbl_efternamn";
            this.lbl_efternamn.Size = new System.Drawing.Size(55, 13);
            this.lbl_efternamn.TabIndex = 12;
            this.lbl_efternamn.Text = "Efternamn";
            // 
            // tbx_fornamn
            // 
            this.tbx_fornamn.Location = new System.Drawing.Point(17, 73);
            this.tbx_fornamn.Name = "tbx_fornamn";
            this.tbx_fornamn.Size = new System.Drawing.Size(137, 20);
            this.tbx_fornamn.TabIndex = 15;
            // 
            // lbl_fornamn
            // 
            this.lbl_fornamn.AutoSize = true;
            this.lbl_fornamn.Location = new System.Drawing.Point(14, 57);
            this.lbl_fornamn.Name = "lbl_fornamn";
            this.lbl_fornamn.Size = new System.Drawing.Size(48, 13);
            this.lbl_fornamn.TabIndex = 14;
            this.lbl_fornamn.Text = "Förnamn";
            // 
            // btn_visa
            // 
            this.btn_visa.Location = new System.Drawing.Point(160, 196);
            this.btn_visa.Name = "btn_visa";
            this.btn_visa.Size = new System.Drawing.Size(43, 21);
            this.btn_visa.TabIndex = 16;
            this.btn_visa.Text = "Visa";
            this.btn_visa.UseVisualStyleBackColor = true;
            // 
            // rb_kund
            // 
            this.rb_kund.AutoSize = true;
            this.rb_kund.Location = new System.Drawing.Point(17, 37);
            this.rb_kund.Name = "rb_kund";
            this.rb_kund.Size = new System.Drawing.Size(50, 17);
            this.rb_kund.TabIndex = 17;
            this.rb_kund.TabStop = true;
            this.rb_kund.Text = "Kund";
            this.rb_kund.UseVisualStyleBackColor = true;
            // 
            // rb_personal
            // 
            this.rb_personal.AutoSize = true;
            this.rb_personal.Location = new System.Drawing.Point(73, 37);
            this.rb_personal.Name = "rb_personal";
            this.rb_personal.Size = new System.Drawing.Size(66, 17);
            this.rb_personal.TabIndex = 18;
            this.rb_personal.TabStop = true;
            this.rb_personal.Text = "Personal";
            this.rb_personal.UseVisualStyleBackColor = true;
            // 
            // lbl_skapaKonto
            // 
            this.lbl_skapaKonto.AutoSize = true;
            this.lbl_skapaKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_skapaKonto.Location = new System.Drawing.Point(12, 9);
            this.lbl_skapaKonto.Name = "lbl_skapaKonto";
            this.lbl_skapaKonto.Size = new System.Drawing.Size(143, 25);
            this.lbl_skapaKonto.TabIndex = 19;
            this.lbl_skapaKonto.Text = "Skapa konto";
            // 
            // btn_avbryt
            // 
            this.btn_avbryt.Location = new System.Drawing.Point(160, 245);
            this.btn_avbryt.Name = "btn_avbryt";
            this.btn_avbryt.Size = new System.Drawing.Size(75, 23);
            this.btn_avbryt.TabIndex = 20;
            this.btn_avbryt.Text = "Avbryt";
            this.btn_avbryt.UseVisualStyleBackColor = true;
            this.btn_avbryt.Click += new System.EventHandler(this.btn_avbryt_Click);
            // 
            // lbl_kontoInfo
            // 
            this.lbl_kontoInfo.AutoSize = true;
            this.lbl_kontoInfo.Location = new System.Drawing.Point(14, 220);
            this.lbl_kontoInfo.Name = "lbl_kontoInfo";
            this.lbl_kontoInfo.Size = new System.Drawing.Size(204, 13);
            this.lbl_kontoInfo.TabIndex = 21;
            this.lbl_kontoInfo.Text = "Eposten är redan registrerad. Försök igen.";
            this.lbl_kontoInfo.Visible = false;
            // 
            // frm_skapaKonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 289);
            this.Controls.Add(this.lbl_kontoInfo);
            this.Controls.Add(this.btn_avbryt);
            this.Controls.Add(this.lbl_skapaKonto);
            this.Controls.Add(this.rb_personal);
            this.Controls.Add(this.rb_kund);
            this.Controls.Add(this.btn_visa);
            this.Controls.Add(this.tbx_fornamn);
            this.Controls.Add(this.lbl_fornamn);
            this.Controls.Add(this.tbx_efternamn);
            this.Controls.Add(this.lbl_efternamn);
            this.Controls.Add(this.btn_skapaKonto);
            this.Controls.Add(this.tbx_losenord);
            this.Controls.Add(this.lbl_losenord);
            this.Controls.Add(this.tbx_epost);
            this.Controls.Add(this.lbl_epost);
            this.Name = "frm_skapaKonto";
            this.Text = "frm_skapaKonto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_skapaKonto;
        private System.Windows.Forms.TextBox tbx_losenord;
        private System.Windows.Forms.Label lbl_losenord;
        private System.Windows.Forms.TextBox tbx_epost;
        private System.Windows.Forms.Label lbl_epost;
        private System.Windows.Forms.TextBox tbx_efternamn;
        private System.Windows.Forms.Label lbl_efternamn;
        private System.Windows.Forms.TextBox tbx_fornamn;
        private System.Windows.Forms.Label lbl_fornamn;
        private System.Windows.Forms.Button btn_visa;
        private System.Windows.Forms.RadioButton rb_kund;
        private System.Windows.Forms.RadioButton rb_personal;
        private System.Windows.Forms.Label lbl_skapaKonto;
        private System.Windows.Forms.Button btn_avbryt;
        private System.Windows.Forms.Label lbl_kontoInfo;
    }
}