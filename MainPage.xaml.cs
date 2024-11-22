using Microsoft.Maui.Controls;
using NovoApp.Pages;

namespace NovoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Evento chamado quando o botão "Continuar" é clicado
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Captura os valores inseridos nos campos
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            // Verifica se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos.", "OK");
                return;
            }

            // Simula a validação de login
            bool isValidLogin = SimulateLoginValidation(email, password);

            if (isValidLogin)
            {
                await DisplayAlert("Sucesso", "Login realizado com sucesso!", "OK");
                // Navegação ou próxima etapa do aplicativo
                // await Navigation.PushAsync(new NextPage());
            }
            else
            {
                await DisplayAlert("Erro", "E-mail ou senha inválidos. Tente novamente.", "OK");
            }
        }

        // Método de validação simulada
        private bool SimulateLoginValidation(string email, string password)
        {
            // Substitua por sua lógica de validação real, como uma API ou banco de dados
            return email == "teste@brotherstech.com" && password == "123456";
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaCadastro());


        }
    }
}
