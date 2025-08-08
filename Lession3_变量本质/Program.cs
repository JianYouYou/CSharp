namespace Lession3_变量本质
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1字节=8比特 / 1byte = 8bit
            //不同类型占的内存空间不同，所以能存储的大小不同
            //有符号需要一个比特来存符号，所以一个类型有无符号能存的大小不同
            //sizeof函数。可以获取变量类型所占的内存空间(字节数)
            //sizeof不能得到sting变量的内存大小，因为string的值可变
            int intsize = sizeof(int);
            Console.WriteLine(intsize);
        }
    }
}
