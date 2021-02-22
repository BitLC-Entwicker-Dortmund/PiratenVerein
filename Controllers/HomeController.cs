using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PiratenVerein.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PiratenVerein.Controllers {
    public class HomeController : Controller {

        public IActionResult Index ( ) {
            return View ( );
        }

        public IActionResult Privacy ( ) {
            return View ( );
        }
    }
}
