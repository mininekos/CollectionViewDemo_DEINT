using CollectionViewDemo_DEINT.MVVM.ViewModels;

namespace CollectionViewDemo_DEINT.MVVM.Views;

public partial class ProductView : ContentPage
{
	public ProductView()
	{
		InitializeComponent();
		BindingContext= new ProductVM();
	}
}