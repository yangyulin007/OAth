namespace LogicServer.DAL
{
    using System;
    using System.Data;
    using Interface;
    public class CustomerDal : ICustomerDal
    {
        /// <summary>
        /// 企业全称，合作产品及有效服务合同
        /// </summary>
        /// <param name="customerid">customerid</param>
        /// <returns></returns>
        public DataTable GetContractInfo(string customerid)
        {
            string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerid);
            string sql = string.Format(
                  @"select  a.customershort,a.parentid,count(distinct (b.contractid)) as contractCount,a.customerid
                  from CU_CUSTOMER a
                  left join em_contract b on a.customerid = b.customerid and b.isdelete=0
                   where 
                   a.customerid in ({0}) 
                   and b.contractstatus = '1'
                   group by a.customershort,a.parentid,a.customerid
                    order by parentid desc
                    ",
                  customerids);
            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取客户的在职员工，以及不同员工类型数量
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
        public DataTable GetCustomerEmployeeNumber(string customerid)
        {
            string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerid);
            string sql = string.Format(
                @"
                    select t.EMPPERSONNELPRO,t.typeCount from (
                        select 
                     decode(b.EMPPERSONNELPRO,
                               '1',
                               '派遣',
                               '2',
                               '代理',
                               '3',
                               '其他',
                               '4',
                               '外包') as EMPPERSONNELPRO,
                  count(*) over(partition by b.EMPPERSONNELPRO) typeCount
          from em_employeecompany a
          left join em_employee b on a.employeeid = b.employeeid
          left join cu_customer c on c.customerid = a.customerid
         where a.isdelete = 0
           and b.isdelete = 0
           and c.isdelete = 0
           and a.customerid in
               ({0})
           and b.islevel = '0') t
         group by (t.EMPPERSONNELPRO,t.typeCount)
         order by t.EMPPERSONNELPRO",
                customerids);
            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取当前登陆客户服务数据
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
        public DataTable GetCustomerInfoNumber(string customerid)
        {
          string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerid);
          string currentTime = DateTime.Now.ToString("G");
          string currentYearMount = DateTime.Now.ToString("yyyy-MM");
          DateTime lastMonth = DateTime.Now.AddMonths(-1);
          string lastMonthFirstDay = lastMonth.AddDays(1 - lastMonth.Day).ToString("yyyy-MM-dd HH:mm:ss");
          string lastMonthLastDay = lastMonth.AddDays(1 - lastMonth.Day).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss");
          DateTime now = DateTime.Now;
          DateTime currentFirstDay = new DateTime(now.Year, now.Month, 1);
          DateTime currentLastDay = currentFirstDay.AddMonths(1).AddDays(-1);
          string eminfosql = string.Format(
                @"select (
        
        select count(distinct b.employeeid) as addNum
          from EM_EMPLOYEECOMPANY A
          LEFT JOIN EM_EMPLOYEE B on a.employeeid = b.employeeid
         where 
            b.isdelete = 0
           and b.servicetime >= to_date('{3}', 'yyyy-MM-dd')
           and b.servicetime <= to_date('{4}', 'yyyy-MM-dd')
           and to_char(decode(servicetime,null,a.addtime,servicetime),'yyyy-MM')='{5}'
           and a.customerid in
               ({0})) as SBAdd,
       (select count(distinct b.employeeid) as subNum
          from EM_EMPLOYEECOMPANY A
          LEFT JOIN EM_EMPLOYEE B on a.employeeid = b.employeeid
         where b.islevel = 1
           and b.isdelete = 0
           and b.leavetime >= to_date('{3}', 'yyyy-MM-dd')
           and b.leavetime <= to_date('{4}', 'yyyy-MM-dd')
           and a.customerid in
               ({0})) as SBSub,
       (select count(distinct e.EMPLOYEEID) as gjjNum
          from SO_EMPLOYEESSOCIAL aa
          left join em_employee e on e.employeeid = aa.employeeid
         where OPERATETYPE = 1
           and e.islevel = 0
           and isactive != 2
           and aa.issstype = 1
           and STARTDATE <
               to_date('{1}', 'yyyy-MM-dd HH24:mi:ss')
           and nvl(enddate, add_months(sysdate, 2)) >=
               to_date('{2}', 'yyyy-MM-dd HH24:mi:ss')
           and aa.isdelete = 0
           and aa.issstype = 1
           and aa.employeeid in
               (select distinct employeeid
                  from em_employeecompany c
                 where customerid in
                       ({0})
                   and c.isjoinacc = 0)) as gjjnum,
       (select count(distinct e.EMPLOYEEID) as sbnum
          from SO_EMPLOYEESSOCIAL aa
          left join em_employee e on e.employeeid = aa.employeeid
         where OPERATETYPE = 1
           and e.islevel = 0
           and isactive != 2
           and aa.issstype = 0
           and STARTDATE <
               to_date('{1}', 'yyyy-MM-dd HH24:mi:ss')
           and nvl(enddate, add_months(sysdate, 2)) >=
               to_date('{2}', 'yyyy-MM-dd HH24:mi:ss')
           and aa.isdelete = 0
           and aa.issstype = 0
           and aa.employeeid in
               (select distinct employeeid
                  from em_employeecompany c
                 where customerid in
                       ({0})
                   and c.isjoinss = 0)) as sbnum,
       (select (SELECT COUNT(A.EMPLOYEEID) SERVICEQTY
                  FROM EM_EMPLOYEE A
                  LEFT JOIN EM_EMPLOYEECOMPANY B ON B.EMPLOYEEID =
                                                    A.EMPLOYEEID
                 WHERE A.ISDELETE = 0
                   AND B.Isdelete = 0
                   AND nvl(A.islevel, 0) != 1
                   and b.customerid in
                       ({0})) as SERVICEQTY
          from dual) as servicesNum,
       (select count(distinct(b.EMPLOYEECODE)) as cantractnum
        
          FROM EM_CONTRACT a
          LEFT JOIN EM_EMPLOYEE b ON b.EMPLOYEEID = a.EMPLOYEEID
          LEFT JOIN em_employeecompany c on c.EMPLOYEEID = a.EMPLOYEEID
          LEFT JOIN cu_customer d on d.CUSTOMERID = c.CUSTOMERID
          LEFT JOIN SY_ADMINUSER e ON e.USERID = d.CUSTOMERSERVICE
         where a.isdelete = 0
           and b.ISLEVEL = 0
           and d.customerid in
               ({0})
           and a.ENDTIME >=
               to_date('{3}', 'yyyy-mm-dd HH24:mi:ss')
           and a.ENDTIME <=
               to_date('{4}', 'yyyy-mm-dd HH24:mi:ss')) as cantractnum,
       (select realfafangnum
          from (select sa.realfafangnum,
                       sa.cyclename,
                       ROW_NUMBER() OVER(order by sa.cyclename desc) as rn
                  from sa_salaryapplydetail t
                  left join sa_salaryapply sa on sa.applyid = t.applyid
                 where t.employeeid in
                       (select ec.employeeid
                          from em_employeecompany ec
                         where ec.customerid in
                               ({0}))
                   and (t.salarystate = 1 or t.salarystate = 3)
                 group by sa.realfafangnum, sa.cyclename)
         where rn = 1) as salarynum

  from dual",   customerids,
                lastMonthLastDay,
                lastMonthFirstDay,
                currentFirstDay.ToString("yyyy-MM-dd"),
                currentLastDay.ToString("yyyy-MM-dd"),
                currentYearMount);
          DataTable dt = FairHR.Common.Helper.FuzhiDT(FairHR.Common.DbHelperOra.Query(eminfosql).Tables[0]);
          return dt;
        }

        /// <summary>
        ///  获取客户名称包括该客户的子公司，子部门
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
        public DataTable GetCustomerName(string customerid)
        {
            string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerid);
            string sql = string.Format(
                @"select cu.customerid,cu.customername,cu.parentid from cu_customer cu where
                   cu.customerid in ({0})", customerids);
            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }
    }
}