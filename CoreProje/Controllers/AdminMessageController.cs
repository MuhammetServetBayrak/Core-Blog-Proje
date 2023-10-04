using BusinessLayer.Concretee;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CoreProje.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            string p;
            p="admin@gmail.com";
            var values = writerMessageManager.GetListRecevierMessages(p);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListSenderMessages(p);
            return View(values);
        }

        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            return View(values);
        }

        public IActionResult AdminMessageDelete(int id)
        {
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.TGetByID(id);
            if (values.Receiver==p)
            {
                writerMessageManager.TDelete(values);
                return RedirectToAction("ReceiverMessageList");
            }
            else
            {
                writerMessageManager.TDelete(values);
                return RedirectToAction("SenderMessageList");
            }
            
        }
        [HttpGet]
        public IActionResult AdminMessageSend()  //ADmin mesaj gönderme işlemi
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date=DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }


    }
        
    
}
