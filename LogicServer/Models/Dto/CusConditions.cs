namespace LogicServer.Models.Dto
{
    public class CusConditions
    {
        /// <summary>
        /// 客户编号
        /// </summary>
        public string customerid { get; set; }

        /// <summary>
        /// 条件
        /// </summary>
        public string conditions { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public string current { get; set; }
    }
}