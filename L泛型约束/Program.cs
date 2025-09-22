
using static System.Net.Mime.MediaTypeNames;

namespace L泛型约束
{
    //让泛型的类型有了约束
    //关键字 where
    //有六种
    //值类型                             where泛型字母:struct
    //引用类型                           where泛型字母:class
    //存在无参公共构造函数类型             where泛型字母:new()
    //某个类本身或者其派生类              where泛型字母:类名
    //某个接口的本身或他的派生类型         where泛型字母:接口名
    //另一个泛型类型本身或者派生类型       where泛型字母:另一个泛型字母

    #region 值类型约束
    class Test1<T> where T : struct
    {
        public T value;

        public void Function1<K>(K value) where K : struct
        {

        }
    }
    #endregion

    #region 引用类型约束
    class Test2<T> where T : class
    {
        public T value;
        public void Function2<T>(T value) where T : class
        {

        }
    }
    #endregion

    #region 公共无参构造约束
    //必须要用 有一个无参的 公共的 非抽象的 构造函数的类 做泛型
    class Test3<T> where T : new()
    {

    }

    class Test11
    {

    }
    class Test111 : Test11
    {

    }
    class Test12
    {
        public Test12(int i)
        {

        }
    }
    #endregion
    
    #region 类约束
    //某个类本身或者其派生类       where泛型字母:类名
    //可以填约束的类 或者他的派生的类 这里可以在后面使用中填Test11 和他的派生Test111
    class Test4<T> where T : Test11
    {
        public T value;
        public void Function2<T>(T value) where T : Test11
        {

        }
    }
    #endregion

    #region 接口约束
    //某个接口的本身或他的派生类型
    interface ITest
    {

    }
    class Test51 : ITest

    {
    }
    class Test5<T> where T : ITest
    {
        public T value;
        public void Function<T>(T value) where T : ITest
        {

        }
    }
    #endregion

    #region 另一个泛型约束
    class Test6<T, U> where T : U    //T要么是和U同一类型 要么T是U泛型类型本身或他的派生类型
    {
        public T value;
        public void Function<T>(T value) where T : U
        {

        }
    }
    #endregion


    //约束的组合使用   相当于多条件 但是上面六种约束不是都可以一起用 在需要时使用 不要为用而用

    //多个泛型有约束
    class Test7<T, K> where T : struct where K : new() 
    { 
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("泛型约束");
            //Test1<object> t1 = new Test1<object>(); 约束为值类型 所以无法声明object引用类型
            Test1<int> test1 = new Test1<int>();
            test1.Function1(1);     //Function1同理

            //Test2<int> test2 = new Test2<int>();    约束为引用类型
            Test2<object> test2 = new Test2<object>();

            Test3<Test11> test3 = new Test3<Test11>();  //用Test11没有问题因为他有非抽象公共(public)无参构造函数
            //Test3<Test12> test33 = new Tese3<Test12>(); 这里不行 因为Test12没有无参构造函数
            //因为结构体也自带无参构造所以也可以用

            //某个类本身或其派生类
            Test4<Test11> test4 = new Test4<Test11>();    //可以用Test11 也可以用他的派生Test111

            //某个接口的本身或他的派生类型
            Test5<ITest> test51 = new Test5<ITest>();
             Test5<Test51> test5 = new Test5<Test51>();

            //另一个泛型约束
            //要么T是U泛型类型本身要么是U的派生类型
            Test6<Test51, ITest> test6 = new Test6<Test51, ITest>();
            Test6<Test51,Test51> test61 = new Test6<Test51,Test51>();
        }
    }
}
