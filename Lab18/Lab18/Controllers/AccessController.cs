using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab18.Controllers
{
    public class AccessController : Controller
    {
// GET: Access
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index()
        {
            try
            {
                return Content("1");
            }
            catch (Exception ex)
            {
                return Content("ocurrio un error:(" + ex.message);
            }
        }
    }
        
    
}