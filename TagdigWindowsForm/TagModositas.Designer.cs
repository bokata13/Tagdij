namespace TagdigWindowsForm
{
    partial class TagModositas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagModositas));
            this.label1 = new System.Windows.Forms.Label();
            this.comb_kriterium = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_nev = new System.Windows.Forms.CheckBox();
            this.cb_szulev = new System.Windows.Forms.CheckBox();
            this.cb_irszam = new System.Windows.Forms.CheckBox();
            this.cb_orszag = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_adat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_irszam = new System.Windows.Forms.TextBox();
            this.num_szulev = new System.Windows.Forms.NumericUpDown();
            this.tb_orszag = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_aktualizal = new System.Windows.Forms.Button();
            this.bt_megsem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_szulev)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keresés kritériuma:";
            // 
            // comb_kriterium
            // 
            this.comb_kriterium.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comb_kriterium.FormattingEnabled = true;
            this.comb_kriterium.Items.AddRange(new object[] {
            "Név",
            "Azonosító"});
            this.comb_kriterium.Location = new System.Drawing.Point(38, 71);
            this.comb_kriterium.Margin = new System.Windows.Forms.Padding(4);
            this.comb_kriterium.Name = "comb_kriterium";
            this.comb_kriterium.Size = new System.Drawing.Size(262, 26);
            this.comb_kriterium.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(42, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adat:";
            // 
            // cb_nev
            // 
            this.cb_nev.AutoSize = true;
            this.cb_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_nev.Location = new System.Drawing.Point(44, 288);
            this.cb_nev.Margin = new System.Windows.Forms.Padding(4);
            this.cb_nev.Name = "cb_nev";
            this.cb_nev.Size = new System.Drawing.Size(57, 22);
            this.cb_nev.TabIndex = 3;
            this.cb_nev.Text = "Név:";
            this.cb_nev.UseVisualStyleBackColor = true;
            // 
            // cb_szulev
            // 
            this.cb_szulev.AutoSize = true;
            this.cb_szulev.Location = new System.Drawing.Point(131, 288);
            this.cb_szulev.Margin = new System.Windows.Forms.Padding(4);
            this.cb_szulev.Name = "cb_szulev";
            this.cb_szulev.Size = new System.Drawing.Size(110, 22);
            this.cb_szulev.TabIndex = 4;
            this.cb_szulev.Text = "Születési év:";
            this.cb_szulev.UseVisualStyleBackColor = true;
            // 
            // cb_irszam
            // 
            this.cb_irszam.AutoSize = true;
            this.cb_irszam.Location = new System.Drawing.Point(273, 288);
            this.cb_irszam.Margin = new System.Windows.Forms.Padding(4);
            this.cb_irszam.Name = "cb_irszam";
            this.cb_irszam.Size = new System.Drawing.Size(111, 22);
            this.cb_irszam.TabIndex = 5;
            this.cb_irszam.Text = "Irányítószám";
            this.cb_irszam.UseVisualStyleBackColor = true;
            // 
            // cb_orszag
            // 
            this.cb_orszag.AutoSize = true;
            this.cb_orszag.Location = new System.Drawing.Point(402, 288);
            this.cb_orszag.Margin = new System.Windows.Forms.Padding(4);
            this.cb_orszag.Name = "cb_orszag";
            this.cb_orszag.Size = new System.Drawing.Size(160, 22);
            this.cb_orszag.TabIndex = 6;
            this.cb_orszag.Text = "Ország(Országkód)";
            this.cb_orszag.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Módosítandó adatok:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(38, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "(Új) Adatok:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Név:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 438);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Születési év:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 477);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Irányítószám:";
            this.label7.Visible = false;
            // 
            // tb_adat
            // 
            this.tb_adat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_adat.Location = new System.Drawing.Point(123, 138);
            this.tb_adat.Margin = new System.Windows.Forms.Padding(4);
            this.tb_adat.Name = "tb_adat";
            this.tb_adat.Size = new System.Drawing.Size(396, 24);
            this.tb_adat.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ország(Országkód):";
            this.label8.Visible = false;
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(191, 401);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(328, 24);
            this.tb_nev.TabIndex = 14;
            this.tb_nev.Visible = false;
            // 
            // tb_irszam
            // 
            this.tb_irszam.Location = new System.Drawing.Point(191, 471);
            this.tb_irszam.Name = "tb_irszam";
            this.tb_irszam.Size = new System.Drawing.Size(100, 24);
            this.tb_irszam.TabIndex = 15;
            this.tb_irszam.Visible = false;
            // 
            // num_szulev
            // 
            this.num_szulev.Location = new System.Drawing.Point(191, 436);
            this.num_szulev.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.num_szulev.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.num_szulev.Name = "num_szulev";
            this.num_szulev.Size = new System.Drawing.Size(120, 24);
            this.num_szulev.TabIndex = 16;
            this.num_szulev.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.num_szulev.Visible = false;
            // 
            // tb_orszag
            // 
            this.tb_orszag.Location = new System.Drawing.Point(191, 514);
            this.tb_orszag.Name = "tb_orszag";
            this.tb_orszag.Size = new System.Drawing.Size(100, 24);
            this.tb_orszag.TabIndex = 17;
            this.tb_orszag.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(767, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 308);
            this.button1.TabIndex = 18;
            this.button1.Text = "Keres";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_aktualizal
            // 
            this.bt_aktualizal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_aktualizal.Location = new System.Drawing.Point(690, 436);
            this.bt_aktualizal.Name = "bt_aktualizal";
            this.bt_aktualizal.Size = new System.Drawing.Size(203, 82);
            this.bt_aktualizal.TabIndex = 19;
            this.bt_aktualizal.Text = "Aktualizál";
            this.bt_aktualizal.UseVisualStyleBackColor = true;
            this.bt_aktualizal.Visible = false;
            this.bt_aktualizal.Click += new System.EventHandler(this.bt_aktualizal_Click);
            // 
            // bt_megsem
            // 
            this.bt_megsem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_megsem.Location = new System.Drawing.Point(962, 436);
            this.bt_megsem.Name = "bt_megsem";
            this.bt_megsem.Size = new System.Drawing.Size(203, 82);
            this.bt_megsem.TabIndex = 20;
            this.bt_megsem.Text = "Mégsem";
            this.bt_megsem.UseVisualStyleBackColor = true;
            this.bt_megsem.Visible = false;
            this.bt_megsem.Click += new System.EventHandler(this.bt_megsem_Click);
            // 
            // TagModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.bt_megsem);
            this.Controls.Add(this.bt_aktualizal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_orszag);
            this.Controls.Add(this.num_szulev);
            this.Controls.Add(this.tb_irszam);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_adat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_orszag);
            this.Controls.Add(this.cb_irszam);
            this.Controls.Add(this.cb_szulev);
            this.Controls.Add(this.cb_nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comb_kriterium);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TagModositas";
            this.Text = "Tag módosítása";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TagModositas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.num_szulev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comb_kriterium;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_nev;
        private System.Windows.Forms.CheckBox cb_szulev;
        private System.Windows.Forms.CheckBox cb_irszam;
        private System.Windows.Forms.CheckBox cb_orszag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_adat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.TextBox tb_irszam;
        private System.Windows.Forms.NumericUpDown num_szulev;
        private System.Windows.Forms.TextBox tb_orszag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_aktualizal;
        private System.Windows.Forms.Button bt_megsem;
    }
}