using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRMProject.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; } = "";
        [BindProperty]
        public string Password { get; set; } = "";
        public string ErrorMessage { get; set; } = "";

        public IActionResult OnPost()
        {
            if (Username == "admin" && Password == "1234")
            {
                HttpContext.Session.SetString("User", Username);
                return RedirectToPage("/Customer/Index");
            }

            ErrorMessage = "Invalid username or password";
            return Page();
        }
    }
}