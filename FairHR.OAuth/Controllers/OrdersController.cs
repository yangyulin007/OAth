using FairHR.OAuth.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace FairHR.OAuth.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public List<Order> Get()
        {
            return Order.CreateOrders();
        }
    }
}