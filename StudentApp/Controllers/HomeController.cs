using StudentApp.Models;
using StudentApp.Repository;
using StudentApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApp.Controllers
{
    public class HomeController : Controller
    {
        IUnitOfWork _uow;
        StudentService _studentService;

        public HomeController()
        {
            _uow = new UnitOfWork<StudentDBDataContext>();
            _studentService = new StudentService(_uow);
        }

        public JsonResult Index()
        {
            return Json(_studentService.GetAllStudents(), JsonRequestBehavior.AllowGet);
        }

    }
}
