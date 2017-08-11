namespace LogicServer.Interface
{
    using System.Collections.Generic;
    using Models.Dto;

    public interface ISocialSecurityBll
    {
        List<SocialSecurityInfo> GetCusSocialSecurity(string customerid, int current);
        List<SocialSecurityInfo> FindSocialSecurity(string customerid, int current, string conditions);
    }
}
