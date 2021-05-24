
namespace johns_projekt
{
    partial class frm_bestallningar
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
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_avbryt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_bestallKlar = new System.Windows.Forms.Label();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_orders
            // 
            this.dgv_orders.AutoGenerateColumns = false;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.addressDataGridViewTextBoxColumn,
            this.prisDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
            this.dgv_orders.DataSource = this.orderBindingSource;
            this.dgv_orders.Location = new System.Drawing.Point(12, 12);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.Size = new System.Drawing.Size(291, 150);
            this.dgv_orders.TabIndex = 0;
            this.dgv_orders.CurrentCellChanged += new System.EventHandler(this.dgv_orders_CurrentCellChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 35;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(301, 196);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 12;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_avbryt
            // 
            this.btn_avbryt.Location = new System.Drawing.Point(382, 196);
            this.btn_avbryt.Name = "btn_avbryt";
            this.btn_avbryt.Size = new System.Drawing.Size(75, 23);
            this.btn_avbryt.TabIndex = 11;
            this.btn_avbryt.Text = "Avbryt";
            this.btn_avbryt.UseVisualStyleBackColor = true;
            this.btn_avbryt.Click += new System.EventHandler(this.btn_avbryt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Skicka beställningen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_bestallKlar
            // 
            this.lbl_bestallKlar.AutoSize = true;
            this.lbl_bestallKlar.Location = new System.Drawing.Point(12, 198);
            this.lbl_bestallKlar.Name = "lbl_bestallKlar";
            this.lbl_bestallKlar.Size = new System.Drawing.Size(140, 13);
            this.lbl_bestallKlar.TabIndex = 14;
            this.lbl_bestallKlar.Text = "Beställningen är nu skickad!";
            this.lbl_bestallKlar.Visible = false;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 80;
            // 
            // prisDataGridViewTextBoxColumn
            // 
            this.prisDataGridViewTextBoxColumn.DataPropertyName = "Pris";
            this.prisDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.prisDataGridViewTextBoxColumn.Name = "prisDataGridViewTextBoxColumn";
            this.prisDataGridViewTextBoxColumn.Width = 60;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 70;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(johns_projekt.Order);
            // 
            // frm_bestallningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 231);
            this.Controls.Add(this.lbl_bestallKlar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_avbryt);
            this.Controls.Add(this.dgv_orders);
            this.Name = "frm_bestallningar";
            this.Text = "frm_bestallningar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_orders;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_avbryt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_bestallKlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fraktDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
    }
}