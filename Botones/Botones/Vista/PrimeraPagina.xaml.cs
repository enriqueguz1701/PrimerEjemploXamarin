using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Botones.Vista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrimeraPagina : ContentPage
	{
		public PrimeraPagina ()
		{
			InitializeComponent ();
		}

        private void btnHola_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Prueba", "Hola", "OK");
        }

        private void btnImagen_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Prueba", "Casa", "OK");
        }
    }
}