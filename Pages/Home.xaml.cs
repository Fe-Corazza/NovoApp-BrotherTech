namespace NovoApp.Pages;

public partial class Home : ContentPage
{
    public Home()
    {
        InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Conheca());
    }
}