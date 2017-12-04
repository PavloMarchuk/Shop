using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BOL.Models
{
	public class ProductVM
	{
		public Guid ProductId { get; set; }

		[Required]
		public string ProductName { get; set; }

		public Guid CategoryId { get; set; }

		public string ProductDescription { get; set; }

		[Column(TypeName = "money")]
		public decimal Price { get; set; }

		public DateTime DateCreate { get; set; }

		[Column(TypeName = "numeric")]
		public decimal Stockpile { get; set; }

		//public virtual Category Category { get; set; }
		[Required]
		[StringLength(128)]
		public string CategoryName { get; set; }		
	}
}
