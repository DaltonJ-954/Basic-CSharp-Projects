using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamousQuoteApp.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string PopularQuote { get; set; }
        public string WhoQuotedIt { get; set; }

        public Quote()
        {
            
        }
    }
}
