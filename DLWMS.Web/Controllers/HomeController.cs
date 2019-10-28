using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DLWMS.Web.Models;
using DLWMS.Service;
using DLWMS.Core;

namespace DLWMS.Web.Controllers
{
    public class HomeController : Controller
    {

        IStudentService studentService;

        public HomeController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        public IActionResult Index()
        {
            Student s = studentService.GetStudentByIme("IB160062");
            s?.Ime.ToUpper();
            studentService.Update(s);
            return View();
        }

        public IActionResult Privacy()
        {

            Student s = new Student() {  Ime = "Denis", Prezime = "Music"};
            studentService.Add(s);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
