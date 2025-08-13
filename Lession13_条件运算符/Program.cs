using System;

namespace Lession13_条件运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件运算符");
            #region 条件运算符
            //== != > >= < <=
            //条件运算符不能空比 要用到结果
            int big = 10, small = 0;
            //big > small;  不能空比
            //比较返回的是布尔值 为真-true 为假-false
            //先算右边 再赋值给左边
            bool result = big > small;
            Console.WriteLine("为真时返回：" + result);
            result = small > big;
            Console.WriteLine("为假时返回：" + result);
            #endregion

            #region 各种应用写法
            //变量和变量比
            int a = 5;
            int b = 10;
            result = a > b;
            Console.WriteLine(result);  //False
            //变量和数值（常量）比
            result = a < 10;
            Console.WriteLine(result);
            //数值与数值比
            result = 5 < 10;
            Console.WriteLine(result);
            //计算结果比较
            //条件运算符 优先级 低于 算数运算符 先算 再比
            result = a + 3 > a - 2 + 3;     //True

            //左边内容 条件运算符 右边内容
            #endregion

            #region 不能进行范围比较
            //不能进行范围比较
            a = 3;
            //result = 1 < a < 5;
            //判断一个变量是否再两个数之间 要结合逻辑运算符的知识
            #endregion

            #region 不同类型之间的比较
            //数值类型不同类型之间可以随意进行条件运算符比较
            //可以使用条件运算符 > < >= <= == ！=
            int i = 5;
            double d = 5.55;
            result = i < d;     //True

            //特殊类型 char string bool只能同类进行 == !=
            string str = "abc";
            string str1 = "abcd";
            result = str == str1;       //False
            Console.WriteLine(result);  
            char c = 'a';
            char c2 = 'A';
            result = c == c2;           //False
            Console.WriteLine(result);
            //char其实可以与数值类型进行比较 因为char会根据ASCII码转换成数值
            #endregion

            #region 练习题
            Console.WriteLine("**************练习题1******************");
            //请口答下列表达式的结果
            //我的年龄(18) > 你们的年龄(22)                      //True
            //兔子的速度(3m / s) < 乌龟的速度(0.3m / s)          //False
            //狗的重量(50kg) < 兔子的重量(5kg)                   //False
            //我身上的Money(10元) == 你身上也有Money(10元)       //True
            Console.WriteLine("**************练习题2******************");
            //求打印结果是什么?bool
            //b = true;
            //Console.WriteLine(b != true)      //False
            //Console.WriteLine(10 == 10);      //True
            //Console.WriteLine(10 > 20);       //False
            //Console.WriteLine(10 <= 20);      //True
            //Console.WriteLine(10 <= 10);      //True
            Console.WriteLine("**************练习题3******************");
            //bool gameOver, startGame;
            //int a = 10 ,b = 15;
            //gameOver = a > (b - 5);   
            //startGame = gameOver == (b > (a + 5));
            //Console.WriteLine("startGame =" + startGame);
            //请问打印结果是什么 ?

            //b - 5 = 10 ;10 == 10;所以gameOver  = False
            //(b > (a + 5) = False ;False == False; 所以 startGame = True
            //所以打印结果为startGame =True

            #endregion
        }
    }
}
