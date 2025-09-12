namespace LessionThere15_万物之父和装修拆箱
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父和装修拆箱");

            #region 万物之父object
            //万物之父
            //关键字 object

            //是所有类的基类 他是一个类(引用类型)

            //可以用里氏替换原则 用object容器装所有的对象
            //用来表示不确定类型 作为函数参数类型

            //用object装引用类型
            //就用 is as 来转换
            //用is判断 用as转换

            //用object 装值类型
            //直接装
            object o = 1;
            //也可以强转 括号强转
            int i = (int)o;

            //string比较特殊 
            //str转object 可以直接转
            object str = "123";
            //object转str可以用ToString
            string str2 = str.ToString();
            //也可以as string;
            str2 = str as string;

            //数组
            //把object转换成目标类型数组 可以用as
            object arr = new int[10];
            int[] ar = arr as int[];
            #endregion

            #region 装箱拆箱
            //用object装值类型 称为装箱
            //把object转换为值类型 称为拆箱

            //object是一个引用类型
            //所以把值类型用引用类型存储
            //栈内存会迁移到堆内存了
            //object在栈里存一个地址 这个地址是堆内的值类型的值

            //拆箱
            //把引用类型在堆里的存储 迁移到栈里

            //好处 不确定的类型可以方便参数的存储和传递
            //坏处 存在内存迁移 增加性能消耗
            #endregion

        }
    }
}
