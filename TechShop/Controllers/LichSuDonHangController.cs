using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechShop.Models;

namespace TechShop.Controllers
{
    public class LichSuDonHangController : Controller
    {
        // GET: LichSuDonHang
        private TechShopDbContext db = new TechShopDbContext();
        public ActionResult Index()
        {
            return View();
        }
    }
}