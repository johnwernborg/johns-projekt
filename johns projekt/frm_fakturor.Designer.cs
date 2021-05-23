
namespace johns_projekt
{
    partial class frm_fakturor
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
            this.components = new System.ComponentModel.Container();
            this.dgv_fakturor = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_avbryt = new System.Windows.Forms.Button();
            this.btn_betala = new System.Windows.Forms.Button();
            this.lbl_bestallKlar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fakturor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_fakturor
            // 
            this.dgv_fakturor.AutoGenerateColumns = false;
            this.dgv_fakturor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fakturor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.prisDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
            this.dgv_fakturor.DataSource = this.fakturaBindingSource;
            this.dgv_fakturor.Location = new System.Drawing.Point(12, 12);
            this.dgv_fakturor.Name = "dgv_fakturor";
            this.dgv_fakturor.Size = new System.Drawing.Size(277, 150);
            this.dgv_fakturor.TabIndex = 1;
            this.dgv_fakturor.CurrentCellChanged += new System.EventHandler(this.dgv_fakturor_CurrentCellChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 35;
            // 
            // prisDataGridViewTextBoxColumn
            // 
            this.prisDataGridViewTextBoxColumn.DataPropertyName = "Pris";
            this.prisDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.prisDataGridViewTextBoxColumn.Name = "prisDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // fakturaBindingSource
            // 
            this.fakturaBindingSource.DataSource = typeof(johns_projekt.Faktura);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(282, 196);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 14;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_avbryt
            // 
            this.btn_avbryt.Location = new System.Drawing.Point(363, 196);
            this.btn_avbryt.Name = "btn_avbryt";
            this.btn_avbryt.Size = new System.Drawing.Size(75, 23);
            this.btn_avbryt.TabIndex = 13;
            this.btn_avbryt.Text = "Avbryt";
            this.btn_avbryt.UseVisualStyleBackColor = true;
            this.btn_avbryt.Click += new System.EventHandler(this.btn_avbryt_Click);
            // 
            // btn_betala
            // 
            this.btn_betala.Location = new System.Drawing.Point(12, 168);
            this.btn_betala.Name = "btn_betala";
            this.btn_betala.Size = new System.Drawing.Size(140, 23);
            this.btn_betala.TabIndex = 15;
            this.btn_betala.Text = "Betala fakturan";
            this.btn_betala.UseVisualStyleBackColor = true;
            this.btn_betala.Click += new System.EventHandler(this.btn_betala_Click);
            // 
            // lbl_bestallKlar
            // 
            this.lbl_bestallKlar.AutoSize = true;
            this.lbl_bestallKlar.Location = new System.Drawing.Point(12, 194);
            this.lbl_bestallKlar.Name = "lbl_bestallKlar";
            this.lbl_bestallKlar.Size = new System.Drawing.Size(111, 13);
            this.lbl_bestallKlar.TabIndex = 16;
            this.lbl_bestallKlar.Text = "Fakturan är nu betald!";
            this.lbl_bestallKlar.Visible = false;
            // 
            // frm_fakturor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 231);
            this.Controls.Add(this.lbl_bestallKlar);
            this.Controls.Add(this.btn_betala);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_avbryt);
            this.Controls.Add(this.dgv_fakturor);
            this.Name = "frm_fakturor";
            this.Text = "frm_fakturor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fakturor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_fakturor;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_avbryt;
        private System.Windows.Forms.Button btn_betala;
        private System.Windows.Forms.Label lbl_bestallKlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fakturaBindingSource;
    }
}