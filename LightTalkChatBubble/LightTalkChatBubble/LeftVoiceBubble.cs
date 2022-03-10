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
    public partial class LeftVoiceBubble : BubbleBase, IVoiceBubble
    {
        private string recordPath;

        public LeftVoiceBubble(Control parent):base(parent)
        {
            InitializeComponent();
        }

        public void setRecord(string recordPath, string sender, string senderID, string profileImgPath)
        {
            this.recordPath = recordPath;

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

            lbl_sender.Text = sender;
            this.senderID = senderID;
            pictureBox_profile.Load(profileImgPath);

        }

        private void pictureBox_img_Click(object sender, EventArgs e)
        {
            WMPHelper.play(this.recordPath,pictureBox_img);
        }


        private void LeftVoiceBubble_Load(object sender, EventArgs e)
        {
            pictureBox_img.Load(@"icons\voice.png");
        }
    }
}
