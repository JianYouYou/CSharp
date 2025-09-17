namespace LessionThere21_命名空间
{
    //命名空间是用来组织和重用代码的
    //命名空间是工具箱 类是工具

    //基本语法
    //namespace 命名空间名 //用帕斯卡命名法
    //{
    //  类
    //}

    //命名空间可以分开写 同一个文件里分开写 不同文件里分开写

    //不同命名空间中的类互相使用 需要引用命名空间 或 表明出处
    //用using 在namespace前
    //或 用.点运算符 命名空间名.成员 

    //不同命名空间中可以有同名类
    //使用重名类需要指定命名空间
    
    //关键字internal 只能在该程序集中使用，无法被其他文件使用
    //abstract 抽象类
    //sealed   密封类
    //partial   分部类

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命名空间");
        }
    }
}
