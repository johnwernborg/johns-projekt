
namespace johns_projekt
{
    partial class frm_bestall
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbx_address = new System.Windows.Forms.TextBox();
            this.tbx_kontaktnamn = new System.Windows.Forms.TextBox();
            this.tbx_telenum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_bestall = new System.Windows.Forms.Button();
            this.btn_avbryt = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_bestallSkickad = new System.Windows.Forms.Label();
            this.btn_bestallInfo = new System.Windows.Forms.Button();
            this.nud_antal = new System.Windows.Forms.NumericUpDown();
            this.lbl_valtSpel = new System.Windows.Forms.Label();
            this.lbl_antal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_antal)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 63);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // tbx_address
            // 
            this.tbx_address.Location = new System.Drawing.Point(332, 109);
            this.tbx_address.Name = "tbx_address";
            this.tbx_address.Size = new System.Drawing.Size(100, 20);
            this.tbx_address.TabIndex = 1;
            // 
            // tbx_kontaktnamn
            // 
            this.tbx_kontaktnamn.Location = new System.Drawing.Point(332, 156);
            this.tbx_kontaktnamn.Name = "tbx_kontaktnamn";
            this.tbx_kontaktnamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_kontaktnamn.TabIndex = 2;
            // 
            // tbx_telenum
            // 
            this.tbx_telenum.Location = new System.Drawing.Point(332, 202);
            this.tbx_telenum.Name = "tbx_telenum";
            this.tbx_telenum.Size = new System.Drawing.Size(100, 20);
            this.tbx_telenum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kontaktnamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefonnummer";
            // 
            // btn_bestall
            // 
            this.btn_bestall.Location = new System.Drawing.Point(332, 232);
            this.btn_bestall.Name = "btn_bestall";
            this.btn_bestall.Size = new System.Drawing.Size(75, 23);
            this.btn_bestall.TabIndex = 8;
            this.btn_bestall.Text = "Beställ";
            this.btn_bestall.UseVisualStyleBackColor = true;
            this.btn_bestall.Click += new System.EventHandler(this.btn_bestall_Click);
            // 
            // btn_avbryt
            // 
            this.btn_avbryt.Location = new System.Drawing.Point(369, 282);
            this.btn_avbryt.Name = "btn_avbryt";
            this.btn_avbryt.Size = new System.Drawing.Size(75, 23);
            this.btn_avbryt.TabIndex = 9;
            this.btn_avbryt.Text = "Avbryt";
            this.btn_avbryt.UseVisualStyleBackColor = true;
            this.btn_avbryt.Click += new System.EventHandler(this.btn_avbryt_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(288, 282);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_bestallSkickad
            // 
            this.lbl_bestallSkickad.AutoSize = true;
            this.lbl_bestallSkickad.Location = new System.Drawing.Point(250, 258);
            this.lbl_bestallSkickad.Name = "lbl_bestallSkickad";
            this.lbl_bestallSkickad.Size = new System.Drawing.Size(131, 13);
            this.lbl_bestallSkickad.TabIndex = 11;
            this.lbl_bestallSkickad.Text = "Din beställning är skickad!";
            this.lbl_bestallSkickad.Visible = false;
            // 
            // btn_bestallInfo
            // 
            this.btn_bestallInfo.Location = new System.Drawing.Point(18, 232);
            this.btn_bestallInfo.Name = "btn_bestallInfo";
            this.btn_bestallInfo.Size = new System.Drawing.Size(220, 23);
            this.btn_bestallInfo.TabIndex = 12;
            this.btn_bestallInfo.Text = "Ladda ner beställningsinfo";
            this.btn_bestallInfo.UseVisualStyleBackColor = true;
            // 
            // nud_antal
            // 
            this.nud_antal.Location = new System.Drawing.Point(332, 63);
            this.nud_antal.Name = "nud_antal";
            this.nud_antal.Size = new System.Drawing.Size(100, 20);
            this.nud_antal.TabIndex = 13;
            // 
            // lbl_valtSpel
            // 
            this.lbl_valtSpel.AutoSize = true;
            this.lbl_valtSpel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valtSpel.Location = new System.Drawing.Point(284, 19);
            this.lbl_valtSpel.Name = "lbl_valtSpel";
            this.lbl_valtSpel.Size = new System.Drawing.Size(79, 20);
            this.lbl_valtSpel.TabIndex = 14;
            this.lbl_valtSpel.Text = "Valt spel";
            // 
            // lbl_antal
            // 
            this.lbl_antal.AutoSize = true;
            this.lbl_antal.Location = new System.Drawing.Point(295, 65);
            this.lbl_antal.Name = "lbl_antal";
            this.lbl_antal.Size = new System.Drawing.Size(31, 13);
            this.lbl_antal.TabIndex = 15;
            this.lbl_antal.Text = "Antal";
            // 
            // frm_bestall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 314);
            this.Controls.Add(this.lbl_antal);
            this.Controls.Add(this.lbl_valtSpel);
            this.Controls.Add(this.nud_antal);
            this.Controls.Add(this.btn_bestallInfo);
            this.Controls.Add(this.lbl_bestallSkickad);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_avbryt);
            this.Controls.Add(this.btn_bestall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_telenum);
            this.Controls.Add(this.tbx_kontaktnamn);
            this.Controls.Add(this.tbx_address);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "frm_bestall";
            this.Text = "frm_Bestall";
            this.Load += new System.EventHandler(this.frm_bestall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_antal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tbx_address;
        private System.Windows.Forms.TextBox tbx_kontaktnamn;
        private System.Windows.Forms.TextBox tbx_telenum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_bestall;
        private System.Windows.Forms.Button btn_avbryt;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_bestallSkickad;
        private System.Windows.Forms.Button btn_bestallInfo;
        private System.Windows.Forms.NumericUpDown nud_antal;
        private System.Windows.Forms.Label lbl_valtSpel;
        private System.Windows.Forms.Label lbl_antal;
    }
}