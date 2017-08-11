namespace LogicServer.Models.Dto
{
    public class ContractInfo
    {
        public string rn
        {
            get; set;
        }

        /// <summary>
        /// 合同ID
        /// </summary>
        private string _contractid;
        public string CONTRACTID
        {
            get { return _contractid; }
            set { _contractid = value; }
        }

        /// <summary>
        /// 员工ID
        /// </summary>
        private string _employeeid;
        public string EMPLOYEEID
        {
            get { return _employeeid; }
            set { _employeeid = value; }
        }

        /// <summary>
        /// 员工姓名
        /// </summary>
        private string _employeeName;
        public string employeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        /// <summary>
        /// 员工性别
        /// </summary>
        private string _sex;
        public string sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        /// <summary>
        /// 员工年龄
        /// </summary>
        private string _age;
        public string age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// 员工身份证
        /// </summary>
        private string _idnumber;
        public string idnumber
        {
            get { return _idnumber; }
            set { _idnumber = value; }
        }

        /// <summary>
        /// 合同开始时间
        /// </summary>
        private string _begintime;
        public string BEGINTIME
        {
            get { return _begintime; }
            set { _begintime = value; }
        }

        /// <summary>
        /// 合同结束时间
        /// </summary>
        private string _endtime;
        public string ENDTIME
        {
            get { return _endtime; }
            set { _endtime = value; }
        }

        /// <summary>
        /// 签约类型 1：新签 2 续签
        /// </summary>
        private string _operatetype;
        public string OPERATETYPE
        {
            get { return _operatetype; }
            set { _operatetype = value; }
        }

        /// <summary>
        /// 合同类型,1=劳动合同,2=劳务合同，3=返聘协议,4=实习协议
        /// </summary>
        private string _contracttype;
        public string CONTRACTTYPE
        {
            get { return _contracttype; }
            set { _contracttype = value; }
        }

        /// <summary>
        /// 合同期限
        /// </summary>
        private string _deadline;
        public string DEADLINE
        {
            get { return _deadline; }
            set { _deadline = value; }
        }

        /// <summary>
        /// 试用期时间
        /// </summary>
        private string _tryTime;
        public string tryTime
        {
            get { return _tryTime; }
            set { _tryTime = value; }
        }

        /// <summary>
        /// 客户ID
        /// </summary>
        private string _customerid;
        public string CUSTOMERID
        {
            get { return _customerid; }
            set { _customerid = value; }
        }

        /// <summary>
        /// 工作地点
        /// </summary>
        private string _workingplace;
        public string WORKINGPLACE
        {
            get { return _workingplace; }
            set { _workingplace = value; }
        }

        /// <summary>
        /// 岗位
        /// </summary>
        private string _joinpost;
        public string JOINPOST
        {
            get { return _joinpost; }
            set { _joinpost = value; }
        }

        /// <summary>
        /// 试用期工资
        /// </summary>
        private string _trialsalary;
        public string TRIALSALARY
        {
            get { return _trialsalary; }
            set { _trialsalary = value; }
        }

        /// <summary>
        /// 转正工资
        /// </summary>
        private string _officialsalary;
        public string OFFICIALSALARY
        {
            get { return _officialsalary; }
            set { _officialsalary = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        private string _remark;
        public string REMARK
        {
            get { return _remark; }
            set { _remark = value; }
        }

        /// <summary>
        /// 合同编号
        /// </summary>
        private string _cONTRACTCODE;
        public string CONTRACTCODE
        {
            get { return _cONTRACTCODE; }
            set { _cONTRACTCODE = value; }
        }

        /// <summary>
        /// 合同状态0待审核 1审核通过 2审核未通过 3 离职失效 4 发起续签 5 续签办理中
        /// </summary>
        private string _contractstatus;
        public string CONTRACTSTATUS
        {
            get { return _contractstatus; }
            set { _contractstatus = value; }
        }
    }
}