namespace Lession2_变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量");
            //知识点一，折叠代码
            //让代码更清晰
            //由#rigion 和#endrigion配对出现
            //本质是编译器的预处理指令
            //只在编辑时有效，发布代码或执行代码会被自动删除
            #region 知识点二/如何申明代码
            //如何申明
            //变量类型 变量名 = 初始值;
            int i = 0;
            //变量类型有14种
            //变量名自定义 要按照一定规则
            //初始值类型与变量类型要统一

            //变量类型
            //1.有符号的整型 存储整数，正负零都可以
            sbyte sb = 1;   //-128~127
            short s = 2;    //-32768~327867
            int i1 = 3;     //-21亿~21亿多
            long l = 4;     //-9百万兆~9百万兆

            //2.无符号的整型 不能存负整数 unsign
            byte b = 1;     //0~255     *与其他三个不同不是加u而是删s
            ushort us = 2;  //0~65535
            uint ui = 3;    //0~42亿
            ulong ul = 4;   //0~18百万兆

            //3.浮点数（小数）
            float f = 0.1234567890f;    //存储小数点后7/8位有效数字，
            Console.WriteLine(f);       //在最后加上f,是因为在C#中小数被默认位double类型，加上f告诉系统，是folat类型
                                        //输出为0.12345679，因为有效存储为小数点后8位，第9位的9四舍五入给第8位变成9

            double d = 0.12345678901234567890123456789;     //能存储15-17位有效数字，抛弃的数字 会四舍五入
            Console.WriteLine(d);      

            decimal de = 0.123456789m;  //能存储27-28位数，一般用不到
            Console.WriteLine(de);      //与float同理告诉编译器该值为decimal类型；

            //4.特殊类型
            //（1.）bool布尔值 表示真假
            //只有两个 ture false
            bool bt = true;
            bool bf = false;
            Console.WriteLine(bt + "_" + bf);

            //(2.)char 存储单个字符 初始值需要加单引号（'c'）
            char c = 'a';
            Console.WriteLine(c);

            //(3.)string 存储字符串 初始值需要加双引号（"string"）
            string str = ("string");
            Console.WriteLine(str);

            //拼接打印 用+号
            Console.WriteLine("i1的数值是" + i1);
            #endregion

        }
    }
}
