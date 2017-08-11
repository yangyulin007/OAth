namespace LogicServer.Models.Dto
{
    using System.Collections.Generic;

    public class CusContract
    {
        /// <summary>
        /// 有效合同数量
        /// </summary>
        public int contractCount { get; set; }

        /// <summary>
        ///  客户名称
        /// </summary>
        public string customerName { get; set; }

        // 父id
        public string parentId { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        public string customerid { get; set; }

        public List<CusContract> children { get; set; }
    }
}