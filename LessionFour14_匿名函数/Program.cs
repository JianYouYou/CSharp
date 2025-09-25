namespace LessionFour14_匿名函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("匿名函数");

            #region 什么是匿名函数
            //没有名字的函数 
            //配合委托和事件使用 其他地方不会使用
            #endregion

            #region 基本语法
            //delegate (参数列表)
            //{
            //    函数逻辑
            //};
            //函数中传递委托参数时、委托和事件赋值时使用
            #endregion

            #region 使用
            //1.无参无返回
            Action a = delegate ()
            {
                Console.WriteLine("匿名函数逻辑");
            };
            //要注意;！！
            //相当于直接写了个函数直接存在委托里 不需要再给名字
            //这样声明函数 只是再声明 没有调用 ，真正使用的时候是容器被调用时才使用

            //2.有参
            Action<int> a1 = delegate(int i)
            {
                Console.WriteLine("有参");
            };

            //3.有返回值
            //有返回值直接return就行 不用在写 你返回什么类型 他就变成什么类型
            //用Func
            Func<int> a2 = delegate ()
            {
                return 1;
            };

            //4.一般情况作为函数参数传递或者作为函数返回值
            Test test = new Test();
            //参数传递
            test.Dosomething(100, delegate ()
            {
                Console.WriteLine("随参数传入的匿名函数逻辑");
            }
            );
            //将无名函数作为参数 传递给函数的委托参数

            //返回值
            test.GetFun();
            #endregion

            #region 缺点
            //添加到委托或事件容器里 不记录 无法单独移除
            #endregion
        }
    }
    class Test
    {
        public Action action;

        //作为参数传递
        public void Dosomething(int i,Action a)
        {
            Console.WriteLine(i);
            a();
        }
       //作为返回值
       public Action GetFun()
        {
            return delegate(){ Console.WriteLine("在委托里作为返回值的无名函数")};
        }
        
    }
}
