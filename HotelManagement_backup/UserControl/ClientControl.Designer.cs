//using System.Windows.Forms;
//using System;

//namespace HotelManagement.UserControl
//{
//    partial class ClientControl
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.label1 = new System.Windows.Forms.Label();
//            this.button1 = new System.Windows.Forms.Button();
//            this.SuspendLayout();
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(50, 50);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(130, 25);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "Client Control";
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(50, 100);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(75, 23);
//            this.button1.TabIndex = 1;
//            this.button1.Text = "Click Me";
//            this.button1.Click += new System.EventHandler(this.button1_Click);
//            // 
//            // ClientControl
//            // 
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.button1);
//            this.Name = "ClientControl";
//            this.Size = new System.Drawing.Size(1456, 616);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Button button1;

//        // Event handler for button click
//        private void button1_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show("Button clicked!");
//        }
//    }
//}


namespace HotelManagement.UserControl
{
    partial class ClientControl
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
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageAddClient = new System.Windows.Forms.TabPage();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchClient = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchPhoneNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageUpdateAndDelete = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPhoneNO1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxLastName1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFirstName1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControlClient.SuspendLayout();
            this.tabPageAddClient.SuspendLayout();
            this.tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPageUpdateAndDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlClient.Controls.Add(this.tabPageAddClient);
            this.tabControlClient.Controls.Add(this.tabPageSearchClient);
            this.tabControlClient.Controls.Add(this.tabPageUpdateAndDelete);
            this.tabControlClient.Location = new System.Drawing.Point(178, 131);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1295, 660);
            this.tabControlClient.TabIndex = 1;
            // 
            // tabPageAddClient
            // 
            this.tabPageAddClient.BackColor = System.Drawing.Color.White;
            this.tabPageAddClient.Controls.Add(this.textBoxAddress);
            this.tabPageAddClient.Controls.Add(this.label5);
            this.tabPageAddClient.Controls.Add(this.textBoxPhoneNo);
            this.tabPageAddClient.Controls.Add(this.label4);
            this.tabPageAddClient.Controls.Add(this.buttonAdd);
            this.tabPageAddClient.Controls.Add(this.textBoxLastName);
            this.tabPageAddClient.Controls.Add(this.label3);
            this.tabPageAddClient.Controls.Add(this.textBoxFirstName);
            this.tabPageAddClient.Controls.Add(this.label2);
            this.tabPageAddClient.Controls.Add(this.label1);
            this.tabPageAddClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClient.Name = "tabPageAddClient";
            this.tabPageAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClient.Size = new System.Drawing.Size(1287, 613);
            this.tabPageAddClient.TabIndex = 0;
            this.tabPageAddClient.Text = "Add Client";
            this.tabPageAddClient.Click += new System.EventHandler(this.tabPage3_Click);
            this.tabPageAddClient.Leave += new System.EventHandler(this.tabPageAddClient_Leave);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddress.Location = new System.Drawing.Point(119, 427);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(1060, 107);
            this.textBoxAddress.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 34);
            this.label5.TabIndex = 14;
            this.label5.Text = "Address:";
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNo.Location = new System.Drawing.Point(118, 305);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(449, 42);
            this.textBoxPhoneNo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone Number:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(143)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(730, 290);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(205, 47);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastName.Location = new System.Drawing.Point(730, 184);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(449, 42);
            this.textBoxLastName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(724, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName.Location = new System.Drawing.Point(119, 184);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(449, 42);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(143)))));
            this.label1.Location = new System.Drawing.Point(112, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Client:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPageSearchClient
            // 
            this.tabPageSearchClient.BackColor = System.Drawing.Color.White;
            this.tabPageSearchClient.Controls.Add(this.dataGridViewClient);
            this.tabPageSearchClient.Controls.Add(this.textBoxSearchPhoneNo);
            this.tabPageSearchClient.Controls.Add(this.label6);
            this.tabPageSearchClient.Controls.Add(this.label7);
            this.tabPageSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClient.Name = "tabPageSearchClient";
            this.tabPageSearchClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchClient.Size = new System.Drawing.Size(1287, 613);
            this.tabPageSearchClient.TabIndex = 1;
            this.tabPageSearchClient.Text = "Search Client";
            this.tabPageSearchClient.Enter += new System.EventHandler(this.tabPageSearchClient_Enter);
            this.tabPageSearchClient.Leave += new System.EventHandler(this.tabPageSearchClient_Leave);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewClient.Location = new System.Drawing.Point(123, 221);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowHeadersWidth = 72;
            this.dataGridViewClient.RowTemplate.Height = 31;
            this.dataGridViewClient.Size = new System.Drawing.Size(1047, 330);
            this.dataGridViewClient.TabIndex = 9;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            this.dataGridViewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Client_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Client_FirstName";
            this.Column2.HeaderText = "First Name";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Client_LastName";
            this.Column3.HeaderText = "Last Name";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Client_Phone";
            this.Column4.HeaderText = "Phone";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // textBoxSearchPhoneNo
            // 
            this.textBoxSearchPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchPhoneNo.Location = new System.Drawing.Point(393, 156);
            this.textBoxSearchPhoneNo.Name = "textBoxSearchPhoneNo";
            this.textBoxSearchPhoneNo.Size = new System.Drawing.Size(449, 42);
            this.textBoxSearchPhoneNo.TabIndex = 8;
            this.textBoxSearchPhoneNo.TextChanged += new System.EventHandler(this.textBoxSearchPhoneNo_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 34);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone number:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(143)))));
            this.label7.Location = new System.Drawing.Point(117, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "Search Client:";
            // 
            // tabPageUpdateAndDelete
            // 
            this.tabPageUpdateAndDelete.BackColor = System.Drawing.Color.White;
            this.tabPageUpdateAndDelete.Controls.Add(this.buttonDelete);
            this.tabPageUpdateAndDelete.Controls.Add(this.textBoxAddress1);
            this.tabPageUpdateAndDelete.Controls.Add(this.label8);
            this.tabPageUpdateAndDelete.Controls.Add(this.textBoxPhoneNO1);
            this.tabPageUpdateAndDelete.Controls.Add(this.label9);
            this.tabPageUpdateAndDelete.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateAndDelete.Controls.Add(this.textBoxLastName1);
            this.tabPageUpdateAndDelete.Controls.Add(this.label10);
            this.tabPageUpdateAndDelete.Controls.Add(this.textBoxFirstName1);
            this.tabPageUpdateAndDelete.Controls.Add(this.label11);
            this.tabPageUpdateAndDelete.Controls.Add(this.label12);
            this.tabPageUpdateAndDelete.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndDelete.Name = "tabPageUpdateAndDelete";
            this.tabPageUpdateAndDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAndDelete.Size = new System.Drawing.Size(1287, 613);
            this.tabPageUpdateAndDelete.TabIndex = 2;
            this.tabPageUpdateAndDelete.Text = "Update and Delete Client";
            this.tabPageUpdateAndDelete.Leave += new System.EventHandler(this.tabPageUpdateAndDelete_Leave);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(956, 308);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(205, 47);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddress1.Location = new System.Drawing.Point(111, 435);
            this.textBoxAddress1.Multiline = true;
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(1060, 107);
            this.textBoxAddress1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 34);
            this.label8.TabIndex = 24;
            this.label8.Text = "Address:";
            // 
            // textBoxPhoneNO1
            // 
            this.textBoxPhoneNO1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNO1.Location = new System.Drawing.Point(110, 313);
            this.textBoxPhoneNO1.Name = "textBoxPhoneNO1";
            this.textBoxPhoneNO1.Size = new System.Drawing.Size(449, 42);
            this.textBoxPhoneNO1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 34);
            this.label9.TabIndex = 22;
            this.label9.Text = "Phone Number:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(143)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(722, 308);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(205, 47);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxLastName1
            // 
            this.textBoxLastName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastName1.Location = new System.Drawing.Point(722, 192);
            this.textBoxLastName1.Name = "textBoxLastName1";
            this.textBoxLastName1.Size = new System.Drawing.Size(449, 42);
            this.textBoxLastName1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(716, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 34);
            this.label10.TabIndex = 19;
            this.label10.Text = "Last Name:";
            // 
            // textBoxFirstName1
            // 
            this.textBoxFirstName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName1.Location = new System.Drawing.Point(111, 192);
            this.textBoxFirstName1.Name = "textBoxFirstName1";
            this.textBoxFirstName1.Size = new System.Drawing.Size(449, 42);
            this.textBoxFirstName1.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 34);
            this.label11.TabIndex = 17;
            this.label11.Text = "First Name:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(213)))), ((int)(((byte)(143)))));
            this.label12.Location = new System.Drawing.Point(104, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 39);
            this.label12.TabIndex = 16;
            this.label12.Text = "Add Client:";
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlClient);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(1716, 959);
            this.Load += new System.EventHandler(this.ClientControl_Load);
            this.tabControlClient.ResumeLayout(false);
            this.tabPageAddClient.ResumeLayout(false);
            this.tabPageAddClient.PerformLayout();
            this.tabPageSearchClient.ResumeLayout(false);
            this.tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPageUpdateAndDelete.ResumeLayout(false);
            this.tabPageUpdateAndDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPageAddClient;
        private System.Windows.Forms.TabPage tabPageSearchClient;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpdateAndDelete;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBoxSearchPhoneNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPhoneNO1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxLastName1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFirstName1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}