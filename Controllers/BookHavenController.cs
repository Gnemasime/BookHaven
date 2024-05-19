using BookHaven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookHaven.Controllers
{
    public class BookHavenController : Controller
    {
        // GET: BookHaven
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(BookOrder bo)
        {
            bo.BasicCost = bo.CalcBasicTotal();
            bo.ExtraCost = bo.CalcExtra();
            bo.TotalCostSingle = bo.CalcTotalCostSingle();
            bo.TotalCost = bo.CalcTotalCost();
            bo.VatDue = bo.CalcVatDue();
            bo.FinalCost = bo.CalcFinalCost();
            return View(bo);
        }
    }
}