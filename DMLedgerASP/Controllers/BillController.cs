using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DMLedgerASP.Models;
using DMLedgerASP.ViewModels;

namespace DMLedgerASP.Controllers
{
    public class BillController : Controller
    {
        private ApplicationDbContext _context;

        public BillController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: /Bill/BillForm
        public ActionResult BillForm()
        {
            return View(new NewBillViewModel());
        }

        // POST: /Bill/BillForm
        [HttpPost]
        public ActionResult Create(Bill bill)
        {
            _context.Bills.Add(bill);
            _context.SaveChanges();
            return RedirectToAction("Index", "User");
        }
    }
}