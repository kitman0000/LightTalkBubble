using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LightTalkChatBubble
{
    public partial class LeftImgBubble : BubbleBase, IImgBubble
    {
        public LeftImgBubble(Control parent):base(parent)
        {
            InitializeComponent();
        }

        public void setImg(string imgPath, string sender, string senderID, string profileImgPath)
        {
            lbl_sender.Text = sender;
            this.senderID = senderID;

            pictureBox_profile.Load(profileImgPath);

            pictureBox_img.Load(imgPath);
            int imgHeight = pictureBox_img.Image.Height;
            int imgWidth = pictureBox_img.Image.Width;

            if(imgWidth > 300||imgHeight >300) // 设置预览图片最大长度、宽度为300
            {
                // 将较大一边设为300
                if(imgWidth > imgHeight)
                {
                    pictureBox_img.Width = 300;

                    pictureBox_img.Height = (int)(imgHeight * (300f / imgWidth));
                }
                else
                {
                    pictureBox_img.Height = 300;

                    pictureBox_img.Width = (int)(imgWidth * (300f / imgHeight));
                }
            }
            else
            {
                pictureBox_img.Width = imgWidth;
                pictureBox_img.Height = imgHeight;
            }


            this.Width = pictureBox_img.Left + pictureBox_img.Width + 1;


            if (pictureBox_img.Top + pictureBox_img.Height > pictureBox_profile.Height)
            {
                this.Height = pictureBox_img.Top + pictureBox_img.Height + 1;
                pictureBox_body.Height = pictureBox_img.Height + 2;
            }

            pictureBox_body.Width = this.Width;
        }
    }
}
