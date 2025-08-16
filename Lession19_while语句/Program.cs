namespace Lession19_while语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while循环语句");
            #region 作用
            //让顺序进行的代码 可以不停的循环执行某一代码块的内容
            //条件分支语句 是 让代码产生分支
            //循环语句 是 让代码可以被重复执行
            #endregion

            #region 语法相关
            //bool类型的变量 条件运算符 逻辑运算符
            //while (bool类型的值) 
            //{
            //    当满足条件时 就会执行while语句块中的内容
            //    当语句块内代码执行完 会回到开头再次进行条件判断 是否进行下一次循环
            //}
            //死循环
            //不停进行循环 直到内存爆炸
            //现在学习 会在控制台里使用 
            //在之后的unity学习中 不会使用
            //可能造成内存问题 或者程序闪退
            #endregion

            #region 嵌套使用
            //不仅可以嵌套 if switch 还可以嵌套while本身
            int a = 1;
            int b = 1;
            while (a < 10)
            {
                ++a;
                while (b < 10) 
                { 
                    ++b;
                }
            }
            Console.WriteLine(a + b);
            //注意变量的使用范围 在while语句块里定义的变量 不能在外面使用
            //在while里声明与while语句外同名的变量 这两个变量 没有关系
            while (a < 10) 
            {
                a++;
                int b2 = 1;
                //每次从外部循环进来时，
                //b2与上一个b2没有关系 -内部循环（b++）结束，
                //进行外部循环 这里遇到b2的声明
                //这里的b2与内部循环里的b++不是一个b2
                //这里的内部循环执行完了，然后b2就被编译器丢失了，再遇到的int b2 = 1；就是一个新的b2声明了；
                while (b2 < 10)
                {  
                    ++b2; 
                }
            }
            #endregion

            #region 流程控制关键词
            //作用 控制循环逻辑的关键词

            //break 跳出循环
            while (true) 
            { 
                Console.WriteLine("break之前的代码");
                break;
                Console.WriteLine("break之前的代码");
            }
            Console.WriteLine("while循环之外的代码");
            //直接跳出的是整个循环 ，
            //就算你嵌套了100万个死循环，只要遇到了一个break就会直接结束整个循环

            //continue 回到循环开始 继续执行
            //while (true)
            //{
            //    Console.WriteLine("continue之前的代码");
            //    continue;
            //    Console.WriteLine("continue之前的代码");
            //    break;
            //}
            //会一直打印Console.WriteLine("continue之前的代码");
            Console.WriteLine("********打印1到20之间的奇数********");
            //要用到continue
            int i = 1;
            while (i <= 20)
            {
                if ((i % 2) == 1)
                {
                    Console.WriteLine(i);
                    i++;
                }
                else 
                {
                    i++;
                    continue;
                }
            }
            //老师的更优解
            int index = 0;
            while (index < 20)
            {
                ++index;
                //什么样的数是奇数
                //不能被2整除的数 ->%
                if (index % 2 == 0)
                continue;       //单个语句不用加花括号
                Console.WriteLine(index);
            }

            //注意 break和continue只要配合循环使用 和if语句没关系
            //break在 switch中的作用 和在while循环中的作用有异曲同工之妙
            //while里嵌套switch语句 里面的break并不会直接结束循环，
            //但是在switch里使用continue会执行
            #endregion
        }
    }
}
