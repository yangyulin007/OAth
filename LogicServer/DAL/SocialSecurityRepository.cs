namespace LogicServer.DAL
{
    using System.Collections.Generic;
    using System.Linq;
    using Interface;
    using Models;

    /// <summary>
    /// Implement CRUD operation for SocialSecurity entity.
    /// </summary>
    public class SocialSecurityRepository : ISocialSecurityRepository
    {
        /// <summary>
        /// 根据客户编号获取客户社保所有城市
        /// </summary>
        /// <param name="customerCode">客户编号</param>
        /// <returns>返回城市字符串集合</returns>
        public IEnumerable<string> GetSocialSecurityCityByCus(string customerCode)
        {
            using (var context = new SocialSecurityandApply())
            {
                IEnumerable<string> citylsit = context.SO_SOCIALSECURITY.Where(s => s.CUSTOMERCODE == customerCode).Select(p => p.CITYNAME).Distinct().ToList();
                return citylsit;
            }
        }
    }
}