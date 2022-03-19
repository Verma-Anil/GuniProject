using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Linq;
using GuniThises.web.Models;
using GuniThises.web.Data;
using GuniThises.web.ViewModels;

namespace GuniThises.web.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        private readonly UserManager<MyIdentityUser> _userManager;
        public readonly ApplicationDbContext _context;

        public StudentsController(
            UserManager<MyIdentityUser> userManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var viewmodel = new StudentViewModel();
            var user = await _userManager.GetUserAsync(this.User);
            if (user != null)
            {
                var student = _context.Students.SingleOrDefault(s => s.UserId == user.Id);
                if (student != null)
                {
                    // user.IsAdminUser
                    viewmodel.DateOfBirth = user.DateOfBirth;
                    viewmodel.ParentName = student.ParentName;
                    viewmodel.EnrollmentId = student.EnrollmentID;
                }
            }

            return View(viewmodel);
        }
    }
}
