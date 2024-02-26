namespace CRUD
{
    partial class Form2
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
            sEARCHToolStripMenuItem = new ToolStripMenuItem();
            cREATEToolStripMenuItem = new ToolStripMenuItem();
            dELETEToolStripMenuItem = new ToolStripMenuItem();
            uPDATEToolStripMenuItem = new ToolStripMenuItem();
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
            sELECTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sEARCHToolStripMenuItem, cREATEToolStripMenuItem, dELETEToolStripMenuItem, uPDATEToolStripMenuItem });
            sELECTToolStripMenuItem.Name = "sELECTToolStripMenuItem";
            sELECTToolStripMenuItem.Size = new Size(57, 20);
            sELECTToolStripMenuItem.Text = "SELECT";
            // 
            // sEARCHToolStripMenuItem
            // 
            sEARCHToolStripMenuItem.Name = "sEARCHToolStripMenuItem";
            sEARCHToolStripMenuItem.Size = new Size(118, 22);
            sEARCHToolStripMenuItem.Text = "SEARCH";
            // 
            // cREATEToolStripMenuItem
            // 
            cREATEToolStripMenuItem.Name = "cREATEToolStripMenuItem";
            cREATEToolStripMenuItem.Size = new Size(118, 22);
            cREATEToolStripMenuItem.Text = "CREATE";
            // 
            // dELETEToolStripMenuItem
            // 
            dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            dELETEToolStripMenuItem.Size = new Size(118, 22);
            dELETEToolStripMenuItem.Text = "DELETE";
            // 
            // uPDATEToolStripMenuItem
            // 
            uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            uPDATEToolStripMenuItem.Size = new Size(118, 22);
            uPDATEToolStripMenuItem.Text = "UPDATE";
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
            singupToolStripMenuItem.Size = new Size(180, 22);
            singupToolStripMenuItem.Text = "Sign Out";
            singupToolStripMenuItem.Click += singupToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 406);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "CRUD";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sELECTToolStripMenuItem;
        private ToolStripMenuItem sEARCHToolStripMenuItem;
        private ToolStripMenuItem cREATEToolStripMenuItem;
        private ToolStripMenuItem dELETEToolStripMenuItem;
        private ToolStripMenuItem uPDATEToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private ToolStripMenuItem singupToolStripMenuItem;
    }
}