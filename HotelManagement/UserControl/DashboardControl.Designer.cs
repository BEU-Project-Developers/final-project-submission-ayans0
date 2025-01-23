namespace HotelManagement.UserControl
{
    partial class DashboardControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClient = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelRoom = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelClientCount = new System.Windows.Forms.Label();
            this.labelRoomCount = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.labelClientCount);
            this.panel2.Controls.Add(this.labelClient);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(77, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 132);
            this.panel2.TabIndex = 1;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(266, 48);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(103, 34);
            this.labelClient.TabIndex = 3;
            this.labelClient.Text = "Client:";
            this.labelClient.Click += new System.EventHandler(this.labelClient_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelManagement.Properties.Resources._7065207_humans_community_people_group_organization_icon;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(147)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.labelRoomCount);
            this.panel3.Controls.Add(this.labelRoom);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(77, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1326, 134);
            this.panel3.TabIndex = 1;
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(266, 48);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(101, 34);
            this.labelRoom.TabIndex = 3;
            this.labelRoom.Text = "Room:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelManagement.Properties.Resources._3793930_furniture_home_house_living_offie_icon;
            this.pictureBox3.Location = new System.Drawing.Point(12, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(208, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // labelClientCount
            // 
            this.labelClientCount.AutoSize = true;
            this.labelClientCount.Location = new System.Drawing.Point(373, 48);
            this.labelClientCount.Name = "labelClientCount";
            this.labelClientCount.Size = new System.Drawing.Size(32, 34);
            this.labelClientCount.TabIndex = 4;
            this.labelClientCount.Text = "?";
            // 
            // labelRoomCount
            // 
            this.labelRoomCount.AutoSize = true;
            this.labelRoomCount.Location = new System.Drawing.Point(373, 48);
            this.labelRoomCount.Name = "labelRoomCount";
            this.labelRoomCount.Size = new System.Drawing.Size(32, 34);
            this.labelRoomCount.TabIndex = 4;
            this.labelRoomCount.Text = "?";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1500, 900);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelClientCount;
        private System.Windows.Forms.Label labelRoomCount;
    }
}
