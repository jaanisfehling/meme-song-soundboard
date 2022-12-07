using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AVFoundation;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Meme_Songs;

[assembly: Dependency(typeof(Meme_Songs.iOS.Soundplayer_IOS))]
namespace Meme_Songs.iOS
{
    public class Soundplayer_IOS : Meme_Songs.ISoundboard.ISoundplayer
    {
        AVAudioPlayer player;
        public void Play(string Filename)
        {
            if (!player.Playing)
            {
                try
                {
                    player = AVAudioPlayer.FromData(NSData.FromFile("Sounds/" + Filename));
                    player.FinishedPlaying += (object sender, AVStatusEventArgs e) => { player = null; };
                    player.Play();
                }
                catch (Exception)
                {
                    player = null;
                }
            }
        }
        public void Pause()
        {
            if (player != null) player.Pause();
        }
        public void Stop()
        {
            if (player != null) player.Stop();
        }
    }
}
