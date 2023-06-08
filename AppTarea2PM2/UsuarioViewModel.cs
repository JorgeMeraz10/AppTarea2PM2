using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace AppTarea2PM2
{
    public class UsuarioViewModel : BindableObject
    {
        private Usuario usuario;
        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                if (usuario != value)
                {
                    usuario = value;
                    OnPropertyChanged(nameof(Usuario));
                }
            }
        }

        public Command EnviarCommand { get; }

        public UsuarioViewModel()
        {
            Usuario = new Usuario();

            EnviarCommand = new Command(async () =>
            {
                var segundaPagina = new SegundaPagina();
                segundaPagina.BindingContext = this.Usuario; // Establecer el contexto de enlace como el objeto Usuario actual
                await Application.Current.MainPage.Navigation.PushAsync(segundaPagina);
            });


        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
