using Shop.BOL.Cervices.Common;
using Shop.BOL.Models;
using Shop.DAL.Entities;
using Step.Repository.Common;
using Step.RepositoryInstatnt.Instatnt;

namespace Shop.BOL.Cervices.Instatnt
{
	public class PhotoVMService : CommonDTOService<PhotoVM, Photo>
	{
		public PhotoVMService(IGenericRepository<Photo> eRep) : base(eRep) { }
	}
}
