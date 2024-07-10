using ColorMaker.ViewModels;

namespace ColorMaker.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}