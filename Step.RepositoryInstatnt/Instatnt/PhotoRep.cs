using System.Data.Entity;
using Shop.DAL.Entities;
using Step.Repository.Common;

namespace Step.RepositoryInstatnt.Instatnt
{
	public class PhotoRep : GenericRepository<Photo>
	{
		public PhotoRep(DbContext context) : base(context)
		{ }
	}
}

