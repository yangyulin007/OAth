namespace LogicServer.Models
{
    public class ReturnDataCustomer
    {
        // 当月入职人数
        public string currentAdd { get; set; }

        // 当月离职人数
        public string currentSub { get; set; }

        // 当月公积金缴纳人数
        public string gjjNum { get; set; }

        // 当月社保缴纳人数
        public string sbNum { get; set; }

        // 总服务人数
        public string serviceNum { get; set; }

        // 最近发薪人数
        public string salaryNum { get; set; }

        // 当月合同到期人数
        public string contractNum { get; set; }

        // 客户名称
        public string customertName { get; set; }
    }
}