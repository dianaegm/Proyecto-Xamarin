using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Proyecto.Model;
using Proyecto.Service;
using Plugin.Connectivity;
using Xamarin.Forms;

namespace Proyecto
{
    public partial class StudentsPage 
    {
        public ApiService DataService { get; } = new ApiService();
        public ObservableCollection<object> Items { get; set; } = new ObservableCollection<object>();
        public Command AgregarComm { get; set; }         public Command RefrescarComm { get; set; }

        private string _data = @"[
     {
             ""Name"": ""ejemplo""

      } ]";

        public string Data { get => _data; }


        public StudentsPage()
        {
            BindingContext = this;              AgregarComm = new Command(() => {
                Items.Add(new Root
                {
                    Name = $"Name { (Items.Count + 1)}"
                }
              );

            
            });

            IsBusy = true;
            RefrescarComm = new Command(() => Refrescar());

            InitializeComponent();              ListaDatos.ItemSelected += ListaDatos_ItemSelected;
        }

        private void ListaDatos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = e.SelectedItem;              var estudiante = selectedItem as Root;

            Navigation.PushAsync(
                new DataPage(estudiante)
                ); 
        }

        private async void Refrescar()
        {
            IsBusy = false;

            if (!CrossConnectivity.Current.IsConnected)             {
                await DisplayAlert("", "No hay conexion a internet", "Continuar");
                return;             }
            try             {
                var data = await DataService.GetStringAsync();                  foreach (var item in data)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Continuar");
            }
            finally
            {
                IsBusy = false;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Refrescar();
        }


    }
}
