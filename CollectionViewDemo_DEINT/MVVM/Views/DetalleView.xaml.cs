using CollectionViewDemo_DEINT.MVVM.Models;
using CollectionViewDemo_DEINT.MVVM.ViewModels;

namespace CollectionViewDemo_DEINT.MVVM.Views;

public partial class DetalleView : ContentPage
{
	public DetalleView()
	{
		InitializeComponent();
	}
	public DetalleView(Product Producto)
	{
		InitializeComponent();
		BindingContext = new DetalleVM(Producto);
	}
}