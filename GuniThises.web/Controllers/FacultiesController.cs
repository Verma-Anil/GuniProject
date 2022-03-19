using GuniThises.web.Data;
using GuniThises.web.Models;
using GuniThises.web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace GuniThises.web.Controllers
{
    [Authorize]
    public class FacultiesController : Controller
    {
        private readonly UserManager<MyIdentityUser> _userManager;
        public readonly ApplicationDbContext _context;

        public FacultiesController(
            UserManager<MyIdentityUser> userManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var viewmodel = new FacultyViewModel();
            var user = await _userManager.GetUserAsync(this.User);
            if (user != null)
            {
                var faculty = _context.Faculty.SingleOrDefault(s => s.UserId == user.Id);
                if (faculty != null)
                {
                    // user.IsAdminUser
                    viewmodel.DateOfBirth = user.DateOfBirth;
                    viewmodel.FacultyType = faculty.FacultyType;                  
                    
                }
            }

            return View(viewmodel);
        }
    }
}
