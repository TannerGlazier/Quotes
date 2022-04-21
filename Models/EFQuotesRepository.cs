using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quotes.Models
{
    public class EFQuotesRepository:IQuotesRepository
    {
        private QuoteContext _context { get; set; }
        public EFQuotesRepository(QuoteContext temp)
        {
            _context = temp;
        }
        public IQueryable<Quote> Quotes => _context.Quotes;

        public void AddQuote(Quote q)
        {
            _context.Add(q);
            _context.SaveChanges();
        }
        public void UpdateQuote(Quote q)
        {
            _context.Update(q);
            _context.SaveChanges();
        }
        public void DeleteQuote(Quote q)
        {
            _context.Remove(q);
            _context.SaveChanges();
        }
    }
}
