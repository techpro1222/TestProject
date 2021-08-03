using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Data;
using DataLib.Entities;
using ManagementSoft.Helper;
using ManagementSoft.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSoft.Controllers
{
    public class AdminController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly DBContext db;

        public AdminController(IHttpContextAccessor httpContextAccessor, DBContext _db)
        {
            this._httpContextAccessor = httpContextAccessor;
            db = _db;
        }
        public IActionResult Login()
        {
            Remove("LoginUserId");
            Remove("LoginUsername");
            Remove("LoginUserRole");            

            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

     
        [HttpPost]
        public async Task<IActionResult> SignUp(Users model)
        {
            try
            {
                Users obj = new Users
                {
                    Id = Guid.NewGuid().ToString(),                   
                    Email = model.Email,
                    UserName = model.UserName,
                    CreatedDate = DateTime.Now,                 
                    PasswordHash = SecurePasswordHasher.Hash(model.PasswordHash),
                    PhoneNumber = model.PhoneNumber,
                    IsActive = true                   
                };

                db.Users.Add(obj);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

            return RedirectToAction("Index", "Home");

        }

        [HttpPost]
        public IActionResult Login(Users login)
        {
            try
            {
                string cookieValueFromContext = _httpContextAccessor.HttpContext.Request.Cookies["LoginUserId"];
                //read cookie from Request object  
                string cookieValueFromReq = Request.Cookies["LoginUserId"];

                Remove("LoginUserId");
                Remove("LoginUsername");

                 var user = db.Users.Where(x => x.UserName == login.UserName).FirstOrDefault();
                if (user != null)
                {
                    if (SecurePasswordHasher.Verify(login.PasswordHash, user.PasswordHash))
                    {
                        SetCookie("LoginUserId", user.Id.ToString(), 1);
                        SetCookie("LoginUsername", user.UserName.ToString(), 1);

                        return RedirectToAction("CustomerDetail", "Home");
                    }
                    else
                    {
                        ViewData["Error"] = "Incorrect User/Password";

                    }
                }
                else
                {
                    ViewData["Error"] = "Incorrect User/Password";
                    return View();

                }
                //  return RedirectToAction("Index", "Home");



            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;                
            }
            return View();
        }
        /// <summary>  
        /// set the cookie  
        /// </summary>  
        /// <param name="key">key (unique indentifier)</param>  
        /// <param name="value">value to store in cookie object</param>  
        /// <param name="expireTime">expiration time</param>  
        private void SetCookie(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddHours(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Append(key, value, option);
        }

        public void Remove(string key)
        {
            Response.Cookies.Delete(key);
        }
    }
}
