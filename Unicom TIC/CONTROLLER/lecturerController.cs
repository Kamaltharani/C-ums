using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unicom_TIC.MADELS;
using Unicom_TIC.MODELS;

namespace Unicom_TIC.CONTROLLER
{
    public class LecturerController : Controller
    {
        private readonly object ModelState;
        AppDbContext db = new AppDbContext();

        // GET: Lecturer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lecturer/Create
        [HttpPost
            ]
        public ActionResult Create(Lecturer lecturer, HttpPostedFileBase photo)
        {
            if (!ModelState.IsValid)
            {
                return View(lecturer);
            }

            if (photo != null && photo.ContentLength > 0)
            {
                string fileName = Path.GetFileName(photo.FileName);
                string path = Path.Combine(
                    Microsoft.SqlServer.Server.MapPath("~/Uploads"),
                    fileName);
                photo.SaveAs(path);

                lecturer.ImagePath = "/Uploads/" + fileName;
            }

            db.Lecturers.Add(lecturer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        private ActionResult RedirectToAction(string v)
        {
            throw new NotImplementedException();
        }

        // GET: Lecturer/Index
        public ActionResult Index()
        {
            var data = db.Lecturers.ToList();
            return View(data);
        }

        private ActionResult View(object data)
        {
            throw new NotImplementedException();
        }
    }
}

    

