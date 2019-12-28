using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;

namespace GothamOnline.Controllers
{
    public class EmployeesController : Controller
    {
        HRManager hrMgr = new HRManager();
        // GET: Employees
        public ActionResult Index()
        {
            return View(hrMgr.GetAllEmployees());
        }

        public ActionResult Details(int id)
        {
            return View(hrMgr.GetEmployee(id));
        }
    }
}