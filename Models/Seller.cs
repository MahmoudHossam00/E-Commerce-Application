using BlogProject.Models;

namespace E_CommerceApp.Models
{
	public class Seller 
	{
		public int UserId { get; set; }
		public ApplicationUser User { get; set; }
		public List<Product> ForSale { get; set; } = new List<Product>();

	}
}
