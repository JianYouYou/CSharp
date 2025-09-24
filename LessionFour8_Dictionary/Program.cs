using System.Collections.Generic;
namespace LessionFour8_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary");
            //可以理解为拥有泛型的Hanstable(哈希表) 是字典 一种数据结构
            //键值的类型 从object 变为了可以自己制定的泛型
            //需要命名空间System.Collections.Generic;

            Dictionary<int,string> test = new Dictionary<int,string>();

            //增删查改
            //增 .Add();
            //不能出现相同键
            test.Add(1, "frist");
            test.Add(2, "secend");
            
            //删 .Remove()
            //删除不存在的键 没有反应
            test.Remove(1);
            //清空 .Clear();

            //查 
            //通过键查看值 变量名[键名];
            //找不到报错  而HansTable找不到只会返回空！！
            Console.WriteLine(test[2]);
            //Console.WriteLine(test[3]); 不存在键值为3的键值对 运行会报错
            //查看是否存在
            //通过键 if + 变量名.ContainsKey(键值)
            if (test.ContainsKey(2))
            {
                Console.WriteLine("存在键值为2的键对值，为：{0}",test[2]);
            }
            //通过值 if + 变量名.ContainsValue(值)
            if (test.ContainsValue("second"))
            {
                Console.WriteLine("存在值为second的键值对");
            }

            test.Add(3, "123");
            //改
            //变量名[键值] = 值;
            Console.WriteLine("华丽分割线");
            Console.WriteLine(test[3]);
            test[3] = "456";
            Console.WriteLine(test[3]);

            //遍历
            //遍历所有键
            foreach(int item in test.Keys)
            {
                Console.WriteLine(item);
                Console.WriteLine(test[item]);  //遍历所有键的同时把键对应的值也打印出来 是键值一起遍历的一种方法
            }
            //遍历所有值
            foreach(string item in test.Values)
            {
                Console.WriteLine(item);
            }
            //键值一起遍历
            foreach (KeyValuePair<int, string> item in test)
            { 
                Console.WriteLine("键：{0}值：{1}",test.Keys,test.Values);
            }


        }
    }
}
