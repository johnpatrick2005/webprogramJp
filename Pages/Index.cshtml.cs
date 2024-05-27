using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string InputString { get; set; }

    public string OutputString { get; private set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        OutputString = "The string you entered is: " + InputString;

        return Page();
    }
}
