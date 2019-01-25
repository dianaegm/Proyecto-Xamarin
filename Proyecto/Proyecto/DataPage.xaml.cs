using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Proyecto.Model;
using Proyecto.Service;
using Plugin.Connectivity;
using Xamarin.Forms;


namespace Proyecto
{

    public partial class DataPage : ContentPage
    {

        public Command ECommand { get; set; }
        Root root;
        public DataPage()
        {
            InitializeComponent();


        }
        public DataPage(Root root)
        {

            BindingContext = root;
            this.root = root;
           
            InitializeComponent();


        }



        async void Handle_Clicked(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new CompanyPage(root));

        }
    }
}
