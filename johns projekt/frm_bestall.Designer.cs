
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
            this.lbl_address = new System.Windows.Forms.Label();
            this.btn_bestall = new System.Windows.Forms.Button();
            this.btn_avbryt = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_bestallInfo = new System.Windows.Forms.Label();
            this.nud_antal = new System.Windows.Forms.NumericUpDown();
            this.lbl_valtSpel = new System.Windows.Forms.Label();
            this.lbl_antal = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_antal)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 82);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2021, 4, 15, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // tbx_address
            // 
            this.tbx_address.Location = new System.Drawing.Point(328, 145);
            this.tbx_address.Name = "tbx_address";
            this.tbx_address.Size = new System.Drawing.Size(100, 20);
            this.tbx_address.TabIndex = 1;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(277, 148);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(45, 13);
            this.lbl_address.TabIndex = 5;
            this.lbl_address.Text = "Address";
            // 
            // btn_bestall
            // 
            this.btn_bestall.Location = new System.Drawing.Point(328, 192);
            this.btn_bestall.Name = "btn_bestall";
            this.btn_bestall.Size = new System.Drawing.Size(75, 23);
            this.btn_bestall.TabIndex = 8;
            this.btn_bestall.Text = "Beställ";
            this.btn_bestall.UseVisualStyleBackColor = true;
            this.btn_bestall.Click += new System.EventHandler(this.btn_bestall_Click);
            // 
            // btn_avbryt
            // 
            this.btn_avbryt.Location = new System.Drawing.Point(365, 263);
            this.btn_avbryt.Name = "btn_avbryt";
            this.btn_avbryt.Size = new System.Drawing.Size(75, 23);
            this.btn_avbryt.TabIndex = 9;
            this.btn_avbryt.Text = "Avbryt";
            this.btn_avbryt.UseVisualStyleBackColor = true;
            this.btn_avbryt.Click += new System.EventHandler(this.btn_avbryt_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(284, 263);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_bestallInfo
            // 
            this.lbl_bestallInfo.AutoSize = true;
            this.lbl_bestallInfo.Location = new System.Drawing.Point(246, 218);
            this.lbl_bestallInfo.Name = "lbl_bestallInfo";
            this.lbl_bestallInfo.Size = new System.Drawing.Size(130, 13);
            this.lbl_bestallInfo.TabIndex = 11;
            this.lbl_bestallInfo.Text = "Gick beställning eller inte?";
            this.lbl_bestallInfo.Visible = false;
            // 
            // nud_antal
            // 
            this.nud_antal.Location = new System.Drawing.Point(328, 99);
            this.nud_antal.Name = "nud_antal";
            this.nud_antal.Size = new System.Drawing.Size(100, 20);
            this.nud_antal.TabIndex = 13;
            // 
            // lbl_valtSpel
            // 
            this.lbl_valtSpel.AutoSize = true;
            this.lbl_valtSpel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valtSpel.Location = new System.Drawing.Point(14, 15);
            this.lbl_valtSpel.Name = "lbl_valtSpel";
            this.lbl_valtSpel.Size = new System.Drawing.Size(79, 20);
            this.lbl_valtSpel.TabIndex = 14;
            this.lbl_valtSpel.Text = "Valt spel";
            // 
            // lbl_antal
            // 
            this.lbl_antal.AutoSize = true;
            this.lbl_antal.Location = new System.Drawing.Point(291, 101);
            this.lbl_antal.Name = "lbl_antal";
            this.lbl_antal.Size = new System.Drawing.Size(31, 13);
            this.lbl_antal.TabIndex = 15;
            this.lbl_antal.Text = "Antal";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(18, 47);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(294, 26);
            this.lbl_info.TabIndex = 16;
            this.lbl_info.Text = "Spelet kommer skickas till angiven address på angivet datum\r\noch en faktura komme" +
    "r skickas till ditt konto";
            // 
            // frm_bestall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 297);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_antal);
            this.Controls.Add(this.lbl_valtSpel);
            this.Controls.Add(this.nud_antal);
            this.Controls.Add(this.lbl_bestallInfo);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_avbryt);
            this.Controls.Add(this.btn_bestall);
            this.Controls.Add(this.lbl_address);
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
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Button btn_bestall;
        private System.Windows.Forms.Button btn_avbryt;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_bestallInfo;
        private System.Windows.Forms.NumericUpDown nud_antal;
        private System.Windows.Forms.Label lbl_valtSpel;
        private System.Windows.Forms.Label lbl_antal;
        private System.Windows.Forms.Label lbl_info;
    }
}