namespace InvestmentPlataform.Server.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) :base(options) 
        {

        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CartItem>()
				.HasKey(ci => new { ci.UserId,ci.ProductId, ci.ProductTypeId });

			modelBuilder.Entity<ProductVariant>()
				.HasKey(p => new { p.ProductId, p.ProductTypeId });

			modelBuilder.Entity<OrderItem>()
				.HasKey(oi => new { oi.OrderId,oi.ProductId, oi.ProductTypeId });

			modelBuilder.Entity<ProductType>().HasData(
					new ProductType { Id = 1, Name = "Default"},
					new ProductType { Id = 2, Name = "tipo2" },
					new ProductType { Id = 3, Name = "típo3" }
				);
			

			modelBuilder.Entity<Category>().HasData(
				new Category
				{
					Id= 1,
					Name = "Grãos",
					Url = "Grãos"
				}, 
				new Category
				{
					Id = 2,
					Name = "Frutas",
					Url = "Frutas"
				},
				new Category
				{
					Id = 3,
					Name = "Massas",
					Url = "Massas"
				}
				);
			modelBuilder.Entity<Product>().HasData(

				new Product
				{
					Id = 1,
					Title = "teste11",
					Description = "desc1",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Eo_circle_red_number-1.svg/800px-Eo_circle_red_number-1.svg.png",
					CategoryId = 1,
					Featured = true
				},
				new Product
				{
					Id = 2,
					Title = "teste2",
					Description = "desc2",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/NYCS-bull-trans-2.svg/1200px-NYCS-bull-trans-2.svg.png",
					CategoryId = 2
				},
				new Product
				{
					Id = 3,
					Title = "teste3",
					Description = "desc3",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/NYCS-bull-trans-3.svg/1200px-NYCS-bull-trans-3.svg.png",
					CategoryId = 3
				}
			);
			modelBuilder.Entity<ProductVariant>().HasData(
				new ProductVariant
				{
					ProductId = 2,
					ProductTypeId = 2,
					Price = 9.22m,
					OriginalPrice = 19.22m

				},
				new ProductVariant
				{
					ProductId = 3,
					ProductTypeId = 3,
					Price = 9.33m,
					OriginalPrice = 19.33m

				},
				new ProductVariant
				{
					ProductId = 1,
					ProductTypeId = 1,
					Price = 9.11m,
					OriginalPrice = 19.11m

				}
			);

		}
		public DbSet<Product> Products { get; set;}
		public DbSet<Category> Categories { get; set;}
		public DbSet<ProductType> ProductTypes { get; set; }
		public DbSet<ProductVariant> ProductVariants { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }

	}
}
