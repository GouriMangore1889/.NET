using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySqlConnector;

namespace CRMProject.Pages.Customer
{
    public class IndexModel : PageModel
    {
        public List<CustomerInfo> listCustomers = new List<CustomerInfo>();
        //  {
        //     new CustomerInfo { Id = 1, Name = "John Doe",Email = "john.doe@example.com", Phone = "123-456-7890" },
        //     new CustomerInfo { Id = 2, Name = "Jane Smith",Email = "jane.smith@example.com", Phone = "987-654-3210" }
        // };

        public IActionResult OnGet()
        {
            var user = HttpContext.Session.GetString("User");

            if (user == null)
            {
                return RedirectToPage("/Login");
            }

            try
            {
                using (var connection = new MySqlConnection(
                    "Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=manager;"))
                {
                    connection.Open();
                    var command = new MySqlCommand("SELECT * FROM customers", connection);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listCustomers.Add(new CustomerInfo
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Email = reader.GetString(2),
                                Phone = reader.GetString(3)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Page();
        }
        public class CustomerInfo
        {
            public int Id { get; set; }
            public string Name { get; set; }= "";
            public string Email { get; set; }= "";
            public string Phone { get; set; } = "";
            
        }

    }
}