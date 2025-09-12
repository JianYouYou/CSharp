namespace LessionThere18_抽象类和抽象方法
{

    //关键字abstract
    //不能被实例化
    //可以包含抽象方法
    //继承抽象类必须重写抽象方法

    //抽象方法 用关键字abstract修饰
    //只能在抽象类里声明
    //一定没有方法体
    //不能是私有的
    //继承后必须实现
    //用override重写
    //纯虚方法 子类必须实现
    
    //虚方法可以不被实现 但纯虚方法必须实现

    abstract class Thing
    {
        //抽象类的子类必须实现
        //在抽象类里声明的抽象方法
        public abstract void Test();
    }
    class Water : Thing
    {
        public override void Test() //实现抽象父类的抽象方法 需要加上override 所以抽象方法被称为纯虚方法 
        {
            Console.WriteLine("如果不在子类实现父类的抽象方法就会报错");
        }
    }
    class NotCleanWater : Water
    {
        public override void Test()
        {
            Console.WriteLine("抽象类的抽象方法不能跨代实现");
        }
    }
    //抽象方法可以不断在后续子类里重载
        
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("抽象类和抽象方法");
            //抽象类不能实例化
            //Thing thing = new Thing();
            //但是可以用里氏替换法，用父类装子类
            Thing water = new Water();
        }
    }
}
