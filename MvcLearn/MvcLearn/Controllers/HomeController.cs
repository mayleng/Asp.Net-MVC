using MvcLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLearn.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //行为 action
        public ActionResult Index()
        {
            //默认不指定显示页面时，会采用与行为同名的页面进行显示(这里显示index页面)
             return View();

            //还可以自定义显示页面  直接写视图名
           // return View("Show");
        }

        //设置一个action用来使用HtmlHelper
        //HtmlHelper主要用来搭建表单
        public ActionResult HtmlTest()
        {
            //数据从controller传到view
            ViewData["zhh"] = "123";
            //上面可以简写成如下
            ViewBag.ww = "这是简写";

            //定义下拉列表传到前端
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() {
                Selected=false,
                Text="mm",
                Value="qwe"
            });
            list.Add(new SelectListItem()
            {
                Selected = false,
                Text = "moon",
                Value = "love"
            });
            list.Add(new SelectListItem()
            {
                Selected = true,
                Text = "fm",
                Value = "all"
            });
            ViewData["downlists"] = list;

            //强类型页面
            ViewData.Model = new People()
            {
                Age = 10,
                QQ = "1234556676"
            };
            return View();
           
        }

        //路由跟controller和action有关，跟视图无关。这里只是用来显示
        //在HtmlHelper中测试的链接跳转
        public ActionResult ShowTest()
        {
            //调用People中的方法和扩展方法
            People p = new People();
            string aa = "123";
            p.Run(aa);
            p.Say(aa);

            return View("Show");
        }

        //这个行为主要用来讲解校验
        public ActionResult Show()
        {
            return View( );
        }
    }
}