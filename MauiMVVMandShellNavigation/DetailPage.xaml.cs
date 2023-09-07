using MauiMVVMandShellNavigation.ViewModels;

namespace MauiMVVMandShellNavigation;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel detailViewModel)
	{
		InitializeComponent();
		BindingContext = detailViewModel;
	}
}