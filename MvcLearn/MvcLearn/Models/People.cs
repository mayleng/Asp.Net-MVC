using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLearn.Models
{
    public class People
    {
        //定义属性
        public int Age { get; set; }
        public string QQ { get; set; }

        //定义一个方法
        public void Run(string aa)
        {
            aa += "myaa";
        }
    }

    //扩展方法   对已经定义好的类扩展新的方法
    //不修改原类的文件  需要先定义一个静态类
    public static class TestKuo
    {
        //Say方法是为People类的扩展方法，第一个参数指明为哪个类的
        //扩展方法，后面接着写方法中的参数
        public static void Say(this People people,string qq)
        {
            qq += "my";
        }


    }
}