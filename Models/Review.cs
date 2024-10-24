using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceApp.Models
{
	public class Review
	{
		public int Id { get; set; }
		public string AuthorName { get; set; }
		[ForeignKey("AuthorName")]
		public ApplicationUser User { get; set; }
		public Product Product { get; set; }
		public int ProductId { get; set; }
		public string ReviewArticle {  get; set; }
		[Range(0, 5, ErrorMessage = "Value must be between 0 and 5.")]
		public byte Rate { get; set; }
	}
}
