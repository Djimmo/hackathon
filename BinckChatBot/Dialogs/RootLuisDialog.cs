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
            return;
        }

        [LuisIntent("Hello")]
        public async Task FavouriteColorIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var random = new Random();

            if (random.Next(0, 10) < 5)
            {
                await context.PostAsync("Hello, I'm Binck Buddy. How may I be of assistance?");
            }
            else
            {
                await context.PostAsync("Hi, I live to serve. How can I please you?");
            }
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("ShowGraph")]
        public async Task ShowGraphIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var query = result.Entities.FirstOrDefault().Entity as string;
            if (query == null)
            {
                var errorResult = "Try something else, please.";
                await context.PostAsync(errorResult);
                context.Wait(this.MessageReceived);
                return;
            }
            var symbol = IntrinioApiService.GetTickerByName(query);
            var quotes = IntrinioApiService.SymbolDailyRequest(symbol.ticker);

            var graphPath = Graphics.GraphCreator.CreateChartClose(quotes.data);

            var replyMessage = context.MakeMessage();
            replyMessage.Text = $"Your wish is my command. Here is the graph for the last 100 days for symbol {symbol.ticker}";
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
            if (query == null)
            {
                var errorResult = "Try something else, please.";
                await context.PostAsync(errorResult);
                context.Wait(this.MessageReceived);
                return;
            }
            var symbol = IntrinioApiService.GetTickerByName(query);
            var quotes = IntrinioApiService.SymbolDailyRequest(symbol.ticker);

            var graphPath = Graphics.GraphCreator.CreateChartCandleStick(quotes.data, 10);

            var replyMessage = context.MakeMessage();
            replyMessage.Text = $"You rang master? Here you have the last 10 day candlestick graph for symbol {symbol.ticker}";
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
            if (query == null)
            {
                var errorResult = "Try something else, please.";
                await context.PostAsync(errorResult);
                context.Wait(this.MessageReceived);
                return;
            }
            var symbol = IntrinioApiService.GetTickerByName(query);
            var info = IntrinioApiService.GetCompanyInfoByTicker(symbol.ticker);

            // Yesssssss master. The company is displayed as you requested.
            var replyMessage = context.MakeMessage();
            replyMessage.Text = $"Yesssssss master. The company is displayed as you requested." +
                $"<br/>The company {info.name} is described as:<br/>{info.short_description}" +
                $"<br/>More can be found at {info.company_url}";

            await context.PostAsync(replyMessage);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("StockLastPrice")]
        public async Task StockLastPriceIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var query = result.Entities.FirstOrDefault().Entity as string;
            if (query == null)
            {
                var errorResult = "Try something else, please.";
                await context.PostAsync(errorResult);
                context.Wait(this.MessageReceived);
                return;
            }
            var symbol = IntrinioApiService.GetTickerByName(query);
            var rtn = IntrinioApiService.GetCloseQuoteForSymbol(symbol.ticker);

            var replyMessage = context.MakeMessage();
            replyMessage.Text = $"I found some information. The last closing stock price is {rtn.adj_high} for symbol {symbol.ticker} on date {rtn.date.ToShortDateString()}";

            await context.PostAsync(replyMessage);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("NewCustomer")]
        public async Task NewCustomerIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var resultTxt = "Sure you can become a customer of the BEST broker in the world. Click this link to join: https://www.binck.nl/meer-informatie";
            await context.PostAsync(resultTxt);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("ThankYouResponse")]
        public async Task ThankYouIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var random = new Random();
            var num = random.Next(1, 100);

            var imageName = string.Empty;
            switch(num % 2)
            {
                case 0: imageName = "thanks.gif"; break;
                case 1: imageName = "gatsby.gif"; break;
                default: imageName = "thanks.gif"; break;
            }

            var replyMessage = context.MakeMessage();
            replyMessage.Text = "You are very welcome :)";
            replyMessage.Attachments.Add(new Attachment
            {
                ContentUrl = System.IO.Path.Combine(Graphics.GraphCreator.GetDesktopPath(), imageName),
                ContentType = "image/gif",
                Name = "Thanks"
            });

            await context.PostAsync(replyMessage);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Help")]
        public async Task HelpIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var replyMessage = context.MakeMessage();
            replyMessage.Text = "Start by saying what you want to know. For example: <br/>" +
                "- What is the stock price of Apple<br/>" +
                "- Show me a candle stick for IBM<br/>" +
                "- Do you have some company info for Microsoft<br/>" +
                "Of course you may always thank me for my hard work. Think of all the CPU cycles :o";

            await context.PostAsync(replyMessage);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("ShowFAQSTREAMING")]
        public async Task FaqIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var replyMessage = context.MakeMessage();
            /*
             "**Waarom zie ik de koersen met 15 minuten vertraging?**",
                "- Omdat de koersen standaard 15 minuten vertraagd zijn aangezien wij onderscheid moeten maken tussen prof- en niet-prof beleggers.
                Euronext/andere beurzen rekenen ons namelijk hoge kosten voor koersdata voor prof-beleggers.U kunt dit instellen op de Binck website via de instellingen."
             */

            replyMessage.Text = "*Why don't I have RealTime streaming quotes*<br/>" +
                "Quotes are delayed by 15 minutes by default since we have to differentiate professionals and non-professionals.<br/>"
                + "Euronext/other exchanges apply higher cost rates for quotes for professional traders.<br/>"
                + "You can change this in the settings on the Binck website at https://web.binck.nl/Settings/Index?groupName=QuoteSubscriptions";

            await context.PostAsync(replyMessage);
            context.Wait(this.MessageReceived);
        }
    }

}