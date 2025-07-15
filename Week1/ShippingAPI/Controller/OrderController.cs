using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShippingAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public ActionResult<BaseAPIRespone<Order>> GetOrder(
            [FromQuery] string customerName,
            [FromQuery] string destinationCountry)
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                CustomerName = customerName,
                DestinationCountry = destinationCountry,
                Status = EOrderStatus.Processing
            };

            order.Ship();

            var response = new BaseAPIRespone<Order>
            {
                Success = true,
                Data = order,
                Message = order.Status == EOrderStatus.Shipped
                    ? "Shipped"
                    : "Processing"
            };

            return Ok(response);

        }
    }
}
