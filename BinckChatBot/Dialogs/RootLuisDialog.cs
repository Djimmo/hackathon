namespace BinckChatBot.Dialogs
{
    using System;
    using IntrinionApi;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web;
    using Microsoft.Bot.Builder.Dialogs;
    using Microsoft.Bot.Builder.FormFlow;
    using Microsoft.Bot.Builder.Luis;
    using Microsoft.Bot.Builder.Luis.Models;
    using Microsoft.Bot.Connector;
    using BinckApi;

    [LuisModel("7fa45f24-e99b-4bea-b24c-e42c71e92152", "6bdbe03e1e20405d88a400f3090d2cd5", domain: "westeurope.api.cognitive.microsoft.com")]
    [Serializable]
    public class RootLuisDialog : LuisDialog<object>
    {
        [LuisIntent("")]
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            var errorResult = "Try something else, please.";
            await context.PostAsync(errorResult);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Hello")]
        public async Task FavouriteColorIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var random = new Random();

            if (random.Next(0, 10) < 5)
            {
                await context.PostAsync("Hello, I'm Binck Buddy. How may I be of assistance?");
            } else
            {
                await context.PostAsync("Hi, I live to serve. How can I please you?");
            }
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("ShowGraph")]
        public async Task ShowGraphIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var query = result.Entities.FirstOrDefault().Entity as string;
            var symbol = IntrinioApiService.GetTickerByName(query);
            var quotes = IntrinioApiService.SymbolDailyRequest(symbol.ticker);

            var graphPath = Graphics.GraphCreator.CreateChartClose(quotes.data);

            var replyMessage = context.MakeMessage();
            replyMessage.Text = "Here is your graph.";
            replyMessage.Attachments.Add(new Attachment
            {
                ContentUrl = graphPath,
                ContentType = "image/png",
                Name = "BinckBank Logo"
            });

            await context.PostAsync(replyMessage);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("ShowGraphCandle")]
        public async Task ShowGraphCandleIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var query = result.Entities.FirstOrDefault().Entity as string;
            var symbol = IntrinioApiService.GetTickerByName(query);
            var quotes = IntrinioApiService.SymbolDailyRequest(symbol.ticker);

            var graphPath = Graphics.GraphCreator.CreateChartCandleStick(quotes.data, 10);

            var replyMessage = context.MakeMessage();
            replyMessage.Text = "Here is your graph.";
            replyMessage.Attachments.Add(new Attachment
            {
                ContentUrl = graphPath,
                ContentType = "image/png",
                Name = "BinckBank Logo"
            });

            await context.PostAsync(replyMessage);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("GetAccount")]
        public async Task GetAccountIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var accountsCollection = BinckApiService.GetAccounts().Accounts;

            await context.PostAsync($"You have a **{accountsCollection.First().Name}** account and your account number is **{accountsCollection.First().Iban}**. <br/> " +
                $"Total number of accounts: **{accountsCollection.Count()}**");
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("CompanyInfoShort")]
        public async Task CompanyInfoShortIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var query = result.Entities.FirstOrDefault().Entity as string;
            var symbol = IntrinioApiService.GetTickerByName(query);
            var info = IntrinioApiService.GetCompanyInfoByTicker(symbol.ticker);


            var replyMessage = context.MakeMessage();
            replyMessage.Text = $"{query} found {info.name} which does:{Environment.NewLine}{info.short_description}" +
                $"{Environment.NewLine}More can be found at {info.company_url}";

            await context.PostAsync(replyMessage);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("StockLastPrice")]
        public async Task StockLastPriceIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var query = result.Entities.FirstOrDefault().Entity as string;
            var symbol = IntrinioApiService.GetTickerByName(query);
            var rtn = IntrinioApiService.GetCloseQuoteForSymbol(symbol.ticker);

            var replyMessage = context.MakeMessage();
            replyMessage.Text = $"The last price for {query} on {rtn.date} is {rtn.adj_high}";

            await context.PostAsync(replyMessage);
            context.Wait(this.MessageReceived);
        }
    }
}