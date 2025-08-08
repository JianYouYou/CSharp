//两个输出函数
//Writeline();  输出一段文字，在输出完毕后自动换行;
//Writr();      输出一段文字，在输出完毕后不换行；
//两个输入函数
//ReadLine();   让玩家输入文字，在遇到回车后结束；
//Readkey()     让玩家输入文字，但是输出任意一个字符后就结束；
namespace 输入输出
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的用户名、年龄、班级");
            Console.ReadLine();
            Console.WriteLine("请问你喜欢什么运动？");
            Console.ReadLine();
            Console.WriteLine("哈哈，好巧，我也喜欢这项运动");

            //输出10X10的星号矩形图
            Console.WriteLine("**********");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("*        *");
            }
            Console.WriteLine("**********");
        }
    }
}
