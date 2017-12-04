using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BOL.Models
{
	public class DeliveryMethodVM
	{
		[Key]
		public Guid DeliveryMethodId { get; set; }

		public string DeliveryMethodName { get; set; }
	}
}
