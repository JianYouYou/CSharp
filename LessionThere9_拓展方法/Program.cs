namespace LessionThere9_拓展方法
{
    //为现有的非静态的 变量类型 添加 新方法
    //在一个静态类里 为另一个 现有的 非静态类 写一个方法函数 (拓展)
    //作用 
    //提升程序拓展性
    //不需要在对象中重新写方法
    //不需要继承来添加方法
    //为别人 的类型 写额外的方法
    //特点
    //一定是写在静态类里的
    //写的一定能是个静态方法
    //第一个参数为拓展目标
    //第一个参数需要用this修饰
    //访问修饰符 static 返回值类型 函数名 (this 拓展类名 参数名, 参数类型 参数名，...)
    //参数类型可以一个也不写 也可以写很多个 你写了几个参数 使用的时候就要给几个参数
    //拓展方法 与被拓展类 自己有的方法重名的话 在后面的使用里 不会使用拓展方法 会使用被拓展类自己原有的方法
    static class Tools
    {
        public static void SpeakValue(this Others Value)    //为Others写了一个方法 方法名叫SpeakValue
        {                                                   //Value是使用这个方法的变量
            //写拓展方法的逻辑                               //使用类的方法需要实例化类型变量
            Console.WriteLine("使用给Others写的拓展方法");
        }


    }

    public class Others
    {
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("拓展方法");
            //使用拓展方法
            Others other = new Others();
            other.SpeakValue();
        }
    }
}
