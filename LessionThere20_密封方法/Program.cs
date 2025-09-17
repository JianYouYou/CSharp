namespace LessionThere20_密封方法
{
    //让抽象方法和虚方法 断子绝孙 不可被继承
    //关键词 sealed
    //配合抽象函数和虚函数使用
    //虚函数关键字 virtual
    //抽象关键字 abstract
    //对override修饰的方法使用 sealed 可以让此方法不能再被继承
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("密封方法");
        }
    }
}
