namespace CRUD
{
    partial class CREATE
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
            btnCreate = new Button();
            lblName = new Label();
            label1 = new Label();
            label2 = new Label();
            listBoxData = new ListBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRead = new Button();
            txtRead = new TextBox();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(222, 196);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(38, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 89);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 154);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "Age";
            // 
            // listBoxData
            // 
            listBoxData.FormattingEnabled = true;
            listBoxData.ItemHeight = 15;
            listBoxData.Location = new Point(338, 30);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(206, 349);
            listBoxData.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 23);
            txtName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(107, 86);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(190, 23);
            txtLastName.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(107, 151);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(190, 23);
            txtAge.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(222, 225);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(222, 254);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(222, 293);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 21);
            btnRead.TabIndex = 12;
            btnRead.Text = "READ";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // txtRead
            // 
            txtRead.Location = new Point(107, 292);
            txtRead.Name = "txtRead";
            txtRead.Size = new Size(109, 23);
            txtRead.TabIndex = 13;
            // 
            // CREATE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 395);
            Controls.Add(txtRead);
            Controls.Add(btnRead);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(listBoxData);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(btnCreate);
            Name = "CREATE";
            Text = "CREATE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Label lblName;
        private Label label1;
        private Label label2;
        private ListBox listBoxData;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtAge;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRead;
        private TextBox txtRead;
    }
}