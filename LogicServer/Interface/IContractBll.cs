namespace LogicServer.Interface
{
    using System.Collections.Generic;
    using Models.Dto;

    public interface IContractBll
    {
        List<ContractInfo> GetContractInfo(string customerid, int current);
        List<ContractInfo> GetContractInfo(string customerid, int current, string conditions);
        List<ContractInfo> FindConstractInfo(ContractConditions model);
        ContractNumber GetContractNumber(string customerid);
    }
}
