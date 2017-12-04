namespace Shop.DAL.Entities
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class ShopContext : DbContext
	{
		public ShopContext()
			: base("name=ShopContext")
		{
		}

		public virtual DbSet<Cart> Carts { get; set; }
		public virtual DbSet<CartStatu> CartStatus { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<DeliveryMethod> DeliveryMethods { get; set; }
		public virtual DbSet<OrderPos> OrderPos { get; set; }
		public virtual DbSet<Photo> Photos { get; set; }
		public virtual DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cart>()
				.HasMany(e => e.OrderPos)
				.WithRequired(e => e.Cart)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Category>()
				.HasMany(e => e.Category1)
				.WithOptional(e => e.Category2)
				.HasForeignKey(e => e.ParentId);

			modelBuilder.Entity<Category>()
				.HasMany(e => e.Products)
				.WithRequired(e => e.Category)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<OrderPos>()
				.Property(e => e.ProductCount)
				.HasPrecision(18, 4);

			modelBuilder.Entity<Product>()
				.Property(e => e.Price)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Product>()
				.Property(e => e.Stockpile)
				.HasPrecision(18, 4);

			modelBuilder.Entity<Product>()
				.HasMany(e => e.OrderPos)
				.WithRequired(e => e.Product)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Product>()
				.HasMany(e => e.Photos)
				.WithRequired(e => e.Product)
				.WillCascadeOnDelete(false);
		}
	}
}
