using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Media;
using Android.Content.Res;
using System.IO;
using Meme_Songs;
using Meme_Songs.Droid;
using Android.Content;
using Xamarin.Forms.Platform.Android;
using Android;

[assembly: Xamarin.Forms.Dependency(typeof(MainActivity))]
namespace Meme_Songs.Droid
{
    [Activity(Label = "Soundboard", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ISoundboard.ISoundplayer
    {
        public MainActivity()
        {

        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
        MediaPlayer player;
        public void Play(string Filename)
        {
            try
            {
                Context context = Android.App.Application.Context;
                AssetManager assets = context.Assets;
                AssetFileDescriptor afd = assets.OpenFd(Filename);
                player = new MediaPlayer();
                player.SetDataSource(afd);
                player.Prepare();
                player.Start();
            }
            catch (Exception)
            {
                player = null;
            }
        }
        public void Pause()
        {
            if (player != null) player.Pause();
        }
        public void Stop()
        {
            if (player != null)
            {
                player.Stop();
                player = null;
            }
        }
    }
}
