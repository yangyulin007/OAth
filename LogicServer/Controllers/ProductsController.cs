namespace LogicServer.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Web.Http;
    using Interface;
    using Models;

    /// <summary>
    /// Use the controller to visit product related resources.
    /// </summary>
    [Authorize]
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        private IProductBusinessHandler productBusinessHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsController"/> class.
        /// </summary>
        /// <param name="theBusinessHandler">Instance of interface IProductBusinessHandler.</param>
        public ProductsController(IProductBusinessHandler theBusinessHandler)
        {
            productBusinessHandler = theBusinessHandler;
        }

        /// <summary>
        /// Get all products.
        /// </summary>
        /// <returns>Collection of products.</returns>
        [Route("")]
        public IEnumerable<Product> GetAllProducts()
        {
            return productBusinessHandler.GetProducts();
        }

        /// <summary>
        /// Get the api to get proudct by its id.
        /// </summary>
        /// <param name="id">Product Id.</param>
        /// <param name="name">Product name.</param>
        /// <returns>The instance of IHttpActionResult which contains requested product.</returns>
        [Route("{id}")]
        public IHttpActionResult GetProduct(int id, string name)
        {
            var result = productBusinessHandler.GetProduct(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        /// <summary>
        /// Receive add new product request.
        /// </summary>
        /// <param name="newProduct">New product.</param>
        [Route("")]
        [HttpPost]
        public void AddNewProduct(Product newProduct)
        {
            productBusinessHandler.AddProduct(newProduct);
        }

        /// <summary>
        /// Call the api to get cached message.
        /// </summary>
        /// <returns>Instance of HttpResponseMessage which contains cached data.</returns>
        [Route("cached")]
        public HttpResponseMessage GetCachedMessage()
        {
            var responseMessage = Request.CreateResponse(HttpStatusCode.OK, "This message is not from cache."); // Set response message content which is defaultyly be xml.
            responseMessage.Content = new StringContent("Hello, I will replace the response content.", Encoding.Unicode);   // Set response message content as plain text.
            responseMessage.Headers.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue()
            {
                MaxAge = TimeSpan.FromMinutes(2),    // The client will cache the response in 2 minutes.
            };

            return responseMessage;
        }
    }
}