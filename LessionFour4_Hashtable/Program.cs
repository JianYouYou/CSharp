using System.Collections;
namespace LessionFour4_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hanstable");
            //哈希表   又称散列表
            //基于键的哈希代码组织起来的 键/值对
            //用来提高数据查询的效率
            //通过键（key）来访问集合中的元素
            //一个键（key）对应一个值（value）
            //通过键算出一个唯一编码 找到对应的值

            //一样需要引用system.collecions
            Hashtable hash = new Hashtable();

            //增删查改
            //增.add(键,值) 
            hash.Add(1,"123");
            hash.Add(2, "456");
            //不能出现相同键 编程是不会报错，但是运算时会，值可以重复
            //hash.Add(1,"1");

            //删 .Remove(键);
            //只能通过键来删除
            hash.Remove(2);
            //删除不存在的键没反应
            //也可以直接清空
            hash.Clear();

            //查
            //数组形式 中括号内为键 
            hash.Add(1,"1");
            hash.Add(2,"2");
            hash.Add(3,"3");
            hash.Add(4,"1");
            Console.WriteLine(hash[1]);
            //找不到会返回空
            Console.WriteLine(hash[99]);//null
            //查看是否存在
            //键是否存在
            if (hash.Contains(1))
            {
                Console.WriteLine("存在建值为1的键");
            }
            if (hash.ContainsKey(2))
            {
                Console.WriteLine("存在建值为2的键");
            }

            //值是否存在
            if (hash.ContainsValue("1"))
            {
                Console.WriteLine("存在值为1的值");
            }

            //改
            //只能改键对应的值 不能改键
            hash[1] = "100";

            //遍历
            //得到所有的键值对 对数
            Console.WriteLine(hash.Count);

            //遍历所有的键
            foreach(Hashtable h in hash.Keys)
            {
                Console.WriteLine("键：{0}",h);
                Console.WriteLine("值：{0}", hash[h]);
            }
            Console.WriteLine("华丽分割线");
            //遍历所有值
            foreach(Hashtable h in hash.Values)
            {
                Console.WriteLine("值：{0}", h);
            }

            //键值一起遍历
            foreach(DictionaryEntry h in hash)  //DictionaryEntry是个结构体 存的键和值 ，迭代器会讲
            {
                Console.WriteLine("键：{0}值：{1}",h.Key,h.Value);
            }

            //迭代器遍历法 之后讲迭代器会明白
            IDictionaryEnumerator myenumerator = hash.GetEnumerator();
            bool flag = myenumerator.MoveNext();
            while (flag)
            {
                Console.WriteLine("键：" + myenumerator.Key + "值：" + myenumerator.Value);
                flag = myenumerator.MoveNext();
            }
        }
    }
}
