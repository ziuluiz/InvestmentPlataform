namespace InvestmentPlataform.Server.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) :base(options) 
        {

        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(

				new Product
				{
					Id = 1,
					Title = "teste11",
					Description = "desc1",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Eo_circle_red_number-1.svg/800px-Eo_circle_red_number-1.svg.png",
					Price = 9.11m
				},
				new Product
				{
					Id = 2,
					Title = "teste2",
					Description = "desc2",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/NYCS-bull-trans-2.svg/1200px-NYCS-bull-trans-2.svg.png",
					Price = 9.22m
				},
				new Product
				{
					Id = 3,
					Title = "teste3",
					Description = "desc3",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/NYCS-bull-trans-3.svg/1200px-NYCS-bull-trans-3.svg.png",
					Price = 9.33m
				}
			);
		}
		public DbSet<Product> Products { get; set;}
    }
}
