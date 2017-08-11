namespace LogicServer.Interface
{
    using System.Data;

    public interface ISocialSecurityDal
    {
        DataTable GetCusSocialSecurity(string customerid, int current);
        DataTable FindSocialSecurity(string customerid, int current, string conditions);
    }
}
