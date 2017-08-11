namespace LogicServer.Controllers
{
    using System.Web.Http;
    using Interface;

    [Authorize]
    [RoutePrefix("api/Customer")]
    public class CustomerController : ApiController
    {
       private ICustomerBll customerBll;
       public CustomerController(ICustomerBll theCustomerBll)
        {
            customerBll = theCustomerBll;
        }

        /// <summary>
        ///  获取当前登陆客户服务数据
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
       [Route("GetCustomerNumber")]
       [HttpGet]
       public IHttpActionResult GetCustomerNumber(string customerid)
        {
            return Json(customerBll.GetCustomerInfoNumber(customerid));
        }

        /// <summary>
        /// 企业全称，合作产品及有效服务合同
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
       [Route("GetContractInfo")]
       [HttpGet]
       public IHttpActionResult GetContractInfo(string customerid)
        {
            return Json(customerBll.GetContractInfo(customerid));
        }

        /// <summary>
        /// 获取客户名称包括该客户的子公司，子部门
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
       [Route("GetCustomerName")]
       [HttpGet]
       public IHttpActionResult GetCustomerName(string customerid)
        {
            return Json(customerBll.GetCustomerName(customerid));
        }

        /// <summary>
        /// 获取客户的在职员工，以及不同员工类型数量
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
       [HttpGet]
       [Route("GetCusEmployee")]
       public IHttpActionResult GetCusEmployee(string customerid)
        {
            return Json(customerBll.GetCusEmployee(customerid));
        }
    }
}