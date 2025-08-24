namespace LessionTwo5_值和引用类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("值类型和引用类型");

            #region 变量类型的复习
            //无符号整型
            byte b = 0;
            ushort us = 0;
            uint ui = 0;
            ulong ul = 0;
            //有符号整型
            sbyte sb = 0;
            short s = 0;
            int i = 0;
            long l = 0;
            //浮点数
            float f = 0.1f;
            double d = 0.1;
            decimal de = 0.1m;
            //布尔
            bool b1 = false;
            bool b2 = true;
            //字符
            char c = 'a';
            string str = "str";
            //复杂数据类型
            //enum 枚举
            //一维数组 二维数组 交错数组

            //上面学过的变量类型 分为 值类型 和 引用类型
            //引用类型：string 数组 类（未学习）
            //值类型：其他都是，结构体（未学习）

            #endregion

            #region 区别
            //区别
            //值类型存储在 栈空间 - 系统分配 自动回收 小而快
            //引用类型存储在 堆控件 - 手动声明和释放 大而慢
            int a = 10;
            int[] arr = { 1, 2, 3, 4 };

            int c1 = a;
            int[] arr1 = arr;
            Console.WriteLine("a={0},c1={1}", a, c1);
            Console.WriteLine("arr[0]={0},arr1[0]={1}", arr[0], arr1[0]);
            Console.WriteLine("修改后");
            c1 = 20;
            arr1[0] = 20;
            Console.WriteLine("a={0},c1={1}", a, c1);
            Console.WriteLine("arr[0]={0},arr1[0]={1}", arr[0], arr1[0]);

            arr1 = new int[] { 99, 98, 97, 96 };
            Console.WriteLine("arr[0]={0},arr1[0]={1}", arr[0], arr1[0]);
            //使用 new int[] 是新建了一个堆内存 
            #endregion
        }
    }
}
