using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlexisSigchaExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if ((user == "Gabriel") && (pass == "Gabo123"))
            {
                await Navigation.PushAsync(new Registro(user));

            }
            else
            {
                await DisplayAlert("Alerta", "Credenciales Incorectas", "cerrar");
            }
        }
    }
}
