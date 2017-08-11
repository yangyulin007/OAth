namespace LogicServer.Controllers
{
    using System.Web.Http;
    using Interface;
    using Models.Dto;

    [Authorize]
    [RoutePrefix("api/SocialSecurity")]
    public class SocialSecurityController : ApiController
    {
        private ISocialSecurityBll socialSecurityBll;
        public SocialSecurityController(ISocialSecurityBll theIsocialsecurityBll)
        {
            socialSecurityBll = theIsocialsecurityBll;
        }

        /// <summary>
        /// 根据客户id分页获取社保信息
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <param name="current">当前页码</param>
        /// <returns></returns>
        [Route("GetCusSocialSecurity")]
        [HttpGet]
        public IHttpActionResult GetCusSocialSecurity(string customerid, int current)
        {
            return Json(socialSecurityBll.GetCusSocialSecurity(customerid, current));
        }

        /// <summary>
        /// 按照姓名和身份证号码查询社保信息
        /// </summary>
        /// <param name="model">客户id(必填)，当前页码（必填），查询条件（可选）</param>
        /// <returns></returns>
        [Route("FindSocialSecurity")]
        [HttpPost]
        public IHttpActionResult FindSocialSecurity(CusConditions model)
        {
            return Json(socialSecurityBll.FindSocialSecurity(model.customerid, int.Parse(model.current), model.conditions));
        }
    }
}