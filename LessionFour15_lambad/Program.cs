using System.Security.Cryptography.X509Certificates;

namespace LessionFour15_lambad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lambad");
            #region 什么是lambad
            //是匿名函数的简写
            //除了写法和匿名函数不一样其他和匿名函数的写法一模一样

            //写法：
            //(参数列表) =>
            //{
            //    函数体
            //};
            #endregion


            #region 使用
            //无参无返回值
            Action action = () =>
            {
                Console.WriteLine("无参无返回值");
            };

            //有参
            Action<int> action1 = (int i) =>
            {
                Console.WriteLine("有参");
            };
            //参数类型都能省略 参数类型 和 委托或事件容器类型一致
            Action<int> action2 = (i2) =>
            {
                Console.WriteLine("有参 省略参数类型");
            };

            //有返回值
            Func<int> func = () =>
            {
                Console.WriteLine("有返回值");
                return 0;
            };

            //其他的使用方法和匿名函数一样
            //缺点也一样
            #endregion

            //使用闭包
            Test test = new Test();
            test.action();
        }
    }
    #region 闭包
    //内层函数可以引用他外层函数的变量 即使外层函数的执行已经终止
    //该变量提供的值不是变量创造是的值 是该值在外层函数范围内的最终值
    class Test
    {
        public Action action;

        public Test()
        { 
            int value = 10;

            value = 100;
            action = () =>
            {
                Console.WriteLine(value);
            };
            value = 200;
        }
    }
    #endregion
}

