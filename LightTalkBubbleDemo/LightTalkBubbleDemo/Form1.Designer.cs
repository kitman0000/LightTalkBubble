namespace LightTalkBubbleDemo
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_sendLeftMsg = new System.Windows.Forms.Button();
            this.txt_leftSend = new System.Windows.Forms.TextBox();
            this.txt_rightSend = new System.Windows.Forms.TextBox();
            this.btn_sendRightMsg = new System.Windows.Forms.Button();
            this.btn_sendLeftImg = new System.Windows.Forms.Button();
            this.btn_sendRightImg = new System.Windows.Forms.Button();
            this.btn_sendLeftVoice = new System.Windows.Forms.Button();
            this.btn_sendRightVoice = new System.Windows.Forms.Button();
            this.chatBox = new LightTalkChatBox.ChatBox();
            this.ProfileRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.taToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.私聊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sendLeftMsg
            // 
            this.btn_sendLeftMsg.Location = new System.Drawing.Point(18, 868);
            this.btn_sendLeftMsg.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sendLeftMsg.Name = "btn_sendLeftMsg";
            this.btn_sendLeftMsg.Size = new System.Drawing.Size(112, 34);
            this.btn_sendLeftMsg.TabIndex = 1;
            this.btn_sendLeftMsg.Text = "发送消息";
            this.btn_sendLeftMsg.UseVisualStyleBackColor = true;
            this.btn_sendLeftMsg.Click += new System.EventHandler(this.btn_sendLeftMsg_Click);
            // 
            // txt_leftSend
            // 
            this.txt_leftSend.Location = new System.Drawing.Point(18, 698);
            this.txt_leftSend.Margin = new System.Windows.Forms.Padding(4);
            this.txt_leftSend.Multiline = true;
            this.txt_leftSend.Name = "txt_leftSend";
            this.txt_leftSend.Size = new System.Drawing.Size(502, 160);
            this.txt_leftSend.TabIndex = 2;
            // 
            // txt_rightSend
            // 
            this.txt_rightSend.Location = new System.Drawing.Point(612, 698);
            this.txt_rightSend.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rightSend.Multiline = true;
            this.txt_rightSend.Name = "txt_rightSend";
            this.txt_rightSend.Size = new System.Drawing.Size(502, 160);
            this.txt_rightSend.TabIndex = 3;
            // 
            // btn_sendRightMsg
            // 
            this.btn_sendRightMsg.Location = new System.Drawing.Point(612, 868);
            this.btn_sendRightMsg.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sendRightMsg.Name = "btn_sendRightMsg";
            this.btn_sendRightMsg.Size = new System.Drawing.Size(112, 34);
            this.btn_sendRightMsg.TabIndex = 4;
            this.btn_sendRightMsg.Text = "发送消息";
            this.btn_sendRightMsg.UseVisualStyleBackColor = true;
            this.btn_sendRightMsg.Click += new System.EventHandler(this.btn_sendRightMsg_Click);
            // 
            // btn_sendLeftImg
            // 
            this.btn_sendLeftImg.Location = new System.Drawing.Point(140, 868);
            this.btn_sendLeftImg.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sendLeftImg.Name = "btn_sendLeftImg";
            this.btn_sendLeftImg.Size = new System.Drawing.Size(112, 34);
            this.btn_sendLeftImg.TabIndex = 5;
            this.btn_sendLeftImg.Text = "发送图片";
            this.btn_sendLeftImg.UseVisualStyleBackColor = true;
            this.btn_sendLeftImg.Click += new System.EventHandler(this.btn_sendLeftImg_Click);
            // 
            // btn_sendRightImg
            // 
            this.btn_sendRightImg.Location = new System.Drawing.Point(734, 868);
            this.btn_sendRightImg.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sendRightImg.Name = "btn_sendRightImg";
            this.btn_sendRightImg.Size = new System.Drawing.Size(112, 34);
            this.btn_sendRightImg.TabIndex = 6;
            this.btn_sendRightImg.Text = "发送图片";
            this.btn_sendRightImg.UseVisualStyleBackColor = true;
            this.btn_sendRightImg.Click += new System.EventHandler(this.btn_sendRightImg_Click);
            // 
            // btn_sendLeftVoice
            // 
            this.btn_sendLeftVoice.Location = new System.Drawing.Point(261, 868);
            this.btn_sendLeftVoice.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sendLeftVoice.Name = "btn_sendLeftVoice";
            this.btn_sendLeftVoice.Size = new System.Drawing.Size(112, 34);
            this.btn_sendLeftVoice.TabIndex = 7;
            this.btn_sendLeftVoice.Text = "发送语音";
            this.btn_sendLeftVoice.UseVisualStyleBackColor = true;
            this.btn_sendLeftVoice.Click += new System.EventHandler(this.btn_sendLeftVoice_Click);
            // 
            // btn_sendRightVoice
            // 
            this.btn_sendRightVoice.Location = new System.Drawing.Point(855, 868);
            this.btn_sendRightVoice.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sendRightVoice.Name = "btn_sendRightVoice";
            this.btn_sendRightVoice.Size = new System.Drawing.Size(112, 34);
            this.btn_sendRightVoice.TabIndex = 8;
            this.btn_sendRightVoice.Text = "发送语音";
            this.btn_sendRightVoice.UseVisualStyleBackColor = true;
            this.btn_sendRightVoice.Click += new System.EventHandler(this.btn_sendRightVoice_Click);
            // 
            // chatBox
            // 
            this.chatBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBox.BackColor = System.Drawing.Color.OliveDrab;
            this.chatBox.Location = new System.Drawing.Point(15, 15);
            this.chatBox.Margin = new System.Windows.Forms.Padding(6);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(1092, 610);
            this.chatBox.TabIndex = 0;
            this.chatBox.profileRightClicked += new LightTalkChatBox.ChatBox.ProfileRightClickHandle(this.chatBox_profileRightClicked);
            // 
            // ProfileRightClickMenu
            // 
            this.ProfileRightClickMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ProfileRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taToolStripMenuItem,
            this.私聊ToolStripMenuItem,
            this.查看ToolStripMenuItem});
            this.ProfileRightClickMenu.Name = "ProfileRightClickMenu";
            this.ProfileRightClickMenu.Size = new System.Drawing.Size(153, 94);
            // 
            // taToolStripMenuItem
            // 
            this.taToolStripMenuItem.Name = "taToolStripMenuItem";
            this.taToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.taToolStripMenuItem.Text = "查看名片";
            // 
            // 私聊ToolStripMenuItem
            // 
            this.私聊ToolStripMenuItem.Name = "私聊ToolStripMenuItem";
            this.私聊ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.私聊ToolStripMenuItem.Text = "@TA";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.查看ToolStripMenuItem.Text = "发起私聊";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 904);
            this.Controls.Add(this.btn_sendRightVoice);
            this.Controls.Add(this.btn_sendLeftVoice);
            this.Controls.Add(this.btn_sendRightImg);
            this.Controls.Add(this.btn_sendLeftImg);
            this.Controls.Add(this.btn_sendRightMsg);
            this.Controls.Add(this.txt_rightSend);
            this.Controls.Add(this.txt_leftSend);
            this.Controls.Add(this.btn_sendLeftMsg);
            this.Controls.Add(this.chatBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ProfileRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LightTalkChatBox.ChatBox chatBox;
        private System.Windows.Forms.Button btn_sendLeftMsg;
        private System.Windows.Forms.TextBox txt_leftSend;
        private System.Windows.Forms.TextBox txt_rightSend;
        private System.Windows.Forms.Button btn_sendRightMsg;
        private System.Windows.Forms.Button btn_sendLeftImg;
        private System.Windows.Forms.Button btn_sendRightImg;
        private System.Windows.Forms.Button btn_sendLeftVoice;
        private System.Windows.Forms.Button btn_sendRightVoice;
        private System.Windows.Forms.ContextMenuStrip ProfileRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem taToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 私聊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
    }
}

