namespace Lession6_转义字符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("转义字符");
            #region 什么是转义字符
            //在字符串里打出无法被表现的字符，如空行，单引号，引号等等
            #endregion

            #region 怎么使用
            //用法：\+字符 不同字符有不同含义
            #endregion

            #region 常用转义字符
            //1.单引号 = \'
            string str = "1.单引号：是一个单引号（\'）";
            Console.WriteLine(str);

            //2.双引号 = \"
            string str2 = "2.双引号：是一个双引号（\"）";
            Console.WriteLine(str2);

            //3.换行 = \n
            string str3 = "3.换行：这是一\n行话吗？";
            Console.WriteLine(str3);

            //4.斜杠 = \\ 这是一个斜杠
            string str4 = "4.斜杠：这是一个斜杠（\\）";
            Console.WriteLine(str4);
            #endregion

            #region 不常用转义字符
            //1.制表符 = \t
            string str5 = "5.制表符：空一个tab键的长度\t大概是4或8个空格";
            Console.WriteLine(str5);

            //2.光标退格 = \b
            string str6 = "6.光标退格：光标\b退格 将光标向左移动一位，但不删除字符，需配合空格覆盖";
            Console.WriteLine(str6);

            //3.空字符 = \0
            string str7 = "7.空字符：一个\0空格";
            Console.WriteLine(str7);

            //4.警报音 = \a
            string str8 = "8.警报音：响了一下\a";
            Console.WriteLine(str8);
            #endregion

            #region 取消转义字符
            string str9 = @"9.取消转义字符：在字符串双引号前加一个@让转义字符不发挥作用\\ \ \t";
            Console.WriteLine(str9);
            #endregion

            #region 练习题
            //请用至少两种方式在控制台打印出:
            //我是小明
            //我今年18
            //我的爱好是制作游戏
            //我要好好学习，天天向上
            Console.WriteLine("**************练习题***************");
            Console.WriteLine("第一种");
            Console.WriteLine("我是小明");
            Console.WriteLine("我今年18");
            Console.WriteLine("我的爱好是制作游戏");
            Console.WriteLine("我要好好学习，天天向上");
            Console.WriteLine("第二种");
            Console.WriteLine("我是小明\n我今年18\n我的爱好是制作游戏\n我要好好学习，天天向上");
            #endregion
        }
    }
}
