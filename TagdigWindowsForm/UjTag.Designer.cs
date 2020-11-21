namespace TagdigWindowsForm
{
    partial class UjTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UjTag));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.num_szulev = new System.Windows.Forms.NumericUpDown();
            this.tb_irszam = new System.Windows.Forms.TextBox();
            this.tb_orszag = new System.Windows.Forms.TextBox();
            this.bt_ujtag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_szulev)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Születési év:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Irányítószám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(29, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ország:";
            // 
            // tb_nev
            // 
            this.tb_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tb_nev.Location = new System.Drawing.Point(178, 41);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(291, 29);
            this.tb_nev.TabIndex = 4;
            // 
            // num_szulev
            // 
            this.num_szulev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.num_szulev.Location = new System.Drawing.Point(178, 105);
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
            this.num_szulev.Size = new System.Drawing.Size(120, 29);
            this.num_szulev.TabIndex = 5;
            this.num_szulev.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // tb_irszam
            // 
            this.tb_irszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tb_irszam.Location = new System.Drawing.Point(178, 170);
            this.tb_irszam.Name = "tb_irszam";
            this.tb_irszam.Size = new System.Drawing.Size(291, 29);
            this.tb_irszam.TabIndex = 6;
            // 
            // tb_orszag
            // 
            this.tb_orszag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tb_orszag.Location = new System.Drawing.Point(178, 235);
            this.tb_orszag.Name = "tb_orszag";
            this.tb_orszag.Size = new System.Drawing.Size(291, 29);
            this.tb_orszag.TabIndex = 7;
            // 
            // bt_ujtag
            // 
            this.bt_ujtag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.bt_ujtag.Location = new System.Drawing.Point(515, 359);
            this.bt_ujtag.Name = "bt_ujtag";
            this.bt_ujtag.Size = new System.Drawing.Size(212, 53);
            this.bt_ujtag.TabIndex = 8;
            this.bt_ujtag.Text = "Hozzáad";
            this.bt_ujtag.UseVisualStyleBackColor = true;
            this.bt_ujtag.Click += new System.EventHandler(this.bt_ujtag_Click);
            // 
            // UjTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_ujtag);
            this.Controls.Add(this.tb_orszag);
            this.Controls.Add(this.tb_irszam);
            this.Controls.Add(this.num_szulev);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UjTag";
            this.Text = "Új tag";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UjTag_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.num_szulev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.NumericUpDown num_szulev;
        private System.Windows.Forms.TextBox tb_irszam;
        private System.Windows.Forms.TextBox tb_orszag;
        private System.Windows.Forms.Button bt_ujtag;
    }
}