using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartupBuilderSite.Models {
	public class BusinessListingModel {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Summary { get; set; }
		public int OwnerId { get; set; }
		public List<SkillItemModel> Skills { get; set; } 
	}
}