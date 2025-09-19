namespace LessionThere23_String
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String类");
            //String提供了很多类来给我们使用

            //字符串指定位置获取
            //String本质上是一个char数组
            string str = "123";
            Console.WriteLine(str[2]);
            //把string转为char数组
            char[] chars = str.ToCharArray();

            //字符串拼接
            str = str = "456";
            str = string.Format(str,"789");
            str = string.Format("{0}{1}", str, "111");

            //正向查找字符位置
            str = "123456";
            int index = str.IndexOf("4");
            Console.WriteLine(index);
            //如果字符没有对应字符，会返回-1

            //反向查找字符位置
            str = "12323";
            index = str.LastIndexOf("2");
            //从后面开始找第一个字符出现的位置
            Console.WriteLine(index);
            //同样没找到对应字符，会返回-1

            //移除指定位置后的字符 所有字符
            str = "012345";
            //因为用的函数 所以需要定义一个新的字符串来接受改变后的字符串
            //函数不会改变调用函数的字符串
            string str1 = str.Remove(3);
            Console.WriteLine(str1);

            //替换指定字符串
            //会将匹配的所有字符都替换
            str = "12323";
            str1 = str.Replace("23", "45");
            Console.WriteLine(str1);

            //大小写转化
            //转大写
            str = "abcd";
            str1 = str.ToUpper();
            Console.WriteLine(str1);
            //转小写
            str1 = str1.ToLower();
            Console.WriteLine(str1);

            //字符串截取
            //删前取后
            str = "01234";
            str1 = str.Substring(2);
            Console.WriteLine(str1);
            //指定距离
            str1 = str.Substring(2, 4);
            //不能超过字符串长度 会报错；
            Console.WriteLine(str1);

            //字符串切割
            //通过符号将字符串切割成字符串数组
            str = "1,2,3,4,5,6";
            string[] str2 = str.Split(',');
            for(int i = 0; i< str2.Length; i++)
            {
                Console.WriteLine(str2[i]);
            }
        }
    }
}
