namespace LessionTwo6_特殊的引用类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("特殊的引用类型string");

            #region 复习值类型 引用类型
            //值类型 - 内存在栈里
            //引用类型之外都是值类型 还有结构体
            //引用类型 - 内存在堆里
            //string 数组 类 枚举
            #endregion

            #region string的他变我不变
            //与数组不同 新声明string 使其等于 以声明的string 这里在堆里会新建一个 内存 存储字符串 
            //不会共用一个堆 自动new
            string str = "123";
            string str2 = str;
            str = "456";
            Console.WriteLine(str);
            Console.WriteLine(str2);

            //!!频繁的改变string 重新赋值 会导致之前的 在堆里的 内存滞留 不会 被系统回收 
            //会导致内存垃圾 影响性能
            #endregion

            //通过断点 在监视窗口 可以查看内存信息
        }
    }
}
