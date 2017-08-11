namespace LogicServer.BLL
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using Interface;
    using Models;
    using Models.Dto;

    /// <summary>
    /// EmployeeBll
    /// </summary>
    public class EmployeeBll : IEmployeeBll
    {
        private IEmployeeDal employeedal;
        private ICustomerBll customerBll;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBll"/> class.
        /// 构造函数
        /// </summary>
        /// <param name="theEmployeedal">员工dal</param>
        /// <param name="theCustomerDal">客户dal</param>
        public EmployeeBll(IEmployeeDal theEmployeedal, ICustomerBll theCustomerDal)
        {
            employeedal = theEmployeedal;
            customerBll = theCustomerDal;
        }

        /// <summary>
        ///  查询在职员工
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <param name="current">当前页码默认第一页</param>
        /// <returns></returns>
        public List<ReturnDataEmployee> GetEnployeeList(string customerid, string current)
        {
            DataTable dt = employeedal.GetEnployeeList(customerid, current);
            List<ReturnDataEmployee> list = new List<ReturnDataEmployee>();
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ReturnDataEmployee emp = new ReturnDataEmployee();
                    emp.employeeId = dt.Rows[i][0].ToString();
                    emp.realName = dt.Rows[i][1].ToString();
                    emp.sex = dt.Rows[i][2].ToString();
                    emp.age = dt.Rows[i][3].ToString();
                    emp.idNumber = dt.Rows[i][4].ToString();
                    emp.mobilephone = dt.Rows[i][5].ToString();
                    emp.customerName = dt.Rows[i][6].ToString();
                    emp.post = dt.Rows[i][7].ToString();
                    emp.emppersonnelpro = dt.Rows[i][8].ToString();
                    emp.state = dt.Rows[i][9].ToString();
                    emp.employeeType = dt.Rows[i][10].ToString();
                    emp.stratTime = dt.Rows[i][11].ToString();
                    emp.leaveTime = dt.Rows[i][12].ToString();
                    emp.customerId = dt.Rows[i][13].ToString();
                    emp.rn = dt.Rows[i][14].ToString();
                    emp.totalCount = Math.Ceiling(int.Parse(dt.Rows[i][15].ToString()) * 1.0 / pageSize).ToString();
                    list.Add(emp);
                }
            }

            return list;
        }

        /// <summary>
        /// 筛选员工信息
        /// </summary>
        /// <param name="model">员工model</param>
        /// <returns></returns>
        public List<ReturnDataEmployee> GetEnployeeList(EmployeeConditions model)
        {
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            DataTable dt = employeedal.GetEnployeeList(model);
            List<ReturnDataEmployee> list = new List<ReturnDataEmployee>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ReturnDataEmployee emp = new ReturnDataEmployee();
                    emp.employeeId = dt.Rows[i][0].ToString();
                    emp.realName = dt.Rows[i][1].ToString();
                    emp.sex = dt.Rows[i][2].ToString();
                    emp.age = dt.Rows[i][3].ToString();
                    emp.idNumber = dt.Rows[i][4].ToString();
                    emp.mobilephone = dt.Rows[i][5].ToString();
                    emp.customerName = dt.Rows[i][6].ToString();
                    emp.post = dt.Rows[i][7].ToString();
                    emp.emppersonnelpro = dt.Rows[i][8].ToString();
                    emp.state = dt.Rows[i][9].ToString();
                    emp.employeeType = dt.Rows[i][10].ToString();
                    emp.stratTime = dt.Rows[i][11].ToString();
                    emp.leaveTime = dt.Rows[i][12].ToString();
                    emp.customerId = dt.Rows[i][13].ToString();
                    emp.rn = dt.Rows[i][14].ToString();
                    emp.totalCount = Math.Ceiling(int.Parse(dt.Rows[i][15].ToString()) * 1.0 / pageSize).ToString();
                    list.Add(emp);
                }
            }

            return list;
        }

        /// <summary>
        /// 查询员工
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <param name="selectWhere">查询条件</param>
        /// <param name="current">当前页码默认第一页</param>
        /// <returns></returns>
        public List<ReturnDataEmployee> SelectEmployee(string customerid, string selectWhere, string current)
        {
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            DataTable dt = employeedal.SelecteEmployee(customerid, selectWhere, current);
            List<ReturnDataEmployee> list = new List<ReturnDataEmployee>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ReturnDataEmployee emp = new ReturnDataEmployee();
                    emp.employeeId = dt.Rows[i][0].ToString();
                    emp.realName = dt.Rows[i][1].ToString();
                    emp.sex = dt.Rows[i][2].ToString();
                    emp.age = dt.Rows[i][3].ToString();
                    emp.idNumber = dt.Rows[i][4].ToString();
                    emp.mobilephone = dt.Rows[i][5].ToString();
                    emp.customerName = dt.Rows[i][6].ToString();
                    emp.post = dt.Rows[i][7].ToString();
                    emp.emppersonnelpro = dt.Rows[i][8].ToString();
                    emp.state = dt.Rows[i][9].ToString();
                    emp.employeeType = dt.Rows[i][10].ToString();
                    emp.stratTime = dt.Rows[i][11].ToString();
                    emp.leaveTime = dt.Rows[i][12].ToString();
                    emp.customerId = dt.Rows[i][13].ToString();
                    emp.rn = dt.Rows[i][14].ToString();
                    emp.totalCount = Math.Ceiling(int.Parse(dt.Rows[i][15].ToString()) * 1.0 / pageSize).ToString();
                    list.Add(emp);
                }
            }

            return list;
        }

        /// <summary>
        ///  获取员工在职信息，个人信息，公积金社保信息
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <param name="employeeid">员工id</param>
        /// <returns></returns>
        public EmployeeInfo GetEmployeeInfo(string customerid, string employeeid)
        {
            DataTable dt = employeedal.GetEmployeeInfo(customerid, employeeid);
            EmployeeInfo result = new EmployeeInfo();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    result.employeeId = dt.Rows[i][0].ToString();
                    result.realName = dt.Rows[i][1].ToString();
                    result.sex = dt.Rows[i][2].ToString();
                    result.age = dt.Rows[i][3].ToString();
                    result.idNumber = dt.Rows[i][4].ToString();
                    result.mobilephone = dt.Rows[i][5].ToString();
                    result.nation = dt.Rows[i][6].ToString();
                    result.politicsstatus = dt.Rows[i][7].ToString();
                    result.nativeplace = dt.Rows[i][8].ToString();
                    result.householdtype = dt.Rows[i][9].ToString();
                    result.CULTUREDEEP = dt.Rows[i][10].ToString();
                    result.DOMICILEPLACE = dt.Rows[i][11].ToString();
                    result.MARITALSTATUS = dt.Rows[i][12].ToString();
                    result.BEARSTATUS = dt.Rows[i][13].ToString();
                    result.EMAIL = dt.Rows[i][14].ToString();
                    result.LIVEADDRESS = dt.Rows[i][15].ToString();
                    result.OPENINGBANK = dt.Rows[i][16].ToString();
                    result.banlaccount = dt.Rows[i][17].ToString();
                    result.cityname = dt.Rows[i][18].ToString();
                    result.SSCARD = dt.Rows[i][19].ToString();
                    result.SSCOMPUTENO = dt.Rows[i][20].ToString();
                    result.SSFEES = dt.Rows[i][21].ToString();
                    result.SSYEAR = dt.Rows[i][22].ToString();
                    result.ACCUMULATIONE = dt.Rows[i][23].ToString();
                    result.GONGJIJINFEE = dt.Rows[i][24].ToString();
                    result.PERSONRATE = dt.Rows[i][25].ToString();
                    result.COPANYRATE = dt.Rows[i][26].ToString();
                    result.GJYEAR = dt.Rows[i][27].ToString();
                    result.customername = dt.Rows[i][28].ToString();
                    result.post = dt.Rows[i][29].ToString();
                    result.workingplace = dt.Rows[i][30].ToString();
                    result.EMPPERSONNELPRO = dt.Rows[i][31].ToString();
                    result.state = dt.Rows[i][32].ToString();
                    result.EMPLOYEETYPE = dt.Rows[i][33].ToString();
                    result.servicetime = dt.Rows[i][34].ToString();
                    result.repWordDateNum = dt.Rows[i][35].ToString();
                    result.customerId = dt.Rows[i][36].ToString();
                    result.idtype = dt.Rows[i][37].ToString();
                    result.bankPovice = dt.Rows[i][38].ToString();
                    result.bankcity = dt.Rows[i][39].ToString();
                    result.bankname = dt.Rows[i][40].ToString();
                    result.openbankPovice = dt.Rows[i][41].ToString();
                    result.bankcarid = dt.Rows[i][42].ToString();
                    result.accountname = dt.Rows[i][43].ToString();
                    result.bankcardtype = dt.Rows[i][44].ToString();
                    result.isotherman = dt.Rows[i][45].ToString();
                    result.project = dt.Rows[i][46].ToString();
                    result.project = dt.Rows[i][47].ToString();
                }
            }

            return result;
        }

        /// <summary>
        /// 根据员工id获取合同信息
        /// </summary>
        /// <param name="employeeid">员工id</param>
        /// <returns></returns>
        public List<EmConstract> GetEmConstractInfo(string employeeid)
        {
            DataTable dt = employeedal.GetEmConstractInfo(employeeid);
            List<EmConstract> list = new List<EmConstract>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    EmConstract result = new EmConstract();
                    result.employeeid = dt.Rows[i][0].ToString();
                    result.firstparty = dt.Rows[i][1].ToString();
                    result.contractid = dt.Rows[i][2].ToString();
                    result.contractType = dt.Rows[i][3].ToString();
                    result.operateype = dt.Rows[i][4].ToString();
                    result.constractStatus = dt.Rows[i][5].ToString();
                    result.beginTime = dt.Rows[i][6].ToString();
                    result.endTime = dt.Rows[i][7].ToString();
                    result.months = dt.Rows[i][8].ToString();
                    result.trydate = dt.Rows[i][9].ToString();
                    result.post = dt.Rows[i][10].ToString();
                    list.Add(result);
                }
            }

            return list;
        }

        /// <summary>
        /// 根据员工id获取该员工最近三个月的工资详情
        /// </summary>
        /// <param name="employeeid">员工id</param>
        /// <returns></returns>
        public List<EmpSalary> GetEmpSalaryIofo(string employeeid)
        {
            DataTable dt = employeedal.GetEmpSalaryIofo(employeeid);
            List<EmpSalary> list = new List<EmpSalary>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    EmpSalary result = new EmpSalary();
                    result.SendDate = dt.Rows[i]["sendtovbankdate"].ToString();
                    result.tureSalary = dt.Rows[i]["tureSalary"].ToString();
                    result.subSalary = dt.Rows[i]["subSalary"].ToString();
                    result.soSalary = dt.Rows[i]["soSalary"].ToString();
                    list.Add(result);
                }
            }

            return list;
        }
    }
}