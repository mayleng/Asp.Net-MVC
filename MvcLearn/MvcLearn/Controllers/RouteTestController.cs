using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLearn.Controllers
{
    public class RouteTestController : Controller
    {
        // GET: RouteTest
        public ActionResult Index()
        {
            return View();
        }

       //想接收几个参数，就为行为写几个参数 参数个数和类型不固定。名字要和路由规则中一致
        public ActionResult Show(string name,int year)
        {
            ViewBag.Name = name;
            ViewBag.Year = year;
            return View();
        }

        //这里的参数是通过路由规则传递过来的，所以参数名字必须和路由
        //规则中相同（本质通过自由装配来接收参数的）
        public ActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        //在MVC中只用post和路由规则传递参数，不会用get方法传递参数












        private void Say1(string name)
        {
            Console.WriteLine(name);
        }

        private void Say2()
        {
            Say1("123");
            Say1(name: "wert");//当有多个参数时，调用方法可以备注参数名
                              //参数顺序任意
        }







    }

}