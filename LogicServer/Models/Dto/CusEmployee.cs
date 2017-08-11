namespace LogicServer.Models
{
    public class CusEmployee
    {
        // 在职员工数量
        public int postEmployee { get; set; }

        // 派遣员工数量
        public string dispatchEmployee { get; set; }

        // 外包员工数量
        public string epibolyEmoloyee { get; set; }

        // 代理员工数量
        public string agencyEmployee { get; set; }

        // 其他员工数量
        public string otherEmoloyee { get; set; }
    }
}