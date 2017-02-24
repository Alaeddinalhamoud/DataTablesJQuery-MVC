using DataTablesJQuery_MVC.Models;
using DataTablesJQuery_MVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace DataTablesJQuery_MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent repositoryStudent;

        public StudentController(IStudent repoStudent)
        {
            repositoryStudent = repoStudent;
        }
        // GET: Student
        public ActionResult Index()
        {
            List<Student> model = new List<Student>();
            model = repositoryStudent.GetStudent;
            return View(model);
        }

        public ActionResult DataTablesJQuery()
        {
            return View();
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public ActionResult DataTablesJQueryJSON()
        {
            List<Student> model = new List<Student>();
            model = repositoryStudent.GetStudent; 
            var UserData = new object[model.Count];
            int j = 0;
            foreach (var i in model)
            {
                UserData[j] = new object[] {i.ID, i.FirstName ,i.LastName, i.City};
                j++;
            }
           
            return Json(UserData, JsonRequestBehavior.AllowGet);
        }
    }
}