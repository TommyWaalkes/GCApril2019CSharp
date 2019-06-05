using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab28DAL.Models
{
    public class Card
    {
        public string Code { get; set; }
        public string Suit { get; set; }
        public string Value { get; set; }
        public string Image { get; set; }

        public Card()
        {

        }

        public Card(JToken json)
        {
            Code = json["code"].ToString();
            Suit = json["suit"].ToString();
            Value = json["value"].ToString();
            Image = json["image"].ToString();
        }
    }
}