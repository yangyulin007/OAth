namespace LogicServer.Common
{
    using System.Collections.Generic;
    using System.Linq;
    using Models.Dto;

    public static class TreeHelper
    {
        public static void LoopToAppendChildren(List<CusContract> list, CusContract children)
        {
            var subItems = list.Where(x => x.parentId == children.customerid).ToList();
            children.children = new List<CusContract>();
            children.children.AddRange(subItems);
            foreach (var item in subItems)
            {
                LoopToAppendChildren(list, item);
            }
        }
    }
}