using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.CONTROLLER
{
    public class LoginController
    {
        private static object GetDebuggerDisplay()
        {
            throw new NotImplementedException();
        }

        [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
        public class LoginController : Controller
        {
            AppDbContext db = new AppDbContext(); // DB Context

            public LoginController()
            {
            }

            public object Session { get; private set; }
            public object ViewBag { get; private set; }

            // GET: Login page
            public ActionResult Index()
            {
                return View();
            }

            private ActionResult View()
            {
                throw new NotImplementedException();
            }

            public object GetSession()
            {
                return Session;
            }


            // POST: Login check
            [HttpPost]
            public ActionResult Index(string username, string password)
            {
                using (var conn = new SQLiteConnection("Data Source=unicomtic.db"))
                {
                    conn.Open();

                    string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Session["UserID"] = reader["UserId"].ToString();
                                Session["Role"] = reader["Role"].ToString();

                                return RedirectToAction("Dashboard", "Home");
                            }
                        }
                    }
                }

                ViewBag.Error = "Invalid Username or Password";
                return View();
            }

            private ActionResult RedirectToAction(string v1, string v2)
            {
                throw new NotImplementedException();
            }

            private string GetDebuggerDisplay() => ToString();
        }
    }
}

    }
}
