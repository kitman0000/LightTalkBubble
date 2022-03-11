using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LightTalkChatBubble;
using System.Collections.Concurrent;

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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _parent_form_width = this.ParentForm.Width;
            this.ParentForm.ResizeEnd += this.ParentForm_ResizeEnd;
        }

        /// <summary>
        /// 记录当前窗体的宽度
        /// </summary>
        private volatile int _parent_form_width;
        /// <summary>
        /// 记录本该置于右侧的Bubble,在窗体的宽度改变后更新这些bubble的位置
        /// </summary>
        private readonly ConcurrentBag<BubbleBase> _right_items = new ConcurrentBag<BubbleBase>();

        /// <summary>
        /// 窗体的Size发生改变后更新右侧bubble的位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParentForm_ResizeEnd(object sender, EventArgs e)
        {
            int current = this.ParentForm.Width;
            int diff = _parent_form_width - current;
            _parent_form_width = current;
            foreach (BubbleBase item in _right_items)
            {
                Point point = item.Location;
                Point newPoint = new Point(point.X - diff, point.Y);
                item.Location = newPoint;
            }
        }

        public enum BubbleSide
        {
            LEFT, RIGHT
        }

        private void add_bubble<T>(BubbleBase bubble,BubbleSide side,Action<T> action)where T:class
        {
            if (side == BubbleSide.RIGHT)
            {
                _right_items.Add(bubble);
            }

            bubble.OnProfileRightClickHandle += ChatBox_profileRightClicked;

            if (chatPanel.Controls.Count != 0)
                bubble.Top = chatPanel.Controls[chatPanel.Controls.Count - 1].Top + chatPanel.Controls[chatPanel.Controls.Count - 1].Height;

            chatPanel.Controls.Add(bubble);

            action.Invoke(bubble as T);

            chatPanel.ScrollControlIntoView(bubble);
        }

        public void addChatBubble(BubbleSide bubbleSide, string msg, string sender, string senderID, string profileImgPath)
        {
            BubbleBase bubble = null;

            if (bubbleSide == BubbleSide.LEFT)
            {
                bubble = new LeftChatBubble(this);
            }
            else if (bubbleSide == BubbleSide.RIGHT)
            {
                bubble = new RightChatBubble(this);
            }

            add_bubble<IChatBubble>(bubble, bubbleSide,(b) => b.setText(msg, sender, senderID, profileImgPath));

        }

        public void addImgBubble(BubbleSide bubbleSide, string imgPath, string sender, string senderID, string profileImgPath)
        {
            BubbleBase bubble = null;
            if (bubbleSide == BubbleSide.LEFT)
            {
                bubble = new LeftImgBubble(this);
            }
            else if (bubbleSide == BubbleSide.RIGHT)
            {
                bubble = new RightImgBubble(this);
            }

            add_bubble<IImgBubble>(bubble, bubbleSide, (b) => b.setImg(imgPath, sender, senderID, profileImgPath));
        }

        public void addVoiceBubble(BubbleSide bubbleSide, string recordPath, string sender, string senderID, string profileImgPath)
        {
            BubbleBase bubble = null;

            if (bubbleSide == BubbleSide.LEFT)
            {
                bubble = new LeftVoiceBubble(this);
            }
            else if (bubbleSide == BubbleSide.RIGHT)
            {
                bubble = new RightVoiceBubble(this);
            }

            add_bubble<IVoiceBubble>(bubble, bubbleSide, (b) => b.setRecord(recordPath, sender, senderID, profileImgPath));

        }

        private void ChatBox_profileRightClicked(string senderID, object sender, MouseEventArgs e)
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
    }
}
