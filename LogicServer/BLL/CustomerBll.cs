namespace LogicServer.BLL
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Common;
    using Interface;
    using Models;
    using Models.Dto;

    public class CustomerBll : ICustomerBll
    {
        private ICustomerDal customerDal;
        public CustomerBll(ICustomerDal theCustomerDal)
        {
            customerDal = theCustomerDal;
        }

        /// <summary>
        /// 企业全称，有效服务合同数量
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
        public CusContract GetContractInfo(string customerid)
        {
            DataTable dt = customerDal.GetContractInfo(customerid);
            CusContract result = new CusContract();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][1].ToString() == "0")
                    {
                        result.customerName = dt.Rows[i][0].ToString();
                        result.customerid = dt.Rows[i][3].ToString();
                    }
                    else
                    {
                        result.customerName = dt.Rows[i][0].ToString();
                        result.customerid = dt.Rows[i][3].ToString();
                    }

                    result.contractCount += int.Parse(dt.Rows[i][2].ToString());
                }
            }

            return result;
        }

        /// <summary>
        /// 获取客户的在职员工，以及不同员工类型数量
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
        public CusEmployee GetCusEmployee(string customerid)
        {
            DataTable dt = customerDal.GetCustomerEmployeeNumber(customerid);
            CusEmployee result = new CusEmployee();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() == "派遣")
                    {
                        result.dispatchEmployee = dt.Rows[i][1].ToString();
                    }
                    else if (dt.Rows[i][0].ToString() == "外包")
                    {
                        result.epibolyEmoloyee = dt.Rows[i][1].ToString();
                    }
                    else if (dt.Rows[i][0].ToString() == "代理")
                    {
                        result.agencyEmployee = dt.Rows[i][1].ToString();
                    }
                    else if (dt.Rows[i][0].ToString() == "其他")
                    {
                        result.otherEmoloyee = dt.Rows[i][1].ToString();
                    }

                    result.postEmployee += int.Parse(dt.Rows[i][1].ToString());
                }
            }

            return result;
        }

        /// <summary>
        /// 获取当前登陆客户服务数据
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
        public ReturnDataCustomer GetCustomerInfoNumber(string customerid)
        {
           DataTable dt = customerDal.GetCustomerInfoNumber(customerid);
           ReturnDataCustomer result = new ReturnDataCustomer();
           if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    result.currentAdd = dt.Rows[i][0].ToString();
                    result.currentSub = dt.Rows[i][1].ToString();
                    result.gjjNum = dt.Rows[i][2].ToString();
                    result.sbNum = dt.Rows[i][3].ToString();
                    result.serviceNum = dt.Rows[i][4].ToString();
                    result.contractNum = dt.Rows[i][5].ToString();
                    result.salaryNum = dt.Rows[i][6].ToString();
                }
            }

           return result;
        }

        /// <summary>
        ///  获取客户名称包括该客户的子公司，子部门
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
        public CusContract GetCustomerName(string customerid)
        {
            DataTable dt = customerDal.GetCustomerName(customerid);
            List<CusContract> list = new List<CusContract>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CusContract result = new CusContract();
                    result.customerid = dt.Rows[i][0].ToString();
                    result.customerName = dt.Rows[i][1].ToString();
                    result.parentId = dt.Rows[i][2].ToString();
                    list.Add(result);
                }
            }

            CusContract root = list.First(x => x.customerid == customerid);
            TreeHelper.LoopToAppendChildren(list, root);
            //string json = JsonConvert.SerializeObject(root);
            return root;
        }
    }
}