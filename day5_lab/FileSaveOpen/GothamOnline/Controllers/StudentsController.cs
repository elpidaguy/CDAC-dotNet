using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;

namespace GothamOnline.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            TrainingManager trainingMgr = new TrainingManager();
            List<Student> studList = trainingMgr.GetAllStudents();

            return View(studList);
        }
    }
}