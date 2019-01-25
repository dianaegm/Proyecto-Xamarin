using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Proyecto
{
    public partial class TabsPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        public TabsPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new StartPage());
        }
    }
}
