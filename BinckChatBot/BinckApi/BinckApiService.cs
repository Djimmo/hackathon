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

        // refresh this token every our
        // use TOPLIN11353100/toplinealex
        static string accessToken = "b793b12f-4125-46e2-9edf-bffa36e4f5db";

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