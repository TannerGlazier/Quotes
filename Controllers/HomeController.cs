using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Quotes.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Quotes.Controllers
{
    public class HomeController : Controller
    {
        private IQuotesRepository _repo { get; set; }
        public HomeController(IQuotesRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var quotes = _repo.Quotes
                .OrderBy(x=> x.Author)
                .ToList();
            return View(quotes);
        }
        [HttpGet]
        public IActionResult AddQuote()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddQuote(Quote q)
        {
            _repo.AddQuote(q);
            return View("Index");
        }
        [HttpGet]
        public IActionResult Edit(int quoteid)
        {
            var quote = _repo.Quotes.Single(x => x.QuoteId == quoteid);
            return View("AddQuote", quote);
        }
        [HttpPost]
        public IActionResult Edit(Quote q)
        {
            _repo.UpdateQuote(q);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int quoteid)
        {
            var quote = _repo.Quotes.Single(x => x.QuoteId == quoteid);
            return View(quote);
        }
        [HttpPost]
        public IActionResult Delete (Quote q)
        {
            _repo.DeleteQuote(q);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int quoteid)
        {
            var quote = _repo.Quotes.Single(x => x.QuoteId == quoteid);
            return View(quote);
        }
        [HttpPost]
        public IActionResult Details(Quote q)
        {
            return View();
        }
    }
}
