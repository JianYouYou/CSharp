namespace Lession18_switch语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region 作用
            //让顺序执行的代码产生分支
            #endregion

            #region 基础语法
            //switch(变量)
            //{
            //    变量 ==常量 执行cae 和 break 之间的代码
            //    case 常量:   //这里是冒号 并非分号
            //        满足条件执行的代码逻辑
            //        break;
            //    case 常量:
            //        满足条件执行的代码逻辑
            //        break;
            //        case 可以有无数个
            //    default:
            //        如果上面的case条件都不满足 就会执行 default中的代码
            //        break
            //}
            //注意 ： 条件为常量 ！！ 只能写一个 不能写范围 不能写条件运算符 逻辑运算符等
            //switch 只判断变量是否等于某个固定值

            int a = 1;
            switch (a)
            {
                case 1:
                    Console.WriteLine("a等于1");
                    break;
                case 2:
                    Console.WriteLine("a等于2");
                    break;
                default:
                    Console.WriteLine("什么条件都不满足");
                    break;
            }

            //后面配合枚举使用
            #endregion

            #region defalut可省略
            string str = "123";
            switch (str)
            {
                case "123":
                    Console.WriteLine("str 等于 123");
                    break;
                case "234":
                    Console.WriteLine("str 等于 234");
                    break;
            }
            #endregion

            #region 可自定义常量
            char c = 'A';
            const char c2 = 'A'; ;
            switch (c)
            {
                case 'A':   //这里case 后面可以放常量对象
                    Console.WriteLine("c = A");
                    break;
                default:
                    break;
            }
            #endregion

            #region 贯穿
            //满足某些条件时 做的事情时一样的 就可以使用管串
            int aa = 1;
            switch (aa)
            {               //意思就是case只有遇到break才停止；
                case 1:     //不写与case配对的break就叫做贯串 
                case 2:     //不止可以叠两个 
                    Console.WriteLine("是个数字");
                     break;
                default:
                    break;
            }
            #endregion
        }
    }
}
