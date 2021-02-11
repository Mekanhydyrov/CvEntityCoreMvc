using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CvEntityCoreMvc.Models.Sinflar;
using System.Web.UI.WebControls;

namespace CvEntityCoreMvc.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c = new Context();
            var deger = c.Yeteneklers.ToList();
            return View(deger);
        }
    }
}