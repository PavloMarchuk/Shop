using Shop.BOL.Cervices.Common;
using Shop.BOL.Models;
using Shop.DAL.Entities;
using Step.RepositoryInstatnt.Instatnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BOL.Cervices.Instatnt
{
	public class CartStatusVMRep : CommonDTOService<CartStatusVM, CartStatu>
	{
		public CartStatusVMRep(CartStatusRep eRep) : base(eRep) { }

	}
}

