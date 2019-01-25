using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Proyecto.Model;
using Proyecto.Service;
using Plugin.Connectivity;
using Xamarin.Forms;



namespace Proyecto
{
    public partial class AddressPage : ContentPage
    {
        public AddressPage(Root root)
        {
           
            BindingContext = root.Address;

            InitializeComponent();
        }
    }
}
