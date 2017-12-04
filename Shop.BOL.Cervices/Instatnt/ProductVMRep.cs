﻿using AutoMapper;
using Shop.BOL.Cervices.Common;
using Shop.BOL.Models;
using Shop.DAL.Entities;
using Step.RepositoryInstatnt.Instatnt;

namespace Shop.BOL.Cervices.Instatnt
{
	public class ProductVMRep : CommonDTOService<ProductVM, Product>
	{
		public ProductVMRep(ProductRep eRep) : base(eRep) { }

		protected override MapperConfiguration MapConfig()
	}
}