using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;
using WebApplication7.Services;


namespace WebApplication7.Controllers
{
    public class FileController : Controller
    {
        private readonly FileDownloadService _fileDownloadService;

        public FileController(FileDownloadService fileDownloadService)
        {
            _fileDownloadService = fileDownloadService;
        }

        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GenerateFile(FileDownloadModel model)
        {
            var fileBytes = _fileDownloadService.GenerateFile(model);
            var fileName = $"{model.FileName}.txt";
            return File(fileBytes, "text/plain", fileName);
        }
    }
}
