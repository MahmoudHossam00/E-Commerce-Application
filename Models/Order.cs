using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceApp.Models
{
	public class Order
	{
		public int OrderId { get; set; }
		public int CustomerId { get; set; }
		[ForeignKey("CustomerId")]
		public ApplicationUser Customer { get; set; }
		public List<OrderItem> OrderItems { get; set; }

		public Status OrderStatus { get; set; } = Status.Pending;
		public DateTime OrderDate { get; set; }
		public decimal TotalOrderPrice { get; set; }
		public int DiscountPercent { get; set; } = 0;
	}
}
