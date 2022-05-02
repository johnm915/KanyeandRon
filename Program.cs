using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace KanyeAndRon
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.kanyeQuote();

            QuoteGenerator.RonQuote();
            
       }
    }
}
