using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightTalkChatBubble
{
    public interface IImgBubble
    {
        void setImg(string imgPath,string sender,string senderID,string profileImgPath);
    }
}
