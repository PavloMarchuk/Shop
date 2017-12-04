using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BOL.Models
{
	public class CartStatusVM
	{
		[Key]
		public Guid CartStatusId { get; set; }

		public string CartStatusName { get; set; }
	}
}
