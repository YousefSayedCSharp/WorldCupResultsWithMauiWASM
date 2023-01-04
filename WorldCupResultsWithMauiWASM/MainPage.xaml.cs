namespace WorldCupResultsWithMauiWASM;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new ViewModels.HomeVM();
    }
}
