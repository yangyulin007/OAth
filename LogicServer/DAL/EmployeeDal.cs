namespace LogicServer.DAL
{
    using System;
    using System.Configuration;
    using System.Data;
    using Interface;
    using Models.Dto;

    public class EmployeeDal : IEmployeeDal
    {
        /// <summary>
        /// 查询在职员工
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <param name="current">当前页码</param>
        /// <returns></returns>
        public DataTable GetEnployeeList(string customerid, string current)
        {
            if (string.IsNullOrEmpty(current))
            {
                current = "1";
            }

            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerid);
            string sql = @"
                        select t.*
                        from (
                            select
                              distinct b.employeeid,
                               b.realname,
                               b.sex,
                               b.age,
                               b.idnumber,
                               b.mobilephone,
                               c.customername,
                               a.post,
                               decode(b.EMPPERSONNELPRO,'1','派遣','2','代理','3','其他','4','外包') as EMPPERSONNELPRO,
                               decode(b.islevel,'0','在职','1','已离职') as state, 
                               decode(b.EMPLOYEETYPE,'1','全日制','2','非全日制') as EMPLOYEETYPE,
                              to_char(nvl(b.servicetime,b.addtime),'yyyy-MM-dd') as startTime,
                                to_char(b.LEAVETIME,'yyyy-MM-dd') as leavetime,
                            a.customerid ,
                            row_number() over(order by to_char(nvl(b.servicetime, b.addtime), 'yyyy-MM-dd') desc) rn,
                        count(*) over() totalCount
                          from em_employeecompany a
                          left join em_employee b on a.employeeid = b.employeeid
                          left join cu_customer c on c.customerid=a.customerid  
                         where a.isdelete = 0
                           and b.isdelete=0
                           and c.isdelete=0 
                           and b.islevel =0
                           and a.customerid in  (" + customerids + ")";
            sql += "order by   to_char(nvl(b.servicetime, b.addtime), 'yyyy-MM-dd') desc";
            sql += ")t where t.rn between (" + current + " -1) * " + pageSize + " and " + current + " *" + pageSize;
            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 筛选员工信息
        /// </summary>
        /// <param name="model">员工model</param>
        /// <returns></returns>
        public DataTable GetEnployeeList(EmployeeConditions model)
        {
            if (string.IsNullOrEmpty(model.current) || model.current == "0")
            {
                model.current = "1";
            }

            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            string customerId = model.customerId;
            string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerId);
            string sql = @"select t.*
                            from (select
                              distinct b.employeeid,
                               b.realname,
                               b.sex,
                               b.age,
                               b.idnumber,
                               b.mobilephone,
                               c.customername,
                               a.post,
                               decode(b.EMPPERSONNELPRO,'1','派遣','2','代理','3','其他','4','外包') as EMPPERSONNELPRO,
                               decode(b.islevel,'0','在职','1','已离职') as state, 
                               decode(b.EMPLOYEETYPE,'1','全日制','2','非全日制') as EMPLOYEETYPE,
                              to_char(nvl(b.servicetime,b.addtime),'yyyy-MM-dd') as startTime,
                                to_char(b.LEAVETIME,'yyyy-MM-dd') as leavetime,
                            a.customerid,
                            row_number() over(order by to_char(nvl(b.servicetime, b.addtime), 'yyyy-MM-dd') desc) rn,
                             count(*) over() totalCount
                          from em_employeecompany a
                          left join em_employee b on a.employeeid = b.employeeid
                          left join cu_customer c on c.customerid=a.customerid  
                         where a.isdelete = 0
                           and b.isdelete=0
                           and c.isdelete=0
                           and a.customerid in  (" + customerids + ")";
            if (!string.IsNullOrEmpty(model.sex))
            {
                sql += "and b.sex='" + model.sex + "'";
            }

            if (!string.IsNullOrEmpty(model.state))
            {
                sql += "and b.islevel='" + model.state + "'";
            }

            if (!string.IsNullOrEmpty(model.emppersonnelpro))
            {
                sql += "and b.EMPPERSONNELPRO='" + model.emppersonnelpro + "'";
            }

            if (!string.IsNullOrEmpty(model.employeeType))
            {
                sql += "and b.EMPLOYEETYPE='" + model.employeeType + "'";
            }

            sql += "order by   to_char(nvl(b.servicetime, b.addtime), 'yyyy-MM-dd') desc";
            sql += ")t where t.rn between (" + model.current + " -1) * " + pageSize + " and " + model.current + " *" + pageSize;
            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 查询员工
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <param name="selectWhere">查询条件</param>
        /// <param name="current">当前页码</param>
        /// <returns></returns>
        public DataTable SelecteEmployee(string customerid, string selectWhere, string current)
        {
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"].ToString());
            string customerids = FairhrForeign.Others.Function.GetParentCustomerID(ref customerid);
            string sql = @"select t.*
                            from (select
                              distinct b.employeeid,
                               b.realname,
                               b.sex,
                               b.age,
                               b.idnumber,
                               b.mobilephone,
                               c.customername,
                               a.post,
                               decode(b.EMPPERSONNELPRO,'1','派遣','2','代理','3','其他','4','外包') as EMPPERSONNELPRO,
                               decode(b.islevel,'0','在职','1','已离职') as state, 
                               decode(b.EMPLOYEETYPE,'1','全日制','2','非全日制') as EMPLOYEETYPE,
                              to_char(nvl(b.servicetime,b.addtime),'yyyy-MM-dd') as startTime,
                                to_char(b.LEAVETIME,'yyyy-MM-dd') as leavetime,
                            a.customerid,
                            row_number() over(order by to_char(nvl(b.servicetime, b.addtime), 'yyyy-MM-dd') desc) rn,
                             count(*) over() totalCount
                          from em_employeecompany a
                          left join em_employee b on a.employeeid = b.employeeid
                          left join cu_customer c on c.customerid=a.customerid  
                         where a.isdelete = 0
                           and b.isdelete=0
                           and c.isdelete=0
                           and a.customerid in  (" + customerids + ")";
            if (!string.IsNullOrEmpty(selectWhere))
            {
                sql += string.Format(@" or b.realname like '%{0}%' or b.idnumber like '%{0}%' or b.mobilephone like '%{0}%'", selectWhere);
            }

            sql += "order by   to_char(nvl(b.servicetime, b.addtime), 'yyyy-MM-dd') desc";
            sql += ")t where t.rn between (" + current + " -1) * " + pageSize + " and " + current + " *" + pageSize;
            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        ///  获取员工在职信息，个人信息，公积金社保信息
        /// </summary>
        /// <param name="customerid">客户id</param>
        /// <param name="employeeid">员工id</param>
        /// <returns></returns>
        public DataTable GetEmployeeInfo(string customerid, string employeeid)
        {
            string sql = string.Format(
                @"select b.employeeid 员工编号,
                b.realname as 姓名,
                b.sex as 性别,
                b.age as 年龄,
                b.idnumber as 身份证,
                b.mobilephone as 手机号,
                b.nation as 民族,
                b.politicsstatus as 政治面貌,
                b.nativeplace as 籍贯,
                decode(b.householdtype,
                       '1',
                       '深圳户籍',
                       '2',
                       '非深户户籍',
                       '3',
                       '本市城镇',
                       '4',
                       '本市农村',
                       '5',
                       '市外城镇',
                       '6',
                       '市外农村',
                       '7',
                       '其它') as 户籍类型,
                b.CULTUREDEEP, --学历
                b.DOMICILEPLACE, --户口所在地
                decode(b.MARITALSTATUS,
                       '1',
                       '未婚',
                       '2',
                       '已婚',
                       '3',
                       '离异',
                       '4',
                       '丧偶') as 婚姻状况,
                decode(b.BEARSTATUS,
                       '1',
                       '未育',
                       '2',
                       '已育',
                       '3',
                       '怀孕中') as 生育状况,
                b.EMAIL as 邮箱,
                b.LIVEADDRESS 现居住地,
                b.OPENINGBANK 紧急联系人,
                b.banlaccount 紧急联系方式,
                g.cityname 参保城市,
                f.SSCARD 社保编号,
                f.SSCOMPUTENO 社保电脑号,
                f.SSFEES 社保缴纳基数,
                to_char(f.SSYEAR, 'yyyy-MM-dd') as 社保缴纳起始年月,
                b.ACCUMULATIONE 公积金账号,
                f.GONGJIJINFEE 公积金基数,
                f.PERSONRATE 公积金个人比例,
                f.COPANYRATE 公积金单位比例,
                f.GJYEAR as 公积金起始年月,
                c.customername,
                a.post 岗位,
                em.workingplace WORKINGPLACE,
                decode(b.EMPPERSONNELPRO,
                       '1',
                       '派遣',
                       '2',
                       '代理',
                       '3',
                       '其他',
                       '4',
                       '外包') as 员工性质,
                decode(b.islevel, '0', '在职', '1', '已离职') as state,
                decode(b.EMPLOYEETYPE, '1', '全日制', '2', '非全日制') as 员工类型,
                to_char(nvl(b.servicetime, b.addtime), 'yyyy-MM-dd') as 入职时间,
                ceil(decode(b.leavetime,
                            '',
                            sysdate - nvl(b.servicetime, b.addtime),
                            sysdate - b.leavetime)) 入职天数,
a.customerid,
decode(b.IDTYPE,'1','身份证','2','护照','3','其他') idtype,
ba.OPENPROVINCE bankROVINC,
ba.OPENCITY bankcity,
ba.BANKNAME,
ba.OPENINGBANKNAME,
ba.EMPLOYEECARD,
ba.ACCOUNTNAME,
decode(ba.BANKCARDTYPE,'1','人民币','2','其他') BANKCARDTYPE,
decode(ba.ISOTHERMAN,'1','不是','0','是') ISOTHERMAN,
decode(a.isjoinss,'0','社保','1',' ')||decode(a.ISJOINACC,'0','公积金','1',' ') project,
b.PHOTO
from em_employeecompany a
left join cu_customer c on c.customerid = a.customerid
left join em_employee b on a.employeeid = b.employeeid
left join em_contract em on em.employeeid=b.employeeid
left join em_bankcard ba on ba.employeeid=b.employeeid
left join so_socialsecurity f on f.customercode = a.customerid
left join so_socialsecurityapply g on g.applyid=f.applyid
 where a.isdelete = 0
   and b.isdelete = 0
   and c.isdelete = 0
   and ba.ISDELETE=0
   and ba.BANKCARDSTATUS=0
   and em.ISDELETE=0
   and a.customerid ='{0}'
   and b.employeeid = '{1}'", customerid,
                employeeid);
            return FairHR.Common.Helper.FuzhiDT(FairHR.Common.DbHelperOra.Query(sql).Tables[0]);
        }

        /// <summary>
        /// 根据员工id获取员工合同信息
        /// </summary>
        /// <param name="employeeid">员工id</param>
        /// <returns></returns>
        public DataTable GetEmConstractInfo(string employeeid)
        {
            string sql = string.Format(
                @"select  d.employeeid,
                d.FIRSTPARTY,
                d.contractid,
               decode(d.CONTRACTTYPE,'1','劳动合同','2','劳务合同','3','返聘协议','4','实习协议') contractType,
                decode(d.OPERATETYPE, '1', '新签', '2', '续签') operatetype,
                decode(d.CONTRACTSTATUS,
                       '1',
                       '有效',
                       '0',
                       '无效',
                       '2',
                       '无效',
                       '3',
                       '无效',
                       '4',
                       '无效',
                       '5',
                       '无效') CONTRACTSTATUS,
                to_char(nvl(d.begintime,d.SIGNEDTIME),'yyyy-MM-dd') beginTime,
                to_char(d.endtime, 'yyyy-MM-dd') endTime,
               ceil( months_between(d.endtime, (nvl(d.begintime,d.SIGNEDTIME)))) months,
                d.TRIALALL,
                d.JOINPOST
  from em_contract d 
  left join em_employee a on a.employeeid=d.employeeid
 where a.isdelete = 0
 and d.isdelete=0
 and a.employeeid='{0}'", employeeid);
            return FairHR.Common.DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 根据员工id获取该员工最近三个月的工资详情
        /// </summary>
        /// <param name="employeeid">员工id</param>
        /// <returns></returns>
        public DataTable GetEmpSalaryIofo(string employeeid)
        {
            string sql = string.Format(
                @" select * from(
                    select  row_number() over(order by A.Sendtobankdate desc) rn,
                     A.employeeid,
                    a.pkid,
                    A.CALENDARID,               
                    to_char( nvl(a.employeesalary,0), 'FM999,999,999,999,999.00') as employeesalary,
                    to_char(A.SENDTOBANKDATE,'yyyy-MM-dd') sendtovbankdate
                    FROM SA_SALARYAPPLYDETAIL A 
                    LEFT JOIN EM_EMPLOYEECOMPANY B ON B.EMPLOYEEID = A.EMPLOYEEID 
                    left join em_employee em on A.EMPLOYEEID=em.employeeid 
                    left join EM_BANKCARD bank on bank.employeeid=b.employeeid 
                    left join CU_CUSTOMER cu on  B.CUSTOMERID =cu.CUSTOMERID
                    WHERE A.employeeid='{0}') t
                    where t.rn<=3
                    ", employeeid);
            DataTable dt = FairHR.Common.Helper.FuzhiDT(FairHR.Common.DbHelperOra.Query(sql).Tables[0]);
            dt.Columns.Add("tureSalary", Type.GetType("System.String"));
            dt.Columns.Add("subSalary", Type.GetType("System.String"));
            dt.Columns.Add("soSalary", Type.GetType("System.String"));
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   string dateId = dt.Rows[i][3].ToString();
                   string sqls = string.Format(@"select amount,itemname from sa_employeesalaryhistory where employeeid='{0}' and calendarid='{1}'", employeeid, dateId);
                   DataTable infoDt = FairHR.Common.DbHelperOra.Query(sqls).Tables[0];
                   if (infoDt.Rows.Count > 0)
                    {
                        for (int j = 0; j < infoDt.Rows.Count; j++)
                        {
                            if (infoDt.Rows[j][1].ToString() == "实发工资")
                            {
                                dt.Rows[i]["tureSalary"] = infoDt.Rows[j]["amount"].ToString();
                            }

                            if (infoDt.Rows[j][1].ToString() == "应扣工资")
                            {
                                dt.Rows[i]["subSalary"] = infoDt.Rows[j]["amount"].ToString();
                            }

                            if (infoDt.Rows[j][1].ToString() == "应发工资")
                            {
                                dt.Rows[i]["soSalary"] = infoDt.Rows[j]["amount"].ToString();
                            }
                        }
                    }
                }
            }

            return dt;
        }
    }
}