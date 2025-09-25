using System;
namespace LessionFour12_委托
{
    #region 声明委托
    //声明了一个存储无参无返回值函数的容器 只是定义了规则 没有使用
    delegate void TestFun();
    //同一个命名空间里不能写重名委托 不存在委托重载
    delegate int TestFunTwo(int value);
    //使用委托
    //委托变量 是 函数的容器
    //作为类的成员
    //作为函数的参数

    //委托装函数 一定要格式相同 返回值一样 参数的类型和数量也要一样
    #endregion

    #region 用类装委托
    class ADekegate
    {
        public TestFun Fun;
        public TestFun Fun2;

        //增
        public void AddFun(TestFun Fun, TestFun Fun2)
        {
            this.Fun += Fun;
            this.Fun2 += Fun2;
        }

        //删
        public void ReMoveFun(TestFun Fun, TestFun Fun2)
        {
            this.Fun -= Fun;
            this.Fun2 -= Fun2;
        }

    }
    #endregion

    //委托可以使用泛型
    //让程序更多变
    public delegate T AFunThree<T>(T value);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("委托");
            #region 委托的定义
            //是表示函数的变量类型
            //是函数的容器 用来存储传递函数 是一个类 用来定义函数的类型;

            //delegate
            //访问修饰符 delegate 返回值 委托名(参数列表)

            //写在namespace 和class里声明
            //更多在namespace 在class里写还要在用类名.点出来使用

            //定义自定义委托
            //访问修饰符默认不写 是public 在别的命名空间也能使用
            #endregion

            #region 使用委托
            //第一种声明方法
            TestFun f = new TestFun(AFun);  //相当于f里装了Afun函数 f就是Afun
            //第一种调用委托 调用委托相当于间接调用函数 .Invoke()
            f.Invoke();     //相等于先把函数存起来一会再用
            Console.WriteLine("华丽分割线");
            //第二种声明方法
            TestFun f2 = AFun;
            //第二种调用委托
            f2();
            Console.WriteLine("华丽分割线");
            //
            //!委托装函数 一定要格式相同 返回值一样 参数的类型和数量也要一样
            TestFunTwo f3 = AFunTwo;
            //TestFun f4 = AFunTwo;     委托与函数的格式不一致 无法存储
            Console.WriteLine(f3(1));

            //委托变量也可以装null; 意思为清空委托容器 (.Clear)
            Console.WriteLine("华丽分割线");
            #endregion

            #region 一个委托变量可以存储多个函数(多播委托)
            //往委托容器里加函数 委托变量名+= 函数名
            TestFun ff = AFun;
            ff += AFun;
            ff += AFunThree;
            ff();
            //这个ff这时候就存储了多个函数 调用ff时候就会运行两次AFun函数一次AFunThree函数
            //注意 存储的函数 他的格式要和 委托 一致

            //从委托容器里删函数 委托变量名 -= 函数名
            ff -= AFunThree;
            //多减函数 不会报错 不处理而已
            ff -= AFunThree;
            ff -= AFunThree;
            ff -= AFunThree;
            #endregion

            #region 用含委托的类    
            //用类里的增
            ADekegate T = new ADekegate();
            T.AddFun(AFun, AFunThree);
            T.Fun();
            Console.WriteLine("华丽分割线");
            #endregion

            #region 系统定义好的委托
            //需要命名空间System
            //常用的委托
            Action action = AFun;
            //Action是一个无参无返回值的

            //Func
            //是一个返回自定类型的委托 存储对应返回值的函数
            //返回类型自己定 无参数
            Func<int> func = AFunFour;

            //Action<>
            //可以传16个参数的泛型委托 <>里可以填16个类型
            //接受一个指定类型的参数 返回为void
            Action<int> action1 = AFunFive;

            //Func<>
            //有参数又有返回值,<>里一个参数 一个返回值
            Func<int,int> func1 = AFunTwo;
            #endregion



        }
        static void AFun() 
        {
            Console.WriteLine("运行了Afun函数");
        }
        static int AFunTwo(int value)
        {
            return value;
        }
        static void AFunThree()
        {
            Console.WriteLine("运行了AfunThree函数");
        }
        static int AFunFour()
        {
            return 1;
        }
        static void AFunFive(int i)
        {

        }
    }
}
