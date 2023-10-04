using Core_Proje_Api.DAL.ApiContext;
using Core_Proje_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje_Api.Controllers
{
    [Route("api/[controller]")]      //Bu contorllerdaki metotlara istek atarken bu şekilde yazacaksın
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategoryList()
        {
            var c = new Context();
            return Ok(c.Categories.ToList());       //Apilerde sonucun başarılı olduğunu gösteren bir method
        }


        [HttpGet("{id}")]
        public IActionResult CategoryGetId(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            using var c=new Context();
            c.Add(category);
            c.SaveChanges();
            return Created("", category);
        }


        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category p)
        {
            using var c = new Context();
            var value = c.Find<Category>(p.CategoryID);
            if (value==null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName=p.CategoryName;
                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }
        }
    }
}
