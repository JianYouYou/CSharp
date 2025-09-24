using System.Collections.Generic;
namespace LessionFour7_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List");
            //是一个封装好的类
            //本质是一个可变类型的泛型数组
            //泛型数组的增删查改

            //声明
            //需要用System.Collections.Generic;
            //是什么类型 泛型替换符写什么类型
            List<int> list = new List<int>();
            List<string> list2 = new List<string>();

            //增删查改和ArrayList的代码一样
            //增
            //.Add()
            list.Add(1);
            list2.Add("123");
            //将一个泛型数组 全部加到另一个泛型数组里面
            //.AddRange(泛型数组);
            List<int> list3 = new List<int>();
            list.Add(2);
            list3.AddRange(list);

            //删
            //移除指定元素 .Remove(指定元素)
            //移除指定位置的元素 .RemoveAt(位置)
            //清空 .Clear()

            //查
            //得到指定位置的   泛型数组名[位置]
            //查看元素是否存在 if函数 + 泛型数组名.contains(指定元素)
            //正向查找元素 .Indexof(指定元素) 找到返回位置 没找到返回-1
            //反向查找元素 .LastIndexof(指定元素) 找到返回位置 没找到返回-1

            //改
            //泛型数组名[位置] = 数值; 即可

            //遍历
            //长度 .Count
            //容量 .Capacity  避免存储垃圾

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
