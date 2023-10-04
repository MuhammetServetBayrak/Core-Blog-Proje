using BusinessLayer.Concretee;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList:ViewComponent
    {
        WriterMessageManager writerMessage = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string p = "admin@gmail.com";
            var values=writerMessage.GetListRecevierMessages(p).OrderByDescending(x=>x.WriterMessageID).Take(3).ToList();  //En son atılan 3 mesajın gelmesini sağlayan linq kodu.
            return View(values);
        }
    }
}
