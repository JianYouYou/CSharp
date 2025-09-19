using System.Text;

namespace LessionThere24_StringBulider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringBulider");
            //String是引用类型
            //反复重新赋值会造成垃圾内存，

            //stringBuilder
            //修改字符而不创建新的对象，需要频繁修改和拼接字符串可以使用，能提升性能

            //使用前需要引用命名空间
            //using System.Text;
            StringBuilder strbd = new StringBuilder("1234567");
            //每次往里增加都会增大容量
            //每次都会提前预留一部分空存方便下一次加内容，
            //获得容量
            //.Capacity获得字符串容量大小
            Console.WriteLine(strbd.Capacity);
            //也可以在一开始就指定大容量 但是用的不好也是浪费内存
            //StringBuilder strbd = new StringBuilder("123",100);
            //获得字符串长度
            Console.WriteLine(strbd.Length);

            //增删查改替换
            //和string不一样，这里的函数会直接改变变量本身，不用在定义一个字符串承接改后的内容
            //增
            strbd.Append("123");    //APP END在最后加
            //未超过最大容量所以容量不会变大
            strbd.AppendFormat("{0}{1}", 100, 9999);
            //超出了最大容量 容量开始扩大
            Console.WriteLine(strbd.Capacity);

            //插入
            //.Insert(第几位,插入的内容);
            Console.WriteLine(strbd.Insert(0,"一二三"));

            //删
            //.Remove(开始位置,长度);
            Console.WriteLine(strbd.Remove(0,10));

            //清空
            //.Clear()
            //Console.WriteLine(strbd.Clear());

            //查
            //直接用变量名[index]
            Console.WriteLine(strbd[0]);

            //改
            strbd[0] = 'A';
            Console.WriteLine(strbd);

            //替换
            strbd.Replace("A", "a");
            Console.WriteLine(strbd);

            //重新赋值
            //清空 然后 赋值
            strbd.Clear();
            strbd.Append("123123");

            //没有判断是否相同的函数，可以使用万物之父里的Equals来判断
            if (strbd.Equals("123123"))
                {
                Console.WriteLine("相等");
                }
            }
        }
    }
}
