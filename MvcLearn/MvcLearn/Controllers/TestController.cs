using MvcLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLearn.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public void Say1()
        {
            //ActionResult 是一个行为结果
            //行为本质是一个public的方法
        }

        private void Say2()
        {
            //当修饰符为private时，即为一个普通方法
        }

        //行为详解  直接或者间接继承ActionResult
        /*ViewResult:使用View（）可以指定一个页面，也可以指定传递的
       模型对象，如果没有指定返回与Action同名的页面
       */
        /*ContentResult:使用Content(string content)返回一个原始字符串
         */

        /*RedirectResult:使用Redirect(string url)将结果转到其他Action
         */
        /*JSonResult：使用JSon(object data)将data序列化为
         json数据并返回，默认只接受post请求。推荐加上JSonRequestsBehavior.AllowGet可以
         处理Get请求，一般结合客户端的ajax请求进行返回。
         */

        //访问该action返回一串字符串   http://ip：port/test/say
        public ActionResult Say()
        {
            string ss = "content string";
            return Content(ss);
            //return Content("wweer");           
        }

        //访问该action就会跳转别的action
        public ActionResult Tiaozhuan()
        {
           // return Redirect("/home/index");
           return Redirect(Url.Action("Index","home"));
        }

        //做异步请求时常用 返回会页面json数据
        public ActionResult JsonTest()
        {
            People p = new People()
            {
                Age=15,
                QQ="1234678889"
            };
            return Json(p, JsonRequestBehavior.AllowGet);
        }

        //参数接收1
        public ActionResult ParamRecv()
        {
            //通过Request["id"]获得的值是string类型
            //获取url中的参数   MVC中这种方式传数据比较少
            int id = int.Parse(Request["id"]);
            ViewBag.Id = id;       
            return View();
        }

        //参数接收2  自动装配（常用这种方法。本质也是上面的方法接收的参数）
        //如果要实现行为的重载需要满足两个条件：1.参数不同（参数个数
        //或者类型不同），2.请求的类型不同（请求该行为的http的method不同）
       [HttpPost]   //标记当post请求时，请求该行为。默认都是get
        public ActionResult ParamRecv(int id)
        {  
            //形参的名字要和传递参数（页面传过来的参数）名字一致
            //通过接收参数来接收参数
            ViewBag.Id2 = id;
            return View();
        }

        public ActionResult AddPerson( )
        {
            //默认会跳到 AddPerson视图
            return View();
        }

        //自动装配：可以完成自定义类型的参数装配
        [HttpPost] //接收对象参数 进行处理
        public ActionResult AddPerson(People people)
        {
            ViewData.Model = people;
            return View("AddPerson1");
        }



        }
}