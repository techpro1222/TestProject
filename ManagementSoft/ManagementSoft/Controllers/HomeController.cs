using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ManagementSoft.Models;
using DataLib.Entities;
using DataLib.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ManagementSoft.Helper;
using Microsoft.Extensions.Configuration;
using System.Data;
using Newtonsoft.Json;
using Microsoft.Extensions.Hosting;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace ECommerceCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBContext db;
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IConfiguration Configuration { get; }
        private readonly IHostingEnvironment _hostingEnvironment;


        public HomeController(ILogger<HomeController> logger, DBContext _db, IHttpContextAccessor httpContextAccessor, IConfiguration configuration, IHostingEnvironment en)
        {
            _logger = logger;
            db = _db;
            _httpContextAccessor = httpContextAccessor;
            Configuration = configuration;
            _hostingEnvironment = en;
        }

        public IActionResult DashBoard()
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
            }
            return View();
        }

        public IActionResult Index()
        {
            //if (!CheckUserexists())
            //{
            //    return RedirectToAction("Login", "Admin");
            //}
            //else
            //{
            // CurrentUser(GetLoginUserId());               
            return View();
            //}
        }

        #region Customer
        public IActionResult CustomerDetail()
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
                var list = db.Customer.ToList();
                return View(list);
            }

        }

        public IActionResult AddCustomer(int? Id)
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
                if (Id > 0 && Id != null)
                {
                    var obj = db.Customer.Where(x => x.Id == Id).FirstOrDefault();
                    return View(obj);
                }
                return View();
            }
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer obj)
        {
            try
            {
                var exists = db.Customer.Where(x => x.Id == obj.Id).FirstOrDefault();
                if (exists != null)
                {
                    exists.ContactTitle = obj.ContactTitle;
                    exists.CompanyName = obj.CompanyName;
                    exists.City = obj.City;
                    exists.Country = obj.Country;
                    exists.Fax = obj.Fax;
                    exists.Phone = obj.Phone;
                    exists.PostalCode = obj.PostalCode;
                    exists.Region = obj.Region;

                    db.Customer.Update(exists);
                }
                else
                {
                    db.Customer.Add(obj);
                }

                db.SaveChanges();
                ViewData["Success"] = "Saved Successfuly";

            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
            }
            return View(obj);
        }

        [HttpPost]
        public JsonResult DeleteCustomer(int Id)
        {
            try
            {
                string result = string.Empty;
                if (Id != 0)
                {
                    Customer obj = db.Customer.Where(x => x.Id == Id).FirstOrDefault();
                    db.Customer.Remove(obj);
                    db.SaveChanges();
                }
                else
                    result = "error";

                return Json(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region Orders
        public IActionResult Order()
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
                var list = db.Order.Include(x=>x.Customer).ToList();
                return View(list);
            }
        }

        public IActionResult AddOrder(int? Id)
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
                ViewBag.Customers = db.Customer.ToList();

                if (Id > 0 && Id != null)
                {
                    var obj = db.Order.Where(x => x.Id == Id).FirstOrDefault();
                    return View(obj);
                }
                return View();
            }
        }
        [HttpPost]
        public IActionResult AddOrder(Order obj)
        {
            try
            {
                ViewBag.Customers = db.Customer.ToList();
                if (obj.CustomerId == 0)
                {
                    ViewData["Warning"] = "Select Customer first";
                    return View(obj);
                }

                var exists = db.Order.Where(x => x.Id == obj.Id).FirstOrDefault();
                if (exists != null)
                {
                    exists.OrderDate = obj.OrderDate;
                    exists.RequiredDate = obj.RequiredDate;
                    exists.ShipingAddress = obj.ShipingAddress;
                    exists.CustomerId = obj.CustomerId;
                    db.Order.Update(exists);
                }
                else
                {
                    db.Order.Add(obj);

                }
                db.SaveChanges();
                ViewData["Success"] = "Saved Successfuly";

            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
            }
            return View(obj);
        }

        [HttpPost]
        public JsonResult DeleteOrder(int Id)
        {
            try
            {
                string result = string.Empty;
                if (Id != 0)
                {
                    Order obj = db.Order.Where(x => x.Id == Id).FirstOrDefault();
                    db.Order.Remove(obj);
                    db.SaveChanges();
                }
                else
                    result = "error";

                return Json(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion



        #region User Details
        public IActionResult UsersDetail()
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
                var data = db.Users.ToList();
                return View(data);
            }
        }
        public IActionResult AddUser(int? Id)
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
                if (Id != null && Id != 0)
                {
                    //  var data = db.Users.GetById(Id??0).Result;
                    return View();
                }
                return View();
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(Users obj)
        {
            try
            {
                //if (string.IsNullOrEmpty(obj.user_name))
                //{
                //    ViewData["Warning"] = "User Saved Successfuly";
                //    return View(obj);
                //}
                //obj.created_at = DateTime.Now;
                //obj.user_pass = SecurePasswordHasher.Hash(obj.user_pass);
                //if (obj.id == 0)
                //{
                //   await db.Users.Add(obj);
                //}
                //else
                //{
                //    db.Users.Update(obj);
                //}

                //await db.SaveAsync();
                ViewData["Success"] = "User Saved Successfuly";
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
            }
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> DeleteUser(int Id)
        {
            try
            {
                string result = string.Empty;
                if (Id != 0)
                {
                    //Users obj = await db.Users.GetById(Id);
                    //db.Users.Delete(obj);
                    //await db.SaveAsync();
                }
                else
                    result = "error";

                return Json(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region User validation

        public void CurrentUser(Users User)
        {
            ViewData["User"] = User.UserName;
        }
        public bool CheckUserexists()
        {
            var user = GetLoginUserId();

            if (user != null)
            {
                Remove("LoginUserId");
                Remove("LoginUsername");

                SetCookie("LoginUserId", user.Id.ToString(), 1);
                SetCookie("LoginUsername", user.UserName.ToString(), 1);

                return true;
            }
            else
            {
                return false;
            }
        }

        private Users GetLoginUserId()
        {
            Users obj = new Users();
            string cookieValueFromReq, cookieValueFromRequser, cookieUserrole;

            //read cookie from Request object  
            cookieValueFromReq = Request.Cookies["LoginUserId"];
            cookieValueFromRequser = Request.Cookies["LoginUsername"];
            cookieUserrole = Request.Cookies["LoginUserRole"];


            if (cookieValueFromReq != null && cookieValueFromRequser != null)
            {
                obj.Id = cookieValueFromReq;
                obj.UserName = cookieValueFromRequser;
                return obj;
            }
            else
            {
                return null;
            }
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
        #endregion


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
