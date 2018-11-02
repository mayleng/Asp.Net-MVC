using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcLearn
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //自定义路由规则要求，小范围写在前，大范围写在后
            //如果把小范围的规则写在了后面，永远也不会匹配到

            //自定义路由（这个范围比默认的小，所以放在前面），匹配到就不会往下匹配
            routes.MapRoute(
                name: "NewShow",
                //当输入路由为2011-w 即匹配该控制器
                url: "{year}-{name}",
                defaults: new
                {
                   controller = "RouteTest",
                    action = "Show"

                },               
                constraints: new
                {
                    year = "^\\d{4}$",
                   
                }
                
                );

            //注册路由（默认）
            routes.MapRoute(
                name: "Default", //当前路由规则名字，不可重复
                url: "{controller}/{action}/{id}", //路由规则
                                                   //{controller}/{action}/这两个名字不可改，顺序可换。别的任意定
                                                   //{id}是参数，通过路由规则传递参数，参数名为id
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //defaults用来设置一些默认值
                //UrlParameter可选参数
                /*
                constraints:设置路由规则约束（默认没用这个参数）,为路由规则中每一部分写约束
                类型为object，可以传递一个匿名对象，属性取决于规则中定义的参数
                参数是正则表达式字符串，如controller=“^[a-z]+$”
                */
                );

           
           





        }
    }
}





/*
 RouteData:可以在Action中通过RouteData.GetRequestString("controller/action")获取本次
 请求中控制器或行为的真实名称；
 RouteCollection:（内存中数据）存放路由规则的集合，一个MVC项目中可以配置
 多个路由规则；
 RouteTable：类中包含静态的RouteCollection属性，完成所有路由规则的全局
 存储，在Global中完成注册；
 */
