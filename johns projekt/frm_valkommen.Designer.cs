
namespace johns_projekt
{
    partial class frm_valkommen
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
            this.lbl_valkommen = new System.Windows.Forms.Label();
            this.btn_skapaKonto = new System.Windows.Forms.Button();
            this.btn_loggaIn = new System.Windows.Forms.Button();
            this.lbl_spelbutik = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_avsluta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_valkommen
            // 
            this.lbl_valkommen.AutoSize = true;
            this.lbl_valkommen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valkommen.Location = new System.Drawing.Point(12, 20);
            this.lbl_valkommen.Name = "lbl_valkommen";
            this.lbl_valkommen.Size = new System.Drawing.Size(184, 29);
            this.lbl_valkommen.TabIndex = 0;
            this.lbl_valkommen.Text = "Välkommen till";
            // 
            // btn_skapaKonto
            // 
            this.btn_skapaKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_skapaKonto.Location = new System.Drawing.Point(35, 112);
            this.btn_skapaKonto.Name = "btn_skapaKonto";
            this.btn_skapaKonto.Size = new System.Drawing.Size(159, 63);
            this.btn_skapaKonto.TabIndex = 10;
            this.btn_skapaKonto.Text = "Skapa konto";
            this.btn_skapaKonto.UseVisualStyleBackColor = true;
            this.btn_skapaKonto.Click += new System.EventHandler(this.btn_skapaKonto_Click);
            // 
            // btn_loggaIn
            // 
            this.btn_loggaIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loggaIn.Location = new System.Drawing.Point(262, 112);
            this.btn_loggaIn.Name = "btn_loggaIn";
            this.btn_loggaIn.Size = new System.Drawing.Size(167, 63);
            this.btn_loggaIn.TabIndex = 11;
            this.btn_loggaIn.Text = "Logga in";
            this.btn_loggaIn.UseVisualStyleBackColor = true;
            this.btn_loggaIn.Click += new System.EventHandler(this.btn_loggaIn_Click);
            // 
            // lbl_spelbutik
            // 
            this.lbl_spelbutik.AutoSize = true;
            this.lbl_spelbutik.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spelbutik.Location = new System.Drawing.Point(191, 9);
            this.lbl_spelbutik.Name = "lbl_spelbutik";
            this.lbl_spelbutik.Size = new System.Drawing.Size(268, 44);
            this.lbl_spelbutik.TabIndex = 12;
            this.lbl_spelbutik.Text = "Spelbutiken";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(14, 53);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(441, 18);
            this.lbl_info.TabIndex = 13;
            this.lbl_info.Text = "Här kan du beställa hem eller ladda ner olika spel, gamla som nya.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Är du ny? Skapa ett konto! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Har du redan ett konto? Logga in! ";
            // 
            // btn_avsluta
            // 
            this.btn_avsluta.Location = new System.Drawing.Point(393, 198);
            this.btn_avsluta.Name = "btn_avsluta";
            this.btn_avsluta.Size = new System.Drawing.Size(75, 23);
            this.btn_avsluta.TabIndex = 16;
            this.btn_avsluta.Text = "Avsluta";
            this.btn_avsluta.UseVisualStyleBackColor = true;
            this.btn_avsluta.Click += new System.EventHandler(this.btn_avsluta_Click);
            // 
            // frm_valkommen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 233);
            this.Controls.Add(this.btn_avsluta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_spelbutik);
            this.Controls.Add(this.btn_loggaIn);
            this.Controls.Add(this.btn_skapaKonto);
            this.Controls.Add(this.lbl_valkommen);
            this.Name = "frm_valkommen";
            this.Text = "frm_valkommen";
            this.Load += new System.EventHandler(this.frm_valkommen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_valkommen;
        private System.Windows.Forms.Button btn_skapaKonto;
        private System.Windows.Forms.Button btn_loggaIn;
        private System.Windows.Forms.Label lbl_spelbutik;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_avsluta;
    }
}