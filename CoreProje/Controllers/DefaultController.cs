using BusinessLayer.Concretee;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProje.Controllers
{
    //Bu controllerlarda yapılan işlemler anasayfa için kullanıcının göreceği işlemler Admin tarafısı için her bir entity için ayrı ayrı controller üzerinden ekleme silme güncelleme listeleme yapıalcak

    public class DefaultController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()   //Bu controller'ın view'ı tek sayfa halinde olduğu için layout kullanmıyoruz.
        {
            return View();
        }

        //PartialViewları tutacağımız alanı default controller içinde tutacağız daha modüler yapıda olması için.
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SendMessage(Message m)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());
            m.Status = true;
            messageManager.TAdd(m);
            return PartialView();
        }
    }
}
