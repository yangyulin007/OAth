namespace LogicServer.Interface
{
    using System.Data;

    public interface ICustomerDal
    {
        DataTable GetCustomerInfoNumber(string customerid);
        DataTable GetContractInfo(string customerid);
        DataTable GetCustomerName(string customerid);
        DataTable GetCustomerEmployeeNumber(string customerid);
    }
}
