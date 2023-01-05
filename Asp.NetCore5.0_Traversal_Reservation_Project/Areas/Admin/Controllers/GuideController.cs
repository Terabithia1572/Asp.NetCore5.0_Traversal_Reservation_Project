using BusinessLayer.Abstract;
using BusinessLayer.ValidationVules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }
        [Route("")]
        [Route("Index")]

        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values);
        }
        [Route("AddGuide")]

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [Route("AddGuide")]
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new();
            ValidationResult result = validationRules.Validate(guide);
            if (result.IsValid)
            {
                _guideService.TAdd(guide);
                return RedirectToAction("Index","Guide",new {area="Admin" });
            }
           else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
             _guideService.TUpdate(guide);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
        [Route("ChangeToTrue/{id}")]
        public IActionResult ChangeToTrue(int id)
        {
            _guideService.TChangeToTrueByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
        [Route("ChangeToFalse/{id}")]

        public IActionResult ChangeToFalse(int id)
        {
            _guideService.TChangeToFalseByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
        [Route("DeleteGuide/{id}")]

        public IActionResult DeleteGuide(int id)
        {
            var values = _guideService.GetByID(id);
            _guideService.TDelete(values);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
            //NULL
        }
    }
}
