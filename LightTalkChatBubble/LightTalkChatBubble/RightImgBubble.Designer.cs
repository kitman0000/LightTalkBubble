namespace LightTalkChatBubble
{
    partial class RightImgBubble
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RightImgBubble));
            this.pictureBox_profile = new System.Windows.Forms.PictureBox();
            this.lbl_sender = new System.Windows.Forms.Label();
            this.pictureBox_body = new System.Windows.Forms.PictureBox();
            this.pictureBox_conner = new System.Windows.Forms.PictureBox();
            this.pictureBox_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_conner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_profile
            // 
            this.pictureBox_profile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_profile.Image")));
            this.pictureBox_profile.Location = new System.Drawing.Point(352, 0);
            this.pictureBox_profile.Name = "pictureBox_profile";
            this.pictureBox_profile.Size = new System.Drawing.Size(55, 55);
            this.pictureBox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_profile.TabIndex = 9;
            this.pictureBox_profile.TabStop = false;
            this.pictureBox_profile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.on_profile_picture_box_clicked);
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_sender.Location = new System.Drawing.Point(287, 0);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(41, 12);
            this.lbl_sender.TabIndex = 8;
            this.lbl_sender.Text = "label1";
            // 
            // pictureBox_body
            // 
            this.pictureBox_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pictureBox_body.Location = new System.Drawing.Point(289, 16);
            this.pictureBox_body.Name = "pictureBox_body";
            this.pictureBox_body.Size = new System.Drawing.Size(39, 39);
            this.pictureBox_body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_body.TabIndex = 6;
            this.pictureBox_body.TabStop = false;
            // 
            // pictureBox_conner
            // 
            this.pictureBox_conner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_conner.Image")));
            this.pictureBox_conner.Location = new System.Drawing.Point(328, 16);
            this.pictureBox_conner.Name = "pictureBox_conner";
            this.pictureBox_conner.Size = new System.Drawing.Size(10, 39);
            this.pictureBox_conner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_conner.TabIndex = 7;
            this.pictureBox_conner.TabStop = false;
            // 
            // pictureBox_img
            // 
            this.pictureBox_img.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_img.Image")));
            this.pictureBox_img.Location = new System.Drawing.Point(289, 17);
            this.pictureBox_img.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox_img.Name = "pictureBox_img";
            this.pictureBox_img.Size = new System.Drawing.Size(39, 39);
            this.pictureBox_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_img.TabIndex = 10;
            this.pictureBox_img.TabStop = false;
            // 
            // RightImgBubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox_img);
            this.Controls.Add(this.pictureBox_profile);
            this.Controls.Add(this.lbl_sender);
            this.Controls.Add(this.pictureBox_body);
            this.Controls.Add(this.pictureBox_conner);
            this.Name = "RightImgBubble";
            this.Size = new System.Drawing.Size(407, 57);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_conner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_profile;
        private System.Windows.Forms.Label lbl_sender;
        private System.Windows.Forms.PictureBox pictureBox_body;
        private System.Windows.Forms.PictureBox pictureBox_conner;
        private System.Windows.Forms.PictureBox pictureBox_img;
    }
}
