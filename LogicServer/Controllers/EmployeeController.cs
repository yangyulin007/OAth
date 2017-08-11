namespace LogicServer.Controllers
{
    using System.Web.Http;
    using Interface;
    using Models.Dto;

    [Authorize]
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        private IEmployeeBll employeeBll;
        public EmployeeController(IEmployeeBll theEmployeeBll)
        {
            employeeBll = theEmployeeBll;
        }

        /// <summary>
        /// 查询在职员工
        /// </summary>
        /// <param name="customerId">客户id</param>
        /// <param name="current">当前页码</param>
        /// <returns></returns>
        [Route("GetEmployeeByCustomerId")]
        [HttpGet]
        public IHttpActionResult GetEmployeeByCustomerId(string customerId, string current)
        {
            return Json(employeeBll.GetEnployeeList(customerId, current));
        }

        /// <summary>
        ///  筛选员工
        /// </summary>
        /// <param name="model">客户id和current是必填选项</param>
        /// <returns></returns>
        [Route("GetEnployeeList")]
        [HttpPost]
        public IHttpActionResult GetEnployeeList(EmployeeConditions model)
        {
            return Json(employeeBll.GetEnployeeList(model));
        }

        /// <summary>
        /// 查询员工（姓名，证件号，电话）
        /// </summary>
        /// <param name="obj">包括客户id（必须），查询条件（必须），当前页码（默认是1）</param>
        /// <returns></returns>
        [HttpPost]
        [Route("SelectEmployee")]
        public IHttpActionResult SelectEmployee(CusConditions obj)
        {
            return Json(employeeBll.SelectEmployee(obj.customerid, obj.conditions, obj.current));
        }

        /// <summary>
        ///  获取员工在职信息，个人信息，公积金社保信息
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <param name="employeeid">员工id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetEmployeeInfo")]
        public IHttpActionResult GetEmployeeInfo(string customerid, string employeeid)
        {
            return Json(employeeBll.GetEmployeeInfo(customerid, employeeid));
        }

        /// <summary>
        ///  根据员工id获取员工合同信息
        /// </summary>
        /// <param name="employeeid">员工id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetEmConstractInfo")]
        public IHttpActionResult GetEmConstractInfo(string employeeid)
        {
            return Json(employeeBll.GetEmConstractInfo(employeeid));
        }

        /// <summary>
        /// 根据员工id获取该员工最近三个月的工资详情
        /// </summary>
        /// <param name="employeeid">员工id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetEmpSalaryIofo")]
        public IHttpActionResult GetEmpSalaryIofo(string employeeid)
        {
            return Json(employeeBll.GetEmpSalaryIofo(employeeid));
        }
    }
}