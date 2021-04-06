using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace YS.Image.Rest.WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        [HttpGet]
        [Route("scale")]
        public void GetScaleImage(string sourceImageUrl, int width=128, int height=128)
        {
            
        }
    }
}