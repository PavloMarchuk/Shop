using System.Data.Entity;
using Shop.DAL.Entities;
using Step.Repository.Common;

namespace Step.RepositoryInstatnt.Instatnt
{
	public class ProductRep : GenericRepository<Product>
	{
		public ProductRep(DbContext context) : base(context)
		{ }
	}
}
