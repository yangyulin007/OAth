namespace LogicServer.BLL
{
    using System.Collections.Generic;
    using System.Data;
    using Interface;
    using Models.Dto;

    public class SocialSecurityBll : ISocialSecurityBll
    {
        private ISocialSecurityDal socialSecurityDal;
        public SocialSecurityBll(ISocialSecurityDal thesocialSecurityDal)
        {
            socialSecurityDal = thesocialSecurityDal;
        }

        /// <summary>
        /// 按照姓名和身份证号码查询社保信息
        /// </summary>
        /// <param name="customerid">客户di</param>
        /// <param name="current">当前页码</param>
        /// <param name="conditions">查询条件</param>
        /// <returns></returns>
        public List<SocialSecurityInfo> FindSocialSecurity(string customerid, int current, string conditions)
        {
            DataTable dt = socialSecurityDal.FindSocialSecurity(customerid, current, conditions);
            List<SocialSecurityInfo> list = new List<SocialSecurityInfo>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SocialSecurityInfo result = new SocialSecurityInfo();
                    result.rn = dt.Rows[i][0].ToString();
                    result.customerid = dt.Rows[i][1].ToString();
                    result.employeeid = dt.Rows[i][2].ToString();
                    result.realname = dt.Rows[i][3].ToString();
                    result.idnumber = dt.Rows[i][4].ToString();
                    result.customername = dt.Rows[i][5].ToString();
                    result.joinsscity = dt.Rows[i][6].ToString();
                    result.insuranceType = dt.Rows[i][7].ToString();
                    result.ssfees = dt.Rows[i][8].ToString();
                    result.gjtype = dt.Rows[i][9].ToString();
                    result.joingjjcity = dt.Rows[i][10].ToString();
                    result.gjjfee = dt.Rows[i][11].ToString();
                    result.companygjjFee = dt.Rows[i][12].ToString();
                    result.persongjjFee = dt.Rows[i][13].ToString();
                    list.Add(result);
                }
            }

            return list;
        }

        /// <summary>
        /// 分页获取员工社保信息
        /// </summary>
        /// <returns></returns>
        public List<SocialSecurityInfo> GetCusSocialSecurity(string customerid, int current)
        {
           DataTable dt = socialSecurityDal.GetCusSocialSecurity(customerid, current);
           List<SocialSecurityInfo> list = new List<SocialSecurityInfo>();
           if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SocialSecurityInfo result = new SocialSecurityInfo();
                    result.rn = dt.Rows[i][0].ToString();
                    result.customerid = dt.Rows[i][1].ToString();
                    result.employeeid = dt.Rows[i][2].ToString();
                    result.realname = dt.Rows[i][3].ToString();
                    result.idnumber = dt.Rows[i][4].ToString();
                    result.customername = dt.Rows[i][5].ToString();
                    result.joinsscity = dt.Rows[i][6].ToString();
                    result.insuranceType = dt.Rows[i][7].ToString();
                    result.ssfees = dt.Rows[i][8].ToString();
                    result.gjtype = dt.Rows[i][9].ToString();
                    result.joingjjcity = dt.Rows[i][10].ToString();
                    result.gjjfee = dt.Rows[i][11].ToString();
                    result.companygjjFee = dt.Rows[i][12].ToString();
                    result.persongjjFee = dt.Rows[i][13].ToString();
                    list.Add(result);
                }
            }

           return list;
        }
    }
}