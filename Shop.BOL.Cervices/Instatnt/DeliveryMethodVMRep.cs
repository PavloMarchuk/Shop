using Shop.BOL.Cervices.Common;
using Shop.BOL.Models;
using Shop.DAL.Entities;
using Step.RepositoryInstatnt.Instatnt;

namespace Shop.BOL.Cervices.Instatnt
{
	public class DeliveryMethodVMRep : CommonDTOService<DeliveryMethodVM, DeliveryMethod>
	{	
			public DeliveryMethodVMRep(DeliveryMethodRep eRep) : base(eRep) { }		
	}
}
