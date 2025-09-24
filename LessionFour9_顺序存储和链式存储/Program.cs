namespace LessionFour9_顺序存储和链式存储
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("顺序存储和链式存储");

            //数据结构
            //相互存在一种或多种特定关系的数据元素的集合
            //简单点理解 是人定义的 存储数据 和表示的数据之间关系 的规则
            //数组 栈 堆 队列 链表 树 图 散列表

            //线性表
            //是一种数据结构 是有n个具有详细特性的数据元素的有限序列
            //代表:数组 Arraylist Queue Stack 链表

            //顺序存储
            //数组 Stack Queue List ArrayList 
            //用一组 地址连续的 存储单元 依次存储 线性表的各个数据元素
            //就像种地 一个坑一个坑的挖 一个坑一个坑放种子 坑之间是连续的 

            //链式存储
            //单向列表 双向链表 循环链表 
            //用一组 任意的存储单元 存储线性表中的各个元素 地址不连续 但是能从上家找到下架  
            //原理像CPP里的指针,
            //有自己的链表节点(地址) 存有自己的数据 有下一个元素的链表节点

            //单向只能从上家找下家
            //双向链表能找上家 

            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            //遍历list 因为我们自己写的没有封装遍历函数 所以需要用循环遍历
            LinkedNode<int> node = list.head;
            while (node.nextnode != null)
            { 
                Console.WriteLine(node.Value);
                node = node.nextnode;
            }
            list.Remove(2);
            Console.WriteLine("华丽分割线");
            node = list.head;
            while (node.nextnode != null)
            {
                Console.WriteLine(node.Value);
                node = node.nextnode;
            }

            //顺序存储和链式存储的优缺点
            //增:链式存储 计算上 优于顺序存储(中间插入时链式不用像顺序一样去移动位置)
            //删:链式存储 计算上 优于顺序存储(中间删除时链式不用像顺序一样去移动位置)
            //查:顺序存储 使用上 优于链式存储(数组可以直接通过下标得到元素，链式需要遍历）
            //改:顺序存储 使用上 优于链式存储(数组可以直接通过下标得到元素，链式需要遍历)

        }
    }
    #region 写一个自己的单向链表
    class LinkedNode<T>  //链表节点类 只是一个节点 
    {
        //自己的数据
        public T Value;
        //下一节点的链表节点(地址)
        public LinkedNode<T> nextnode;
        //构造函数 声明节点变量时赋值
        public LinkedNode(T Value)
        {
            this.Value = Value;
        }
    }
    class LinkedList<T>  //链表管理 一个节点系统 是一整个链表 而不是一个节点
    {
        public LinkedNode<T> head;      //head是头 确定之后只有删除节点时使用
        public LinkedNode<T> last;      //last是中间值 在我们ADD或REMOVE时会改变
        //增加节点
        public void Add(T Value)
        {
            LinkedNode<T> node = new LinkedNode<T>(Value);
            if (head == null)
            {
                head = node;
                last = node;
            }
            else
            {
                last.nextnode = node;   //这个意思就是 让上一节点的nextnode指向node node是一个新的LinkedNode变量 
                last = node;            //每个LinkedNode都有一个nextnode节点变量 这里用last.nextnode = node;就是让上一个节点的下一节点引用改为node这个新建的节点 
                                        //然后在把last = node;意思这个新建的node就是最新的最后节点
                                        //节点类里是没有head和last的 这是单向链表 所以每个节点变量都有的nextnode的作用是引用下一个节点
            }
        }
        public void Remove(T Value)
        {
            //节点系统没有节点
            if (head == null)
            {
                return;
            }
            //删除的节点是头节点
            if (head.Value.Equals(Value)) //因为用的泛型 可能不支持重载运算符
            {
                head = head.nextnode;
                //如果头节点被删除 头节点为空了 说明链表里只有一个节点 那么尾节点也要为空
                if (head == null)
                {
                    last = null;
                }
            }
            //删除的是中间节点
            //设立一个新节点 来从头遍历所有节点 找到对应的数据的节点进行删除
            LinkedNode<T> node = head;
            while (node.nextnode != null)   //只要遍历的下一节点不为空就能继续遍历
            {
                if (node.nextnode.Value.Equals(Value))    //匹配数据
                {
                    node.nextnode = node.nextnode.nextnode;
                    break;
                }
                //如果数据没有匹配成功 使node向后节点移动 （循环条件+1）
                node = node.nextnode;
            }
        }
    }
    #endregion

}
