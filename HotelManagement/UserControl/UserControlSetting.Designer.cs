namespace HotelManagement.UserControl
{
    partial class UserControlSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchUser = new System.Windows.Forms.TabPage();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateAndDeleteUser = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUsername1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControlUser.SuspendLayout();
            this.tabPageAddUser.SuspendLayout();
            this.tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.UpdateAndDeleteUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlUser.Controls.Add(this.tabPageAddUser);
            this.tabControlUser.Controls.Add(this.tabPageSearchUser);
            this.tabControlUser.Controls.Add(this.UpdateAndDeleteUser);
            this.tabControlUser.Location = new System.Drawing.Point(207, 119);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(1295, 660);
            this.tabControlUser.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.BackColor = System.Drawing.Color.White;
            this.tabPageAddUser.Controls.Add(this.buttonAdd);
            this.tabPageAddUser.Controls.Add(this.textBoxPassword);
            this.tabPageAddUser.Controls.Add(this.label3);
            this.tabPageAddUser.Controls.Add(this.textBoxUsername);
            this.tabPageAddUser.Controls.Add(this.label2);
            this.tabPageAddUser.Controls.Add(this.label1);
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUser.Size = new System.Drawing.Size(1287, 613);
            this.tabPageAddUser.TabIndex = 0;
            this.tabPageAddUser.Text = "Add User";
            this.tabPageAddUser.Click += new System.EventHandler(this.tabPageAddUser_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(143)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(125, 363);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(205, 47);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Leave += new System.EventHandler(this.buttonAdd_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(736, 301);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(449, 42);
            this.textBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(730, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.Location = new System.Drawing.Point(125, 301);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(449, 42);
            this.textBoxUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(143)))));
            this.label1.Location = new System.Drawing.Point(118, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User:";
            // 
            // tabPageSearchUser
            // 
            this.tabPageSearchUser.BackColor = System.Drawing.Color.White;
            this.tabPageSearchUser.Controls.Add(this.dataGridViewUser);
            this.tabPageSearchUser.Controls.Add(this.textBoxSearchUsername);
            this.tabPageSearchUser.Controls.Add(this.label5);
            this.tabPageSearchUser.Controls.Add(this.label4);
            this.tabPageSearchUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchUser.Name = "tabPageSearchUser";
            this.tabPageSearchUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchUser.Size = new System.Drawing.Size(1287, 613);
            this.tabPageSearchUser.TabIndex = 1;
            this.tabPageSearchUser.Text = "Search User";
            this.tabPageSearchUser.Enter += new System.EventHandler(this.tabPageSearchUser_Enter);
            this.tabPageSearchUser.Leave += new System.EventHandler(this.tabPageSearchUser_Leave);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewUser.Location = new System.Drawing.Point(101, 238);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.RowHeadersWidth = 72;
            this.dataGridViewUser.RowTemplate.Height = 31;
            this.dataGridViewUser.Size = new System.Drawing.Size(1047, 330);
            this.dataGridViewUser.TabIndex = 5;
            this.dataGridViewUser.Enter += new System.EventHandler(this.dataGridViewUser_Enter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "User_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "User_Name";
            this.Column2.HeaderText = "Username";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "User_Password";
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // textBoxSearchUsername
            // 
            this.textBoxSearchUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchUsername.Location = new System.Drawing.Point(371, 173);
            this.textBoxSearchUsername.Name = "textBoxSearchUsername";
            this.textBoxSearchUsername.Size = new System.Drawing.Size(449, 42);
            this.textBoxSearchUsername.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 34);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(143)))));
            this.label4.Location = new System.Drawing.Point(95, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search User:";
            // 
            // UpdateAndDeleteUser
            // 
            this.UpdateAndDeleteUser.BackColor = System.Drawing.Color.White;
            this.UpdateAndDeleteUser.Controls.Add(this.buttonDelete);
            this.UpdateAndDeleteUser.Controls.Add(this.buttonUpdate);
            this.UpdateAndDeleteUser.Controls.Add(this.textBoxPassword1);
            this.UpdateAndDeleteUser.Controls.Add(this.label6);
            this.UpdateAndDeleteUser.Controls.Add(this.textBoxUsername1);
            this.UpdateAndDeleteUser.Controls.Add(this.label7);
            this.UpdateAndDeleteUser.Controls.Add(this.label8);
            this.UpdateAndDeleteUser.Location = new System.Drawing.Point(4, 4);
            this.UpdateAndDeleteUser.Name = "UpdateAndDeleteUser";
            this.UpdateAndDeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateAndDeleteUser.Size = new System.Drawing.Size(1287, 613);
            this.UpdateAndDeleteUser.TabIndex = 2;
            this.UpdateAndDeleteUser.Text = "Update and Delete User";
            this.UpdateAndDeleteUser.Leave += new System.EventHandler(this.UpdateAndDeleteUser_Leave);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(375, 338);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(205, 47);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(143)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(154, 338);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(205, 47);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword1.Location = new System.Drawing.Point(765, 276);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(449, 42);
            this.textBoxPassword1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(759, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 34);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password:";
            // 
            // textBoxUsername1
            // 
            this.textBoxUsername1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername1.Location = new System.Drawing.Point(154, 276);
            this.textBoxUsername1.Name = "textBoxUsername1";
            this.textBoxUsername1.Size = new System.Drawing.Size(449, 42);
            this.textBoxUsername1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 34);
            this.label7.TabIndex = 7;
            this.label7.Text = "Username:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(143)))));
            this.label8.Location = new System.Drawing.Point(147, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "Update or Delete User";
            // 
            // UserControlSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UserControlSetting";
            this.Size = new System.Drawing.Size(1716, 959);
            this.tabControlUser.ResumeLayout(false);
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.tabPageSearchUser.ResumeLayout(false);
            this.tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.UpdateAndDeleteUser.ResumeLayout(false);
            this.UpdateAndDeleteUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.TabPage tabPageSearchUser;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textBoxSearchUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage UpdateAndDeleteUser;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUsername1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDelete;
    }
}
