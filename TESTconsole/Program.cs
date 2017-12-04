using Shop.BOL.Cervices.Instatnt;
using Shop.BOL.Models;
using Shop.DAL.Entities;
using Step.RepositoryInstatnt.Instatnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTconsole
{
	class Program
	{
		static void Main(string[] args)
		{
			ShopContext SC = new ShopContext();

			CategoryVMRep categoryRep = new CategoryVMRep(new CategoryRep(SC));
			ProductVMRep PR = new ProductVMRep(new ProductRep(SC));
			CategoryVM laptops = categoryRep.FindBy(c => c.CategoryName == "Laptop").FirstOrDefault();
			PhotoVMRep photoRep = new PhotoVMRep(new PhotoRep(SC));

			ProductVM ноут = PR.FindBy(n => n.ProductName.Contains("Ноутбук Dell")).FirstOrDefault();
			
			var ноутбукФОТОклекція = photoRep.FindBy(c => c.ProductId== ноут.ProductId);

			foreach (PhotoVM item in ноутбукФОТОклекція)
			{
				Console.WriteLine($"{ item.PhotoURL }");
			}
			


			//foreach (var item in categoryRep.GetAll())
			//{
			//	Console.WriteLine($"{item.CategoryId} {item.CategoryName, -32}  {item.ParentId}  {item.ParentName, - 15}");
			//}

			//ProductVM photoVoid = new ProductVM
			//{
			//	CategoryId = laptops.CategoryId,
			//	DateCreate = DateTime.Now,
			//	Price = 0,				
			//	ProductName = "photoVoid",
			//	Stockpile = 0

			//};

			//PR.AddOrUpdate(photoVoid);

			

			//PhotoVM foto = new PhotoVM
			//{
			//	PhotoURL = 
			//	@"F:\Projects\20. ASP.NET\28. КУРСОВА\Shop\TESTconsole\img\Blue.PNG",
			//	PrimePhoto = true,
			//	ProductId = photoVoid.ProductId
			//};

			//photoRep.AddOrUpdate(foto);



		}
	}
}
//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]