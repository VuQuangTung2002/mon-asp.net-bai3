using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai3.Controllers
{
    public class ThongTinSinhVienController : Controller
    {
        // GET: ThongTinSinhVien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult View2()
        {
            ViewBag.Message= "Thông tin chi tiết sinh viên";
            return View();
        }
    }
}