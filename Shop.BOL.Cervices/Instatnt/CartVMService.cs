using AutoMapper;
using Shop.BOL.Cervices.Common;
using Shop.BOL.Models;
using Shop.DAL.Entities;
using Step.RepositoryInstatnt.Instatnt;
using System.Linq;

namespace Shop.BOL.Cervices.Instatnt
{
	public class CartVMService : CommonDTOService<CartVM, Cart>
	{
		public CartVMService(Step.Repository.Common.IGenericRepository<Cart> eRep) : base(eRep) { }

		protected override MapperConfiguration MapConfig()
		{
			MapperConfiguration config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<CartVM, Cart>();
				cfg.CreateMap<Cart, CartVM>()
				.ForMember("CartStatusName", opt => opt.MapFrom(ef => ef.CartStatu.CartStatusName))
				.ForMember("DeliveryMethodName", opt => opt.MapFrom(ef => ef.DeliveryMethod.DeliveryMethodName))
				.ForMember("OrderTotalSum", opt => opt.MapFrom(ef => ef.OrderPos.Select(p=>p.Product.Price * p.ProductCount)))
				;
			});
			return config;
		}
	}
}


//public string CartStatusName { get; set; }

//public string DeliveryMethodName { get; set; }

//[Column(TypeName = "money")]
//public decimal OrderTotalSum { get; set; }