namespace LogicServer.Interface
{
    using System.Data;
    using Models.Dto;

    public interface IContractDal
    {
        DataTable GetContractInfo(string customerid, int current);
        DataTable GetContractInfo(string customerid, int current, string condirions);
        DataTable FindConstractInfo(ContractConditions model);
        DataTable GetContractNumber(string customerid);
    }
}
