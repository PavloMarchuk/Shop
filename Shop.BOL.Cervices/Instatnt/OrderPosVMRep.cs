using AutoMapper;
using Shop.BOL.Cervices.Common;
using Shop.BOL.Models;
using Shop.DAL.Entities;
using Step.RepositoryInstatnt.Instatnt;

namespace Shop.BOL.Cervices.Instatnt
{
	public class OrderPosVMRep : CommonDTOService<OrderPosVM, OrderPos>
	{
		public OrderPosVMRep(OrderPosRep eRep) : base(eRep) { }

		protected override MapperConfiguration MapConfig()
		{
			MapperConfiguration config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<OrderPosVM, OrderPos>();
				cfg.CreateMap<OrderPos, OrderPosVM>()
				.ForMember("ProductName", opt => opt.MapFrom(ef => ef.Product.ProductName))
				.ForMember("LineSum", opt => opt.MapFrom(ef => ef.Product.Price* ef.ProductCount))
				;
			});
			return config;
		}
	}
}

