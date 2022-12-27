using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechShop.Common;
using TechShop.Models;

namespace TechShop.Controllers
{
    public class LichSuDonHangController : Controller
    {
        // GET: LichSuDonHang
        private TechShopDbContext db = new TechShopDbContext();
        public ActionResult Index()
        {
            var user = Session[SessionMember.UserSession];
            if (user == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                var CustomerID = user.ToString();
                var model = db.Orders.Where(x => x.CustomerID == CustomerID).OrderByDescending(x => x.CreatedDate).ToList();
                return View(model);
            }            
        }
    }
}