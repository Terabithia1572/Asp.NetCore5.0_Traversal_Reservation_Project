using Asp.NetCore5._0_Traversal_Reservation_Project.Areas.Admin.Models;
using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            //List<Announcement> announcements = _announcementService.TGetList();
            //List<AnnouncementListViewModel> model = new();
            //foreach (var item in announcements)
            //{
            //    AnnouncementListViewModel announcementListViewModel = new();
            //    announcementListViewModel.ID = item.AnnouncementID;
            //    announcementListViewModel.Title = item.Title;
            //    announcementListViewModel.Content = item.Content;

            //    model.Add(announcementListViewModel);
            //}
            var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.TGetList());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date=Convert.ToDateTime(DateTime.Now.ToShortDateString())

                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
