﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using coseees_mvc.Models;

namespace coseees_mvc.Controllers
{
    public class AboutController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Activity()
        {
            return View();
        }

        
    }
}
