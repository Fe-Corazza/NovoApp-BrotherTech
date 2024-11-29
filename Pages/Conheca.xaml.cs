namespace NovoApp.Pages;

public partial class Conheca : ContentPage
{
	public Conheca()
	{
		InitializeComponent();
	}

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void OnBackButtonClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync(); // Retorna para a página anterior
    }
}