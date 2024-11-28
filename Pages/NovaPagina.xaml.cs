namespace NovoApp.Pages;

public partial class NovaPagina : ContentPage
{
	public NovaPagina()
	{
		InitializeComponent();

        // Aplica tema din�mico
        var currentTheme = Application.Current.UserAppTheme;
        Style = currentTheme == AppTheme.Dark
                ? (Style)Application.Current.Resources["DarkTheme"]
                : (Style)Application.Current.Resources["LightTheme"];
    }
}