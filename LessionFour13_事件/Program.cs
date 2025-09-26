namespace LessionFour13_事件
{
    #region 事件是什么
    //时间是委托的安全包裹 让委托更具有安全性
    //是一种特殊的变量类型
    //作用就是保护委托
    #endregion

    #region 事件的使用
    //访问修饰符 event 委托类型 事件名;

    //事件是 
    //作为成员变量存在与类中
    //委托怎么用 事件就怎么用
    //与委托的区别
    //不能再类外部赋值
    //不能在类为外部调用
    //只能作为成员存在于类和接口以及结构体中
    #endregion
    class Test
    {
        //委托成员变量
        public Action Fun;
        //事件成员变量
        public event Action MyEvent;

        //事件和委托在使用上几乎一模一样
        //增 = +=
        //删 -=
        //清空 = full;
        //使用 事件变量名(); 或 事件变量名.Invoke();

        //些微区别
        //不能在类外部赋值、调用 只能在类里使用
        //但是可以 加减 来添加移除 在类里赋值的函数 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
