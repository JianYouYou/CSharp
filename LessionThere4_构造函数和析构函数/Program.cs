namespace LessionThere4_构造函数和析构函数
{
    #region 构造函数
    //构造函数
    //在实例化对象时 会调用的用于初始化的函数
    //实例化对象的时候会执行一次构造函数
    //如果不写 默认存在一个无参构造函数 默认初始化

    //构造函数的写法
    //没有返回值
    //函数名和类名相同
    //无特殊需求 一般都是public

    //构造函数具体用哪个 是看实例化对象的时候 给不给参数
    //Person p = new Person() <- 是看这个括号里给不给参数 然后 根据参数的类型 顺序 去匹配与之相应的构造函数 
    //如果你不给参数 就会执行默认无参构造函数
    //这也是为什么构造函数的无参函数很重呀
    class Person
    {
        public string name;
        public int age;

        //类中允许自己声明无参构造函数
        //结构体不允许
        //无参构造函数
        public Person()
        {
            name = "clark";
            age = 20;
        }

        //构造函数可以重载
        //有参构造函数
        public Person(int age)
        {
            //this 代表当前调用该函数的对象自己
            //区分是该有参函数自己的参数 还是类对象的参数
            this.age = age;
            //前面的age是该构造函数自己的参数age
            //后面的age是调用了该构造函数的 类对象的age成员变量
        }
        //重载构造函数的意义就是方便我们初始化函数
        public Person(string name)
        { 
            this.name = name; 
        }
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        //当引用类型的堆内存被回收时 会使用该函数
        //当垃圾被真正回收的时候 才会调用函数
        ~Person()
        {

        }
        //!!如果声明了有参构造函数 并且自己没有声明无参构造函数 
        //那么就会失去默认的无参构造函数

        //构造函数的特殊写法
        //访问修饰符 构造函数名（参数列表）:this(参数1,参数2....)
        //意思先调用this（参数1,参数2....） 他会匹配相应参数的构造函数
        //然后再执行这个构造函数语句块的内容
        //参数甚至可以是常量 然后会匹配相应类型参数的构造函数
    }
    #endregion

    #region 析构函数
    //不重要 承上启下 不用关注
    //当引用类型的堆内存被回收时 会使用该函数
    //对应需要手动管理内存的语言（如CPP）需要在函数中做一些内存的回收处理
    //CSharp有自动垃圾回收机制GC
    //所以几乎不会用析构函数 除非想在某一对象被当垃圾回收，做一些特殊的处理

    //在unity开发中析构函数几乎不会使用 
    //基本语法
    //~类型()
    //{
    //}

    #endregion


    #region 垃圾回收机制
    //
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("构造函数和析构函数");

            //手动回收垃圾GC
            //手动触发，一般情况下不会频繁使用
            //都是在Loading过场景时才会调用
            GC.Collect();

        }
    }
}
