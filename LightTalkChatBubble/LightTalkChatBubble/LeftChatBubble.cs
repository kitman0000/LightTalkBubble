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
    public partial class LeftChatBubble : BubbleBase, IChatBubble
    {

        public LeftChatBubble(Control parent):base(parent)
        {
            InitializeComponent();
        }


        public void setText(string msg,string sender,string senderID, string profileImgPath)
        {
            lbl_sender.Text = sender;

            this.Left = 0;


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

            pictureBox_body.Width = txt_Msg.Width + txt_Msg.Left - pictureBox_body.Left;

            this.Width = this.Parent.Width - 10;

            this.senderID = senderID;

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
