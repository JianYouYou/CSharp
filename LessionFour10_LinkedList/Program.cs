using System.Collections.Generic;
namespace LessionFour10_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList");

            //也是一个CSharp风霜好的类
            //是一个可变类型的泛型双向链表
            //需要命名空间system.collections.generic

            LinkedList<int> ilink = new LinkedList<int>();
            LinkedList<string> slink = new LinkedList<string>();

            //增
            //1.在链表尾部添加元素
            ilink.AddLast(10);
            //2.在链表头部添加元素
            ilink.AddFirst(1);
            ilink.AddLast(20);
            ilink.AddLast(30);
            //下面两个可以结合查找功能来使用
            //3.在某一个节点之前添加节点 .AddBefore(位置,值)
            LinkedListNode<int> n = ilink.Find(20);
            ilink.AddBefore(n, 15);
            //4.在某一个节点之后添加节点 .AddAfter(位置,值)
            ilink.AddAfter(n, 25);

            //删
            //1.移除头节点
            slink.RemoveFirst();
            //2.移除尾节点
            slink.RemoveLast();
            //3.移除指定节点
            //无法通过位置直接移除 这里是删除指定元素节点
            ilink.Remove(20);
            //4.清空 .Clear()
            //查
            //1.头节点 .First
            LinkedListNode<int> first = ilink.First;
            //2.尾节点
            LinkedListNode<int> last = ilink.Last;
            //3.无法找指定值的节点 不能通过下标查找指定位置元素 
            //只能通过遍历查找
            LinkedListNode<int> node = ilink.Find(30);
            //找不到会返回空

            //改
            //要先得再改 得到节点 再改变其中的值 节点.Value
            Console.WriteLine(ilink.First.Value);
            ilink.First.Value = 100;
            Console.WriteLine(ilink.First.Value);

            //遍历
            //foreach 
            foreach (int item in ilink)  //这里直接得到了节点里的值value 通过迭代器
            {
                Console.WriteLine(item);
            }
            //通过节点遍历
            //和上节课程的while遍历一样 是用官方封装好的代码
            //从头到位
            //先得到头节点
            Console.WriteLine("华丽分割线");
            LinkedListNode<int> nowNode = ilink.First;
            while (nowNode != null)
            { 
                Console.WriteLine(nowNode.Value);
                nowNode = nowNode.Next;     //表示下一个节点
            }
            //从尾到头
            Console.WriteLine("华丽分割线");
            nowNode = ilink.Last;
            while (nowNode != null)
            {
                Console.WriteLine(nowNode.Value);
                nowNode = nowNode.Previous; //表示上一个节点
            }
        }
    }
}
