using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRMProject.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            var user = HttpContext.Session.GetString("User");

            if (user != null)
            {
                return RedirectToPage("/Customer/Index");
            }

            return RedirectToPage("/Login");
        }
    }
}