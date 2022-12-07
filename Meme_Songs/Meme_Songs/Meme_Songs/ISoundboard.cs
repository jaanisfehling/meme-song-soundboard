using System;
using System.Collections.Generic;
using System.Text;

namespace Meme_Songs
{
    public class ISoundboard
    {
        public ISoundboard()
        {

        }
        public interface ISoundplayer
        {
            void Play(string Filename);
            void Stop();
            void Pause();
        }
    }
}
