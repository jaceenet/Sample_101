using System;
using System.Web.Mvc;

namespace Gluu_101.Controllers
{
    using System.Linq;

    using Gluu_101.SimpleDb;

    public class UserController : Controller
    {
        public ActionResult Get(int? id)
        {
            using (var db = new GluuSimpleDb())
            {
                return this.Json(db.Users.First(), JsonRequestBehavior.AllowGet);
            }            
        }        
    }
}
