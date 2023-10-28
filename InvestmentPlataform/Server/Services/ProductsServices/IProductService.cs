namespace InvestmentPlataform.Server.Services.ProductsServices
{
	public interface IProductService
	{
		Task<ServiceResponse<List<Product>>> GetProductsAsync();
		Task<ServiceResponse<Product>> GetProductAsync(int productId);
	}
}
