using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ceiti_mania
{
    internal class PlayMusic
    {
        SoundPlayer audio = new SoundPlayer(@"..\..\..\audio\play.wav");
        audio.PlayLooping();
    }
}
