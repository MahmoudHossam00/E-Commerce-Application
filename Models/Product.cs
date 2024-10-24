using System.ComponentModel.DataAnnotations;

namespace E_CommerceApp.Models
{
	public class Product
	{
		public int ProductId { get; set; }
		[MaxLength(200)]
		public string Name { get; set; }
		[MaxLength(400)]
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public decimal Price { get; set; } //Price per each

		public byte[]? ProductPhoto { get; set; }
		public int Quantity { get; set; } //The remaining in stock
		public bool IsDeleted { get; set; }
		public Seller Seller { get; set; }
		public int SellerId { get; set; }

		public List<Review> Reviews { get; set; } = new List<Review>();
		public int AverageRate { get; set; } = 0;
		public int RatingCount { get; set; } = 0;
		
	}
}
