namespace LogicServer.Controllers
{
    using System.Web.Http;
    using Interface;
    using Models.Dto;

    [Authorize]
    [RoutePrefix("api/Contract")]
    public class ContractController : ApiController
    {
        private IContractBll contractBll;
        public ContractController(IContractBll theContractBll)
        {
            contractBll = theContractBll;
        }

        /// <summary>
        /// 获取客户在职员工的合同信息
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <param name="current">当前页码</param>
        /// <returns></returns>
        [Route("GetContractInfo")]
        [HttpGet]
        public IHttpActionResult GetContractInfo(string customerid, int current)
        {
            return Json(contractBll.GetContractInfo(customerid, current));
        }

        /// <summary>
        /// 根据员工姓名和合同编号查询合同信息
        /// </summary>
        /// <param name="obj">客户id,当前页码，查询条件</param>
        /// <returns></returns>
        [Route("GetContractInfo")]
        [HttpPost]
        public IHttpActionResult GetContractInfo(CusConditions obj)
        {
            return Json(contractBll.GetContractInfo(obj.customerid, int.Parse(obj.current), obj.conditions));
        }

        /// <summary>
        /// 筛选员工合同
        /// </summary>
        /// <param name="model">mode（是否在职，签约类型，合同开始和结束时间）</param>
        /// <returns></returns>
        [Route("FindConstractInfo")]
        [HttpPost]
        public IHttpActionResult FindConstractInfo(ContractConditions model)
        {
            return Json(contractBll.FindConstractInfo(model));
        }

        /// <summary>
        /// 获取在职员工以及有效合同数量
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetContractNumber")]
        public IHttpActionResult GetContractNumber(string customerid)
        {
            return Json(contractBll.GetContractNumber(customerid));
        }
    }
}