using BusinessLayer.Concretee;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreProje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        //List
        public IActionResult Index()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }
        //Add
        [HttpGet]
        public IActionResult AddPortfolio()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results=validations.Validate(portfolio);
            if (results.IsValid)
            {
                portfolioManager.TAdd(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }           
            return View();
        }
        //Delete
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult PortfolioEdit(int id)
        {
            //Değiştireceğimizin verinin id sini Get de tutturup değiştirme işlemini ise Post üzerinden yapacağız. 
            var values = portfolioManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult PortfolioEdit(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();  
            ValidationResult result=validations.Validate(portfolio);
            if (result.IsValid)
            {
                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                
            }
            return View();
        }
    }
}
