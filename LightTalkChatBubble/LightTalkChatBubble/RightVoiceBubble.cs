using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Shell32;
using System.Text.RegularExpressions;

namespace LightTalkChatBubble
{
    public partial class RightVoiceBubble : BubbleBase, IVoiceBubble
    {

        private string recordPath;

        readonly int PARENT_WIDTH = 734;

        public RightVoiceBubble(Control parent):base(parent)
        {
            InitializeComponent();
            PARENT_WIDTH = parent.Width;
        }

        public void setRecord(string recordPath, string sender, string senderID, string profileImgPath)
        {
            lbl_sender.Text = sender;
            this.senderID = senderID;
            pictureBox_profile.Load(profileImgPath);

            // 调整自身位置与大小
            this.recordPath = recordPath;

            this.Width = PARENT_WIDTH + 1;

            pictureBox_body.Left = PARENT_WIDTH - pictureBox_body.Width - pictureBox_conner.Width - pictureBox_profile.Width - 10 -30;
            pictureBox_conner.Left = pictureBox_body.Left + pictureBox_body.Width;
            pictureBox_profile.Left = PARENT_WIDTH - pictureBox_profile.Width -30;
            lbl_sender.Left = PARENT_WIDTH - lbl_sender.Width - pictureBox_profile.Width - 10-30 ;

            pictureBox_img.Left = pictureBox_body.Left + 1;
            lbl_time.Left = pictureBox_img.Left + 30;

            this.Height += 20;

            // 获取音频时间
            string dirName = System.IO.Path.GetDirectoryName(recordPath);
            FileInfo fInfo = new FileInfo(recordPath);
            string SongName = System.IO.Path.GetFileName(recordPath);
            ShellClass sh = new ShellClass();
            Folder dir = sh.NameSpace(dirName);
            FolderItem item = dir.ParseName(SongName);

            string time = Regex.Match(dir.GetDetailsOf(item, -1), "\\d:\\d{2}:\\d{2}").Value;
            string[] timeArray = Regex.Split(time, ":");
            int hour =int.Parse(timeArray[0]);
            int min = int.Parse(timeArray[1]);
            int sec = int.Parse(timeArray[2]);

            lbl_time.Text =  (hour * 3600 + min * 60 + sec) + "s";



        }

        private void pictureBox_img_Click(object sender, EventArgs e)
        {
            WMPHelper.play(this.recordPath,pictureBox_img);
        }

        private void RightVoiceBubble_Load(object sender, EventArgs e)
        {
            pictureBox_img.Load(@"icons\voice.png");
        }
    }
}
