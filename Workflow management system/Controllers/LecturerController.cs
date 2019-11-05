using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Workflow_management_system.Controllers
{
    public class LecturerController : Controller
    {

        public ActionResult Index()
        {
            if(!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                ViewBag.From = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd h:mm tt");
                ViewBag.To = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
                return GetIndex(DateTime.Now.AddDays(-30), DateTime.Now);
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string from, string to)
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                var today = DateTime.Now;
                ViewBag.From = from;
                ViewBag.To = to;

                var dateFrom = from;
                var dateTo = to;
                if ((dateFrom >= dateTo) || (dateTo > today.Date) || (dateFrom > today.Date))
                {
                    ViewBag.Error = "Incorrect Date Range";
                    ViewBag.From = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd h:mm tt");
                    ViewBag.To = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
                    return GetIndex(DateTime.Now.AddDays(-30), DateTime.Now);
                }

                return GetIndex(dateFrom, dateTo);
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }
        }

        public ActionResult AllRequests()
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                ViewBag.From = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd h:mm tt");
                ViewBag.To = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
                return GetAll(DateTime.Now.AddDays(-30), DateTime.Now);
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AllRequests(string from, string to)
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                var today = DateTime.Now;
                ViewBag.From = from;
                ViewBag.To = to;

                var dateFrom = from;
                var dateTo = to;
                if ((dateFrom >= dateTo) || (dateTo > today.Date) || (dateFrom > today.Date))
                {
                    ViewBag.Error = "Incorrect Date Range";
                    ViewBag.From = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd h:mm tt");
                    ViewBag.To = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
                    return GetAll(DateTime.Now.AddDays(-30), DateTime.Now);
                }

                return GetAll(dateFrom, dateTo);
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }
        }

        public ActionResult PendingRequests()
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                ViewBag.From = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd h:mm tt");
                ViewBag.To = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
                return GetPending(DateTime.Now.AddDays(-30), DateTime.Now);
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PendingRequests(string from, string to)
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                var today = DateTime.Now;
                ViewBag.From = from;
                ViewBag.To = to;

                var dateFrom = from;
                var dateTo = to;
                if ((dateFrom >= dateTo) || (dateTo > today.Date) || (dateFrom > today.Date))
                {
                    ViewBag.Error = "Incorrect Date Range";
                    ViewBag.From = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd h:mm tt");
                    ViewBag.To = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
                    return GetPending(DateTime.Now.AddDays(-30), DateTime.Now);
                }

                return GetPending(dateFrom, dateTo);
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }
        }

        public ActionResult AcceptedRequests()
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                ViewBag.From = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd h:mm tt");
                ViewBag.To = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
                return GetAccepted(DateTime.Now.AddDays(-30), DateTime.Now);
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AcceptedRequests(string from, string to)
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                var today = DateTime.Now;
                ViewBag.From = from;
                ViewBag.To = to;

                var dateFrom = from;
                var dateTo = to;
                if ((dateFrom >= dateTo) || (dateTo > today.Date) || (dateFrom > today.Date))
                {
                    ViewBag.Error = "Incorrect Date Range";
                    ViewBag.From = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd h:mm tt");
                    ViewBag.To = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
                    return GetAccepted(DateTime.Now.AddDays(-30), DateTime.Now);
                }

                return GetAccepted(dateFrom, dateTo);
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }
        }

        public ActionResult RejectedRequests()
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                ViewBag.From = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd h:mm tt");
                ViewBag.To = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
                return GetRejected(DateTime.Now.AddDays(-30), DateTime.Now);
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RejectedRequests(string from, string to)
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                var today = DateTime.Now;
                ViewBag.From = from;
                ViewBag.To = to;

                var dateFrom = from;
                var dateTo = to;
                if ((dateFrom >= dateTo) || (dateTo > today.Date) || (dateFrom > today.Date))
                {
                    ViewBag.Error = "Incorrect Date Range";
                    ViewBag.From = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd h:mm tt");
                    ViewBag.To = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
                    return GetRejected(DateTime.Now.AddDays(-30), DateTime.Now);
                }

                return GetRejected(dateFrom, dateTo);
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }
        }

        public ActionResult ViewRequest()
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditRequests()
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                return RedirectToAction("AllRequests");
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }
        }

        public ActionResult SendMail()
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendMail()
        {
            if (!ValidateUser())
                return RedirectToAction("LogIn", "Home");

            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return View("../Home/LogIn");
            }
        }


        //==========================Private Functions=======================================================

        private ViewResult GetIndex(DateTime from, DateTime to)
        {
            ViewData["UserName"] = "Hope";

            //var fromDate = from;
            //var toDate = to;

            //CSummary summary = new CSummary();

            return View();
        }

        private ViewResult GetAll(DateTime from, DateTime to)
        {
            ViewData["UserName"] = "Hope";

            return View();
        }

        private ViewResult GetPending(DateTime from, DateTime to)
        {
            ViewData["UserName"] = "Hope";

            return View();
        }

        private ViewResult GetAccepted(DateTime from, DateTime to)
        {
            ViewData["UserName"] = "Hope";

            return View();
        }

        private ViewResult GetRejected(DateTime from, DateTime to)
        {
            ViewData["UserName"] = "Hope";

            return View();
        }

        private bool ValidateUser()
        {
            return true;
        }
    }
}