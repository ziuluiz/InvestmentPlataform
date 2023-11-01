namespace InvestmentPlataform.Server.Services.OrderServices
{
	public interface IOrderService
	{
		Task<ServiceResponse<bool>> PlaceOrder();
		Task<ServiceResponse<List<OrderOverviewResponse>>> GetOrders();
		Task<ServiceResponse<OrderDetailsResponse>> GetOrderDetails(int orderId);
	}
}
