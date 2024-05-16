using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using testNettly.web.Models;

namespace testNettly.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SignIn(string username, string password)
        {
            bool isAuthenticated = AuthenticateUser(username, password);
            if (isAuthenticated)
            {
                return RedirectToAction("Booking");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View("SignIn");
            }
        }

        [HttpPost]
        public IActionResult SignUp(FormModel model)
        {
            if (ModelState.IsValid)
            {
                // Assuming user creation logic is handled here
                // For now, just redirecting to the booking to simulate successful signup
                return RedirectToAction("Booking");
            }
            else
            {
                return View("SignUp", model);
            }
        }

        public IActionResult Booking()
        {
            return View();
        }

        public IActionResult BookingDisplay()
        {
            return View();
        }

        public IActionResult AppointmentBooking()
        {
            return View();
        }

        // Redirect actions for Feedback management, assuming they are handled by a separate FeedbackController
        public IActionResult Feedback()
        {
            return RedirectToAction("Index", "Feedback");
        }

        public IActionResult FeedbackCollection()
        {
            return RedirectToAction("FeedbackCollection", "Feedback");
        }

        // Additional pages
        public IActionResult FAQs()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Help()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }



        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Exit()
        {
            // Simulating an exit by returning to a "Goodbye" page
            return RedirectToAction("Goodbye");
        }

        public IActionResult Goodbye()
        {
            return View();
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Dummy authentication logic
            return username == "admin" && password == "admin";  // Consider implementing real authentication logic here
        }
    }



    public class FormModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

