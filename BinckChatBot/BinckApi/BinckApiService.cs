using Binck.OpenApi.Models.Account;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace BinckChatBot.BinckApi
{
    public class BinckApiService
    {
        static string accessToken = "26cae252-5651-4389-850f-cb643e7ccd3b";

        static public AccountsCollectionModel GetAccounts()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.sandbox.binck.com/api/v1/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                var response = client.GetStringAsync("accounts").Result;
                var jo = JObject.Parse(response);
                var accounts = jo["accountsCollection"].ToString();

                var model = JsonConvert.DeserializeObject<AccountsCollectionModel>(accounts);
                return model;
            }
        }
    }
}