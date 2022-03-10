namespace LightTalkChatBox
{
    partial class ChatBox
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
            this.chatPanel = new CCWin.SkinControl.SkinPanel();
            this.SuspendLayout();
            // 
            // chatPanel
            // 
            this.chatPanel.AutoScroll = true;
            this.chatPanel.BackColor = System.Drawing.Color.White;
            this.chatPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.DownBack = null;
            this.chatPanel.Location = new System.Drawing.Point(0, 0);
            this.chatPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatPanel.MouseBack = null;
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.NormlBack = null;
            this.chatPanel.Size = new System.Drawing.Size(1098, 628);
            this.chatPanel.TabIndex = 0;
            this.chatPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.chatPanel_Paint);
            // 
            // ChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.chatPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChatBox";
            this.Size = new System.Drawing.Size(1098, 628);
            this.Load += new System.EventHandler(this.ChatBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel chatPanel;
    }
}
