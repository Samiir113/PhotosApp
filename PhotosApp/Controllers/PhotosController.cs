using Microsoft.AspNetCore.Mvc;
using PhotosApp.Models;

namespace PhotosApp.Controllers
{
    public class PhotosController : Controller
    {
        private readonly DataService dataService;

        public PhotosController(DataService dataService)
        {
            this.dataService = dataService;
        }

        [Route("")]
        public IActionResult Index()
        {
            var model = dataService.GetAll();
            return View(model);
        }

        [Route("1")]
        public IActionResult First()
        {
            return View();
        }

    }
}
