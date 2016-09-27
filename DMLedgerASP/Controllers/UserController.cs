using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DMLedgerASP.Models;
using DMLedgerASP.ViewModels;

namespace DMLedgerASP.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext _context;

        public UserController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: user
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNew(UserData userData)
        {
            switch (userData.NewItemTypeId)
            {
                case 1:
                    return RedirectToAction("BankAccountForm", "BankAccount");
                case 2:
                    return RedirectToAction("BillForm", "Bill");
                case 3:
                    return RedirectToAction("CreditCardForm", "CreditCard");
                default:
                    break;
            }
            return View();
        }
    }
}