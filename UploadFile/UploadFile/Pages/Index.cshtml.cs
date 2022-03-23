using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace UploadFile.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHostingEnvironment _he;

        public IndexModel(ILogger<IndexModel> logger, IHostingEnvironment he)
        {
            _logger = logger;
            this._he = he;
        }

        [BindProperty]
        public IFormFile Photo { get; set; }

        public void OnGet()
        {

        }

        public async Task OnPost()
        {
            var path = Path.Combine(this._he.WebRootPath, "images", Photo.FileName);
            var stream = new FileStream(path, FileMode.Create);
            await this.Photo.CopyToAsync(stream);
            //using (var fs = new FileStream(fileUpload, FileMode.Create))
            //{
            //    await UploadFiles.CopyToAsync(fs);
            //    ViewData["Message"] = UploadFiles.FileName + " has been successfully uploaded";
            //}
        }
    }
}
