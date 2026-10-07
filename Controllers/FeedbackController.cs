using Practical_7.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Practical_7.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbackList = new List<Feedback>();

        // Starting Page
        public ActionResult Home()
        {
            return View();
        }

        // View all feedback
        public ActionResult Index()
        {
            return View(feedbackList);
        }

        // Give Feedback - GET
        public ActionResult Create()
        {
            return View();
        }

        // Give Feedback - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);

                return RedirectToAction("Index");
            }

            return View(feedback);
        }

        // View one feedback
        public ActionResult View(int enrollmentNo)
        {
            Feedback feedback = feedbackList.Find(
                f => f.EnrollmentNo == enrollmentNo.ToString()
            );

            if (feedback == null)
            {
                return HttpNotFound();
            }

            return base.View(feedback);
        }
    }
}