using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ProfileController : Controller
    {
        public static List<Models.Profile> ListProfile = new List<Models.Profile>();
        public ActionResult Index()
        {
            return View(ListProfile);
        }
        // GET: Profile
        public ActionResult AddProfile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProfile(Models.Profile model)
        {
            ListProfile.Add(model);
            return View("Detail", model);
            
        }
        
        public ActionResult Detail()
        {
            Models.Profile item = new Models.Profile()
            {
                ID = 1,
                NamaLengkap = "Ahmad Roni",
                Alamat = "Jakarta",
                Hobi = "hiking"
            };
            return View(item);
        }
    }
}