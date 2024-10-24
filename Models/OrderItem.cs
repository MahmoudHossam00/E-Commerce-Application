namespace E_CommerceApp.Models
{
	public class OrderItem
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
		public int OrderId { get; set; }
		public Order Order { get; set; }
		public int Quantity { get; set; } //The Number of the items ordered
		public int PriceAtOrder { get; set; } //in case the price is changing 
		
	}
}