using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using Autofac;
using System.Data.Entity;

using Shop.DAL.Entities;
using Step.Repository.Common;
using Step.RepositoryInstatnt.Instatnt;

using Shop.BOL.Models;
using Shop.BOL.Cervices.Common;
using Shop.BOL.Cervices.Instatnt;


namespace Shop.WUI.Modules
{
	public class AdderessAutofacModule :Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType(typeof(ShopContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
			//////////
			builder.RegisterType(typeof(CartRep)).As(typeof(IGenericRepository<Cart>)).InstancePerRequest();
			builder.RegisterType(typeof(CartStatusRep)).As(typeof(IGenericRepository<CartStatu>)).InstancePerRequest();
			builder.RegisterType(typeof(CategoryRep)).As(typeof(IGenericRepository<Category>)).InstancePerRequest();
			builder.RegisterType(typeof(DeliveryMethodRep)).As(typeof(IGenericRepository<DeliveryMethod>)).InstancePerRequest();
			builder.RegisterType(typeof(OrderPosRep)).As(typeof(IGenericRepository<OrderPos>)).InstancePerRequest();
			builder.RegisterType(typeof(PhotoRep)).As(typeof(IGenericRepository<Photo>)).InstancePerRequest();
			builder.RegisterType(typeof(ProductRep)).As(typeof(IGenericRepository<Product>)).InstancePerRequest();
			/////////////////////
			builder.RegisterType(typeof(CartStatusVMRep)).As(typeof(IDTOService<CartStatu>)).InstancePerRequest();
			builder.RegisterType(typeof(CartVMRep)).As(typeof(IDTOService<Cart>)).InstancePerRequest();
			builder.RegisterType(typeof(CategoryVMRep)).As(typeof(IDTOService<Category>)).InstancePerRequest();
			builder.RegisterType(typeof(DeliveryMethodVMRep)).As(typeof(IDTOService<DeliveryMethod>)).InstancePerRequest();
			builder.RegisterType(typeof(OrderPosVMRep)).As(typeof(IDTOService<OrderPos>)).InstancePerRequest();
			builder.RegisterType(typeof(PhotoVMRep)).As(typeof(IDTOService<Photo>)).InstancePerRequest();
			builder.RegisterType(typeof(ProductVMRep)).As(typeof(IDTOService<Product>)).InstancePerRequest();
		}
	}
}




