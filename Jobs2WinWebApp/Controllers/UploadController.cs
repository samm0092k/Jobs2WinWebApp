using Microsoft.AspNetCore.Mvc;

namespace Jobs2WinWebApp.Controllers
{
    public class UploadController : Controller
    {
        //[HttpPost]
        //public IActionResult Index(List<IFormFile> file)
        //{
        //    return View();
        //}
        [HttpPost]
        public IActionResult Index(IFormFile file)
        {

            return View();
        }
        //[HttpPost]
        //public IActionResult Upload(IFormFile formFile)
        //{
        //    return View();
        //}
        //[HttpPost("FileUpload")]
        //public async Task<IActionResult> Index(List<IFormFile> files)
        //{
        //    return View(files);
        //}
    }
}
