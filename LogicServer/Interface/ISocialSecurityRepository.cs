namespace LogicServer.Interface
{
    using System.Collections.Generic;

    /// <summary>
    /// SocialSecurity Repository.
    /// </summary>
    public interface ISocialSecurityRepository
    {
        /// <summary>
        /// 根据客户编号获取客户社保所有城市
        /// </summary>
        /// <param name="customerCode">客户编号</param>
        /// <returns>返回城市字符串集合</returns>
        IEnumerable<string> GetSocialSecurityCityByCus(string customerCode);
    }
}