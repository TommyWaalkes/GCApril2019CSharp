using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Lab28DAL.Models
{
    public class CardAPIDAL
    {
        public static string APICall(string URL)
        {
            HttpWebRequest request = WebRequest.CreateHttp(URL);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            return APIText;
        }

        public static Deck GetNewDeck()
        {
            string URL = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            string APIText = APICall(URL);

            JToken json = JToken.Parse(APIText);

            Deck d = new Deck();

            d.DeckID = json["deck_id"].ToString();
            d.RemainingCards = int.Parse(json["remaining"].ToString());

            return d;

            //Code from here down will be moved to a new method called DrawCards
        }

        public static List<Card> DrawCards(int cardsToDraw, Deck d)
        {
            string CardURL = $"https://deckofcardsapi.com/api/deck/{d.DeckID}/draw/?count={cardsToDraw}";

            string CardText = APICall(CardURL);

            JToken cardJson = JToken.Parse(CardText);

            List<JToken> cardsToken = cardJson["cards"].ToList();
            List<Card> cards = new List<Card>();

            foreach (JToken card in cardsToken)
            {
                Card c = new Card(card);
                cards.Add(c);
            }
            return cards;
        }

        public static Deck UpdateDeck(Deck d)
        {
            // d.RemainingCards = int.Parse(t["remaining"].ToString());
            if (d.RemainingCards <= 0)
            {
                d = GetNewDeck();
            }
            else
            {
                string URL = $"https://deckofcardsapi.com/api/deck/{d.DeckID}/";
                string APIText = APICall(URL);
                JToken t = JToken.Parse(APIText);
                d.RemainingCards = int.Parse(t["remaining"].ToString());
            }

            return d;
        }
    }
}