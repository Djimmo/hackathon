namespace BinckChatBot.IntrinionApi
{
    using BinckChatBot.Contracts;
    using Newtonsoft.Json;
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    [Serializable]
    public class IntrinioApiService
    {
        private static HttpClient client;
        public static HttpClient Client
        {
            get
            {
                if (client == null)
                {
                    client = new HttpClient();

                    var byteArray = Encoding.ASCII.GetBytes($"{INConsts.Username}:{INConsts.Password}");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                }
                return client;
            }
        }

        public static INDailyResponse SymbolDailyRequest(string symbol)
        {
            var requestUrl = $"{INConsts.Base}{INConsts.Prices}{symbol}";
            var response = Client.GetStringAsync(requestUrl).GetAwaiter().GetResult();

            //System.IO.File.WriteAllText(@"C:\Users\gebruiker\Desktop\hackathon\msftdata.txt", response);

            var inDailyResponse = JsonConvert.DeserializeObject<INDailyResponse>(response);
            return inDailyResponse;
        }

        public static INSearchResult GetTickerByName(string name)
        {
            var requestUrl = $"{INConsts.Base}{INConsts.CompaniesSearch}{name}";
            var response = Client.GetStringAsync(requestUrl).GetAwaiter().GetResult();

            var result = JsonConvert.DeserializeObject<INSearchResults>(response);
            if (!result.data.Any())
                return null;

            return result.data[0];
        }

        public static INCompany GetCompanyInfoByTicker(string ticker)
        {
            var requestUrl = $"{INConsts.Base}{INConsts.CompanyInfo}{ticker}";
            var response = Client.GetStringAsync(requestUrl).GetAwaiter().GetResult();

            var result = JsonConvert.DeserializeObject<INCompany>(response);
            return result;
        }

        public static INDaily GetCloseQuoteForSymbol(string symbol)
        {
            var dailyResult = SymbolDailyRequest(symbol);
            if (!dailyResult.data.Any())
                return null;

            return dailyResult.data.FirstOrDefault(q => q.date == dailyResult.data.Max(qq => qq.date)) ?? null;
        }
    }
}
