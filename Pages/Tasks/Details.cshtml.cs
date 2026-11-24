using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using wt_lab12_12auth_validation_liseychikov.Data;
using wt_lab12_12auth_validation_liseychikov.Models;

namespace wt_lab12_12auth_validation_liseychikov.Pages.Tasks;

public class DetailsModel : PageModel
{
    private readonly AppDbContext _context;

    public DetailsModel(AppDbContext context)
    {
        _context = context;
    }

    public TaskModel? Task { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        Task = await _context.Tasks.FindAsync(id);

        if (Task == null)
        {
            return NotFound();
        }

        return Page();
    }
}