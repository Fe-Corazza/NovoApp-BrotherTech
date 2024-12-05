namespace NovoApp.Pages;

public partial class Conheca : ContentPage
{
	public Conheca()
	{
		InitializeComponent();
	}

    private async void ImageSeta_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Home());
    }

    
}