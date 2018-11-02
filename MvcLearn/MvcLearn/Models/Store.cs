using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//校验需要引进该依赖
using System.Linq;
using System.Web;

namespace MvcLearn.Models
{
    //通过这个类来讲解校验。
    //在客户端跟服务端关联校验
    public class Store
    {
        //给属性加一些特性，才可以修改在前端的提示
        /*
         [Required] 必须的
         [StringLength] 字符串长度
         [Range]    只针对int和float长度
         [RegularExpression] 正则表达式
         属性ErrorMessage:指定错误提示信息

        上面的属性可以用一个或者多个
         */

        [Required(ErrorMessage="编号不能为空")]
        [Range(10,100,ErrorMessage ="必须是10到100间的值")]
        public int Id { get; set; }
        public string   Name { get; set; }
        //有校验功能时，前端输入的类型有问题时，数据不会提交到后端
    }
}