namespace Lession10_异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获");
            #region 作用
            ////通过对异常捕获的学习，解决程序卡死的情况 比如玩家输入的值不符合类型
            //string str = Console.ReadLine(); //检测用户的输入 并存入string类型的变量当中
            //int i1 = int.Parse(str);    //如果用户输入的不是整型，那么程序就会报错
            
            #endregion

            #region 基本语法
            //必备部分
            try 
            { 
                //希望进行异常捕获的代码块
                //放到try中
                //如果try中的代码报错了 不会让程序卡死
            }
            catch
            {
                //如果出错了 会执行 catch里的代码块 来捕获异常
            }
            //可选部分
            finally
            {
                //最后执行的代码 不管有没有出错 都会执行
            }
            //注意 异常捕获代码代码块后不需要加;在里面去写代码逻辑时 每一句才加
            #endregion

            #region 实践用法
            try
            {
                string str = Console.ReadLine();
                int i1 = int.Parse(str);
                Console.WriteLine(i1);
            }
            catch
            {
                Console.WriteLine("请输入整数");
            }
            #endregion

            #region 练习题
            Console.WriteLine("*********************练习题1*******************");
            //请用户输入一个数字如果输入有误，则提示用户输入错误
            try
            {
                Console.WriteLine("请输入一个数字");
                string str1 = Console.ReadLine();
                int i2 = int.Parse(str1);
            }
            catch 
            {
                Console.WriteLine("输入错误");
            }

            Console.WriteLine("*********************练习题2*******************");
            //提示用户输入姓名、语文、数学、英语成绩
            //如果输入的成绩有误，
            //则提示用户输入错误否则将输入的字符串转为整形变量存储
            Console.WriteLine("请输入姓名：");
            string nameStr = Console.ReadLine();

            try
            {
                Console.WriteLine("请输入语文成绩：");
                string yuWen = Console.ReadLine();
                int yuWen1 = int.Parse(yuWen);
                if (yuWen1 < 0 || yuWen1 > 150)
                {
                    Console.WriteLine("输入错误");
                }
                else
                {
                    Console.WriteLine("请输入数学成绩：");
                    string shuXue = Console.ReadLine();
                    int shuXue1 = int.Parse(shuXue);
                    if (shuXue1 < 0 || shuXue1 > 150)
                    {
                        Console.WriteLine("输入错误");
                    }
                    else
                    {
                        Console.WriteLine("请输入英语成绩：");
                        string yingYu = Console.ReadLine();
                        int yingYu1 = int.Parse(yingYu);
                        if (yingYu1 < 0 || yingYu1 > 150)
                        {
                            Console.WriteLine("输入错误");
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("输入错误");
            }
            #endregion
        }
    }
}
