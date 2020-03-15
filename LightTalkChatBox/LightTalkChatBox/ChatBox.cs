using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightTalkChatBubble;
using System.Runtime.InteropServices;

namespace LightTalkChatBox
{
    public partial class ChatBox : UserControl
    {
        public delegate void ProfileRightClickHandle(string senderID, object sender, MouseEventArgs e);
        public event ProfileRightClickHandle profileRightClicked;

        public ChatBox()
        {
            InitializeComponent();
        }

        public enum BubbleSide
        {
            LEFT,RIGHT
        }

        public void addChatBubble(BubbleSide bubbleSide,string msg,string sender,string senderID,string profileImgPath)
        {

            IChatBubble bubble = null;

            if(bubbleSide == BubbleSide.LEFT)
            {
                bubble = new LeftChatBubble();
                (bubble as LeftChatBubble).profileRightClicked += ChatBox_profileRightClicked;
            }
            else if(bubbleSide == BubbleSide.RIGHT)
            {
                bubble = new RightChatBubble();
                (bubble as RightChatBubble).profileRightClicked += ChatBox_profileRightClicked;
            }

            if (chatPanel.Controls.Count != 0)
                (bubble as Control).Top = chatPanel.Controls[chatPanel.Controls.Count - 1].Top + chatPanel.Controls[chatPanel.Controls.Count - 1].Height;

            chatPanel.Controls.Add(bubble as Control);

            bubble.setText(msg, sender,senderID,profileImgPath);

            chatPanel.ScrollControlIntoView(bubble as Control);
        }

        public void addImgBubble(BubbleSide bubbleSide,string imgPath, string sender, string senderID, string profileImgPath)
        {
            IImgBubble imgBubble = null;

            if (bubbleSide == BubbleSide.LEFT)
            {
                imgBubble = new LeftImgBubble();

                (imgBubble as LeftImgBubble).profileRightClicked += ChatBox_profileRightClicked;
            }
            else if (bubbleSide == BubbleSide.RIGHT)
            {
                imgBubble = new RightImgBubble();
                (imgBubble as RightImgBubble).profileRightClicked += ChatBox_profileRightClicked;
            }

            if (chatPanel.Controls.Count != 0)
                (imgBubble as Control).Top = chatPanel.Controls[chatPanel.Controls.Count - 1].Top + chatPanel.Controls[chatPanel.Controls.Count - 1].Height;

            chatPanel.Controls.Add(imgBubble as Control);

            imgBubble.setImg(imgPath, sender, senderID, profileImgPath);

            chatPanel.ScrollControlIntoView(imgBubble as Control);
        }

        public void addVoiceBubble(BubbleSide bubbleSide, string recordPath, string sender, string senderID, string profileImgPath)
        {
            IVoiceBubble voiceBubble = null;

            if (bubbleSide == BubbleSide.LEFT)
            {
                voiceBubble = new LeftVoiceBubble();

                (voiceBubble as LeftVoiceBubble).profileRightClicked += ChatBox_profileRightClicked;
            }
            else if (bubbleSide == BubbleSide.RIGHT)
            {
                voiceBubble = new RightVoiceBubble();
                (voiceBubble as RightVoiceBubble).profileRightClicked += ChatBox_profileRightClicked;
            }

            if (chatPanel.Controls.Count != 0)
                (voiceBubble as Control).Top = chatPanel.Controls[chatPanel.Controls.Count - 1].Top + chatPanel.Controls[chatPanel.Controls.Count - 1].Height;

            chatPanel.Controls.Add(voiceBubble as Control);

            voiceBubble.setRecord(recordPath, sender, senderID, profileImgPath);

            chatPanel.ScrollControlIntoView(voiceBubble as Control);

        }

        private void ChatBox_profileRightClicked(string senderID,object sender, MouseEventArgs e)
        {
            profileRightClicked(senderID, sender, e);
        }

        private void ChatBox_Load(object sender, EventArgs e)
        {
            chatPanel.Width = this.Width;
            chatPanel.Height = this.Height;
            chatPanel.HorizontalScroll.Maximum = 0;
            chatPanel.AutoScroll = true;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int ShowScrollBar(IntPtr hWnd, int bar, int show);

        private void chatPanel_Paint(object sender, PaintEventArgs e)
        {
            Control _Control = (Control)sender;
            ShowScrollBar(_Control.Handle, 0, 0);
        }

        private void ChatBox_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
