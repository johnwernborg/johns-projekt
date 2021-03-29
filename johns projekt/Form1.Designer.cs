
namespace johns_projekt
{
    partial class Form1
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
            this.tbx_spel = new System.Windows.Forms.TextBox();
            this.lbx_spel = new System.Windows.Forms.ListBox();
            this.btn_hamtaSpel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_spel
            // 
            this.tbx_spel.Location = new System.Drawing.Point(183, 72);
            this.tbx_spel.Multiline = true;
            this.tbx_spel.Name = "tbx_spel";
            this.tbx_spel.Size = new System.Drawing.Size(166, 109);
            this.tbx_spel.TabIndex = 0;
            // 
            // lbx_spel
            // 
            this.lbx_spel.FormattingEnabled = true;
            this.lbx_spel.Location = new System.Drawing.Point(355, 72);
            this.lbx_spel.Name = "lbx_spel";
            this.lbx_spel.Size = new System.Drawing.Size(214, 225);
            this.lbx_spel.TabIndex = 1;
            this.lbx_spel.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_hamtaSpel
            // 
            this.btn_hamtaSpel.Location = new System.Drawing.Point(183, 188);
            this.btn_hamtaSpel.Name = "btn_hamtaSpel";
            this.btn_hamtaSpel.Size = new System.Drawing.Size(166, 23);
            this.btn_hamtaSpel.TabIndex = 2;
            this.btn_hamtaSpel.Text = "Beställ";
            this.btn_hamtaSpel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 323);
            this.Controls.Add(this.btn_hamtaSpel);
            this.Controls.Add(this.lbx_spel);
            this.Controls.Add(this.tbx_spel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_spel;
        private System.Windows.Forms.ListBox lbx_spel;
        private System.Windows.Forms.Button btn_hamtaSpel;
    }
}

