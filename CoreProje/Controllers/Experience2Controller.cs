using BusinessLayer.Concretee;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreProje.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);  //Json formatında döndürmek için convert işlemi ile dönüşümünü gerkeçleştirmek gerekiyor.
            return Json(values);
        }
        [HttpPost]
        public IActionResult DeleteExperience(Experience p)
        {
            experienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);  //Json formatında döndürmek için convert işlemi ile dönüşümünü gerkeçleştirmek gerekiyor.
            return Json(values);
        }

        public IActionResult GetById(int ExprerienceID)
        {
            var v = experienceManager.TGetByID(ExprerienceID);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }

        public IActionResult DeleteExperience(int id)
        {
            var v = experienceManager.TGetByID(id);
            experienceManager.TDelete(v);
            return NoContent();
        }

        [HttpPost]
        public IActionResult UpdateExperince(int id,string ad,string tarih)
        {
            var arananIdDeger = experienceManager.TGetByID(id);
            if (arananIdDeger != null) //Eğer ıd bulunur ise aşağdıdaki işlemleri yp
            {
                arananIdDeger.Name = ad;
                arananIdDeger.Date = tarih;
                experienceManager.TUpdate(arananIdDeger);  //üst satırlardaki paramatrelerden gelen değerleri veri tabanındaki verilere ata.
                var jFormat = JsonConvert.SerializeObject(arananIdDeger);
            }         
                return NoContent();
            
            
        }
    }
}
