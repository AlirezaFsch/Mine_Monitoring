using Microsoft.AspNetCore.Mvc;

namespace Mine_Monitoring.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Authenticate(string username, string password)
        {
            // Your authentication logic here
            // Example: check if username and password match a user in the database

            if (username == "admin" && password == "password")
            {
                // Authentication successful
                // Redirect the user to the dashboard
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Authentication failed
                // Show an error message or redirect back to the login page
                return RedirectToAction("Index");
            }
        }
    }
}


