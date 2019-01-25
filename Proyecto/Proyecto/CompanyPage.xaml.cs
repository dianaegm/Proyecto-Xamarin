using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Proyecto.Model;
using Proyecto.Service;
using Plugin.Connectivity;
using Xamarin.Forms;

namespace Proyecto
{
    public partial class CompanyPage : ContentPage
    {
        Company empresa;
        Root root;


        public CompanyPage(Root root)
        {

            BindingContext = root.Company;
            this.root = root;
            InitializeComponent();

            empresa =root.Company;


        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddressPage(root));
        }

    }
}
