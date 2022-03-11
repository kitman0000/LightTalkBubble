using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LightTalkChatBubble
{
    public partial class RightChatBubble : BubbleBase, IChatBubble
    {
        readonly int PARENT_WIDTH = 734;

        public RightChatBubble(Control parent) : base(parent)
        {
            InitializeComponent();
            PARENT_WIDTH = parent.Width;
        }

        /// <summary>
        /// 初始化原状态
        /// </summary>
        private void init()
        {
            this.Width = 366;
            this.Height = 61;

            pictureBox_body.Left = 3;
            pictureBox_body.Top = 21;
            pictureBox_body.Width = 280;
            pictureBox_body.Height = 39;

            pictureBox_conner.Left = 281;
            pictureBox_conner.Top = 21;
            pictureBox_conner.Width = 10;
            pictureBox_conner.Height = 39;

            lbl_sender.Left = 257;
            lbl_sender.Top = 6;
        }

        public void setText(string msg, string sender, string senderID, string profileImgPath)
        {
            //init(); // 第二次调用界面可能出现bug，先恢复到初始化状态

            this.senderID = senderID;

            lbl_sender.Text = sender;

            float zhFontSize = this.Font.Size * 1.4f;
            float enFontSize = this.Font.Size * 0.7f;

            float lineLength = 0;
            float totalLineLength = 0;

            foreach (string line in Regex.Split(msg, "\r\n"))
            {
                float currentLineLength = 0;

                foreach (char c in line)
                {
                    if (c <= 127) // 认为是英文
                    {
                        currentLineLength += enFontSize;
                    }
                    else // 认为是中文
                    {
                        currentLineLength += zhFontSize;
                    }
                }

                if (currentLineLength > lineLength)
                {
                    lineLength = currentLineLength;
                }

                totalLineLength += currentLineLength;
            }



            int lineToAdd = 0; // 需要增加的行数

            // 设置最大宽度，并计算需要添加的行数
            if (lineLength > 300)
            {
                lineToAdd = (int)totalLineLength / 300;
                lineLength = 300;
            }

            lineToAdd += msg.Length - msg.Replace("\r", "").Length; // 计算换行数量

            if (lineToAdd != 0)
            {
                this.Height = (int)(this.Font.Size * 1.7f) * (lineToAdd + 3);
                pictureBox_body.Height = this.Height + pictureBox_body.Top;
            }
            txt_Msg.Height = pictureBox_body.Height - (txt_Msg.Top - pictureBox_body.Top);

            // 补上头像的高度
            this.Height += (pictureBox_profile.Height - 39);

            txt_Msg.Width = (int)lineLength + 10;
            txt_Msg.Text = msg;

            pictureBox_body.Width = txt_Msg.Width + 10;

            this.Width = PARENT_WIDTH - 10;

            pictureBox_body.Left = PARENT_WIDTH - pictureBox_body.Width - pictureBox_conner.Width - pictureBox_profile.Width - 10 - 30;
            pictureBox_conner.Left = pictureBox_body.Width + pictureBox_body.Left;
            pictureBox_profile.Left = PARENT_WIDTH - pictureBox_profile.Width - 30;
            lbl_sender.Left = PARENT_WIDTH - lbl_sender.Width - pictureBox_profile.Width - 10 - 30;


            txt_Msg.Left = pictureBox_body.Left + 10;


            // 设置行间距
            CSetLineSpace.SetLineSpace(txt_Msg, 100);
            CSetLineSpace setter = new CSetLineSpace();
            setter.setMargin(txt_Msg, 0, 10, 0, 0);

            // 读取头像
            try
            {
                pictureBox_profile.Load(profileImgPath);
            }
            catch (Exception ex)
            {
                pictureBox_profile.Load("icons/defaultProfile.png");
            }
        }

    }
}
