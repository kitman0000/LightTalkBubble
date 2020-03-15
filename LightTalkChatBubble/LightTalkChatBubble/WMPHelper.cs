using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMPLib;
using System.Windows.Forms;

namespace LightTalkChatBubble
{
    class WMPHelper
    {
        static WindowsMediaPlayerClass player = null;
        static PictureBox currentVoiceBtn;

        public static void play(string recordPath,PictureBox voiceBtn)
        {
            if (player == null)
            {
                player = new WindowsMediaPlayerClass();
                player.PlayStateChange += Player_PlayStateChange;
            }

            if (player.URL == recordPath && player.playState == WMPPlayState.wmppsPlaying)
            {
                currentVoiceBtn.Load(@"icons\voice.png");
                player.stop();
                Console.WriteLine("停止播放");
            }
            else
            {
                // 停止上一个在播放的图标
                if(currentVoiceBtn != null)
                {
                    currentVoiceBtn.Load(@"icons\voice.png");
                }

                // 开始播放新图标
                currentVoiceBtn = voiceBtn;
                currentVoiceBtn.Load(@"icons\voicePlay.gif");

                player.URL = recordPath;

                player.play();

                Console.WriteLine("开始播放" + recordPath);
            }
        }

        private static void Player_PlayStateChange(int NewState)
        {
            if(NewState == 1&& currentVoiceBtn != null)
            {
                currentVoiceBtn.Load(@"icons\voice.png");
            }
        }
    }
}
