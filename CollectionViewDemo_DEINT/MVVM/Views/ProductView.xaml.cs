using CollectionViewDemo_DEINT.MVVM.Models;
using CollectionViewDemo_DEINT.MVVM.ViewModels;

namespace CollectionViewDemo_DEINT.MVVM.Views;

public partial class ProductView : ContentPage
{
	public ProductView()
	{
		InitializeComponent();
		BindingContext= new ProductVM();
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		Product productoSeleccionado = e.CurrentSelection[0] as Product;
		
		if(productoSeleccionado.HasOffer)
		{
			Navigation.PushAsync(new DetalleView(productoSeleccionado));
		}
		else
		{
			DisplayAlert("Productos", "No está en oferta", "OK");
		}
	}
}