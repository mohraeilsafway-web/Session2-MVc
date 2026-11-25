using GymManagementSystem.contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagementSystem.Controllers
{
    public class PlanController : Controller
    {
        #region PlanController
        private readonly GymDbContext dbContext = new GymDbContext();

        //Get/BaseURL/Plan
        //Get/BaseURL/Plan/Index
        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            var plans = await dbContext.Plans.ToListAsync();

            return View(plans);
        }
        #endregion

    }
}
