using System.Collections;

namespace LessionFour1_Arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arraylist");
            //是一个封装好的类 
            //本质是Object类型的数组
            //可以进行增删查改操作
            //声明
            ArrayList array = new ArrayList();
            //Arraylist在System.Collections命名空间里 使用需要using该命名空间

            //增
            array.Add(1);   //因为Arraylist是Object类型的 所以可以所有类型的变量
            array.Add(2345);
            array.Add("123");
            array.Add(new object());  //引用类型也能存
            //还可以拼接 将一个Arraylist的内容全部接到另一个Arraylist里
            ArrayList array2 = new ArrayList();
            array2.AddRange(array);
            //插入
            array.Insert(0, "123");    //在前面的位置 插入后面的值
            
            //删
            //移除指定元素 从头找 找到删
            array.Remove(1);
            //移除指定位置的元素
            array.RemoveAt(0);
            //清空 全部移除
            //array.Clear();

            //查
            //得到指定位置的元素
            Console.WriteLine(array[0]);
            //查看元素是否存在
            if (array.Contains("123")) 
            {
                Console.WriteLine("存在123");
            }
            //正向查找元素位置
            //找到 返回值 是位置 找不到 返回值是-1
            int index = array.IndexOf("123");
            Console.WriteLine(index);
            //反向查找元素位置
            int lastindex = array.LastIndexOf("123");
            Console.WriteLine(lastindex);
            //从后面开始找 但是位置是正向数的

            //改
            Console.WriteLine(array[0]);
            array[0] = "9";
            Console.WriteLine(array[0]);

            Console.WriteLine("华丽分割线");
            //遍历
            //传统方法for循环遍历
            Console.WriteLine(array.Count);     //获得长度
            Console.WriteLine(array.Capacity);  //获得容量
            for(int i = 0;i < array.Count;i++) 
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("华丽分割线");
            //新方法迭代器循环  后面学习迭代器
            foreach (object item in array)     //每次循环都把array的每一个变量都依次取出来放到item里
            {
                Console.WriteLine(item);
            }

            //拆箱 装箱
            //Arraylist本质上是一个object类型的数组
            //所以往里输入值类型是装箱 取出值类型相当于拆箱
            //Arraylist少用 后面会学习更好的数据容器
        }
    }
}
