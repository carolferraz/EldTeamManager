using Microsoft.AspNetCore.Mvc;
using TeamManager.Application.Services.SkillType;
using TeamManager.Domain.Entities;
using TeamManager.Web.Helpers;
using TeamManager.Web.Models.SkillType;

namespace TeamManager.Web.Controllers
{
    public class SkillTypeController : Controller
    {
        private readonly ISkillTypeService _skillTypeService;

        public SkillTypeController(ISkillTypeService skillTypeService)
        {
            _skillTypeService = skillTypeService;
        }

        public IActionResult List()
        {
            var skillType = _skillTypeService.ListAll();
            var skillTypeViewModel = new SkillTypeListViewModel(skillType);
            return View(skillTypeViewModel);
        }

        public IActionResult Delete(int id)
        {
           var skillType = _skillTypeService.GetById(id);
            ViewBag.HashId = HashIdHelper.Encode(id);
            return View(skillType);
        }

        public IActionResult DeleteConfirm(int id, string hash)
        {
            var decodedId = HashIdHelper.Decode(hash);
            if (decodedId == id)
                _skillTypeService.Delete(id);

            return RedirectToAction("List");
        }

        public IActionResult New()
        {
            return View("Form");
        }

        public IActionResult Edit(int id)
        {
            var skillType = _skillTypeService.GetById(id);
            return View("Form", skillType);
        }

        public IActionResult Save(SkillType skillType)
        {
            ModelState.Remove("Id");

            if (ModelState.IsValid)
            {
                _skillTypeService.Save(skillType);
                return RedirectToAction("List");
            }
            else
                return View("Form", skillType);
        }

    }
}
