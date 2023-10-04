using BusinessLayer.Concretee;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoreProje.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager WriterUserManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()  //Ajax veri eklediğimiz zaman sayfayı yenilemeden verilerin gösterilmesini sağlar.
        {
            return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(WriterUserManager.TGetList());   //Gelen veriyi json türüne çevirmek için kullanılır.    //!!!Listeleme işlemlerinde SerializeObject kullanılır.
            return Json(values);
        }

        public IActionResult AddUser(WriterUser p)
        {
            WriterUserManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

    }
}
