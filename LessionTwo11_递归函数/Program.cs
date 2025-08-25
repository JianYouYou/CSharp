namespace LessionTwo11_递归函数
{
    internal class Program
    {
        #region 基本概念
        //就是自己调用自己
        //会爆栈
        //一个正确的递归函数
        //1.必须有结束调用的条件
        //2.用于条件判断的 条件 必须改变 能够达到停止的目的
        #endregion

        #region 实例
        //用递归函数打印出0到10
        static void Fun(int x)
        {
            if (x > 10)
            {
                return;
            }
            Console.WriteLine(x);
            ++x;    //增值在递归前不然整值一直无法运行
            Fun(x);

        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("递归函数");
            int x = 0;
            Fun(x);

        }
    }
}
