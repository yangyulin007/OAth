namespace LogicServer.Models.Dto
{
    public class EmConstract
    {
        public string employeeid { get; set; }

        // 甲方
        public string firstparty { get; set; }
        public string contractid { get; set; }
        public string operateype { get; set; }
        public string contractType { get; set; }
        public string constractStatus { get; set; }
        public string beginTime { get; set; }
        public string endTime { get; set; }
        public string months { get; set; }

        // 试用期
        public string trydate { get; set; }
        public string post { get; set; }
    }
}