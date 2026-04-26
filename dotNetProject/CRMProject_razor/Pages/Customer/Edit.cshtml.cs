using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySqlConnector;

namespace CRMProject.Pages.Customer
{
    public class Edit : PageModel
{
    [BindProperty]
    public int Id { get; set; }

    [BindProperty, Required(ErrorMessage = "Enter the name")]
    public string Name { get; set; } = "";

    [BindProperty, Required(ErrorMessage = "Enter the email"),
    EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; } = "";

    [BindProperty, Required(ErrorMessage = "Enter the phone number")]
    public string Phone { get; set; } = "";

    public string Message { get; set; } = "";

    public IActionResult OnGet(int id)
    {
        using var connection = new MySqlConnection("Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=manager;");
        connection.Open();

        var command = new MySqlCommand(
            "SELECT * FROM Customers WHERE id=@id",
            connection);

        command.Parameters.AddWithValue("@id", id);

        using var reader = command.ExecuteReader();

        if (!reader.Read())
            return RedirectToPage("/Customer/Index");

        Id = reader.GetInt32("id");
        Name = reader.GetString("name");
        Email = reader.GetString("email");
        Phone = reader.GetString("phone");

        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        try
        {
            using var connection = new MySqlConnection("Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=manager;");
            connection.Open();

            var command = new MySqlCommand(
                "UPDATE Customers SET name=@name, email=@email, phone=@phone WHERE id=@id",
                connection);

            command.Parameters.AddWithValue("@id", Id);
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@email", Email);
            command.Parameters.AddWithValue("@phone", Phone);

            int rows = command.ExecuteNonQuery();

            if (rows > 0)
            {
                TempData["Success"] = "Customer updated successfully.";
                return RedirectToPage("/Customer/Index");
            }
            else
            {
                Message = "Update failed.";
                return Page();
            }
        }
        catch (Exception ex)
        {
            Message = "Error: " + ex.Message;
            return Page();
        }
    }
}
}