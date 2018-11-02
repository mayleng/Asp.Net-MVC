using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLearn.Areas.News.Controllers
{
    //区域下的controller不可与主项目下的controller重名
    public class NewController : Controller
    {
        // GET: News/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}