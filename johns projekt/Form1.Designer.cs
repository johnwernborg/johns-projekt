
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
            this.components = new System.ComponentModel.Container();
            this.btn_hamtaSpel = new System.Windows.Forms.Button();
            this.tbx_sok = new System.Windows.Forms.TextBox();
            this.btn_rensa = new System.Windows.Forms.Button();
            this.lbl_spel = new System.Windows.Forms.Label();
            this.lbl_spelbutik = new System.Windows.Forms.Label();
            this.rb_retro = new System.Windows.Forms.RadioButton();
            this.rb_modernt = new System.Windows.Forms.RadioButton();
            this.btn_sort = new System.Windows.Forms.Button();
            this.rb_az = new System.Windows.Forms.RadioButton();
            this.rb_za = new System.Windows.Forms.RadioButton();
            this.rb_stigande = new System.Windows.Forms.RadioButton();
            this.rb_fallande = new System.Windows.Forms.RadioButton();
            this.lbl_titel = new System.Windows.Forms.Label();
            this.lbl_utgivning = new System.Windows.Forms.Label();
            this.lbl_pris = new System.Windows.Forms.Label();
            this.btn_sok = new System.Windows.Forms.Button();
            this.dgv_spel = new System.Windows.Forms.DataGridView();
            this.btn_radera = new System.Windows.Forms.Button();
            this.btn_uppdatera = new System.Windows.Forms.Button();
            this.btn_laggTill = new System.Windows.Forms.Button();
            this.lbl_ejHitta = new System.Windows.Forms.Label();
            this.lbl_kontoNamn = new System.Windows.Forms.Label();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aldersgransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plattformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utgivningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fysisktSpelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fysisktSpelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hamtaSpel
            // 
            this.btn_hamtaSpel.Location = new System.Drawing.Point(29, 154);
            this.btn_hamtaSpel.Name = "btn_hamtaSpel";
            this.btn_hamtaSpel.Size = new System.Drawing.Size(111, 23);
            this.btn_hamtaSpel.TabIndex = 2;
            this.btn_hamtaSpel.Text = "Beställ";
            this.btn_hamtaSpel.UseVisualStyleBackColor = true;
            this.btn_hamtaSpel.Click += new System.EventHandler(this.btn_hamtaSpel_Click);
            // 
            // tbx_sok
            // 
            this.tbx_sok.Location = new System.Drawing.Point(108, 127);
            this.tbx_sok.Name = "tbx_sok";
            this.tbx_sok.Size = new System.Drawing.Size(203, 20);
            this.tbx_sok.TabIndex = 3;
            // 
            // btn_rensa
            // 
            this.btn_rensa.Location = new System.Drawing.Point(27, 101);
            this.btn_rensa.Name = "btn_rensa";
            this.btn_rensa.Size = new System.Drawing.Size(75, 22);
            this.btn_rensa.TabIndex = 5;
            this.btn_rensa.Text = "Rensa";
            this.btn_rensa.UseVisualStyleBackColor = true;
            this.btn_rensa.Click += new System.EventHandler(this.btn_rensa_Click);
            // 
            // lbl_spel
            // 
            this.lbl_spel.AutoSize = true;
            this.lbl_spel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spel.Location = new System.Drawing.Point(143, 155);
            this.lbl_spel.Name = "lbl_spel";
            this.lbl_spel.Size = new System.Drawing.Size(72, 18);
            this.lbl_spel.TabIndex = 7;
            this.lbl_spel.Text = "Valt spel";
            // 
            // lbl_spelbutik
            // 
            this.lbl_spelbutik.AutoSize = true;
            this.lbl_spelbutik.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spelbutik.Location = new System.Drawing.Point(21, 19);
            this.lbl_spelbutik.Name = "lbl_spelbutik";
            this.lbl_spelbutik.Size = new System.Drawing.Size(268, 44);
            this.lbl_spelbutik.TabIndex = 8;
            this.lbl_spelbutik.Text = "Spelbutiken";
            // 
            // rb_retro
            // 
            this.rb_retro.AutoSize = true;
            this.rb_retro.Location = new System.Drawing.Point(235, 83);
            this.rb_retro.Name = "rb_retro";
            this.rb_retro.Size = new System.Drawing.Size(51, 17);
            this.rb_retro.TabIndex = 9;
            this.rb_retro.TabStop = true;
            this.rb_retro.Text = "Retro";
            this.rb_retro.UseVisualStyleBackColor = true;
            // 
            // rb_modernt
            // 
            this.rb_modernt.AutoSize = true;
            this.rb_modernt.Location = new System.Drawing.Point(235, 104);
            this.rb_modernt.Name = "rb_modernt";
            this.rb_modernt.Size = new System.Drawing.Size(64, 17);
            this.rb_modernt.TabIndex = 10;
            this.rb_modernt.TabStop = true;
            this.rb_modernt.Text = "Modernt";
            this.rb_modernt.UseVisualStyleBackColor = true;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(27, 66);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(75, 32);
            this.btn_sort.TabIndex = 11;
            this.btn_sort.Text = "Sortera";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // rb_az
            // 
            this.rb_az.AutoSize = true;
            this.rb_az.Location = new System.Drawing.Point(108, 83);
            this.rb_az.Name = "rb_az";
            this.rb_az.Size = new System.Drawing.Size(48, 17);
            this.rb_az.TabIndex = 12;
            this.rb_az.TabStop = true;
            this.rb_az.Text = "A - Z";
            this.rb_az.UseVisualStyleBackColor = true;
            // 
            // rb_za
            // 
            this.rb_za.AutoSize = true;
            this.rb_za.Location = new System.Drawing.Point(108, 103);
            this.rb_za.Name = "rb_za";
            this.rb_za.Size = new System.Drawing.Size(48, 17);
            this.rb_za.TabIndex = 13;
            this.rb_za.TabStop = true;
            this.rb_za.Text = "Z - A";
            this.rb_za.UseVisualStyleBackColor = true;
            // 
            // rb_stigande
            // 
            this.rb_stigande.AutoSize = true;
            this.rb_stigande.Location = new System.Drawing.Point(162, 83);
            this.rb_stigande.Name = "rb_stigande";
            this.rb_stigande.Size = new System.Drawing.Size(67, 17);
            this.rb_stigande.TabIndex = 14;
            this.rb_stigande.TabStop = true;
            this.rb_stigande.Text = "Stigande";
            this.rb_stigande.UseVisualStyleBackColor = true;
            // 
            // rb_fallande
            // 
            this.rb_fallande.AutoSize = true;
            this.rb_fallande.Location = new System.Drawing.Point(162, 104);
            this.rb_fallande.Name = "rb_fallande";
            this.rb_fallande.Size = new System.Drawing.Size(65, 17);
            this.rb_fallande.TabIndex = 15;
            this.rb_fallande.TabStop = true;
            this.rb_fallande.Text = "Fallande";
            this.rb_fallande.UseVisualStyleBackColor = true;
            // 
            // lbl_titel
            // 
            this.lbl_titel.AutoSize = true;
            this.lbl_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titel.Location = new System.Drawing.Point(117, 64);
            this.lbl_titel.Name = "lbl_titel";
            this.lbl_titel.Size = new System.Drawing.Size(39, 16);
            this.lbl_titel.TabIndex = 16;
            this.lbl_titel.Text = "Titel";
            // 
            // lbl_utgivning
            // 
            this.lbl_utgivning.AutoSize = true;
            this.lbl_utgivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_utgivning.Location = new System.Drawing.Point(232, 66);
            this.lbl_utgivning.Name = "lbl_utgivning";
            this.lbl_utgivning.Size = new System.Drawing.Size(78, 13);
            this.lbl_utgivning.TabIndex = 17;
            this.lbl_utgivning.Text = "Utgivningsår";
            // 
            // lbl_pris
            // 
            this.lbl_pris.AutoSize = true;
            this.lbl_pris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pris.Location = new System.Drawing.Point(178, 64);
            this.lbl_pris.Name = "lbl_pris";
            this.lbl_pris.Size = new System.Drawing.Size(35, 16);
            this.lbl_pris.TabIndex = 18;
            this.lbl_pris.Text = "Pris";
            // 
            // btn_sok
            // 
            this.btn_sok.Location = new System.Drawing.Point(27, 127);
            this.btn_sok.Name = "btn_sok";
            this.btn_sok.Size = new System.Drawing.Size(75, 20);
            this.btn_sok.TabIndex = 19;
            this.btn_sok.Text = "Sök";
            this.btn_sok.UseVisualStyleBackColor = true;
            this.btn_sok.Click += new System.EventHandler(this.btn_sok_Click);
            // 
            // dgv_spel
            // 
            this.dgv_spel.AllowUserToAddRows = false;
            this.dgv_spel.AllowUserToDeleteRows = false;
            this.dgv_spel.AutoGenerateColumns = false;
            this.dgv_spel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_spel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreDataGridViewTextBoxColumn,
            this.titelDataGridViewTextBoxColumn,
            this.prisDataGridViewTextBoxColumn,
            this.aldersgransDataGridViewTextBoxColumn,
            this.plattformDataGridViewTextBoxColumn,
            this.utgivningDataGridViewTextBoxColumn});
            this.dgv_spel.DataSource = this.spelBindingSource;
            this.dgv_spel.Location = new System.Drawing.Point(29, 180);
            this.dgv_spel.Name = "dgv_spel";
            this.dgv_spel.ReadOnly = true;
            this.dgv_spel.Size = new System.Drawing.Size(422, 236);
            this.dgv_spel.TabIndex = 20;
            this.dgv_spel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_spel.CurrentCellChanged += new System.EventHandler(this.dgv_spel_CurrentCellChanged);
            // 
            // btn_radera
            // 
            this.btn_radera.Location = new System.Drawing.Point(162, 422);
            this.btn_radera.Name = "btn_radera";
            this.btn_radera.Size = new System.Drawing.Size(107, 23);
            this.btn_radera.TabIndex = 21;
            this.btn_radera.Text = "Radera valt spel";
            this.btn_radera.UseVisualStyleBackColor = true;
            this.btn_radera.Click += new System.EventHandler(this.btn_radera_Click);
            // 
            // btn_uppdatera
            // 
            this.btn_uppdatera.Location = new System.Drawing.Point(275, 422);
            this.btn_uppdatera.Name = "btn_uppdatera";
            this.btn_uppdatera.Size = new System.Drawing.Size(123, 23);
            this.btn_uppdatera.TabIndex = 22;
            this.btn_uppdatera.Text = "Uppdatera valt spel";
            this.btn_uppdatera.UseVisualStyleBackColor = true;
            this.btn_uppdatera.Click += new System.EventHandler(this.btn_uppdatera_Click);
            // 
            // btn_laggTill
            // 
            this.btn_laggTill.Location = new System.Drawing.Point(29, 422);
            this.btn_laggTill.Name = "btn_laggTill";
            this.btn_laggTill.Size = new System.Drawing.Size(127, 23);
            this.btn_laggTill.TabIndex = 23;
            this.btn_laggTill.Text = "Nytt spel/Fakturor";
            this.btn_laggTill.UseVisualStyleBackColor = true;
            this.btn_laggTill.Click += new System.EventHandler(this.btn_laggTill_Click);
            // 
            // lbl_ejHitta
            // 
            this.lbl_ejHitta.AutoSize = true;
            this.lbl_ejHitta.Location = new System.Drawing.Point(317, 131);
            this.lbl_ejHitta.Name = "lbl_ejHitta";
            this.lbl_ejHitta.Size = new System.Drawing.Size(112, 13);
            this.lbl_ejHitta.TabIndex = 25;
            this.lbl_ejHitta.Text = "Kunde inte hitta spelet";
            this.lbl_ejHitta.Visible = false;
            // 
            // lbl_kontoNamn
            // 
            this.lbl_kontoNamn.AutoSize = true;
            this.lbl_kontoNamn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_kontoNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kontoNamn.Location = new System.Drawing.Point(370, 28);
            this.lbl_kontoNamn.Name = "lbl_kontoNamn";
            this.lbl_kontoNamn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_kontoNamn.Size = new System.Drawing.Size(59, 15);
            this.lbl_kontoNamn.TabIndex = 27;
            this.lbl_kontoNamn.Text = "Namn (roll)";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreDataGridViewTextBoxColumn.Width = 50;
            // 
            // titelDataGridViewTextBoxColumn
            // 
            this.titelDataGridViewTextBoxColumn.DataPropertyName = "Titel";
            this.titelDataGridViewTextBoxColumn.HeaderText = "Titel";
            this.titelDataGridViewTextBoxColumn.Name = "titelDataGridViewTextBoxColumn";
            this.titelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prisDataGridViewTextBoxColumn
            // 
            this.prisDataGridViewTextBoxColumn.DataPropertyName = "Pris";
            this.prisDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.prisDataGridViewTextBoxColumn.Name = "prisDataGridViewTextBoxColumn";
            this.prisDataGridViewTextBoxColumn.ReadOnly = true;
            this.prisDataGridViewTextBoxColumn.Width = 30;
            // 
            // aldersgransDataGridViewTextBoxColumn
            // 
            this.aldersgransDataGridViewTextBoxColumn.DataPropertyName = "Aldersgrans";
            this.aldersgransDataGridViewTextBoxColumn.HeaderText = "Aldersgrans";
            this.aldersgransDataGridViewTextBoxColumn.Name = "aldersgransDataGridViewTextBoxColumn";
            this.aldersgransDataGridViewTextBoxColumn.ReadOnly = true;
            this.aldersgransDataGridViewTextBoxColumn.Width = 70;
            // 
            // plattformDataGridViewTextBoxColumn
            // 
            this.plattformDataGridViewTextBoxColumn.DataPropertyName = "Plattform";
            this.plattformDataGridViewTextBoxColumn.HeaderText = "Plattform";
            this.plattformDataGridViewTextBoxColumn.Name = "plattformDataGridViewTextBoxColumn";
            this.plattformDataGridViewTextBoxColumn.ReadOnly = true;
            this.plattformDataGridViewTextBoxColumn.Width = 70;
            // 
            // utgivningDataGridViewTextBoxColumn
            // 
            this.utgivningDataGridViewTextBoxColumn.DataPropertyName = "Utgivning";
            this.utgivningDataGridViewTextBoxColumn.HeaderText = "Utgivning";
            this.utgivningDataGridViewTextBoxColumn.Name = "utgivningDataGridViewTextBoxColumn";
            this.utgivningDataGridViewTextBoxColumn.ReadOnly = true;
            this.utgivningDataGridViewTextBoxColumn.Width = 60;
            // 
            // spelBindingSource
            // 
            this.spelBindingSource.DataSource = typeof(johns_projekt.Spel);
            this.spelBindingSource.CurrentChanged += new System.EventHandler(this.spelBindingSource_CurrentChanged);
            // 
            // fysisktSpelBindingSource
            // 
            this.fysisktSpelBindingSource.DataSource = typeof(johns_projekt.FysisktSpel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 462);
            this.Controls.Add(this.lbl_kontoNamn);
            this.Controls.Add(this.lbl_ejHitta);
            this.Controls.Add(this.btn_laggTill);
            this.Controls.Add(this.btn_uppdatera);
            this.Controls.Add(this.btn_radera);
            this.Controls.Add(this.dgv_spel);
            this.Controls.Add(this.btn_sok);
            this.Controls.Add(this.lbl_pris);
            this.Controls.Add(this.lbl_utgivning);
            this.Controls.Add(this.lbl_titel);
            this.Controls.Add(this.rb_fallande);
            this.Controls.Add(this.rb_stigande);
            this.Controls.Add(this.rb_za);
            this.Controls.Add(this.rb_az);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.rb_modernt);
            this.Controls.Add(this.rb_retro);
            this.Controls.Add(this.lbl_spelbutik);
            this.Controls.Add(this.lbl_spel);
            this.Controls.Add(this.btn_rensa);
            this.Controls.Add(this.tbx_sok);
            this.Controls.Add(this.btn_hamtaSpel);
            this.Name = "Form1";
            this.Text = ".";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fysisktSpelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_hamtaSpel;
        private System.Windows.Forms.TextBox tbx_sok;
        private System.Windows.Forms.Button btn_rensa;
        private System.Windows.Forms.Label lbl_spel;
        private System.Windows.Forms.Label lbl_spelbutik;
        private System.Windows.Forms.RadioButton rb_retro;
        private System.Windows.Forms.RadioButton rb_modernt;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.RadioButton rb_az;
        private System.Windows.Forms.RadioButton rb_za;
        private System.Windows.Forms.RadioButton rb_stigande;
        private System.Windows.Forms.RadioButton rb_fallande;
        private System.Windows.Forms.Label lbl_titel;
        private System.Windows.Forms.Label lbl_utgivning;
        private System.Windows.Forms.Label lbl_pris;
        private System.Windows.Forms.Button btn_sok;
        private System.Windows.Forms.BindingSource spelBindingSource;
        private System.Windows.Forms.BindingSource fysisktSpelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aldersgransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plattformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utgivningDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_radera;
        private System.Windows.Forms.Button btn_uppdatera;
        private System.Windows.Forms.Button btn_laggTill;
        private System.Windows.Forms.Label lbl_ejHitta;
        private System.Windows.Forms.Label lbl_kontoNamn;
        internal System.Windows.Forms.DataGridView dgv_spel;
    }
}

