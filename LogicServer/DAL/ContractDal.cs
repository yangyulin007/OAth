namespace LogicServer.DAL
{
    using System.Configuration;
    using System.Data;
    using Interface;
    using Models.Dto;

    public class ContractDal : IContractDal
    {
        /// <summary>
        /// 筛选员工
        /// </summary>
        /// <param name="model">刷选model</param>
        /// <returns></returns>
        public DataTable FindConstractInfo(ContractConditions model)
        {
            string customerid = model.customerid;
            string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerid);
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            string sql =
                @"select *
  from (select row_number() over(order by a.ADDTIME desc) rn,
               b.employeeid,
               b.REALNAME,
               b.SEX,
               b.age,
               b.idnumber,
               decode(a.CONTRACTTYPE,
                      '1',
                      '劳动合同',
                      '2',
                      '劳务合同',
                      '3',
                      '返聘协议',
                      '4',
                      '实习协议') contractType,
               decode(a.OPERATETYPE, '1', '新签', '续签') AS OPERATETYPE,
               decode(a.CONTRACTSTATUS, '1', '有效', '无效') AS CONTRACTSTATUS,
               TO_CHAR(nvl(a.begintime, a.signedtime), 'YYYY-MM-DD') as begintime,
               TO_CHAR(a.ENDTIME, 'YYYY-MM-DD') AS ENDTIME,
               a.DEADLINE as DEADLINE,
               ceil(months_between(a.trialendtime, a.trialstarttime)) tryTime,
               a.joinpost,
               a.workingplace,
               a.TRIALSALARY,
               a.OFFICIALSALARY,
               a.REMARK,
               d.customerid,
               a.contractid，
                a.contractcode
          FROM EM_CONTRACT a
          LEFT JOIN EM_EMPLOYEE b ON b.EMPLOYEEID = a.EMPLOYEEID
          LEFT JOIN em_employeecompany c on c.EMPLOYEEID = a.EMPLOYEEID
          LEFT JOIN cu_customer d on d.CUSTOMERID = c.CUSTOMERID
         where a.isdelete = 0
           AND d.CUSTOMERID in (" + customerids + ")";

            if (!string.IsNullOrEmpty(model.contractState))
            {
                sql += "and a.CONTRACTSTATUS='" + model.contractState + "'";
            }

            if (!string.IsNullOrEmpty(model.employeeType))
            {
                sql += " and b.ISLEVEL='" + model.employeeType + "'";
            }

            if (!string.IsNullOrEmpty(model.opreateType))
            {
                sql += "and a.OPERATETYPE='" + model.opreateType + "'";
            }

            if (!string.IsNullOrEmpty(model.constractStartTime_start))
            {
                sql += "and  nvl(a.begintime,a.signedtime)>= to_date('" + model.constractStartTime_start + "','yyyy-MM-dd')";
            }

            if (!string.IsNullOrEmpty(model.constractStartTime_end))
            {
                sql += "and   nvl(a.begintime,a.signedtime)<=to_date('" + model.constractStartTime_end + "','yyyy-MM-dd')";
            }

            if (!string.IsNullOrEmpty(model.constractEndTime_start))
            {
                sql += "and   a.ENDTIME >=to_date('" + model.constractEndTime_start + "','yyyy-MM-dd')";
            }

            if (!string.IsNullOrEmpty(model.constractEndTime_end))
            {
                sql += "and   a.endtime <=to_date('" + model.constractEndTime_end + "','yyyy-MM-dd')";
            }

            sql += ")t where t.rn between (" + model.current + " -1) * " + pageSize + " and " + model.current + " *" + pageSize;

            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 分页获取客户在职人员合同信息
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <param name="current">当前页码</param>
        /// <returns></returns>
        public DataTable GetContractInfo(string customerid, int current)
        {
            string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerid);
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            string sql = string.Format(
                @"select *
  from (select row_number() over(order by a.ADDTIME desc) rn,
               b.employeeid,
               b.REALNAME,
               b.SEX,
               b.age,
               b.idnumber,
               decode(a.CONTRACTTYPE,
                      '1',
                      '劳动合同',
                      '2',
                      '劳务合同',
                      '3',
                      '返聘协议',
                      '4',
                      '实习协议') contractType,
               decode(OPERATETYPE, '1', '新签', '续签') AS OPERATETYPE,
               decode(a.CONTRACTSTATUS, '1', '有效', '无效') AS CONTRACTSTATUS,
               TO_CHAR(nvl(a.begintime, a.signedtime), 'YYYY-MM-DD') as begintime,
               TO_CHAR(a.ENDTIME, 'YYYY-MM-DD') AS ENDTIME,
               a.DEADLINE as DEADLINE,
               ceil(months_between(a.trialendtime, a.trialstarttime)) tryTime,
               a.joinpost,
               a.workingplace,
               a.TRIALSALARY,
               a.OFFICIALSALARY,
               a.REMARK,
               d.customerid,
               a.contractid，
                a.contractcode
          FROM EM_CONTRACT a
          LEFT JOIN EM_EMPLOYEE b ON b.EMPLOYEEID = a.EMPLOYEEID
          LEFT JOIN em_employeecompany c on c.EMPLOYEEID = a.EMPLOYEEID
          LEFT JOIN cu_customer d on d.CUSTOMERID = c.CUSTOMERID
         where a.isdelete = 0
           and b.ISLEVEL = 0
           AND d.CUSTOMERID in
               ({0})) t
         where t.rn between ({1} - 1) * {2} and  {1} *{2}", customerids,
                current,
                pageSize);
            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 查询合同
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <param name="current">当前页码</param>
        /// <param name="condirions">条件</param>
        /// <returns></returns>
        public DataTable GetContractInfo(string customerid, int current, string condirions)
        {
            string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerid);
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            string sql = string.Format(
                @"select *
  from (select row_number() over(order by a.ADDTIME desc) rn,
               b.employeeid,
               b.REALNAME,
               b.SEX,
               b.age,
               b.idnumber,
               decode(a.CONTRACTTYPE,
                      '1',
                      '劳动合同',
                      '2',
                      '劳务合同',
                      '3',
                      '返聘协议',
                      '4',
                      '实习协议') contractType,
               decode(OPERATETYPE, '1', '新签', '续签') AS OPERATETYPE,
               decode(a.CONTRACTSTATUS, '1', '有效', '无效') AS CONTRACTSTATUS,
               TO_CHAR(nvl(a.begintime, a.signedtime), 'YYYY-MM-DD') as begintime,
               TO_CHAR(a.ENDTIME, 'YYYY-MM-DD') AS ENDTIME,
               a.DEADLINE as DEADLINE,
               ceil(months_between(a.trialendtime, a.trialstarttime)) tryTime,
               a.joinpost,
               a.workingplace,
               a.TRIALSALARY,
               a.OFFICIALSALARY,
               a.REMARK,
               d.customerid,
               a.contractid,
            a.contractcode
          FROM EM_CONTRACT a
          LEFT JOIN EM_EMPLOYEE b ON b.EMPLOYEEID = a.EMPLOYEEID
          LEFT JOIN em_employeecompany c on c.EMPLOYEEID = a.EMPLOYEEID
          LEFT JOIN cu_customer d on d.CUSTOMERID = c.CUSTOMERID
         where a.isdelete = 0
           AND d.CUSTOMERID in
               ({0})
           or   b.REALNAME like '%{3}%'
             or     a.contractcode like '%{3}%' ) t
         where t.rn between ({1} - 1) * {2} and  {1} *{2}", customerids,
                current,
                pageSize,
                condirions);
            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取在职员工以及有效合同数量
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <returns></returns>
        public DataTable GetContractNumber(string customerid)
        {
            string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerid);
            string sql = string.Format(
                @"select (select count(*)
          from em_employee a
          left join em_employeecompany b on b.employeeid = a.employeeid
          left join cu_customer c on c.customerid = b.customerid
         where c.customerid in
               ({0})
           and a.islevel = '0'
           and a.isdelete = '0') as totalPerson,
       (select count(*)
          FROM EM_CONTRACT a
          LEFT JOIN EM_EMPLOYEE b ON b.EMPLOYEEID = a.EMPLOYEEID
          LEFT JOIN em_employeecompany c on c.EMPLOYEEID = a.EMPLOYEEID
          LEFT JOIN cu_customer d on d.CUSTOMERID = c.CUSTOMERID
         where a.isdelete = 0
           and b.ISLEVEL = 0
           AND d.CUSTOMERID in
               ({0})
           and a.contractstatus = '1') as contracttotal 
  from dual", customerids);
            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }
    }
}