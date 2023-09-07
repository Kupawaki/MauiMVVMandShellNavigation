using MauiMVVMandShellNavigation.ViewModels;

namespace MauiMVVMandShellNavigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = mainViewModel;
        }
    }
}