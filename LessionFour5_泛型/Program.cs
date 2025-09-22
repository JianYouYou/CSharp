namespace LessionFour5_泛型
{

    //泛型类 泛型接口
    //泛型类
    //class 类名<泛型占位字母>
    //interface 接口名<泛型占位字母>
    //泛型函数
    //函数名 <泛型占位字母> (参数列表)
    //泛型占位字母可以有很多个 用逗号分开

    class Test0
    {
        #region 普通类里的 泛型方法
        public void Function<T>(T value)      //可以用作参数
        {
            Console.WriteLine(value);
            //也可以用泛型类型在里面做一些逻辑处理
            T t = default(T);
        }
        //T也可以用作返回值 但因为类型不定 一般只用了返回类型默认值 default
        #endregion
    }
    class Test<T>
    {
        public T value; //占个位置 后面再觉得T是什么类型
        #region 泛型类里的泛型方法
        //泛型类里的泛型方法的占位符不能与泛型类的占位符相同
        public A Function<A>(A value)
        {
            return value;
        }
        #endregion


    }

    class Test2<A,B,C,D>    //给多少个占位符都可以 用帕斯卡命名法 用的时候给的类型依次待人ABCD
    {

    }
    //接口同理
    interface ITest<T> 
    {
        public T Function();
    }
    class Test3 : ITest<string>
    {
        public string Function()
        {
            return "nothing";
        }

    }
    //不同类型对象的相同逻辑处理可以选择泛型
    //泛型可以一定程度避免装箱拆箱
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("泛型");
            //实现了类型参数化 达到代码复用的目的 实现一份代码上操作多种类型
            Test<int> test = new Test<int>();   //使用时 我们想让这个类作用什么类型就在<>里给什么类型
            test.value = 10;
            test.Function<string>("123");   //泛型类里的泛型函数

            Test0 test0 = new Test0();
            test0.Function<int>(100);     //普通类里的泛型函数

            //<>里变隐 因为可以省略 编译器会根据输入的变量的类型给占位符赋类型 但初学多用 熟练
            Test3 test3 = new Test3();
            test3.Function();

        }
    }
}
