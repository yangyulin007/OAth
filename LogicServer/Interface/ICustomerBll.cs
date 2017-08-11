namespace LogicServer.Interface
{
    using Models;
    using Models.Dto;

    public interface ICustomerBll
    {
        ReturnDataCustomer GetCustomerInfoNumber(string customerid);
        CusContract GetContractInfo(string customerid);
        CusContract GetCustomerName(string customerid);
        CusEmployee GetCusEmployee(string customerid);
    }
}