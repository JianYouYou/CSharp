namespace LessionTwo9_函数重载
{
    internal class Program
    {

        #region 基本概念
        //在同一语句块中class struct中
        //函数名相同
        //参数数量不同
        //参数数量相同但类型和顺序不同
        //作用：
        //命名一组功能相似的函数，减少函数名的数量 避免污染命名空间
        //提生程序可读性
        #endregion

        #region 实例
        //重载和返回值类型无关 只和参数类型 个数 顺序有关
        //调用时 程序会根据传入的参数类型判断使用哪一个重载
        static int GetSum(int i,int i2)
        {
            return i2 + i;
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int a = 0; a < arr.Length; a++)
            {
                sum += arr[a];
            }
            return sum;
        }

        //加了ref和out也是一种重载
        //数量相同 类型不同
        //注意out需要传入的函数必须初始化
        //而且不能同时使用out和ref
        static void GetSum(ref int i)
        {

        }
        //static void GetSum(out int i)
        //{

        //}
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("函数重载");
        }
    }
}
