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

    public class IntrinioApiService
    {
        private readonly HttpClient client;

        public IntrinioApiService()
        {
            this.client = new HttpClient();

            var byteArray = Encoding.ASCII.GetBytes($"{INConsts.Username}:{INConsts.Password}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

        public async Task<INDailyResponse> SymbolDailyRequest(string symbol)
        {
            var requestUrl = $"{INConsts.Base}{INConsts.Prices}{symbol}";
            var response = await client.GetStringAsync(requestUrl);

            //System.IO.File.WriteAllText(@"C:\Users\gebruiker\Desktop\hackathon\msftdata.txt", response);

            var inDailyResponse = JsonConvert.DeserializeObject<INDailyResponse>(response);
            return inDailyResponse;
        }

        public async Task<INSearchResult> GetTickerByName(string name)
        {
            var requestUrl = $"{INConsts.Base}{INConsts.CompaniesSearch}{name}";
            var response = await client.GetStringAsync(requestUrl);

            var result = JsonConvert.DeserializeObject<INSearchResults>(response);
            if (!result.data.Any())
                return null;

            return result.data[0];
        }

        public async Task<INCompany> GetCompanyInfoByTicker(string ticker)
        {
            var requestUrl = $"{INConsts.Base}{INConsts.CompanyInfo}{ticker}";
            var response = await client.GetStringAsync(requestUrl);

            var result = JsonConvert.DeserializeObject<INCompany>(response);
            return result;
        }

        public async Task<double> GetCloseQuoteForSymbol(string symbol)
        {
            var dailyResult = await SymbolDailyRequest(symbol);
            if (!dailyResult.data.Any())
                return -1;

            return dailyResult.data.FirstOrDefault(q => q.date == dailyResult.data.Max(qq => qq.date))?.adj_close ?? -1;
        }
    }
}
