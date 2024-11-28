
namespace NovoApp;

public partial class Bitcoin : ContentPage
{
    public class Criptomoeda
    {
        public string Nome { get; set; }
        public decimal CapitalizacaoMercado { get; set; }
        public decimal VariacaoPreco { get; set; }
    }

    // ... (resto do código XAML)

    // Code-behind
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new
            {
                ListaCriptomoedas = new List<Criptomoeda>
            {
                new Criptomoeda { Nome = "BNB", CapitalizacaoMercado = 573.3m, VariacaoPreco = 0.05m },
                // ... (outros itens)
            }
            };
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}