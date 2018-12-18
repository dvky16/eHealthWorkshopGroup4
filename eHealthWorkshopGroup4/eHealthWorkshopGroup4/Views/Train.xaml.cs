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
	public partial class Train : ContentPage
	{
        bool isTraining;
        //boolean describing the status of the current training
		public Train ()
		{
			InitializeComponent ();
            this.isTraining = false;
        }

        private void ChangeTrainingStatus(object sender, EventArgs e)
        {
            if (this.isTraining = !this.isTraining)
            {
                ((Button)sender).Text = "Stop Workout";
                //TODO treat case of training
            }
            else
            {
                ((Button)sender).Text = "Start Workout";
                //TODO close operation
            }
        }
    }
}