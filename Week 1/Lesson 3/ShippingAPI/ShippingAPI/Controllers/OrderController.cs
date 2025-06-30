using Microsoft.AspNetCore.Mvc;
using ShippingAPI.Models;
using System;

namespace ShippingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public ActionResult<ApiResponse<Order>> GetOrder(
            [FromQuery] string customerName,
            [FromQuery] string destinationCountry)
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                CustomerName = customerName,
                DestinationCountry = destinationCountry,
                Status = OrderStatusEnum.Processing
            };

            order.Ship();

            var response = new ApiResponse<Order>
            {
                Success = true,
                Data = order,
                Message = order.Status == OrderStatusEnum.Shipped
                    ? "Order shipped successfully"
                    : "Order is processing"
            };

            return Ok(response);
        }
    }
} 