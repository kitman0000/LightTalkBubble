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
            this.btn_sendLeftMsg = new System.Windows.Forms.Button();
            this.txt_leftSend = new System.Windows.Forms.TextBox();
            this.txt_rightSend = new System.Windows.Forms.TextBox();
            this.btn_sendRightMsg = new System.Windows.Forms.Button();
            this.btn_sendLeftImg = new System.Windows.Forms.Button();
            this.btn_sendRightImg = new System.Windows.Forms.Button();
            this.btn_sendLeftVoice = new System.Windows.Forms.Button();
            this.btn_sendRightVoice = new System.Windows.Forms.Button();
            this.chatBox = new LightTalkChatBox.ChatBox();
            this.SuspendLayout();
            // 
            // btn_sendLeftMsg
            // 
            this.btn_sendLeftMsg.Location = new System.Drawing.Point(12, 579);
            this.btn_sendLeftMsg.Name = "btn_sendLeftMsg";
            this.btn_sendLeftMsg.Size = new System.Drawing.Size(75, 23);
            this.btn_sendLeftMsg.TabIndex = 1;
            this.btn_sendLeftMsg.Text = "发送消息";
            this.btn_sendLeftMsg.UseVisualStyleBackColor = true;
            this.btn_sendLeftMsg.Click += new System.EventHandler(this.btn_sendLeftMsg_Click);
            // 
            // txt_leftSend
            // 
            this.txt_leftSend.Location = new System.Drawing.Point(12, 465);
            this.txt_leftSend.Multiline = true;
            this.txt_leftSend.Name = "txt_leftSend";
            this.txt_leftSend.Size = new System.Drawing.Size(336, 108);
            this.txt_leftSend.TabIndex = 2;
            // 
            // txt_rightSend
            // 
            this.txt_rightSend.Location = new System.Drawing.Point(408, 465);
            this.txt_rightSend.Multiline = true;
            this.txt_rightSend.Name = "txt_rightSend";
            this.txt_rightSend.Size = new System.Drawing.Size(336, 108);
            this.txt_rightSend.TabIndex = 3;
            // 
            // btn_sendRightMsg
            // 
            this.btn_sendRightMsg.Location = new System.Drawing.Point(408, 579);
            this.btn_sendRightMsg.Name = "btn_sendRightMsg";
            this.btn_sendRightMsg.Size = new System.Drawing.Size(75, 23);
            this.btn_sendRightMsg.TabIndex = 4;
            this.btn_sendRightMsg.Text = "发送消息";
            this.btn_sendRightMsg.UseVisualStyleBackColor = true;
            this.btn_sendRightMsg.Click += new System.EventHandler(this.btn_sendRightMsg_Click);
            // 
            // btn_sendLeftImg
            // 
            this.btn_sendLeftImg.Location = new System.Drawing.Point(93, 579);
            this.btn_sendLeftImg.Name = "btn_sendLeftImg";
            this.btn_sendLeftImg.Size = new System.Drawing.Size(75, 23);
            this.btn_sendLeftImg.TabIndex = 5;
            this.btn_sendLeftImg.Text = "发送图片";
            this.btn_sendLeftImg.UseVisualStyleBackColor = true;
            this.btn_sendLeftImg.Click += new System.EventHandler(this.btn_sendLeftImg_Click);
            // 
            // btn_sendRightImg
            // 
            this.btn_sendRightImg.Location = new System.Drawing.Point(489, 579);
            this.btn_sendRightImg.Name = "btn_sendRightImg";
            this.btn_sendRightImg.Size = new System.Drawing.Size(75, 23);
            this.btn_sendRightImg.TabIndex = 6;
            this.btn_sendRightImg.Text = "发送图片";
            this.btn_sendRightImg.UseVisualStyleBackColor = true;
            this.btn_sendRightImg.Click += new System.EventHandler(this.btn_sendRightImg_Click);
            // 
            // btn_sendLeftVoice
            // 
            this.btn_sendLeftVoice.Location = new System.Drawing.Point(174, 579);
            this.btn_sendLeftVoice.Name = "btn_sendLeftVoice";
            this.btn_sendLeftVoice.Size = new System.Drawing.Size(75, 23);
            this.btn_sendLeftVoice.TabIndex = 7;
            this.btn_sendLeftVoice.Text = "发送语音";
            this.btn_sendLeftVoice.UseVisualStyleBackColor = true;
            this.btn_sendLeftVoice.Click += new System.EventHandler(this.btn_sendLeftVoice_Click);
            // 
            // btn_sendRightVoice
            // 
            this.btn_sendRightVoice.Location = new System.Drawing.Point(570, 579);
            this.btn_sendRightVoice.Name = "btn_sendRightVoice";
            this.btn_sendRightVoice.Size = new System.Drawing.Size(75, 23);
            this.btn_sendRightVoice.TabIndex = 8;
            this.btn_sendRightVoice.Text = "发送语音";
            this.btn_sendRightVoice.UseVisualStyleBackColor = true;
            this.btn_sendRightVoice.Click += new System.EventHandler(this.btn_sendRightVoice_Click);
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.Transparent;
            this.chatBox.Location = new System.Drawing.Point(12, 24);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(733, 419);
            this.chatBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 602);
            this.Controls.Add(this.btn_sendRightVoice);
            this.Controls.Add(this.btn_sendLeftVoice);
            this.Controls.Add(this.btn_sendRightImg);
            this.Controls.Add(this.btn_sendLeftImg);
            this.Controls.Add(this.btn_sendRightMsg);
            this.Controls.Add(this.txt_rightSend);
            this.Controls.Add(this.txt_leftSend);
            this.Controls.Add(this.btn_sendLeftMsg);
            this.Controls.Add(this.chatBox);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

