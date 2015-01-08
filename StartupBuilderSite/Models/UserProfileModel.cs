using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartupBuilderSite.Models {
	public class UserProfileModel {
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Phone { get; set; }
		public string GChatHandle { get; set; }
		public string SkypeHanle { get; set; }
		public string ProfileMission { get; set; }
	}
}