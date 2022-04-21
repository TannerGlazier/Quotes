using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quotes.Models
{
    public interface IQuotesRepository
    {
        IQueryable<Quote> Quotes { get; }
        public void AddQuote(Quote q);
        public void UpdateQuote(Quote q);
        public void DeleteQuote(Quote q);
    }
}
