﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SolProductStore.Models;

namespace SolProductStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(string slugLink)
        {
            Product product = Database.GetProduct(slugLink);
            return View(product);
        }

        public IActionResult List()
        {
            List<Product> products = Database.GetProduct();
            return View(products);
        }
    }
}
