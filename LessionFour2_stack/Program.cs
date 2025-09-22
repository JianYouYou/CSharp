using System.Collections;
namespace LessionFour2_stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stack");
            //stack是CSharp封装好的类
            //本质也是object[]数组 知识封装了特殊的存储规则
            //是一个先进后出的数据结构
            //一个弹匣 存只能从后面存，一个子弹一个子弹压（压栈） 取只能从后面取 一发一发打出去 最后才打出第一个压的子弹
            //和Arraylast一样 需要引用命名空间System.Collections;d

            Stack stack = new Stack();

            //增取查改
            //增(压栈) .push() 一个一个放 一个一个取
            stack.Push("123");
            stack.Push("456");

            //取(弹栈) .pop() 栈不存在删 只有取
            //需要定义一个新的变量存取出来的变量
            object obj = stack.Pop();
            Console.WriteLine(obj);

            //查 
            //.peek() 栈无法查看指定位置的元素 只能查看栈顶的 只是看 没有取
            obj = stack.Peek();
            //查看元素是否存在与栈中
            //Arraylast一样 用contains
            if (stack.Contains("123"))
            {
                Console.WriteLine("存在123字符串");
            }

            //改
            //栈无法改变其中的元素 只能压(存)和弹(取)
            //实在要改 只有清空 .Clear();
            stack.Clear();
            stack.Push("123");
            stack.Push("456");


            //遍历
            //长度
            Console.WriteLine(stack.Count);

            //用foreach遍历
            //遍历的顺序也是从栈顶到栈底
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
            //把栈转成一个object数组 然后用for循环
            //遍历出来的顺序也是从栈顶到栈底
            object[] obj1 = stack.ToArray();

            Console.WriteLine("华丽分割线");
            //循环弹栈
            //用while
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            //装箱拆箱
            //和Arraylist一样
            //存值类型是装箱
            //取值类型是拆箱
            
        }
    }
}
