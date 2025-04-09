
using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nombusoStudyGroup.Models;


namespace nombusoStudyGroup.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public static List<Models.PersonModel> people = new List<Models.PersonModel>();

        public ActionResult ListPeople()
        {

            //people.Add(new Models.PersonModel { StudentNumber = 12345, Name = "Nombuso", Surname = "Mdletshe", Email = "nombuso.mdletshe@tuks.co.za" });
            //people.Add(new Models.PersonModel { StudentNumber = 12346, Name = "Mbalenhle", Surname = "Mdletshe", Email = "mbalenhle.mdletshe@tuks.co.za" });
            //people.Add(new Models.PersonModel { StudentNumber = 12347, Name = "Nothando", Surname = "Mdletshe", Email = "nothando.mdletshe@tuks.co.za" });
            //people.Add(new Models.PersonModel { StudentNumber = 12348, Name = "Laksa", Surname = "Mdletshe", Email = "laska.mdletshe@tuks.co.za" });
            //people.Add(new Models.PersonModel { StudentNumber = 12349, Name = "Lola", Surname = "Mdletshe", Email = "lola.mdletshe@tuks.co.za" });


            return View(people);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.PersonModel pm)
        {
            people.Add(new Models.PersonModel { Name = pm.Name, Surname = pm.Surname, Email = pm.Email, StudentNumber = pm.StudentNumber });
            return RedirectToAction("ListPeople");

        }
    }
}