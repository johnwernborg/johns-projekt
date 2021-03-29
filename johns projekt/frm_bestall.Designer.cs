
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
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // tbx_address
            // 
            this.tbx_address.Location = new System.Drawing.Point(332, 12);
            this.tbx_address.Name = "tbx_address";
            this.tbx_address.Size = new System.Drawing.Size(100, 20);
            this.tbx_address.TabIndex = 1;
            // 
            // tbx_kontaktnamn
            // 
            this.tbx_kontaktnamn.Location = new System.Drawing.Point(332, 59);
            this.tbx_kontaktnamn.Name = "tbx_kontaktnamn";
            this.tbx_kontaktnamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_kontaktnamn.TabIndex = 2;
            // 
            // tbx_telenum
            // 
            this.tbx_telenum.Location = new System.Drawing.Point(332, 105);
            this.tbx_telenum.Name = "tbx_telenum";
            this.tbx_telenum.Size = new System.Drawing.Size(100, 20);
            this.tbx_telenum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kontaktnamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefonnummer";
            // 
            // btn_bestall
            // 
            this.btn_bestall.Location = new System.Drawing.Point(332, 135);
            this.btn_bestall.Name = "btn_bestall";
            this.btn_bestall.Size = new System.Drawing.Size(75, 23);
            this.btn_bestall.TabIndex = 8;
            this.btn_bestall.Text = "Beställ";
            this.btn_bestall.UseVisualStyleBackColor = true;
            // 
            // btn_avbryt
            // 
            this.btn_avbryt.Location = new System.Drawing.Point(369, 212);
            this.btn_avbryt.Name = "btn_avbryt";
            this.btn_avbryt.Size = new System.Drawing.Size(75, 23);
            this.btn_avbryt.TabIndex = 9;
            this.btn_avbryt.Text = "Avbryt";
            this.btn_avbryt.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(288, 212);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // lbl_bestallSkickad
            // 
            this.lbl_bestallSkickad.AutoSize = true;
            this.lbl_bestallSkickad.Location = new System.Drawing.Point(250, 161);
            this.lbl_bestallSkickad.Name = "lbl_bestallSkickad";
            this.lbl_bestallSkickad.Size = new System.Drawing.Size(131, 13);
            this.lbl_bestallSkickad.TabIndex = 11;
            this.lbl_bestallSkickad.Text = "Din beställning är skickad!";
            // 
            // btn_bestallInfo
            // 
            this.btn_bestallInfo.Location = new System.Drawing.Point(18, 186);
            this.btn_bestallInfo.Name = "btn_bestallInfo";
            this.btn_bestallInfo.Size = new System.Drawing.Size(220, 23);
            this.btn_bestallInfo.TabIndex = 12;
            this.btn_bestallInfo.Text = "Ladda ner beställningsinfo";
            this.btn_bestallInfo.UseVisualStyleBackColor = true;
            // 
            // frm_Bestall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 242);
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
            this.Name = "frm_Bestall";
            this.Text = "frm_Bestall";
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
    }
}