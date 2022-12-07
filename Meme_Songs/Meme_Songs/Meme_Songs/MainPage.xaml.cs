using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Meme_Songs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button1_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("titanic_flute.mp3");
        }
        void Button2_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("big_shaq.mp3");
        }
        void Button3_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("shooting_stars.mp3");
        }
        void Button4_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("jake_paul.mp3");
        }
        void Button5_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("john_cena.mp3");
        }
        void Button6_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("nyan_cat.mp3");
        }
        void Button7_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("next_episode.mp3");
        }
        void Button8_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("russia_national.mp3");
        }
        void Button9_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("russland.mp3");
        }
        void Button10_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("keemstar.mp3");
        }
        void Button11_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("mine_diamonds.mp3");
        }
        void Button12_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("sanic.mp3");
        }
        void Button13_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("mine.mp3");
        }
        void Button14_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("doin_your_mom.mp3");
        }
        void Button15_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("wii.mp3");
        }
        void Button16_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("sandstorm.mp3");
        }
        void Button17_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("epic_sax.mp3");
        }
        void Button18_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("deja_vu.mp3");
        }
        void Button19_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("dance.mp3");
        }
        void Button20_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("super_saiyan.mp3");
        }
        void Button21_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("to_be_continued.mp3");
        }
        void Button22_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Play("cheeki_breeki.mp3");
        }
        void Button23_Clicked(object sender, EventArgs args)
        {
            //DependencyService.Get<ISoundboard.ISoundplayer>().Play("");
        }
        void Button24_Clicked(object sender, EventArgs args)
        {
            //DependencyService.Get<ISoundboard.ISoundplayer>().Play("");
        }

        void Stop_Clicked(object sender, EventArgs args)
        {
            DependencyService.Get<ISoundboard.ISoundplayer>().Stop();
        }
    }
}
