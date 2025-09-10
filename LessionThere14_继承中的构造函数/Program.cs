namespace LessionThere14_继承中的构造函数
{
    //当声明一个子类对象时
    //先执行父类的构造函数 
    //然后执行子类的构造函数
    //执行顺序
    //父类的父类构造函数 -> 父类的构造函数 -> 子类的构造函数

    class GameObject
    {
        public GameObject()
        {
            Console.WriteLine("GameObject构造");
        }
        public GameObject(string name) 
        {
            Console.WriteLine(" GameObject name = {0}",name);
        }
    }
    class Player : GameObject
    {
        public string name = "玩家";
        //父类的无参构造函数很重要
        //因为声明一个子类的对象后会执行父类以及父类的父类的构造函数
        //如果有一个父类构造了有参构造函数但是没有额外构造一个无参构造函数 就会导致报错
        //子类无法执行父类的无参构造函数 就无法向下继续运行
        public Player()     //如果父类没有无参构造函数这里就会报错
        {
            Console.WriteLine("Player构造");
        }
        //子类可以通过 base关键词代表父类 调用父类的构造函数
        //base 用法相似与 构造函数的 this
        //this 调用自己的 构造函数
        //base 调用父类的 构造函数
        //这样其实不算在子类里重载构造函数 如果子类只有这一个base调用 是不会让子类默认的 无参构造函数消失
        public Player(string name) : base(name)
        {
            this.name = name;
            Console.WriteLine("Player name = {0}",name);
        }
    }
    class MainPlayer : Player
    {
        public MainPlayer()
        {
            Console.WriteLine("MainPlayer构造");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承中的构造函数");

            MainPlayer p = new MainPlayer();
            Player p1 = new Player("玩家");

        }
    }
}
