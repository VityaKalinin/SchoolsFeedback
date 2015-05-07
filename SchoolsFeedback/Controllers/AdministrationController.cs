using SchoolsFeedback.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolsFeedback.Controllers
{
    [Authorize(Roles="Administrator")]
    public class AdministrationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //
        // GET: /Adminisration/
        public ActionResult AllMessages()
        {
            var messages = db.Messages.ToList();
            return View(messages);
        }

        public ActionResult Details(int id)
        {
            var message = db.Messages.Find(id);
            if (message == null)
            {
                return HttpNotFound();
            }

            return View(message);
        }

	}
}