using System.Security.Cryptography;

namespace LessionThere10_运算符重载
{
    //让自定义的类和结构体
    //能够使用运算符
    //关键词：operator
    //特点
    //一定是公共的静态方法
    //返回值写在operator前
    //逻辑处理自定义
    //作用
    //让自定义的类和结构体可以运算
    //注意
    //一个符号可以多次重载
    //不能使用ref和out

    //基本语法
    //public static 返回类型 operator 运算符(参数列表)

    //可以重载的运算符
    //算术运算符： + - * / % ++ --
    //需要注意需要的参数数量
    
    //逻辑运算符： ！
    //只有逻辑非

    //位运算：& ^ ~ << >>
    //要注意需要的参数数量

    //条件运算符：> < >= <= == !=
    //条件运算符需要成对实现 有大于必须有小于
    //返回值一般是bool值可以是其他 

    //不能重载的运算符
    //逻辑与&& 逻辑或|| 索引[] 强转() 点运算符. 三目运算符?: 赋值=

    class Point
    {
        public int x;
        public int y;

        public static Point operator +(Point a, Point b)    
        {
            Point p = new Point();
            p.x = a.x + b.x;    
            p.y = a.y + b.y;
            return p;
        }
        //一个运算符可以多次重载
        //参数可以是别的类型 但是最少要有一个该类的类型 顺序也很重要 主要去看运算符需要几个 以及你类型是否合适
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运算符重载");
            //使用重载后的运算符
            Point p = new Point();
            Point p2 = new Point();
            p.x = 1;
            p.y = 1;
            p2.x = 2;
            p2.y = 2;
            Point p3 = new Point();
            p3.x = p.x + p2.x;
            p3.y = p.y + p2.y;
            Console.WriteLine("{0},,{1}",p3.x,p3.y);
        }
    }
}
