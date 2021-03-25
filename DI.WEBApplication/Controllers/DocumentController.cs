using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.WEBApplication.Controllers
{
    public class DocumentController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
