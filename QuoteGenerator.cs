using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KanyeAndRon
{
    public class QuoteGenerator
    {
        public static void kanyeQuote()
        {
            var client = new HttpClient();

            var kanysURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanysURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Kanye:  '{kanyeQuote}'");
            Console.WriteLine("----------------------------------------------------------");
        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var RonResponse = client.GetStringAsync(ronURL).Result;

           

            var RonQuote = JArray.Parse(RonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Ron:  '{RonQuote}'");
            Console.WriteLine("----------------------------------------------------------");
        }

    }
}
