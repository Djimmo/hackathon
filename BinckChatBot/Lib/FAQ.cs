namespace BinckChatBot
{
    using System.Collections.Generic;

    public static class Faq
    {
        public static Dictionary<string, string> NL = new Dictionary<string, string>()
        {
            {
                "**Waarom krijg ik de melding dat ik niet genoeg VBR heb voor het plaatsen van een order voor Amerikaanse aandelen terwijl ik genoeg saldo heb?**",
                "- Omdat al het saldo van de klant in euro’s staan. Dit moet de klant eerst intern overboeken naar dollars (mits de klant geen gebruik maakt van effectenkrediet)."
            },
            {
                "**Waarom krijg ik de melding dat mijn overboeking leidt tot een valutaire debetstand wanneer ik mijn saldo wil overboeken naar mijn tegenrekening?**",
                "- Omdat het 2 beursdagen(europese effecten) of 3 (Amerikaanse effecten) beursdagen duurt voordat de verkoop van uw effecten valutair is afgewikkeld(voordat wij het geld binnen hebben van de beurs). Wanneer u niet wacht tot het saldo valutair is afgewikkeld gaat u 2-3 dagen debetrente betalen."
            },
            {
                "**Waarom zie ik de koersen met 15 minuten vertraging?**",
                "- Omdat de koersen standaard 15 minuten vertraagd zijn aangezien wij onderscheid moeten maken tussen prof- en niet-prof beleggers.Euronext/andere beurzen rekenen ons namelijk hoge kosten voor koersdata voor prof-beleggers.U kunt dit instellen op de Binck website via de instellingen."
            },
            {
                "**Wanneer ik intern geld overboek van euro’s naar dollars wordt er 5% van het bedrag ingehouden op mijn VBR waarom is dat? zijn dat kosten?**",
                "- Op uw posities genoteerd in vreemde valuta loopt u naast marktrisico (bijvoorbeeld een koersdaling van het aandeel), ook valutarisico(bijvoorbeeld een koersdaling van de dollar ten opzichte van de euro). Het laatste risico kan mogelijk leiden tot een waardevermindering van uw positie ten opzichte van de basisvaluta. De euro is bij Binck de basisvaluta. Het valutarisico loopt u op uw nettopositie in de desbetreffende valuta. Om deze reden wordt er 5% van de waarde van uw USD-saldo ingehouden op uw VBR. Wanneer u het saldo weer terugboekt of een order plaatst vervalt het valutarisico. Het zijn dus geen kosten!"
            },
            {
                "**Hoe koppel ik de mobiele Binck app?**",
                "- u download de Binck app.Vervolgens kunt u de stappen volgen op de Binck website via mijn Binck -> instellingen -> Producten & diensten -> Binck app."
            },
            {
                "**Kan ik meerdere rekeningen koppelen aan de Binck-app?**",
                "- Nee. Mocht u een Zelf Beleggen en een Fundcoach rekening hebben die gekoppeld aan elkaar zijn kunt u wel uw Fundcoach rekening raadplegen. Meerdere afzonderlijke rekeningen koppelen aan de Binck app kan echter (nog) niet. Als alternatief raden wij u de mobiele Binck website aan: mobiel.binck.nl."
            },
            {
                "**Kan ik dollars overboeken van mijn prive rekening naar mijn Binck dollarrekening? En andersom?**",
                "- Ja, u kunt dollars overboeken naar uw Binck dollarrekening. Wij kunnen u per e-mail de juiste instructies sturen.Uw dollars van uw Binck rekening naar uw tegenrekening overboeken kan echter niet."
            },
            {
                "**Waarom zie ik een negatief rendement op mijn aandelen in een andere valuta (dollar, noorse kronen, zwitzerse franken etc) terwijl de koers van het aandeel hoger is dan mijn aankoopkoers?**",
                "- het rendement wordt weergegeven in euro’s. De valuta waarin u uw aandelen aanhoudt is echter minder waard geworden ten opzichte van de euro waardoor u ondanks uw koerswinst toch een negatief rendement heeft."
            },
            {
                "**Ik heb gisteravond/in het weekend/op een feestdag geld overgemaakt naar Binck. Waarom staat het geld nog niet op mijn rekening?**",
                "- Omdat er ‘s avonds, in het weekend en op feestdagen geen betalingsverkeer plaatsvind. Op werkdagen duurt een geldoverboeking maximaal 24 uur."
            },
            {
                "**Ik heb een order geplaatst voor een beleggingsfonds. Waarom is de order nog niet uitgevoerd?**",
                "- In de regel worden beleggingsfondsen eenmaal per handelsdag verhandeld tegen de intrinsieke waarde, oftewel de net asset value (NAV) van het fonds. Om deze reden kunt u orders enkel bestens, dus tegen de eerstvolgende net asset value op het eerstvolgende mogelijke handelsmoment, plaatsen. Omdat de uitvoering vaak later plaatsvindt dan de dag waarop de order wordt opgegeven, is het uitsluitend mogelijk een doorlopende order te plaatsen voor een beleggingsfonds. Bij een dagorder zou de order immers kunnen komen te vervallen voordat deze is uitgevoerd. Beleggingsfondsen kunnen worden onderverdeeld in genoteerde en niet-genoteerde beleggingsfondsen. Genoteerde beleggingsfondsen worden verhandeld via Euronext Fund Service (EFS). Voor deze fondsen geldt, op een enkele uitzondering na, dat wanneer de order op handelsdagen voor 15:45 uur wordt opgegeven, de order de volgende handelsdag om 10:00 uur uitvoering krijgt. Niet-genoteerde beleggingsfondsen worden via een handelsplatform rechtstreeks tegen de betreffende fondsmanager verhandeld. Voor niet-genoteerde beleggingsfondsen geldt dat het per fondsaanbieder verschilt wanneer de order uitvoering krijgt.In de regel is dit binnen enkele handelsdagen na het plaatsen van de order. De terugmelding van de order ontvangt u enkele werkdagen na de uitvoering."
            }
        };
    }
}