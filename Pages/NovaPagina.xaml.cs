using System.Net.Http.Json;
using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace NovoApp.Pages
{
    public partial class NovaPagina : ContentPage
    {
        public NovaPagina()
        {
            InitializeComponent();
            LoadCryptoPrices();
        }

        public List<CryptoData> Moedas { get; set; }

        private async void LoadCryptoPrices()
        {
            try
            {
                // Configura o cliente HTTP
                using var httpClient = new HttpClient();

                // Exemplo de consulta para múltiplas moedas
                var moedas = new List<string> { "BTCUSDT", "ETHUSDT", "BNBUSDT", "ADAUSDT", "SOLUSDT", "DOGEUSDT", "XRPUSDT" };
                var cryptoList = new List<CryptoData>();

                foreach (var moeda in moedas)
                {
                    var url = $"https://api.binance.com/api/v3/ticker/price?symbol={moeda}";
                    var response = await httpClient.GetFromJsonAsync<CryptoResponse>(url);
                    if (response != null)
                    {
                        cryptoList.Add(new CryptoData { Nome = moeda, Preco = double.Parse(response.Price) });
                    }
                }

                Moedas = cryptoList;

                // Define o BindingContext para atualizar o XAML
                BindingContext = this;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", $"Falha ao carregar dados: {ex.Message}", "OK");
            }
        }

        // Classes para mapeamento dos dados
        public class CryptoResponse
        {
            public string Symbol { get; set; }
            public string Price { get; set; }
        }

        public class CryptoData
        {
            public string Nome { get; set; }
            public double Preco { get; set; }
        }
    }
}
