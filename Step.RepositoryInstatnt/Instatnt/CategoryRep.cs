using System.Data.Entity;
using Shop.DAL.Entities;
using Step.Repository.Common;

namespace Step.RepositoryInstatnt.Instatnt
{
	public class CategoryRep : GenericRepository<Category>
	{
		public CategoryRep(DbContext context) : base(context)
		{ }
	}
}
