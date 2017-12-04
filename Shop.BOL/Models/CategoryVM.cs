using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BOL.Models
{
	public class CategoryVM
	{
		public Guid CategoryId { get; set; }

		[Required]
		[StringLength(128)]
		public string CategoryName { get; set; }

		public Guid? ParentId { get; set; }

		public string ParentName { get; set; }		
	}
}
