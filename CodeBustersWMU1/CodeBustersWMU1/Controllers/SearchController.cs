﻿using CodeBustersWMU1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeBustersWMU1.Controllers
{
    public class SearchController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: Search
        public ActionResult Search(int id)
        {
            id = 1;
            var product =
            from o in db.Orders
            where o.OrderId == id
            select o;

            
            //TempData["Order"] = product.First();

            return View(product.ToList());
        }
    }
}