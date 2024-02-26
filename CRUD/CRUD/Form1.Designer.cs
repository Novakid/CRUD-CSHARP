namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUser = new Label();
            lblPass = new Label();
            btnEnter = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnAcc = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(200, 85);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(34, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "USER";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(190, 167);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(57, 15);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password";
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(176, 247);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(107, 121);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(232, 23);
            txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(107, 200);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(232, 23);
            txtPass.TabIndex = 4;
            // 
            // btnAcc
            // 
            btnAcc.Location = new Point(12, 12);
            btnAcc.Name = "btnAcc";
            btnAcc.Size = new Size(75, 23);
            btnAcc.TabIndex = 5;
            btnAcc.Text = "ACC";
            btnAcc.UseVisualStyleBackColor = true;
            btnAcc.Click += btnAcc_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(176, 291);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(421, 364);
            Controls.Add(btnExit);
            Controls.Add(btnAcc);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnEnter);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "CRUD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPass;
        private Button btnEnter;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnAcc;
        private Button btnExit;
    }
}
