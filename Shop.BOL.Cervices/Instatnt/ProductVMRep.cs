using AutoMapper;
using Shop.BOL.Cervices.Common;
using Shop.BOL.Models;
using Shop.DAL.Entities;
using Step.RepositoryInstatnt.Instatnt;

namespace Shop.BOL.Cervices.Instatnt
{
	public class ProductVMRep : CommonDTOService<ProductVM, Product>
	{
		public ProductVMRep(ProductRep eRep) : base(eRep) { }

		protected override MapperConfiguration MapConfig()		{			MapperConfiguration config = new MapperConfiguration(cfg =>			{				cfg.CreateMap<ProductVM, Product>();				cfg.CreateMap<Product, ProductVM>()				.ForMember("CategoryName", opt => opt.MapFrom(ef => ef.Category.CategoryName));			});			return config;		}
	}
}
