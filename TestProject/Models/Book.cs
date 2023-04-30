using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Models
{
	public class Book
	{
		[Key]
		[Required]
		public int Id { get; set; }
		public string BookName { get; set; }
		public string PublisherName { get; set; }
		public int PublisherAge { get; set; }
		public string PublishDate { get; set; }
		public BookType BookType { get; set; }
		public int BookTypeId { get; set; }
        public int PageNo { get; set; }

    }
}
