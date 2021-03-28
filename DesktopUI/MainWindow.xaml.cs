using CrytpoLibrary;
using System.Windows;

namespace DesktopUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private async void ShowPrice_Click(object sender, RoutedEventArgs e)
        {
            var bitcoinInfo = await BitcoinProcessor.LoadBitcoin();

            var price = bitcoinInfo.Usd.ToString("C");
            var cap = bitcoinInfo.Usd_Market_Cap.ToString("C");

            BitcoinPrice.Text = $"Price: { price }";
            BitcoinMarketCap.Text = $"Market Cap: { cap }";

        }
    }
}
