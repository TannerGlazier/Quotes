using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quotes.Models
{
    public class QuoteContext : DbContext
    {
        public QuoteContext(DbContextOptions<QuoteContext> options): base(options)
        {

        }
        public DbSet<Quote> Quotes { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Quote>().HasData(
                new Quote
                {
                    QuoteId = 1,
                    QuoteText = "All we have to decide is what to do with the time that is given us.",
                    Author = "J.R.R. Tolkien",
                    Date = "7/29/1954",
                    Subject = "Time",
                    Citation = "The Lord of the Rings: The Fellowship of the Ring"
                },
                new Quote
                {
                    QuoteId = 2,
                    QuoteText = "Do not pity the dead, Harry. Pity the living, and above all those who live without love.",
                    Author = "J.K. Rowling",
                    Date = "7/14/2007",
                    Subject = "Love",
                    Citation = "Harry Potter and the Deathly Hallows"
                },
                new Quote
                {
                    QuoteId = 3,
                    QuoteText = "Spencer, out!",
                    Author = "Spencer Hilton",
                    Date = "3/28/2022",
                    Subject = "Enthusiasm",
                    Citation = "MySQL - Part 07 - Concluding Thoughts"
                }

                );
        }

    }
}
