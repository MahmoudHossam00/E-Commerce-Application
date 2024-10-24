using System.ComponentModel.DataAnnotations;

namespace E_CommerceApp.Models
{
	public class Category
	{
		[MaxLength(100)]
		public int CategoryId { get; set; }
		public string Name { get; set; }
	}
}
