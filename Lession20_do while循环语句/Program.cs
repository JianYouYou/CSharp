namespace Lession20_do_while循环语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do while循环");
            #region 基本语法
            //while经过判断之后才决定执不执行
            //do while先做一遍，再进行判断是否循环
            //do
            //{
            //    do while循环语句
            //}
            //while (bool);

            #endregion

            #region 实际应用

            //实际开发中do while使用较少
            int i = 1;
            do
            {
                Console.WriteLine("执行第{0}次", i);
                i++;
            }
            while (i < 5);

            #endregion

            #region 嵌套使用
            //if switch while do whlie都可以嵌套
            //也可以使用break continue;
            //do里的continue回到的是下面的while判断 而不是回到开始的do
            #endregion
        }
    }
}
