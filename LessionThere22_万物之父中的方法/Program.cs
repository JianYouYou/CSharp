namespace LessionThere22_万物之父中的方法
{
    class Test
    {
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父中的方法");
            //基类里的静态方法
            //Equals    判断两个对象是否相等
            //最终的判断权交给左侧对象的Equals方法
            //不管是值类型还是引用类型 都会按照左侧对象Equals方法的规则来进行比较
            //判断引用类型是判断他们的是否指向同一个堆内存
            //使用方法
            Console.WriteLine(Object.Equals(1, 1));
            Test t = new Test();
            Test t1 = new Test();
            Console.WriteLine(Object.Equals(t,t1));
            //静态方法RefereenceEquals
            //比较两个对象是否是相同的引用 只要用来比较引用类型的对象
            //给两个值类型一定会返回false
            //使用方法
            Test t2 = t;
            Console.WriteLine(Object.Equals(t,t2));
            //因为Object是所有类的基类
            //所以使用时可以不加Object.前缀，但用的时候要知道
            Console.WriteLine(Equals(1, 1));

            //普通方法GetType
            //在反射相关知识点中非常重要（还没学） 
            //得到对象运行是的类型Type
            //不要用来比值
            Type ty = t.GetType();
            //普通方法MenberwiseClone
            //用于得到对象的浅拷贝对象 
            //返回一个新的对象
            //新对象中的引用对象和老对象一致，
            //相当于新对象 拷贝了 老对象的 的引用类型 他们指向的是同一个堆

            //Object里的虚方法
            //虚方法Equals
            //比较两个对象是否为同一个引用 相当于 ReferenceEquals
            //微软在所有值类型的基类System.ValueType中重写了该方法 用来比较值相等
            
            //GetHashCode
            //几乎用不到
            //获取对象的哈希码
            //每个对象的唯一编码
            //也可以自己重写

            //ToString
            //用于返回当前对象代表的字符串
            //非常常用
        }
    }
}
