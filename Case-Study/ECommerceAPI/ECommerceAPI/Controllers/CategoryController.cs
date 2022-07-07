using ECommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        EcommerceDBContext db;
        public CategoryController(EcommerceDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblCategory> GetCategory()
        {
            return db.TblCategories;
        }
        [HttpPost]
        public string post([FromBody] TblCategory ct)
        {
            db.TblCategories.Add(ct);
            db.SaveChanges();
            return "Success";
        }
    }
}
