
namespace johns_projekt
{
    partial class frm_laddaNer
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
            this.lbl_valtSpel = new System.Windows.Forms.Label();
            this.btn_laddaNer = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_avbryt = new System.Windows.Forms.Button();
            this.dlgSparaFil = new System.Windows.Forms.SaveFileDialog();
            this.lbl_laddatNer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_address = new System.Windows.Forms.TextBox();
            this.lbl_felAddress = new System.Windows.Forms.Label();
            this.lbl_faktura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_valtSpel
            // 
            this.lbl_valtSpel.AutoSize = true;
            this.lbl_valtSpel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valtSpel.Location = new System.Drawing.Point(12, 9);
            this.lbl_valtSpel.Name = "lbl_valtSpel";
            this.lbl_valtSpel.Size = new System.Drawing.Size(79, 20);
            this.lbl_valtSpel.TabIndex = 15;
            this.lbl_valtSpel.Text = "Valt spel";
            // 
            // btn_laddaNer
            // 
            this.btn_laddaNer.Location = new System.Drawing.Point(16, 117);
            this.btn_laddaNer.Name = "btn_laddaNer";
            this.btn_laddaNer.Size = new System.Drawing.Size(75, 23);
            this.btn_laddaNer.TabIndex = 16;
            this.btn_laddaNer.Text = "Ladda ner";
            this.btn_laddaNer.UseVisualStyleBackColor = true;
            this.btn_laddaNer.Click += new System.EventHandler(this.btn_laddaNer_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(12, 173);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 18;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_avbryt
            // 
            this.btn_avbryt.Location = new System.Drawing.Point(93, 173);
            this.btn_avbryt.Name = "btn_avbryt";
            this.btn_avbryt.Size = new System.Drawing.Size(75, 23);
            this.btn_avbryt.TabIndex = 17;
            this.btn_avbryt.Text = "Avbryt";
            this.btn_avbryt.UseVisualStyleBackColor = true;
            // 
            // lbl_laddatNer
            // 
            this.lbl_laddatNer.AutoSize = true;
            this.lbl_laddatNer.Location = new System.Drawing.Point(17, 143);
            this.lbl_laddatNer.Name = "lbl_laddatNer";
            this.lbl_laddatNer.Size = new System.Drawing.Size(127, 13);
            this.lbl_laddatNer.TabIndex = 19;
            this.lbl_laddatNer.Text = "Nedladdningen lyckades!";
            this.lbl_laddatNer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Address";
            // 
            // tbx_address
            // 
            this.tbx_address.Location = new System.Drawing.Point(68, 68);
            this.tbx_address.Name = "tbx_address";
            this.tbx_address.Size = new System.Drawing.Size(100, 20);
            this.tbx_address.TabIndex = 20;
            // 
            // lbl_felAddress
            // 
            this.lbl_felAddress.AutoSize = true;
            this.lbl_felAddress.Location = new System.Drawing.Point(65, 91);
            this.lbl_felAddress.Name = "lbl_felAddress";
            this.lbl_felAddress.Size = new System.Drawing.Size(142, 13);
            this.lbl_felAddress.TabIndex = 22;
            this.lbl_felAddress.Text = "Måste ange en giltig address";
            this.lbl_felAddress.Visible = false;
            // 
            // lbl_faktura
            // 
            this.lbl_faktura.AutoSize = true;
            this.lbl_faktura.Location = new System.Drawing.Point(17, 38);
            this.lbl_faktura.Name = "lbl_faktura";
            this.lbl_faktura.Size = new System.Drawing.Size(146, 13);
            this.lbl_faktura.TabIndex = 23;
            this.lbl_faktura.Text = "Faktura skickas till addressen";
            this.lbl_faktura.Visible = false;
            // 
            // frm_laddaNer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 209);
            this.Controls.Add(this.lbl_faktura);
            this.Controls.Add(this.lbl_felAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_address);
            this.Controls.Add(this.lbl_laddatNer);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_avbryt);
            this.Controls.Add(this.btn_laddaNer);
            this.Controls.Add(this.lbl_valtSpel);
            this.Name = "frm_laddaNer";
            this.Text = "frm_LaddaNer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_valtSpel;
        private System.Windows.Forms.Button btn_laddaNer;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_avbryt;
        private System.Windows.Forms.SaveFileDialog dlgSparaFil;
        private System.Windows.Forms.Label lbl_laddatNer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_address;
        private System.Windows.Forms.Label lbl_felAddress;
        private System.Windows.Forms.Label lbl_faktura;
    }
}