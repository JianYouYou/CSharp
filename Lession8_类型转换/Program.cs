namespace Lession8_类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换-隐式转换");
            //大范围装小范围
            #region 相同大类型之间的转换
            //有符号 long——>int——>short——>sbyte
            long l = 1;
            int i = 1;
            short s = 1;
            sbyte sb = 1;

            //隐式转换，int转换成了long 但是i的类型没有变成long
            l = i;
            Type i_type = i.GetType();
            Console.WriteLine(i_type);
            //不能小范围装大范围的
            //i = l;

            //无符号也是大范围装小范围
            //无符号 ulong——>uint——>ushort——>byte

            //浮点数decimal double——>float
            decimal de = 10.1m;
            double d = 10.1;
            float f = 10.1f;
            //decimal类型 不能用隐式转化成double 和 float 类型
            //de = d;
            //de = f;
            //double可以存float /float可以隐式转换成double

            //特殊类型 bool string char
            //特殊类型不存在隐式转换；
            #endregion

            #region 不同大类型之间的转换
            //有符号装无符号
            //无符号
            byte b2 = 1;
            ushort us2 = 1;
            uint ui = 1;
            ulong ul = 1;
            //有符号
            sbyte sb2 = 1;
            short s2 = 1;
            int i2 = 1;
            long l2 = 1;

            //无符号装有符号 / 有符号转换成无符号
            //X无符号不包含负数，所以无符号不能装有符号
            //b2 = sb2;
            //us2 = s2;

            //有符号装无符号 / 无符号转换成有符号
            //必须有符号类型能存值的范围 大于 无符号类型能存值的范围才能 将无符号转换成有符号
            //i2 = ui2;
            l2 = ui;
            #endregion

            #region 浮点数和整数（有符号、无符号）之间转换
            float f2 = 1f;
            double d2 = 1;
            decimal dec = 1m;
            //浮点数可以装任何类型的整数的
            f2 = b2;
            f2 = us2;
            f2 = ui;
            f2 = ul;
            f2 = sb2;
            f2 = s2;
            f2 = i2;
            f2 = l2;
            //decimal也可以隐式装所有整型

            //整数型什么浮点数都装不了；//与C++不同C++里浮点数会把小数部分直接删除；

            //bool无法和其他类型相互转换；
            //string和bool一样；

            //char 也不能隐式存储其他类型
            //但是char可以隐式转换成浮点型和整型，但是以ASCII码呈现
            int i3 = 0;
            char c = 'z';
            i3 = c;
            Console.WriteLine("i3 = " + i3);
            #endregion

            #region 练习题
            char myCharName1 = '简';
            char myCharName2 = '由';
            int myIntName1 = 0;
            int myIntName2 = 0;
            myIntName1 = myCharName1;
            myIntName2 = myCharName2;
            Console.WriteLine("我的名字对应的ASCII码值为：" + myIntName1+ ' ' + myIntName2 + ' ' + myIntName2);
            #endregion
        }
    }
}
