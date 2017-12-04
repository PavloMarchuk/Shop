using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.BOL.Models
{
	public class CartVM
	{		
		public Guid CartId { get; set; }

		[Required]
		[StringLength(128)]
		public string AspNetUserId { get; set; }

		public DateTime DateCreate { get; set; }

		public Guid? CartStatusId { get; set; }

		public Guid? DeliveryMethodId { get; set; }

		public string DeliveryDescription { get; set; }		
		/// ///////////////////////////	
		public string CartStatusName  { get; set; }

		public string DeliveryMethodName  { get; set; }

		[Column(TypeName = "money")]
		public decimal OrderTotalSum { get; set; }
	}
}
