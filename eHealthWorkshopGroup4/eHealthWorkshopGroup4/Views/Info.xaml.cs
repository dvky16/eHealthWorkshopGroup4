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
	public partial class Info : ContentPage
	{
		public Info ()
		{
			InitializeComponent ();

            Label header = new Label{
                Text = "Archive",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Button excerciseButton = new Button{
                Text = "push ups",
                BorderWidth = 1,
                Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayuotOptions.CenterAndExpand
            };
            excerciseButton.Clicked += OnButtonClicked;

            Content = new StackLayout() {
                Children = {
                    header, excerciseButton
                }
            };
		}
	}
}