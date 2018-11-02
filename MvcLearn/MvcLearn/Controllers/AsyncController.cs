using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLearn.Controllers
{
    //这里主要讲MVC中的异步
    public class AsyncController : Controller
    {
        // GET: Async
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalAdd(int calc1,int calc2)
        {
            int sum = calc1 + calc2;
            return Content(sum.ToString());
        }

        //demo这里有参数，导致ajax请求失败
        public ActionResult CalAdd1(int calc1, int  calc2)
        {
            try
            {
              int sum = calc1 +calc2;
                var temp = new
                {
                   Sum = sum
                };
                //直接将结果作为一个json对象返回
                return Json(temp, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Content("678");
            }                              
          
        }

       

        //行为中没有跳转视图，则不会直接访问视图
        public ActionResult Show( )
        {
            return View();
        }


        /*
         异步常用的方法：
         方式1：使用jquery的异步函数
         方式2：使用MVC的Ajaxhelper
         */





    }

}