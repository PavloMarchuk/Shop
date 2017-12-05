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
			builder.RegisterType(typeof(CartStatusVMService)).As(typeof(IDTOService<CartStatusVM>)).InstancePerRequest();
			builder.RegisterType(typeof(CartVMService)).As(typeof(IDTOService<CartVM>)).InstancePerRequest();
			builder.RegisterType(typeof(CategoryVMService)).As(typeof(IDTOService<CategoryVM>)).InstancePerRequest();
			builder.RegisterType(typeof(DeliveryMethodVMService)).As(typeof(IDTOService<DeliveryMethodVM>)).InstancePerRequest();
			builder.RegisterType(typeof(OrderPosVMService)).As(typeof(IDTOService<OrderPosVM>)).InstancePerRequest();
			builder.RegisterType(typeof(PhotoVMService)).As(typeof(IDTOService<PhotoVM>)).InstancePerRequest();
			builder.RegisterType(typeof(ProductVMService)).As(typeof(IDTOService<ProductVM>)).InstancePerRequest();

			base.Load(builder);

			//ProductVMService xxxx = new ProductVMService(new ProductRep(new ShopContext()));
		}
	}
}

//////////////builder.RegisterType(typeof(StreetRepository)).As(typeof(IGenericRepository<Street>)).InstancePerRequest();
