using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySqlConnector;

namespace CRMProject.Pages.Customer
{
    public class Delete : PageModel
    {
        [BindProperty]
        public int Id { get; set; }

        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";

        private readonly string connectionString =
            "Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=manager;";

        public IActionResult OnGet(int id)
        {
            using var connection = new MySqlConnection(connectionString);
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
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            var command = new MySqlCommand(
                "DELETE FROM Customers WHERE id=@id",
                connection);

            command.Parameters.AddWithValue("@id", Id);
            command.ExecuteNonQuery();

            return RedirectToPage("/Customer/Index");
        }
    }
}