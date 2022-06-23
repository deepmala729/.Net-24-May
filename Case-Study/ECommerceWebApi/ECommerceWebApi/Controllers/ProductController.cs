using ECommerceWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ECommerceDB1Context db;
        public ProductController(ECommerceDB1Context _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblProduct> GetProducts()
        {
            return db.TblProducts;
        }
    }
}
