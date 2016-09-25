using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DMLedgerASP.Models;
using DMLedgerASP.ViewModels;

namespace DMLedgerASP.Controllers
{
    public class CreditCardController : Controller
    {
        private ApplicationDbContext _context;

        public CreditCardController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: CreditCard/CreditCardForm
        public ActionResult CreditCardForm()
        {
            return View(new NewCreditCardViewModel());
        }

        // POST: /CreditCard/CreditCardForm
        [HttpPost]
        public ActionResult Create(CreditCard creditCard)
        {
            _context.CreditCards.Add(creditCard);
            _context.SaveChanges();
            return RedirectToAction("Index", "User");
        }
    }
}