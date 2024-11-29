using Microsoft.AspNetCore.Mvc;

namespace CustomerProject.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            //Basit bir Customer modeli oluştur.
            var customer = new CustomerProject.Models.Customer
            {
                Id = 1,
                FirstName = "Arda",
                LastName = "Aktaş",
                Email = "ardaa62@gmail.com"
            };

            var viewModel = new CustomerProject.Models.CustomerViewModel
            {
                customer = customer,
                WelcomeMessage = "Welcome " + customer.FirstName + " " + customer.LastName
            };

            return View(viewModel);
        }
    }
}
