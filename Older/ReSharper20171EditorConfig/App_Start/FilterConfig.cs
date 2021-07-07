using System.Web;
using System.Web.Mvc;

namespace ReSharper20171EditorConfig
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
