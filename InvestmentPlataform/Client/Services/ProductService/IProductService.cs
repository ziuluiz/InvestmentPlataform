using InvestmentPlataform.Shared;
using System.Threading.Tasks;

namespace InvestmentPlataform.Client.Services.ProductService
{
	public interface IProductService
	{
		List<Product> Products { get; set; }
		Task GetProducts();
		Task<ServiceResponse<Product>> GetProduct(int productId);
	}
}
