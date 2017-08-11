namespace LogicServer.Interface
{
    using System.Data;
    using Models.Dto;

    public interface IEmployeeDal
    {
         DataTable GetEnployeeList(string customerid, string current);
         DataTable GetEnployeeList(EmployeeConditions model);
         DataTable SelecteEmployee(string customerid, string selectWhere, string current);
         DataTable GetEmployeeInfo(string customerid, string employeeid);
         DataTable GetEmConstractInfo(string employeeid);
         DataTable GetEmpSalaryIofo(string employeeid);
    }
}