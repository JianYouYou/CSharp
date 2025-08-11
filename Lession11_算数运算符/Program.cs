using static System.Formats.Asn1.AsnWriter;

namespace Lession11_算数运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("算术运算符");

            #region 赋值符号
            // =
            // 先看右侧 再看左侧 把右侧的值赋值给左侧的变量
            string myName = "简由由";
            #endregion

            #region 算术运算符

            #region + 加法
            int i = 1;
            Console.WriteLine("i加法前：" + i);
            //用自己计算，先计算右侧结果，再赋值给左侧变量
            i = i + 1;
            Console.WriteLine("i加法后：" + i);

            //连续运算，先计算右侧结果，再赋值给左侧变量
            i = 1 + 2 + 3 + i;
            Console.WriteLine("i连续加法后：" + i);

            //初始化时就运算，先计算右侧结果，再赋值给左侧变量
            int i2 = 1 + 2 + 3 + 4;
            Console.WriteLine(i2);
            #endregion

            #region - 减法
            //与加法同理
            #endregion

            #region * 乘法
            //同上
            #endregion

            #region / 除法
            //同上
            //默认整数是 int 会丢失小数点后的小数
            //想用浮点数要再运算时加一个 f
            float f = 2 / 4f;
            #endregion

            #region % 取余
            //取余 是整除之后所剩的值
            //规则同上
            #endregion

            #endregion

            #region 运算符的优先级
            //优先级是再混合运算时的运算顺序
            //乘、除、取余 优先级> 加减 先乘除取余 后加减 
            Console.WriteLine("*******************");
            int i1 = 2 + 7 % 3 - 4 * 5 / 6;
            Console.WriteLine(i1);
            //顺序运算等于
            int i3 = (((((2 + 7) % 3) - 4) * 5) / 6);
            Console.WriteLine("括号可以改变运算顺序");
            Console.WriteLine(i3);
            #endregion

            #region 复合运算符
            //固定写法 运算符=
            //+= -= /+ *= %=
            //用于自己=自己进行运算，自己当运算对象，然后将运算后的值赋给自己
            //只能进行一种运算
            Console.WriteLine("*********************");
            int i4 = 10;
            Console.WriteLine(i4);
            i4 += 10;
            Console.WriteLine(i4);
            #endregion

            #region 自增减
            int i5 = 1;
            Console.WriteLine(i5);
            i5++;
            Console.WriteLine(i5);

            //i5++  先用后加    先用后增值
            //++i5  先加后用    先增值后用
            //减法于加法一样
            #endregion

            #region 练习题
            Console.WriteLine("**************");
            int age = 21;
            Console.WriteLine("我现在的年龄" + age);
            int Age = age + 10;
            Console.WriteLine("我十年后的年龄" + Age);
            //计算一个半径为5的圆的面积和周长
            //面积公式:πr2
            //周长公式:2πr
            float π = 3.14f;
            float area = π * 5 * 5;
            Console.WriteLine("面积：" + area);
            float howLong = 5 * 2 * π;
            Console.WriteLine("周长：" + howLong);
            //计算任意三门成绩的总分、平均分打印到控制台。
            //三门成绩均为整数类型(C# Unity Math)
            int CSharp = 70;
            int Unity = 80;
            int Math = 90;
            double averageScore = (CSharp +Unity + Math) / 3;
            Console.WriteLine(averageScore);
            //商店T恤的价格为285元/件，裤子的价格为720元/条，
            //小李在该店买了2件T恤和3条裤子，
            //请计算小李该付多少钱?打3.8折后呢?
            int Tshirt = 285;
            int pants = 720;
            int price = Tshirt * 2 + pants * 3;
            Console.WriteLine("小李付了" + price + "元");
            double price2 = price * 0.38 ;
            Console.WriteLine("打3.8折之后付了" + price2 + "元");
            //int a = 10, b = 20;
            //int number1 = ++a + b;    //++a 先增值后使用所以number = 11 + 20 =31;
            //a= 10;b = 20;
            //int number2 =a + b++;     //b++ 先使用后增值 所以number = 10 + 20 = 30;
            //a= 10;
            //b = 20;
            //int number3 = a++ + ++b + a++;    //number = 10 + 21 +11 = 42;第二个a++因为第一个a++变为11；
            //请说明 number1和number2和number3的结果

            //有两个数a=99，b=87，请写出两种方法交换他们的值，让a=87，b=99
            //方法一 建立中间值变量
            int a = 99, b = 87;
            int value = 0;
            value = a;
            a = b;
            b = value;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //方法二
            a = 99;
            b = 87;
            a = a + b;  //a = 99 + 87;
            b = a - b;  //b = 99 + 87 - 87 = 99;
            a = a - b;  //a = 99 + 87 - 99 = 87;

            //请把987652秒通过代码转为n天n小时n分钟n秒显示在控制台中
            //1day = 60 * 60 * 24;
            //1hour = 60 * 60;
            //1min = 60;
            int all = 987652;
            int oneDay = 60 * 60 * 24;
            int oneHour = 60 * 60;
            int oneMin = 60;

            int day = all / oneDay;
            all = all % oneDay;
            int hour = all / oneHour;
            all = all % oneHour;
            int min = all / oneMin;
            all = all % oneMin;
            Console.WriteLine("987652秒共有" + day + "天"+ hour +"小时"+ min +"分钟"+ all +"秒");
            #endregion
        }
    }
}
