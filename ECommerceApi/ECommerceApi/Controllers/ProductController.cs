﻿using ECommerceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ECommerceDBContext ec;
        public ProductController(ECommerceDBContext _ec)
        {
            ec = _ec;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ec.Products;
        }
        [HttpPost]
        public string Post([FromBody] Product product)
        {
            ec.Products.Add(product);
            ec.SaveChanges();
            return "success";

        }
    }
}
    
