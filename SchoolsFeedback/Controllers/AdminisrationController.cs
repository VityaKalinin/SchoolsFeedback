using SchoolsFeedback.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolsFeedback.Controllers
{
    public class AdminisrationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //
        // GET: /Adminisration/
        public ActionResult AllMessages()
        {
            var messages = db.Messages.ToList();
            return View(messages);
        }


	}
}