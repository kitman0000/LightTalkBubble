using LightTalkChatBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightTalkBubbleDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sendLeftMsg_Click(object sender, EventArgs e)
        {
            chatBox.addChatBubble(ChatBox.BubbleSide.LEFT, txt_leftSend.Text, "kitman543210", "110", @"temp\testProfile1.png");
        }

        private void btn_sendRightMsg_Click(object sender, EventArgs e)
        {
            chatBox.addChatBubble(ChatBox.BubbleSide.RIGHT, txt_rightSend.Text, "kitman543210", "110", @"temp\testProfile2.png");
        }

        private void btn_sendLeftImg_Click(object sender, EventArgs e)
        {
            chatBox.addImgBubble(ChatBox.BubbleSide.LEFT, @"temp\testImg2.jpg", "kitman011", "110", @"temp\testProfile1.png");
        }

        private void btn_sendRightImg_Click(object sender, EventArgs e)
        {
            chatBox.addImgBubble(ChatBox.BubbleSide.RIGHT, @"temp\testImg1.jpg", "kitman011", "110", @"temp\testProfile2.png");
        }

        private void btn_sendLeftVoice_Click(object sender, EventArgs e)
        {
            chatBox.addVoiceBubble(ChatBox.BubbleSide.LEFT, System.IO.Directory.GetCurrentDirectory() + @"\temp\testSound1.mp3", "kitman111", "110", @"temp\testProfile1.png");
        }

        private void btn_sendRightVoice_Click(object sender, EventArgs e)
        {
            chatBox.addVoiceBubble(ChatBox.BubbleSide.RIGHT, System.IO.Directory.GetCurrentDirectory() + @"\temp\testSound2.mp3", "kitman11122222", "110", @"temp\testProfile2.png");
        }

        private void chatBox_profileRightClicked(string senderID, object sender, MouseEventArgs e)
        {
            ProfileRightClickMenu.Show(MousePosition.X, MousePosition.Y);
        }
    }
}
