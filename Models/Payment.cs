namespace E_CommerceApp.Models
{
	public class Payment
	{
		public int PaymentId { get; set; }
		public int OrderId { get; set; }
		public Order order { get; set; }
		//public decimal Amount { get; set; }
		public ApplicationUser customer { get; set; }
		public int CustomerId { get; set; } 
		 
		public decimal AmountPaid { get; set; }
		//public Status Status { get; set; } = Status.Pending;

	}
}
