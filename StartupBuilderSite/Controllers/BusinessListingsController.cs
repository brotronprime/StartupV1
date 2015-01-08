using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StartupBuilderSite.Models;

namespace StartupBuilderSite.Controllers
{
    public class BusinessListingsController : Controller
    {
        // GET: BusinessListings
        public ActionResult Listings()
        {
			List<BusinessListingModel> listings = new List<BusinessListingModel>();
			listings.Add(new BusinessListingModel(){
				Id = 1,
				Name = "Trashcan Basketball Hoops",
				OwnerId = 2201,
				Summary = "This is the best business idea EVER!",
				Skills = new List<SkillItemModel>(){
					new SkillItemModel() { SkillName = "Sales", SkillIsFilled = true },
					new SkillItemModel() { SkillName = "Web Developer", SkillIsFilled = false },
					new SkillItemModel() { SkillName = "Database Developer", SkillIsFilled = true }
				}
			});

			listings.Add(new BusinessListingModel() {
				Id = 2,
				Name = "Shoe Keyless Entry for Cars",
				OwnerId = 1802,
				Summary = "Second best business idea EVER!",
				Skills = new List<SkillItemModel>(){
					new SkillItemModel() { SkillName = "Web Developer", SkillIsFilled = true },
					new SkillItemModel() { SkillName = "Web Developer", SkillIsFilled = true},
					new SkillItemModel() { SkillName = "Modile Developer", SkillIsFilled = false }
				}
			});

			listings.Add(new BusinessListingModel() {
				Id = 3,
				Name = "Healthcare Technology",
				OwnerId = 9807,
				Summary = "This is a sensitive business dealing with healthcare.  If you have experience please inquire.",
				Skills = new List<SkillItemModel>(){
					new SkillItemModel() { SkillName = "Sales", SkillIsFilled = false },
					new SkillItemModel() { SkillName = "Web Developer", SkillIsFilled = false},
					new SkillItemModel() { SkillName = "Database Developer", SkillIsFilled = false },
					new SkillItemModel() { SkillName = "Accountant", SkillIsFilled = false }
				}
			});

			return View(listings);
        }
    }

}