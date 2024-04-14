using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CloudStorageTest.API.Controllers;
{
    [ApiController]
    [Route("api/[controller]")]
    public class StorageController : ControllerBase
    {
        [HttpPost]
        public IActionResult UploadImage(IFormFile)
        {
            return Created();
        }
    }
}