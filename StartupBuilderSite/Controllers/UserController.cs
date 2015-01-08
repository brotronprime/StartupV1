using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StartupBuilderSite.Models;

namespace StartupBuilderSite.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Profile()
        {
			UserProfileModel user = new UserProfileModel();
	        user.FirstName = "Bill";
	        user.LastName = "Barber";
	        user.MiddleName = "Sylvester";
	        user.City = "Lehi";
	        user.State = "Utah";
	        user.Zip = "84043";
	        user.Phone = "801-801-8011";
	        user.Email = "billsylvester@inc.com";
	        user.GChatHandle = "billsylvester@gchat.com";
	        user.SkypeHanle = "billysilly@skype.com";
	        user.ProfileMission =
		        "I have done amazing work in the past and will continue to do some great work for any team that I'm apart of.";

            return View(user);
        }
    }
}