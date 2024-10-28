using System.Text;
using WebApplication7.Models;

namespace WebApplication7.Services
{
    public class FileDownloadService
    {
        public byte[] GenerateFile(FileDownloadModel model)
        {
            var fileContent = $"Name: {model.FirstName} {model.LastName}";
            return Encoding.UTF8.GetBytes(fileContent);
        }
    }
}
