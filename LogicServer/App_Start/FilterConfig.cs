namespace LogicServer
{
    using System.Web.Mvc;

    /// <summary>
    /// Config filter.
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Regist global filters.
        /// </summary>
        /// <param name="filters">Filters container.</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
