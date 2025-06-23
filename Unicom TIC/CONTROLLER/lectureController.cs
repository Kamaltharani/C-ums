using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom_TIC.MADELS;

namespace Unicom_TIC.CONTROLLER
{
    public class lectureController
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

    


    

