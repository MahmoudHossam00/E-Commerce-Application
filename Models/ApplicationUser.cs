using E_CommerceApp.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Models
{
	public class ApplicationUser : IdentityUser
	{
		[MaxLength(100)]
		public string FirstName { get; set; }
		[MaxLength(100)]
		public string LastName { get; set; }
		public string Address { get; set; }
		public bool IsDeleted { get; set; }

		public List<Product> Cart { get; set; } = new List<Product>();
		public List<Order> UserOrders { get; set; } = new List<Order>();
		[CreditCard]
		public List<string> CreditCards { get; set; } = new List<string>();

		public List<Review> UserReviews { get; set; } = new List<Review>();

		public bool IsSeller { get; set; }

	}
}
