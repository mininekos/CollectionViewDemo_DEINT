using CollectionViewDemo_DEINT.MVVM.Views;

namespace CollectionViewDemo_DEINT;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage( new ProductView());
	}
}
