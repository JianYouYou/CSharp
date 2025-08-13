namespace Lession12_字符串拼接
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("字符串拼接");
            #region 方法一
            //通过+（加号）进行字符串拼接 把字符串拼接起来
            string str = "123";
            str = str + "456";
            string str1 = "321";
            str = str + str1;
            Console.WriteLine(str);
            str1 = str1 + 1;          //得到的是3211；
            Console.WriteLine(str1);   //Lession9学到当字符串进行字符拼接时会自动调用ToString函数
                                      //所以这里的整型1被转换成字符串"1"
            //string可以使用+=复合运算符
            str = "123";
            str += "1" + 4 + true;
            Console.WriteLine(str);
            //规则 有两种情况 1.运算为字符串 2.运算为算数运算符
            //     先看运算符右侧，从左向右看，左侧为字符串，运算为字符串。
            //                               左侧为整型等其他类型，运算为算数运算符  
            str = "123";
            str += 1 + 2 + 3 + 4;           //这里左侧为整型，所以运算为算术运算符
            Console.WriteLine(str);
            str = "123";
            str += "/" + 1 + 2 + 3 + 4;     //这里左侧为字符串所以之后的运算为字符串拼接
            Console.WriteLine(str);
            str = "123";
            str = 1 + 2 + "/" + 3 + 4;       //前两个为算数运算符，第三个之后有了字符串,之后的运算就转换为了字符串拼接
            Console.WriteLine(str);
            //括号可以改变运算顺序
            str = "123";
            str = 1 + 2 + "/" + (3 + 4);
            Console.WriteLine(str);
            #endregion

            #region 方法二
            //固定语法 
            //string.Format("待拼接的内容",内容1,内容2,.....);
            //待拼接内容中的规定规则
            //想要被拼接的内容用占位符代替{数字} 数字：0~n 依次顺序往后
            //string.Format("待{数字}拼接{数字}的内容",内容1,内容2,.....);
            Console.WriteLine("*********************************");
            string str3 = string.Format("我叫{0},今年{1}岁，我想要{2}","简由由",21,"减肥");
            Console.WriteLine(str3);
            //同样会自动调用ToString函数
            #endregion

            #region 控制台打印
            //方法二可以直接在Console.WriteLine()函数使用，like
            //Console.WriteLine(string.Format("我叫{0},今年{1}岁，我想要{2}","简由由",21,"减肥"));
            //但不建议 因为
            //可以直接Console.WriteLine("我叫{0},今年{1}岁，我想要{2}","简由由",21,"减肥");
            Console.WriteLine("我叫{0},今年{1}岁，我想要{2}", "简由由", 21, "减肥");
            //所以直接在输出函数里使用format函数没必要

            //后面输入的内容 比 占位符 多 不会报错
            //后面输入的内容 比 占位符 少 会报错
            #endregion

            #region 练习题
            Console.WriteLine("**************练习题1******************");
            //定义一个变量存储客户的姓名，然后再屏幕上显示:“你好，XXX”XXX代表客户的姓名
            string nameOne = "XXX";
            Console.WriteLine("你好，" + nameOne);
            Console.WriteLine("**************练习题2******************");
            //定义两个变量，一个存储客户的姓名，另一个存储年龄，
            //然后再屏幕上显示:“xxx + yyy岁了"
            //xxx代表客户的姓名，yyy代表年龄
            //举例(唐老狮18岁了)
            string nameTwo = "XXX";
            int age = 180;
            Console.WriteLine(nameTwo + age + "岁了");
            Console.WriteLine("**************练习题3******************");
            //当我们去面试时，前台会要求我们填一张表格，
            //有姓名，年龄，邮箱，家庭住址，期望工资，
            //请把这些信息在控制台输出。
            string nameThree = "XXX";
            int ageTwo = 210;
            string eMail = "1234567891@QQ.com";
            string home = "天宫";
            long salary = 20000;
            Console.WriteLine("name:" + nameThree + "\nage:" + ageTwo + "\nemile:" + eMail + "\nhome:" + home + "\nsalary:" + salary);
            Console.WriteLine("**************练习题4******************");
            //请用户输入用户名、年龄、班级，最后一起用占位符形式打印出来
           Console.WriteLine("请输入姓名：");
            string nameFour = Console.ReadLine();
            Console.WriteLine("请输入年龄：");
            string ageThree = Console.ReadLine();
            Console.WriteLine("请输入班级：");
            string yourClass = Console.ReadLine();
            Console.WriteLine("你的姓名：{0}。\n你的年龄：{1}。\n你的班级：{2}。",nameFour,ageThree,yourClass);
            #endregion
        }
    }
}
