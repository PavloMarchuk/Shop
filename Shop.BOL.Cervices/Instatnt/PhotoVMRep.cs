using Shop.BOL.Cervices.Common;
using Shop.BOL.Models;
using Shop.DAL.Entities;
using Step.RepositoryInstatnt.Instatnt;

namespace Shop.BOL.Cervices.Instatnt
{
	public class PhotoVMRep : CommonDTOService<PhotoVM, Photo>
	{
		public PhotoVMRep(PhotoRep eRep) : base(eRep) { }
	}
}
