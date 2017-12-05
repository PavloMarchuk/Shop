﻿using AutoMapper;
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

		protected override MapperConfiguration MapConfig()
	}
}
//Shop.BOL.Cervices.Instatnt.ProductVMRep