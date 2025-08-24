namespace LessionTwo7_函数基础
{
    internal class Program
    {
        #region 函数写在这里
        //写在class语句块中
        //写在struct语句块中
        #endregion


        #region 实际运用
        //无参无返回值的函数
        static void SayHellow()
        {
            Console.WriteLine("Hello World!!");
        }

        //有参无返回值的函数
        static void SayYourName(string name)
        { 
            Console.WriteLine("你的名字是{0}",name);
        }

        //无参有返回值的函数
        static string WhatYourName()
        {
            Console.WriteLine("请输入你的名字");
            string name = Console.ReadLine();
            return name;    //一定要返回与返回类型相同的内容
        }

        //有参有返回值的函数
        static int SumTwo(int i,int i2)
        {
            int sum = i + i2;
            return sum;
            //也可以return i + i2;
        }

        //有参有多返回值的函数
        //想传入两个数 然后计算两个数的和 以及平均数 得出结果后返回出来
        static int[] SumAndAvg(int i, int i2)
        {
            int sum = i + i2;
            int avg = sum / 2;
            //Console.WriteLine("这两个数的和为{0}平均数为{1}",sum,avg);
            int[] arr = new int[] { sum, avg };
            return arr;
        }


        #endregion

        #region 关于return
        //即使函数没有返回值 也可以使用return
        //return可以直接不执行之后的代码 可以直接返回到函数外部 后面的代码不执行
        //
        static void Speak(int i)
        {
            if(i == 0)
            {
                Console.WriteLine("跳过了后面的代码");
                return; 
            }
            Console.WriteLine("没有跳过代码");
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("函数基础");
            #region 基本概念
            //也被称为方法
            //封装代码
            //提升代码复用率
            //抽象行为
            #endregion

            #region 基本语法
            //static 返回类型 函数名(参数类型 参数名1,参数类型 参数名2,.....)
            //{ 
            //      函数封装的逻辑代码;
            //      函数封装的逻辑代码;
            //      .................
            //      return 返回值;(如果有返回类型才返回)
            //}
            //static 不是必须的 现在默认

            //返回类型 void 代表没有返回值
            //返回类型可以写任意的变量类型

            //函数名用帕斯卡命名法 全部单词的首字母都大写

            //参数 不是必须的 可以有 0到n个 也可以是任意类型
            //参数名 用驼峰命名法 第一个单词首字母小写 后面的单词首字母全部大写
            //参数之间用,隔开

            //如果返回类型不是void 必须要有return返回值
            //viod也可以用return
            #endregion



            //调用函数
            //函数名(参数)
            SayHellow();

            //参数可以是 常量 变量 函数
            //一定是能得到相应类型的表达式
            SayYourName("简由由");

            //SayYourName(WhatYourName());

            Console.WriteLine(SumTwo(1,1));

            Speak(1);
        }
    }
}
