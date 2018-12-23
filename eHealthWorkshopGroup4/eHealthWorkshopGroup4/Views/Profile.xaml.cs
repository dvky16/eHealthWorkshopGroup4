using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eHealthWorkshopGroup4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
            BackgroundImage.Source = ImageSource.FromFile("KungFuBackGround.png");
            ProfileImage.Source = ImageSource.FromFile("BruceLeeProfile.png");
            UserName.Text = "Bruse Lee";
            NickName.Text = "Dragon";
            UserRank.Text = "Black belt";
            CoachName.Text = "Ip Man";
            HeartRateData.Text = "70 BPM";
        }

        void takePhoto(object sender, EventArgs e)
        {
            
        }
        


    }
}