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
        float n1, n2, resultado;
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
            //DisplayAlert("Prueba", "Casa", "OK");
            Navigation.PushAsync(new MainPage());
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            if(txtNumero1.Text != null && txtNumero2.Text != null)
            {
                n1 = float.Parse(txtNumero1.Text);
                n2 = float.Parse(txtNumero2.Text);
                resultado = n1 + n2;
                DisplayAlert("Resultado", resultado.ToString(), "OK");
            }
            else
            {
                DisplayAlert("Error", "Introduce números correctos", "OK");
            }
            
        }
    }
}