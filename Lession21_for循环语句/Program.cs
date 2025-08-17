namespace Lession21_for循环语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for循环语句");

            #region 语法
            //for (初始表达式;条件表达式;增量表达式 )
            //{
            //      循环语句
            //}
            //初始表达式：声明一个 临时 变量 用来计数用
            //条件表达式：表明进入循环的条件
            //增量表达式:对临时变量进行自增减

            //第一次进入循环 才开始调用初始表达式
            //每次进入循环之前都通过条件表达式进行判断
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("打印{0}遍",i);
            }
            //执行完循环语句块中的逻辑后 最后执行增量表达式

            //初始表达式里进行临时变量的定义 可以用一条语句连续定义多个变量
            //int i = 1, j = 2;
            //条件表达式 只要结果式bool类型结果的表达就行
            //增量表达式 是在每次循环之后做的事 不一定是自增或自减 什么都行
            #endregion

            #region 支持嵌套
            //for(; ; )
            //{
            //    for(; ; )
            //    { 
            //    }
            //}
            //可以嵌套其他的语句
            #endregion

            #region 特殊写法
            //可以写死循环
            //for(; ; )
            //{
            //    Console.WriteLine("这是for死循环");
            //}
            //三个位置都能为空
            #endregion

            #region 对比while循环
            //for循环 一般用来可以准确得到 一个范围中的所有数
            int sum = 0;
            for (int i = 0;i <=10000;i++) 
            {
                sum += i;
            }
            Console.WriteLine(sum);
            //for循环之后更常用
            //选择合适的循环 最大程度优化
            #endregion
        }
    }
}
