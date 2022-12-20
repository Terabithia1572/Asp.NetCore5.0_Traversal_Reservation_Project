using Asp.NetCore5._0_Traversal_Reservation_Project.Areas.Member.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task< IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new();
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.Surname;
            userEditViewModel.phonenumber = values.PhoneNumber;
            userEditViewModel.mail = values.Email;
            //userEditViewModel.password = values.PasswordHash;
            //userEditViewModel.confirmpassword = values.PasswordHash;
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task< IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if(userEditViewModel.Image !=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditViewModel.Image.FileName);
                var ImageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/UserImages/" + ImageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await userEditViewModel.Image.CopyToAsync(stream);
                user.ImageURL = ImageName;
            }
            user.Name = userEditViewModel.name;
            user.Surname = userEditViewModel.surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }
            return View();
        }
    }
}
