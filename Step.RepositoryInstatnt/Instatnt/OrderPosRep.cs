using System.Data.Entity;
using Shop.DAL.Entities;
using Step.Repository.Common;

namespace Step.RepositoryInstatnt.Instatnt
{
	public class OrderPosRep : GenericRepository<OrderPos>
	{
		public OrderPosRep(DbContext context) : base(context)
		{ }
	}
}
