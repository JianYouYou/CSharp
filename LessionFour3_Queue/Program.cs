using System.Collections;
namespace LessionFour3_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue队列");
            //也是一个object[]数组 封装了特殊存取规则
            //先进先出 先存的先取 后存的后取
            //也需要引用命名空间System.collections
        
            Queue queue = new Queue();

            //增取查改
            //增 .Enqueue()
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue(3);
            queue.Enqueue(true);

            //取 .Deueue()
            //不存在删除的概念 先进先取
            object obj = queue.Dequeue();

            //查 .Peek()
            //只是查看 没有取出
            obj = queue.Peek();
            //也能用contains
            if (queue.Contains("2"))
            {
                Console.WriteLine("存在2");
            }        

            //改
            //一样不能改 只能清空.Clear()

            //遍历
            //长度Count
            //用foreach
            //转换为object数组.ToArray()
            //用while

            //拆箱装箱
        }
    }
}
