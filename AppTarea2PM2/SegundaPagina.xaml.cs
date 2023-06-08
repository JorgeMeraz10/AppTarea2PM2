using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTarea2PM2
{
   
    public partial class SegundaPagina : ContentPage
    {
        public SegundaPagina(Usuario usuario)
        {
            InitializeComponent();
            BindingContext = usuario;
        }
    }

}
