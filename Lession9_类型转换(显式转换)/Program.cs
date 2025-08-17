namespace Lession9_类型转换_显式转换_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("显式转换");
            #region 用括号强行进行类型转换
            //作用 一般用在强行将高精度类型转换为低精度类型
            //用法 变量类型 变量名 = （变量类型）变量；

            //有符号整型
            sbyte sb = 1;
            short s = 1;
            int i = 40000;
            long l = 1;
            //s = i; 无法转换；
            s = (short)i;
            Console.WriteLine("s = " + s);
            //强行转换会有范围问题，涉及到补码
            //无符号强转和有符号情况一样

            //浮点之间
            float f = 1.1f;
            double d = 1.1234567890;
            f = (float)d;
            Console.WriteLine("f = " + f);
            //超出小范围浮点型能存储的位数之外的小数会被舍弃；

            //有无符号之间转换
            int i2 = -100;
            uint ui = 100;
            ui = (uint)i2;
            Console.WriteLine("ui = " + ui);
            //与有符号无符号同类型之间强转一样，会出现范围问题 转换时要注意范围

            //浮点数与整型
            //浮点数转换为整型，会直接舍弃小数点后的值 精度丢失
            int i3 = (int)f;
            Console.WriteLine("i3 = " + i3);

            //char 
            //int类型强转为char型并输出 会直接输出int里的值对应ASCII码表里的字符；
            char c1 = (char)ui;
            Console.WriteLine("c1 = " + c1);

            //bool和string
            //这两种都不能通过括号方式进行强转
            #endregion
            //1
            #region Parse法
            //作用 专门把字符串转换成对应的类型
            //用法 变量类型.Parse("字符串")
            //注意 字符串必须能转换成对应类型 否则报错
            Console.WriteLine("**********************");

            //有符号：
            int i4 = int.Parse("123");
            Console.WriteLine(i4);
            //int i5 = int.Parse("123.45"); //123.45不是整型所以会报错
            //Console.WriteLine(i5);
            //short s3 = short.Parse("40000");  //转换的值 必须能够被存储 不然会报错
            //Console.WriteLine(s3);

            //也可以直接在输出语句里使用Parse语句
            Console.WriteLine(long.Parse("12345"));

            //无符号
            //无符号与有符号一样
            Console.WriteLine(byte.Parse("123"));
            Console.WriteLine(ushort.Parse("123"));
            Console.WriteLine(uint.Parse("1234"));
            Console.WriteLine(ulong.Parse("123459"));

            //浮点数
            float f1 = float.Parse("1.22");
            double d1 = double.Parse("1.33");

            //布尔
            bool b1 = bool.Parse("true");
            bool b2 = bool.Parse("false");
            Console.WriteLine(b1);

            //char
            char c2 = char.Parse("a");
            Console.WriteLine(c2);
            #endregion

            #region Convert法
            //作用 更准确的将 各个类型之间进行互相转换
            //语法 Convert.To目标类型(变量或常量)
            //注意 填写的变量或常量必须正确
            Console.WriteLine("****************************");
            //转字符串
            int i5 = Convert.ToInt32("15");     //转字符串需要类型对应；
            Console.WriteLine(i5);
            //精度比括号强转好
            i5 = Convert.ToInt32(1.6f);         //会四舍五入
            Console.WriteLine(i5);
            //可以把bool转换成 数值类型 true是1 flase是0
            int i6 = Convert.ToInt32(true);
            Console.WriteLine("true: " + i6);
            i6 = Convert.ToInt32(false);
            Console.WriteLine("false：" + i6);

            //每个类型都有对应的Convert中的方法
            #endregion

            #region 其他类型转string
            //作用 拼接打印
            //语法 变量.ToString(); 这里的变量是具体值，不是变量名/标识符
            Console.WriteLine("*************************");
            string str = 1.ToString();
            bool bo1 = true;
            string str1 = bo1.ToString();
            Console.WriteLine("123" + 1 + true);
            //使用字符串拼接 编译器会自动调用ToString
            Console.WriteLine(1223);

            #endregion

            #region 练习题
            Console.WriteLine("******************");
            //四种，括号强转、Parse Convert ToString
            double d10 = 10.2;
            int i10 = (int)d10; //会导致精度缺失
            Console.WriteLine(i10);
            string str10 = "1000";
            int i11 = int.Parse(str10);
            Console.WriteLine(i11);
            Console.WriteLine(Convert.ToInt32(str10));
            string str12 = 10.2.ToString();
            Console.WriteLine(str12);

            int i12 = 24068;
            char a = (char)i12;
            Console.WriteLine(a);

            Console.WriteLine("请输入姓名");
            string name = Console.ReadLine();

            Console.WriteLine("请输入语文成绩");
            string yuwen = Console.ReadLine();
            int yuwen1 = Convert.ToInt32(yuwen);
            
            Console.WriteLine("请输入数学成绩");
            string shuxue = Console.ReadLine();
            int shuxue1 = Convert.ToInt32(shuxue);

            Console.WriteLine("请输入英语成绩");
            string yingyu = Console.ReadLine();
            int yingyu1 = Convert.ToInt32(yingyu);
            #endregion
        }
    }
}
