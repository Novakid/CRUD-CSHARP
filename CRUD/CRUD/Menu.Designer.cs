namespace CRUD
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            sELECTToolStripMenuItem = new ToolStripMenuItem();
            cREATEToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            singupToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sELECTToolStripMenuItem, eXITToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(710, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sELECTToolStripMenuItem
            // 
            sELECTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cREATEToolStripMenuItem });
            sELECTToolStripMenuItem.Name = "sELECTToolStripMenuItem";
            sELECTToolStripMenuItem.Size = new Size(57, 20);
            sELECTToolStripMenuItem.Text = "SELECT";
            // 
            // cREATEToolStripMenuItem
            // 
            cREATEToolStripMenuItem.Name = "cREATEToolStripMenuItem";
            cREATEToolStripMenuItem.Size = new Size(180, 22);
            cREATEToolStripMenuItem.Text = "CRUD";
            cREATEToolStripMenuItem.Click += cREATEToolStripMenuItem_Click;
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { singupToolStripMenuItem });
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(41, 20);
            eXITToolStripMenuItem.Text = "EXIT";
            // 
            // singupToolStripMenuItem
            // 
            singupToolStripMenuItem.Name = "singupToolStripMenuItem";
            singupToolStripMenuItem.Size = new Size(120, 22);
            singupToolStripMenuItem.Text = "Sign Out";
            singupToolStripMenuItem.Click += singupToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 406);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "CRUD";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sELECTToolStripMenuItem;
        private ToolStripMenuItem cREATEToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private ToolStripMenuItem singupToolStripMenuItem;
    }
}