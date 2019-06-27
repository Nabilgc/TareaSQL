using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tareasql.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tareasql.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaVentas : ContentPage
	{
        public ListaVentas()
        {
            InitializeComponent();
        }

        private void BListar_Clicked(object sender, EventArgs e)
        {
            var allVentas = VentasViewModel.Instance.GetAllVentas();
            listaventas.ItemsSource = allVentas;

        }
    }
}