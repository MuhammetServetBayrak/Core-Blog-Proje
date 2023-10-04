﻿using BusinessLayer.Concretee;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProje.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        
        public IViewComponentResult Invoke()
        {
            var values = skillManager.TGetList();
            return View(values);
        }
    }
}
