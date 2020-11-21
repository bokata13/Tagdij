namespace TagdigWindowsForm
{
    partial class UjBefizetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UjBefizetes));
            this.label1 = new System.Windows.Forms.Label();
            this.comb_kriterium = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_rogzit = new System.Windows.Forms.Button();
            this.tb_adat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_osszeg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_adat2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_megse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keresés kritériuma:";
            // 
            // comb_kriterium
            // 
            this.comb_kriterium.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comb_kriterium.FormattingEnabled = true;
            this.comb_kriterium.Items.AddRange(new object[] {
            "Név",
            "Azonosító"});
            this.comb_kriterium.Location = new System.Drawing.Point(17, 63);
            this.comb_kriterium.Margin = new System.Windows.Forms.Padding(4);
            this.comb_kriterium.Name = "comb_kriterium";
            this.comb_kriterium.Size = new System.Drawing.Size(262, 26);
            this.comb_kriterium.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adat:";
            // 
            // bt_rogzit
            // 
            this.bt_rogzit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_rogzit.Location = new System.Drawing.Point(562, 21);
            this.bt_rogzit.Name = "bt_rogzit";
            this.bt_rogzit.Size = new System.Drawing.Size(203, 82);
            this.bt_rogzit.TabIndex = 20;
            this.bt_rogzit.Text = "Rögzít";
            this.bt_rogzit.UseVisualStyleBackColor = true;
            this.bt_rogzit.Click += new System.EventHandler(this.bt_rogzit_Click);
            // 
            // tb_adat
            // 
            this.tb_adat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_adat.Location = new System.Drawing.Point(68, 115);
            this.tb_adat.Margin = new System.Windows.Forms.Padding(4);
            this.tb_adat.Name = "tb_adat";
            this.tb_adat.Size = new System.Drawing.Size(396, 24);
            this.tb_adat.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(29, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Összeg:";
            // 
            // tb_osszeg
            // 
            this.tb_osszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_osszeg.Location = new System.Drawing.Point(133, 102);
            this.tb_osszeg.Margin = new System.Windows.Forms.Padding(4);
            this.tb_osszeg.Name = "tb_osszeg";
            this.tb_osszeg.Size = new System.Drawing.Size(376, 24);
            this.tb_osszeg.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(564, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 76);
            this.button1.TabIndex = 24;
            this.button1.Text = "Keres";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Adat:";
            // 
            // tb_adat2
            // 
            this.tb_adat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_adat2.Location = new System.Drawing.Point(68, 163);
            this.tb_adat2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_adat2.Name = "tb_adat2";
            this.tb_adat2.Size = new System.Drawing.Size(396, 24);
            this.tb_adat2.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.bt_megse);
            this.panel1.Controls.Add(this.tb_osszeg);
            this.panel1.Controls.Add(this.bt_rogzit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 230);
            this.panel1.TabIndex = 28;
            // 
            // bt_megse
            // 
            this.bt_megse.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_megse.Location = new System.Drawing.Point(562, 133);
            this.bt_megse.Name = "bt_megse";
            this.bt_megse.Size = new System.Drawing.Size(203, 82);
            this.bt_megse.TabIndex = 24;
            this.bt_megse.Text = "Mégsem";
            this.bt_megse.UseVisualStyleBackColor = true;
            this.bt_megse.Click += new System.EventHandler(this.bt_megse_Click);
            // 
            // UjBefizetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_adat2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_adat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comb_kriterium);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UjBefizetes";
            this.Text = "Új befizetés";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UjBefizetes_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comb_kriterium;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_rogzit;
        private System.Windows.Forms.TextBox tb_adat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_osszeg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_adat2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_megse;
    }
}