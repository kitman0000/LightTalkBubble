namespace LightTalkChatBubble
{
    partial class LeftChatBubble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeftChatBubble));
            this.pictureBox_body = new System.Windows.Forms.PictureBox();
            this.pictureBox_conner = new System.Windows.Forms.PictureBox();
            this.lbl_sender = new System.Windows.Forms.Label();
            this.pictureBox_profile = new System.Windows.Forms.PictureBox();
            this.txt_Msg = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_conner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_body
            // 
            this.pictureBox_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            this.pictureBox_body.Location = new System.Drawing.Point(75, 21);
            this.pictureBox_body.Name = "pictureBox_body";
            this.pictureBox_body.Size = new System.Drawing.Size(280, 39);
            this.pictureBox_body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_body.TabIndex = 0;
            this.pictureBox_body.TabStop = false;
            // 
            // pictureBox_conner
            // 
            this.pictureBox_conner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_conner.Image")));
            this.pictureBox_conner.Location = new System.Drawing.Point(65, 21);
            this.pictureBox_conner.Name = "pictureBox_conner";
            this.pictureBox_conner.Size = new System.Drawing.Size(10, 39);
            this.pictureBox_conner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_conner.TabIndex = 1;
            this.pictureBox_conner.TabStop = false;
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_sender.Location = new System.Drawing.Point(67, 6);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(41, 12);
            this.lbl_sender.TabIndex = 3;
            this.lbl_sender.Text = "label1";
            // 
            // pictureBox_profile
            // 
            this.pictureBox_profile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_profile.Image")));
            this.pictureBox_profile.Location = new System.Drawing.Point(3, 6);
            this.pictureBox_profile.Name = "pictureBox_profile";
            this.pictureBox_profile.Size = new System.Drawing.Size(55, 55);
            this.pictureBox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_profile.TabIndex = 4;
            this.pictureBox_profile.TabStop = false;
            this.pictureBox_profile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.on_profile_picture_box_clicked);
            // 
            // txt_Msg
            // 
            this.txt_Msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            this.txt_Msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Msg.Location = new System.Drawing.Point(88, 32);
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.ReadOnly = true;
            this.txt_Msg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_Msg.Size = new System.Drawing.Size(100, 21);
            this.txt_Msg.TabIndex = 5;
            this.txt_Msg.Text = "";
            // 
            // LeftChatBubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.pictureBox_profile);
            this.Controls.Add(this.lbl_sender);
            this.Controls.Add(this.pictureBox_body);
            this.Controls.Add(this.pictureBox_conner);
            this.Name = "LeftChatBubble";
            this.Size = new System.Drawing.Size(366, 61);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_conner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_body;
        private System.Windows.Forms.PictureBox pictureBox_conner;
        private System.Windows.Forms.Label lbl_sender;
        private System.Windows.Forms.PictureBox pictureBox_profile;
        private System.Windows.Forms.RichTextBox txt_Msg;
    }
}
