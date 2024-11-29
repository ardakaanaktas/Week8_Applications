using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Arda",
                LastName = "Aktaş",
                Email = "ardaa62@gmail.com"
            };

            Order order1 = new Order
            {
                Id = 1,
                ProductName = "Laptop",
                Price = 5000,
                Quantity = 95
            };
            Order order2 = new Order
            {
                Id = 2,
                ProductName = "Mouse",
                Price = 50,
                Quantity = 100
            };
            Order order3 = new Order
            {
                Id = 3,
                ProductName = "Keyboard",
                Price = 100,
                Quantity = 50
            };

            List<Order> orders = new List<Order> { order1, order2, order3 };

            CustomerOrderViewModel viewModel = new CustomerOrderViewModel
            {
                customer = customer,
                orders = orders
            };
            return View(viewModel);
        }
    }
}
