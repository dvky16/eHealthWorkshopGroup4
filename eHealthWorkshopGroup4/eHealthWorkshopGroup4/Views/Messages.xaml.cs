using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
  
namespace eHealthWorkshopGroup4.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Messages : ContentPage
	{
        static List<Services.Message> MessageList;

		public Messages()
        {
            InitializeComponent();
            MessageList = new List<Services.Message>();
            CoachMessages.ItemsSource = MessageList;
            MessageList.Add(new Services.Message("Message1", "15/12/2018", "This is mesage #1"));
            MessageList.Add(new Services.Message("Message2", "15/12/2018", "This is mesage #2"));
            MessageList.Add(new Services.Message("Message3", "15/12/2018", "This is mesage #3"));
            MessageList.Add(new Services.Message("Message4", "15/12/2018", "This is mesage #4"));
            MessageList.Add(new Services.Message("Message5", "15/12/2018", "This is mesage #5"));
            
        }

        /*private async void ButtonHendler(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContentMessagePage());
        }
        */
        

    }
}