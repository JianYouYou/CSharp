namespace LessionFour17_协变逆变
{
    #region 什么是协边逆变
    //协 和谐 里氏替换 父类可以装子类
    //逆 逆常规 子类不能装父类 
    //用来修饰泛型 泛型字母 只有泛型接口和泛型委托可以用
    //协变 ： out 父类总是能被子类替换
    //逆变 ： in   父类总是能被子类替换

    //！！
    //函数的里氏替换原则
    //协变 可以用父类泛型委托装子类泛型委托
    //逆变 反过来 用子类泛型委托装父类泛型委托 允许从父类到子类的赋值
    #endregion

    //返回值 和 参数
    //用out修饰的泛型 只能作为返回值
    delegate T Test<out T>(/*T*/);
    //这里T不能在作为参数类型 会报错

    //用in修饰的泛型 只能作为参数
    delegate void Test1<in T>(T i);
    // 这里void处不能用T因为后面T是逆变

    //结合李氏替换原则

    class Father
    {

    }
    class Son : Father
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("协变逆变");

            Test<Son> os = () =>
            {
                return new Son();
            };

            Test<Father> of = os;
            Father f = of();

            Test1<Father> If = (value) =>
            {

            };
            Test1<Son> Is = If;
            Is(new Son());
        }
    }
}
