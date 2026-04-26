using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySqlConnector;

namespace CRMProject.Pages.Customer
{
    public class Create : PageModel
    {
        private string ErrorMessage= "";

        [BindProperty, Required(ErrorMessage = "Enter the name")]
        public string name { get; set; } = "";
        [BindProperty, Required(ErrorMessage = "Enter the email"),
        EmailAddress(ErrorMessage = "Invalid email format")]
        public string email { get; set; } = "";
        [BindProperty, Required(ErrorMessage = "Enter the phone number")]
        public string phone { get; set; } = "";
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
                {
                    if (!ModelState.IsValid)
                    {
                        return Page();
                    }

                    try
                    {
                        using (var connection = new MySqlConnection("Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=manager;"))
                        {
                            connection.Open();

                            var command = new MySqlCommand(
                                "INSERT INTO Customers (name,email,phone) VALUES (@name,@email,@phone)",
                                connection);

                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@phone", phone);

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                       ErrorMessage = ex.Message;
                        return Page();
                    }

                    return RedirectToPage("/Customer/Index");
                }

    }
}

