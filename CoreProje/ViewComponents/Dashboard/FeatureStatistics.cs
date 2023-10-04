using BusinessLayer.Concretee;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProje.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    { 
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Skills.Count();//Yetenek sayısı
            ViewBag.v2 = c.Messages.Where(x=>x.Status==false).Count();//Okunmamış mesaj sayısı
            ViewBag.v3 = c.Messages.Where(x=>x.Status==true).Count();//Okunmuş mesaj sayısı
            ViewBag.v4 = c.Experiences.Count();//Deneyim sayısı
            return View();
        }
    }
}
