
namespace johns_projekt
{
    partial class frm_inlogg
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
            this.tbx_losenord = new System.Windows.Forms.TextBox();
            this.lbl_losenord = new System.Windows.Forms.Label();
            this.btn_loggaIn = new System.Windows.Forms.Button();
            this.tbx_epost = new System.Windows.Forms.TextBox();
            this.lbl_epost = new System.Windows.Forms.Label();
            this.lbl_skapaKonto = new System.Windows.Forms.Label();
            this.btn_avbryt = new System.Windows.Forms.Button();
            this.lbl_inloggFel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_losenord
            // 
            this.tbx_losenord.Location = new System.Drawing.Point(17, 97);
            this.tbx_losenord.Name = "tbx_losenord";
            this.tbx_losenord.Size = new System.Drawing.Size(137, 20);
            this.tbx_losenord.TabIndex = 3;
            // 
            // lbl_losenord
            // 
            this.lbl_losenord.AutoSize = true;
            this.lbl_losenord.Location = new System.Drawing.Point(14, 81);
            this.lbl_losenord.Name = "lbl_losenord";
            this.lbl_losenord.Size = new System.Drawing.Size(51, 13);
            this.lbl_losenord.TabIndex = 2;
            this.lbl_losenord.Text = "Lösenord";
            // 
            // btn_loggaIn
            // 
            this.btn_loggaIn.Location = new System.Drawing.Point(17, 143);
            this.btn_loggaIn.Name = "btn_loggaIn";
            this.btn_loggaIn.Size = new System.Drawing.Size(137, 23);
            this.btn_loggaIn.TabIndex = 4;
            this.btn_loggaIn.Text = "Logga in";
            this.btn_loggaIn.UseVisualStyleBackColor = true;
            this.btn_loggaIn.Click += new System.EventHandler(this.btn_loggaIn_Click);
            // 
            // tbx_epost
            // 
            this.tbx_epost.Location = new System.Drawing.Point(17, 58);
            this.tbx_epost.Name = "tbx_epost";
            this.tbx_epost.Size = new System.Drawing.Size(137, 20);
            this.tbx_epost.TabIndex = 8;
            // 
            // lbl_epost
            // 
            this.lbl_epost.AutoSize = true;
            this.lbl_epost.Location = new System.Drawing.Point(14, 42);
            this.lbl_epost.Name = "lbl_epost";
            this.lbl_epost.Size = new System.Drawing.Size(74, 13);
            this.lbl_epost.TabIndex = 7;
            this.lbl_epost.Text = "E-postaddress";
            // 
            // lbl_skapaKonto
            // 
            this.lbl_skapaKonto.AutoSize = true;
            this.lbl_skapaKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_skapaKonto.Location = new System.Drawing.Point(12, 9);
            this.lbl_skapaKonto.Name = "lbl_skapaKonto";
            this.lbl_skapaKonto.Size = new System.Drawing.Size(103, 25);
            this.lbl_skapaKonto.TabIndex = 20;
            this.lbl_skapaKonto.Text = "Logga in";
            // 
            // btn_avbryt
            // 
            this.btn_avbryt.Location = new System.Drawing.Point(160, 143);
            this.btn_avbryt.Name = "btn_avbryt";
            this.btn_avbryt.Size = new System.Drawing.Size(75, 23);
            this.btn_avbryt.TabIndex = 21;
            this.btn_avbryt.Text = "Avbryt";
            this.btn_avbryt.UseVisualStyleBackColor = true;
            this.btn_avbryt.Click += new System.EventHandler(this.btn_avbryt_Click);
            // 
            // lbl_inloggFel
            // 
            this.lbl_inloggFel.AutoSize = true;
            this.lbl_inloggFel.Location = new System.Drawing.Point(17, 124);
            this.lbl_inloggFel.Name = "lbl_inloggFel";
            this.lbl_inloggFel.Size = new System.Drawing.Size(184, 13);
            this.lbl_inloggFel.TabIndex = 22;
            this.lbl_inloggFel.Text = "Inloggningen var felaktig. Försök igen";
            this.lbl_inloggFel.Visible = false;
            // 
            // frm_inlogg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 178);
            this.Controls.Add(this.lbl_inloggFel);
            this.Controls.Add(this.btn_avbryt);
            this.Controls.Add(this.lbl_skapaKonto);
            this.Controls.Add(this.tbx_epost);
            this.Controls.Add(this.lbl_epost);
            this.Controls.Add(this.btn_loggaIn);
            this.Controls.Add(this.tbx_losenord);
            this.Controls.Add(this.lbl_losenord);
            this.Name = "frm_inlogg";
            this.Text = "frm_inlogg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_losenord;
        private System.Windows.Forms.Label lbl_losenord;
        private System.Windows.Forms.Button btn_loggaIn;
        private System.Windows.Forms.TextBox tbx_epost;
        private System.Windows.Forms.Label lbl_epost;
        private System.Windows.Forms.Label lbl_skapaKonto;
        private System.Windows.Forms.Button btn_avbryt;
        private System.Windows.Forms.Label lbl_inloggFel;
    }
}