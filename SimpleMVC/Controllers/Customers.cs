using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace SimpleMVC.Controllers
{
    public class Customers : Controller
    {
        public List<CustomerInfo> CustomersList { get; set; } = [];

        public void onGet()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-09M400V\\SQLEXPRESS;Initial Catalog=crmdb;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM customers";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CustomerInfo customer = new CustomerInfo();
                                customer.Id = reader.GetInt32(0);
                                customer.FirstName = reader.GetString(1);
                                customer.LastName = reader.GetString(2);
                                customer.Email = reader.GetString(3);
                                customer.Phone = reader.GetString(4);
                                customer.Address = reader.GetString(5);
                                customer.Company = reader.GetString(6);
                                customer.Notes = reader.GetString(7);
                                customer.CreatedAt = reader.GetDateTime(8).ToString("dd/MM/yyyy");
                                CustomersList.Add(customer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public class CustomerInfo
        {
            public int Id { get; set; }
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
            public string Email { get; set; } = "";
            public string Phone { get; set; } = "";
            public string Address { get; set; } = "";
            public string Company { get; set; } = "";
            public string Notes { get; set; } = "";
            public string CreatedAt { get; set; } = "";
        }
    }
}
