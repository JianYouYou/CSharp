namespace LessionThere2_成员变量和访问修饰符
{
    //声明在类类语句块中
    //用来描述对象的特征
    //可以是任何类型
    //数量没有限制
    //是否赋值根据需求来定
    class Person
    {
        //访问修饰符
        //public--公共的 自己（内部）和别人（外部）都能访问和使用
        //private--私有的 自己（）内部能使用 别人（外部）不能访问和使用
        //protected--保护的 自己（内部）和子类才能访问和使用
        //声明成员变量不设定访问修饰符 默认为private
        //特征--成员变量
        //血量
        public int HP;
        //姓名
        public string Name = "clark";
        //防御
        public int DEF;
        //攻击力
        public int ATK;
        //女朋友
        //在类中声明一个和自己相同类型的成员变量时 
        //不能对他进行实例化（初始化）
        public Person GridFriend;
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员变量和访问修饰符");
            //声明不初始化 会进行默认初始化
            //值类型 整型这类的都是0 bool是false
            //引用类型的是 null
            //看默认初始化给的值的技巧(default(变量类型))
            Console.WriteLine(default(int));
            Console.WriteLine("*********************");
            //使用成员变量
            Person clark = new Person();
            clark.HP = 100;
            Console.WriteLine(clark.HP);
        }
    }
}
