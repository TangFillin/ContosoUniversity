﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using ContosoUniversity.IService;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly SchoolContext _context;
        private readonly IAccountService _service;
        public AccountController(SchoolContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}