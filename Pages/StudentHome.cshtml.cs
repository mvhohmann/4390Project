using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _4390Project.Pages;
public class StudentHomeModel : PageModel
{
    private readonly ILogger<StudentHomeModel> _logger;

    public StudentHomeModel(ILogger<StudentHomeModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}