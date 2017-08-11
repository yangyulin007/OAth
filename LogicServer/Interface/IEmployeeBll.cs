namespace LogicServer.Interface
{
    using System.Collections.Generic;
    using Models;
    using Models.Dto;

    public interface IEmployeeBll
    {
        List<ReturnDataEmployee> GetEnployeeList(EmployeeConditions model);
        List<ReturnDataEmployee> GetEnployeeList(string customerid, string current);
        List<ReturnDataEmployee> SelectEmployee(string customerid, string selectWhere, string current);
        EmployeeInfo GetEmployeeInfo(string customerid, string employeeid);
        List<EmConstract> GetEmConstractInfo(string employeeid);
        List<EmpSalary> GetEmpSalaryIofo(string employeeid);
    }
}