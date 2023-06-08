using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTarea2PM2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new Usuario();
        }

        private void Enviar_Clicked(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Nombres = ((Usuario)BindingContext).Nombres,
                Apellidos = ((Usuario)BindingContext).Apellidos,
                Edad = ((Usuario)BindingContext).Edad,
                CorreoElectronico = ((Usuario)BindingContext).CorreoElectronico
            };

            Navigation.PushAsync(new SegundaPagina(usuario));
        }

    }
}
