namespace LogicServer.DAL
{
    using System.Configuration;
    using System.Data;
    using Interface;

    public class SocialSecurityDal : ISocialSecurityDal
    {
        /// <summary>
        /// 按照姓名和身份证号码查询社保信息
        /// </summary>
        /// <param name="customerid">客户di</param>
        /// <param name="current">当前页码</param>
        /// <param name="conditions">查询条件</param>
        /// <returns></returns>
        public DataTable FindSocialSecurity(string customerid, int current, string conditions)
        {
            string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerid);
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            string sql =
                @"                       
              select *
                from (select row_number() over(order by b.employeeid desc) rn,
               c.customerid,
               b.employeeid,
               b.realname,
               b.idnumber,
               c.CUSTOMERNAME,
               a.joinsscity,
               f.INSURANCETYPE,
               f.SSFEES,
               f.GJTYPE,
               a.JOINJOINACCCITY,
               f.GONGJIJINFEE,
               f.COPANYRATE,
                f.PERSONRATE
          from em_employeecompany a
          left join cu_customer c on c.customerid = a.customerid
          left join em_employee b on a.employeeid = b.employeeid
          left join so_socialsecurity f on f.customercode = a.customerid
          where a.isdelete = 0
           and b.islevel = 0
           and b.isdelete = 0
           and c.isdelete = 0
           and a.customerid in (" + customerids + ")";

            if (!string.IsNullOrEmpty(conditions))
            {
                sql += "or b.realname like '%" + conditions + "%' or b.idnumber like '%" + conditions + "%'";
            }

            sql += ")t where t.rn between (" + current + " -1) * " + pageSize + " and " + current + " *" + pageSize;
            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 分页获取员工社保信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetCusSocialSecurity(string customerid, int current)
        {
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerid);
            string sql = string.Format(
                      @"                       
              select *
                from (select row_number() over(order by b.employeeid desc) rn,
               c.customerid,
               b.employeeid,
               b.realname,
               b.idnumber,
               c.CUSTOMERNAME,
               a.joinsscity,
               f.INSURANCETYPE,
               f.SSFEES,
               f.GJTYPE,
               a.JOINJOINACCCITY,
               f.GONGJIJINFEE,
               f.COPANYRATE,
                f.PERSONRATE
          from em_employeecompany a
          left join cu_customer c on c.customerid = a.customerid
          left join em_employee b on a.employeeid = b.employeeid
          left join so_socialsecurity f on f.customercode = a.customerid
          where a.isdelete = 0
           and b.islevel = 0
           and b.isdelete = 0
           and c.isdelete = 0
           and a.customerid in ({0})) t
        where t.rn between ({1} -1) *{2} and {1} *{2}", customerids,
                      current,
                      pageSize);
            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }
    }
}