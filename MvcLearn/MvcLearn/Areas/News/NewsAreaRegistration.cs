using System.Web.Mvc;

namespace MvcLearn.Areas.News
{
    public class NewsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "News";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "News_default",
                "News/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
        /*
        当项目较大时，不能的功能放到不能区域。这时可以创建区域.
        在项目上右键添加区域 （可以任意命名）
        在新的区域里添加新的控制器和model以及视图.

        先注册区域的路由规则，再注册主的路由规则。所有区域的路由规则
        直接在子的里面注册。
        */
    }
}