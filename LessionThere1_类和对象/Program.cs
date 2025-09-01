namespace LessionThere1_类和对象
{
    //万物皆对象
    //用程序来抽象形容对象
    //类是对象的模板 通过类声明对象
    //类的关键词 class

    //类在namespace命名空间里声明

    //类的声明
    //命名用帕斯卡命名法 首字母大写
    //同一语句块里（namespace命名空间里）的不同类不能重名
    class MyClass
    {
        //特征-成员变量
        //行为-成员函数
        //保护特征-成员属性

        //构造函数 析构函数
        //索引器
        //运算符重载
        //静态变量
    }
    class Person
    {

    }
    class Mechine
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类和对象");
            //类创造类对象的行为 叫做实例化对象
            //类对象 是引用类型

            //类名 变量名;
            //类名 变量名 = null;(null代表空)
            //类名 变量名 = new 类名();        这是初始化了的 上面两个没有初始化

            //实例化对象

            Person p;
            Person p1 = null;
            Person p2 = new Person();
            Person p3 = new Person();
            //没初始化类变量 只在栈里占据了地址 并没有在堆里占用内存
            //只有初始化之后 才在堆里占据内存空间 并有栈指向该堆
            //虽然p2p3是同一个类的实例化 但是他们两个没有联系 都是独有的数据

            //面向对象编程 是女娲模式。。 想要什么对象 就new什么对象
        }
    }
}
