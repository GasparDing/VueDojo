﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VueDojo.WebApplication.Controllers
{
    public class VueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}