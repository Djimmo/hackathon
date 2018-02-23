namespace BinckChatBot
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Http;
    using Microsoft.Bot.Connector;
    using Oracle.ManagedDataAccess.Client;

    [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        ///     POST: api/Messages
        ///     Receive a message from a user and reply to it
        /// </summary>
        public async Task<HttpResponseMessage> Post([FromBody] Activity activity)
        {
            if (activity.Type == ActivityTypes.Message)
            {
                ConnectorClient connector = new ConnectorClient(new Uri(activity.ServiceUrl));
                Activity reply;
                var inputCommand = activity.Text.Split();

                switch (inputCommand[0])
                {
                    case "/aex":
                        reply =
                            activity.CreateReply(
                                $"De huidige koers van de **AEX** is **{GetPrice(3829)}** punten.");
                        break;
                    case "/price":
                        try
                        {
                            var info = GetPriceByName(inputCommand[1]);
                            reply =
                                activity.CreateReply(
                                    $"De huidige koers van **{info[1]}** is **{info[0]}** punten.");
                        }
                        catch
                        {
                            reply =
                                activity.CreateReply(
                                    "Dit symbool is niet bekend bij mij. Probeer het nog eens of zoek op naam via **/search** voor een lijst met symbolen.");
                        }
                        break;
                    case "/search":
                        try
                        {
                            var resultTable = GetSymbolByName(inputCommand[1]);

                            StringBuilder sb = new StringBuilder();
                            for (int i = 0; i < resultTable.Rows.Count; i++)
                            {
                                sb.Append(
                                    $"Fonds **{resultTable.Rows[i][0]}** {resultTable.Rows[i][1]} -> Symbool **{resultTable.Rows[i][2]}**<br/>");
                            }
                            reply =
                                activity.CreateReply(sb.ToString());
                        }
                        catch
                        {
                            reply =
                                activity.CreateReply(
                                    "Deze naam is niet bekend, probeer het eens met een andere naam");
                        }
                        break;
                    case "/help":
                        reply =
                            activity.CreateReply(
                                "**Command List:**<br/>**/aex**: prijs van AEX-index<br/>**/price** <i>(symbool)</i>: prijs van gekozen stock<br/>**/search** <i>(fondsnaam)</i>: zoek symbool op fondsnaam.<br/>**/faq**: Veelgestelde vragen.<br/>**/klantworden**: Informatie om klant te worden.<br/>**/disclaimer**: disclaimer BinckChatBot.");
                        break;
                    case "/klantworden":
                        reply = activity.CreateReply("Word klant bij Binck!<br/>https://www.binck.nl/meer-informatie");
                        reply.Attachments.Add(new Attachment()
                        {
                            ContentUrl = "http://beleggenvergelijk.nl/wp-content/uploads/2011/12/binckbank.jpg",
                            ContentType = "image/png",
                            Name = "BinckBank Logo"
                        }
                            );
                        break;
                    case "/disclaimer":
                        reply =
                            activity.CreateReply(
                                "**Disclaimer:**<br/>De tarieven, meningen, nieuws, gegevens en andere informatie via deze chatbot zijn continu aan wijziging onderhevig en deels afkomstig van derden. BinckBank betracht de grootst mogelijke zorgvuldigheid in de samenstelling van de Informatie, maar garandeert niet dat de Informatie compleet en/of accuraat is, noch aanvaardt BinckBank enige aansprakelijkheid voor directe of indirecte schade welke is ontstaan door gebruikmaking van de Informatie, behoudens opzet of grove schuld van BinckBank. De Informatie kan niet worden aangemerkt als enige vorm van (beleggings)advies.");
                        reply.Attachments.Add(new Attachment()
                        {
                            ContentUrl =
                                "https://www.binck.nl/images/librariesprovider9/headerandfooter/logo-188x31.png?sfvrsn=4",
                            ContentType = "image/png",
                            Name = "BinckBank Logo"
                        });
                        break;
                    case "/faq":
                        string faqQuestions = Faq.NL.Aggregate("", (current, item) => current + "" + item.Key + "<br/>" + item.Value + "<br/>---<br/>");

                        reply = activity.CreateReply(faqQuestions);
                        break;
                    default:
                        reply =
                            activity.CreateReply(
                                "Welkom bij de BinckChatBot.<br/>Typ **/help** om een overzicht van alle commando's te krijgen.");
                        break;
                }

                // return our reply to the user
                await connector.Conversations.ReplyToActivityAsync(reply);
            }
            else
            {
                HandleSystemMessage(activity);
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        private static DataTable GetSymbolByName(string s)
        {
            using (OracleConnection connection = new OracleConnection("Data Source=TOT7;User Id=lees;Password=read;"))
            {
                connection.Open();
                DataTable table;
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        $"select fon.fondsnaam, fon.val_valutacode, fon.symbool from fon_fondsen fon where fon.fondsnaam like \'%{FirstLetterToUpperCase(s)}%\' and fon.fst_fondstype_nr in (100,106,108,109,113,114,115,116,117) and fon.vervallen = \'N\' and fon.verhandelbaar = \'J\'";
                    //cmd.Parameters[""] =;
                    command.CommandType = CommandType.Text;
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        table = new DataTable();
                        adapter.Fill(table);
                    }
                }
                connection.Dispose();
                return table;
            }
        }

        private static string[] GetPriceByName(string s)
        {
            using (OracleConnection connection = new OracleConnection("Data Source=TOT4;User Id=lees;Password=read;"))
            {
                connection.Open();
                DataTable table;
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        $"select fon.fondsid, fon.fondsnaam from fon_fondsen fon where fon.symbool = \'{s.ToUpper()}\' and fon.fst_fondstype_nr in (100,106,108,109,113,114,115,116,117,120,125) and fon.vervallen = \'N\'";
                    //cmd.Parameters[""] =;
                    command.CommandType = CommandType.Text;
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        table = new DataTable();
                        adapter.Fill(table);
                    }
                }
                connection.Dispose();
                return new string[] {GetPrice(int.Parse(table.Rows[0][0].ToString())), table.Rows[0][1].ToString()};
            }
        }

        private static string GetPrice(int securityId)
        {
            using (OracleConnection connection = new OracleConnection("Data Source=QNT7;User Id=lees;Password=read;"))
            {
                connection.Open();
                DataTable table;
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        $"select mrq.price from qds_most_recent_quotes mrq where mrq.sec_security_id = {securityId} and mrq.qqt_quote_type_nr = 2";
                    //cmd.Parameters[""] =;
                    command.CommandType = CommandType.Text;
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        table = new DataTable();
                        adapter.Fill(table);
                    }
                }
                connection.Dispose();
                return table.Rows[0][0].ToString();
            }
        }

        /// <summary>
        ///     Returns the input string with the first character converted to uppercase
        /// </summary>
        private static string FirstLetterToUpperCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentException("There is no first letter");

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        private static Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                // Handle conversation state changes, like members being added and removed
                // Use Activity.MembersAdded and Activity.MembersRemoved and Activity.Action for info
                // Not available in all channels
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing that the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            return null;
        }
    }
}