namespace LessionThere12_继承的基本规则
{
    //被继承的类 叫做 父类 基类 超类
    //继承的类 叫做 子类 衍生类
    //子类可以使用父类的所有内容
    //单根性：一个子类只能有一个父类
    //传递性：一个子类可以继承他父类的父类 向上无限延生
    //使用方法
    //class 类名 : 被继承的类名
    //{
    //
    //}
    class Father
    {

    }
    class Son : Father
    {

    }
    //访问修饰符的使用
    //protected 保护 只有内部类和子类可以访问
    
    //CShrp同意子类里存在和父类相同名字 的成员
    //但是不建议用 显的多余
    //可以在类型名前加一个new 这样不会出黄色波浪线 但是 还是不建议用
    //学了多态后再解决这个问题
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承的基本规则");
        }
    }
}
