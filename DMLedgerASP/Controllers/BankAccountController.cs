using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DMLedgerASP.Models;
using DMLedgerASP.ViewModels;

namespace DMLedgerASP.Controllers
{
    public class BankAccountController : Controller
    {
        private ApplicationDbContext _context;

        public BankAccountController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: BankAccount/BankAccountForm
        public ActionResult BankAccountForm()
        {
            return View(new NewBankAccountViewModel { });
        }

        // POST: BankAccount/BankAccountForm
        [HttpPost]
        public ActionResult Create(BankAccount bankAccount)
        {
            _context.BankAccounts.Add(bankAccount);
            _context.SaveChanges();
            return RedirectToAction("Index", "User");
        }
    }
}