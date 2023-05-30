using MauiApp1.ViewModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

    public MainPage(MainViewModel vm) // auto dependency injection system... Still need to register it.
    {
        InitializeComponent();
        // BindingContext = new MainViewModel(); // This is one option of doing this.
        BindingContext = vm;
    }

}

