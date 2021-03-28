using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CrytpoLibrary
{
    public class BitcoinProcessor
    {
        public static async Task<BitcoinModel> LoadBitcoin()
        {
            string url = "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd&include_market_cap=true";


            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    BitcoinResultModel bitcoin = await response.Content.ReadAsAsync<BitcoinResultModel>();

                    return bitcoin.Bitcoin;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
