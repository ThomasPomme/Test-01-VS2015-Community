using Microsoft.AspNet.Mvc;
using Bjj.Core.Contract;
using Microsoft.Framework.DependencyInjection;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class ChartController : Controller
    {
        private readonly IChartDrawerService _chartDrawerService;

        public ChartController (IServiceCollection services)
        {
            _chartDrawerService = Context.RequestServices.GetRequiredService<IChartDrawerService>();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {

            var item = _chartDrawerService.DrawAttackBox("Test", "Toto");
            return View();
        }
    }
}
