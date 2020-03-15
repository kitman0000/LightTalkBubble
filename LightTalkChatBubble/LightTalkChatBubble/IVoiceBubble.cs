using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightTalkChatBubble
{
    public interface IVoiceBubble
    {
        void setRecord(string recordPath, string sender, string senderID, string profileImgPath);
    }
}
