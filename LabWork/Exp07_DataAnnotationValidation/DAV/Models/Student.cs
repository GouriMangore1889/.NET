using System.ComponentModel.DataAnnotations;

public class Student
{
    [Required(ErrorMessage = "Name field required")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Email field required")]
    [EmailAddress]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Password field required")]
    public string Password { get; set; } = "";

    [Range(18, 60)]
    public int Age { get; set; }

    public string Phone { get; set; } = "";
}