namespace TagdigWindowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tagokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagMódisításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.befizetésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újBefizetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.befizetésLekérdezéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tagokToolStripMenuItem,
            this.befizetésekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tagokToolStripMenuItem
            // 
            this.tagokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újTagToolStripMenuItem,
            this.tagMódisításaToolStripMenuItem});
            this.tagokToolStripMenuItem.Name = "tagokToolStripMenuItem";
            this.tagokToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.tagokToolStripMenuItem.Text = "Tagok";
            // 
            // újTagToolStripMenuItem
            // 
            this.újTagToolStripMenuItem.Name = "újTagToolStripMenuItem";
            this.újTagToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újTagToolStripMenuItem.Text = "Új tag";
            this.újTagToolStripMenuItem.Click += new System.EventHandler(this.újTagToolStripMenuItem_Click);
            // 
            // tagMódisításaToolStripMenuItem
            // 
            this.tagMódisításaToolStripMenuItem.Name = "tagMódisításaToolStripMenuItem";
            this.tagMódisításaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tagMódisításaToolStripMenuItem.Text = "Tag módisítása";
            this.tagMódisításaToolStripMenuItem.Click += new System.EventHandler(this.tagMódisításaToolStripMenuItem_Click);
            // 
            // befizetésekToolStripMenuItem
            // 
            this.befizetésekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újBefizetésToolStripMenuItem,
            this.befizetésLekérdezéseToolStripMenuItem});
            this.befizetésekToolStripMenuItem.Name = "befizetésekToolStripMenuItem";
            this.befizetésekToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.befizetésekToolStripMenuItem.Text = "Befizetések";
            // 
            // újBefizetésToolStripMenuItem
            // 
            this.újBefizetésToolStripMenuItem.Name = "újBefizetésToolStripMenuItem";
            this.újBefizetésToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.újBefizetésToolStripMenuItem.Text = "Új befizetés";
            this.újBefizetésToolStripMenuItem.Click += new System.EventHandler(this.újBefizetésToolStripMenuItem_Click);
            // 
            // befizetésLekérdezéseToolStripMenuItem
            // 
            this.befizetésLekérdezéseToolStripMenuItem.Name = "befizetésLekérdezéseToolStripMenuItem";
            this.befizetésLekérdezéseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.befizetésLekérdezéseToolStripMenuItem.Text = "Befizetés lekérdezése";
            this.befizetésLekérdezéseToolStripMenuItem.Click += new System.EventHandler(this.befizetésLekérdezéseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main Window";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tagokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagMódisításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem befizetésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újBefizetésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem befizetésLekérdezéseToolStripMenuItem;
    }
}

