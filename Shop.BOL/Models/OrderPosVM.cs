using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.BOL.Models
{
	public class OrderPosVM
	{
		public Guid OrderPosId { get; set; }

		public Guid CartId { get; set; }

		public Guid ProductId { get; set; }

		[Column(TypeName = "numeric")]
		public decimal ProductCount { get; set; }
		
		[Required]
		public string ProductName { get; set; }

		[Column(TypeName = "money")]
		public decimal Price { get; set; }

		[Column(TypeName = "money")]
		public decimal LineSum { get; set; }
	}
}
