using AutoMapper;
using Shop.BOL.Cervices.Common;
using Shop.BOL.Models;
using Shop.DAL.Entities;
using Step.Repository.Common;
using Step.RepositoryInstatnt.Instatnt;

namespace Shop.BOL.Cervices.Instatnt
{
	public class ProductVMService : CommonDTOService<ProductVM, Product>
	{
		public ProductVMService(IGenericRepository<Product> pRep) : base(pRep) { }

		protected override MapperConfiguration MapConfig()		{			MapperConfiguration config = new MapperConfiguration(cfg =>			{				cfg.CreateMap<ProductVM, Product>();				cfg.CreateMap<Product, ProductVM>()				.ForMember("CategoryName", opt => opt.MapFrom(ef => ef.Category.CategoryName));			});			return config;		}
	}
}
//Shop.BOL.Cervices.Instatnt.ProductVMRep