namespace LogicServer.BLL
{
    using System.Collections.Generic;
    using System.Data;
    using Interface;
    using Models.Dto;

    public class ContractBll : IContractBll
    {
        private IContractDal contractDal;
        public ContractBll(IContractDal theContractDal)
        {
            contractDal = theContractDal;
        }

        /// <summary>
        /// 筛选员工合同
        /// </summary>
        /// <param name="model">筛选model</param>
        /// <returns></returns>
        public List<ContractInfo> FindConstractInfo(ContractConditions model)
        {
            List<ContractInfo> list = new List<ContractInfo>();
            DataTable dt = contractDal.FindConstractInfo(model);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ContractInfo result = new ContractInfo();
                    result.rn = dt.Rows[i][0].ToString();
                    result.EMPLOYEEID = dt.Rows[i][1].ToString();
                    result.employeeName = dt.Rows[i][2].ToString();
                    result.sex = dt.Rows[i][3].ToString();
                    result.age = dt.Rows[i][4].ToString();
                    result.idnumber = dt.Rows[i][5].ToString();
                    result.CONTRACTTYPE = dt.Rows[i][6].ToString();
                    result.OPERATETYPE = dt.Rows[i][7].ToString();
                    result.CONTRACTSTATUS = dt.Rows[i][8].ToString();
                    result.BEGINTIME = dt.Rows[i][9].ToString();
                    result.ENDTIME = dt.Rows[i][10].ToString();
                    result.DEADLINE = dt.Rows[i][11].ToString();
                    result.tryTime = dt.Rows[i][12].ToString();
                    result.JOINPOST = dt.Rows[i][13].ToString();
                    result.WORKINGPLACE = dt.Rows[i][14].ToString();
                    result.TRIALSALARY = dt.Rows[i][15].ToString();
                    result.OFFICIALSALARY = dt.Rows[i][16].ToString();
                    result.REMARK = dt.Rows[i][17].ToString();
                    result.CUSTOMERID = dt.Rows[i][18].ToString();
                    result.CONTRACTID = dt.Rows[i][19].ToString();
                    result.CONTRACTCODE = dt.Rows[i][20].ToString();
                    list.Add(result);
                }
            }

            return list;
        }

        public List<ContractInfo> GetContractInfo(string customerid, int current)
        {
            List<ContractInfo> list = new List<ContractInfo>();
            DataTable dt = contractDal.GetContractInfo(customerid, current);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ContractInfo result = new ContractInfo();
                    result.rn = dt.Rows[i][0].ToString();
                    result.EMPLOYEEID = dt.Rows[i][1].ToString();
                    result.employeeName = dt.Rows[i][2].ToString();
                    result.sex = dt.Rows[i][3].ToString();
                    result.age = dt.Rows[i][4].ToString();
                    result.idnumber = dt.Rows[i][5].ToString();
                    result.CONTRACTTYPE = dt.Rows[i][6].ToString();
                    result.OPERATETYPE = dt.Rows[i][7].ToString();
                    result.CONTRACTSTATUS = dt.Rows[i][8].ToString();
                    result.BEGINTIME = dt.Rows[i][9].ToString();
                    result.ENDTIME = dt.Rows[i][10].ToString();
                    result.DEADLINE = dt.Rows[i][11].ToString();
                    result.tryTime = dt.Rows[i][12].ToString();
                    result.JOINPOST = dt.Rows[i][13].ToString();
                    result.WORKINGPLACE = dt.Rows[i][14].ToString();
                    result.TRIALSALARY = dt.Rows[i][15].ToString();
                    result.OFFICIALSALARY = dt.Rows[i][16].ToString();
                    result.REMARK = dt.Rows[i][17].ToString();
                    result.CUSTOMERID = dt.Rows[i][18].ToString();
                    result.CONTRACTID = dt.Rows[i][19].ToString();
                    result.CONTRACTCODE = dt.Rows[i][20].ToString();
                    list.Add(result);
                }
            }

            return list;
        }

        /// <summary>
        /// 查询员工
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <param name="current">当前页码</param>
        /// <param name="conditions">查询条件</param>
        /// <returns></returns>
        public List<ContractInfo> GetContractInfo(string customerid, int current, string conditions)
        {
            List<ContractInfo> list = new List<ContractInfo>();
            DataTable dt = contractDal.GetContractInfo(customerid, current, conditions);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ContractInfo result = new ContractInfo();
                    result.rn = dt.Rows[i][0].ToString();
                    result.EMPLOYEEID = dt.Rows[i][1].ToString();
                    result.employeeName = dt.Rows[i][2].ToString();
                    result.sex = dt.Rows[i][3].ToString();
                    result.age = dt.Rows[i][4].ToString();
                    result.idnumber = dt.Rows[i][5].ToString();
                    result.CONTRACTTYPE = dt.Rows[i][6].ToString();
                    result.OPERATETYPE = dt.Rows[i][7].ToString();
                    result.CONTRACTSTATUS = dt.Rows[i][8].ToString();
                    result.BEGINTIME = dt.Rows[i][9].ToString();
                    result.ENDTIME = dt.Rows[i][10].ToString();
                    result.DEADLINE = dt.Rows[i][11].ToString();
                    result.tryTime = dt.Rows[i][12].ToString();
                    result.JOINPOST = dt.Rows[i][13].ToString();
                    result.WORKINGPLACE = dt.Rows[i][14].ToString();
                    result.TRIALSALARY = dt.Rows[i][15].ToString();
                    result.OFFICIALSALARY = dt.Rows[i][16].ToString();
                    result.REMARK = dt.Rows[i][17].ToString();
                    result.CUSTOMERID = dt.Rows[i][18].ToString();
                    result.CONTRACTID = dt.Rows[i][19].ToString();
                    result.CONTRACTCODE = dt.Rows[i][20].ToString();
                    list.Add(result);
                }
            }

            return list;
        }

        /// <summary>
        /// 获取在职员工以及有效合同数量
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
        public ContractNumber GetContractNumber(string customerid)
        {
           DataTable dt = contractDal.GetContractNumber(customerid);
           ContractNumber result = new ContractNumber();
           if (dt.Rows.Count > 0)
            {
                result.totalPerson = dt.Rows[0]["totalPerson"].ToString();
                result.contractNumber = dt.Rows[0]["contracttotal"].ToString();
            }

           return result;
        }
    }
}