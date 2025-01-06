using mpAPINasa.ViewModels;

namespace mpAPINasa.Views;

public partial class MPApodPage : ContentPage
{
    public MPApodPage()
    {
        InitializeComponent();
        BindingContext = new MPApodViewModel();
    }
}