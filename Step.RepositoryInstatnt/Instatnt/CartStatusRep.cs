using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Shop.DAL.Entities;
using Step.Repository.Common;

namespace Step.RepositoryInstatnt.Instatnt
{
	public class CartStatusRep : GenericRepository<CartStatu>
	{
		public CartStatusRep(DbContext context) :base(context)
		{ }
	}
}
