using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BOL.Models
{
	public class PhotoVM
	{
		public Guid PhotoId { get; set; }

		[Required]
		public string PhotoURL { get; set; }

		public Guid ProductId { get; set; }

		public bool? PrimePhoto { get; set; }
	}
}
