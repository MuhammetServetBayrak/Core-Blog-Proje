using BusinessLayer.Concretee;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProje.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = featureManager.TGetByID(1);//Sadece 1 kişilik kullanıcı olacağı için blog sayfasında o yüzden bu şekilde yaptık
            //Dışarıdan ID vermedik çünkü bir tane Id ile sadece güncelleme işlemi yapılıp blog sayfasına veriler sunulacak.
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {

            featureManager.TUpdate(feature);
            return RedirectToAction("Index","Default");//Default içinde bulunan indexe yönlendiriyoruz.
        }
    }
}
