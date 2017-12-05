using Shop.BOL.Cervices.Common;
using Shop.BOL.Models;
using Shop.DAL.Entities;
using Step.Repository.Common;
using Step.RepositoryInstatnt.Instatnt;

namespace Shop.BOL.Cervices.Instatnt
{
	public class DeliveryMethodVMService : CommonDTOService<DeliveryMethodVM, DeliveryMethod>
	{	
			public DeliveryMethodVMService(IGenericRepository<DeliveryMethod> eRep) : base(eRep) { }		
	}
}
