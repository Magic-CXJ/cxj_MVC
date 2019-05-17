using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cxj_MVC.Models
{
    public class MyDbInit
         : System.Data.Entity.CreateDatabaseIfNotExists<MyDb>
    {
        protected override void Seed(MyDb context)
        {
            base.Seed(context);


            context.StuInfoes.Add(new StuInfo
            {
                Xueshengxuehao = "20180001",
                Xueshengxingming = "张三",
                Xueshengxingbie = "男"

            });
            context.StuInfoes.Add(new StuInfo
            {
                Xueshengxuehao = "20180002",
                Xueshengxingming = "李四",
                Xueshengxingbie = "女"
            });


        }


    }
    //作为测试用的类
}