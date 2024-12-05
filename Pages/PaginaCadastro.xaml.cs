namespace NovoApp.Pages;

public partial class PaginaCadastro : ContentPage
{
	public PaginaCadastro()
	{
		InitializeComponent();


        // Aplica tema dinâmico
        var currentTheme = Application.Current.UserAppTheme;
        Style = currentTheme == AppTheme.Dark
                ? (Style)Application.Current.Resources["DarkTheme"]
                : (Style)Application.Current.Resources["LightTheme"];
    }

    private void cadastrar_Clicked(object sender, EventArgs e)
    {

    }
}