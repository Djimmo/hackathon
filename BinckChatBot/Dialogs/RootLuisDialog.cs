namespace BinckChatBot.Dialogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web;
    using Microsoft.Bot.Builder.Dialogs;
    using Microsoft.Bot.Builder.FormFlow;
    using Microsoft.Bot.Builder.Luis;
    using Microsoft.Bot.Builder.Luis.Models;
    using Microsoft.Bot.Connector;

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

        [LuisIntent("ShowStockIntent")]
        public async Task ShowStockIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            await context.PostAsync("My favourite technologies are Azure, Mixed Reality and Xamarin!");
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("FavouriteColorIntent")]
        public async Task FavouriteColorIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            await context.PostAsync("My favourite color is Blue!");
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("WhatsYourNameIntent")]
        public async Task WhatsYourNameIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            await context.PostAsync("My name is Davide, of course :)");
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("HelloIntent")]
        public async Task HelloIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            await context.PostAsync(@"Hi there! Davide here :) This is my personal Bot. Try asking 'What are your favourite technologies?'");
            context.Wait(this.MessageReceived);
        }
    }
}