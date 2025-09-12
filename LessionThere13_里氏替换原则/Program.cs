namespace LessionThere13_李氏替换原则
{

    //面向对象七大原则
    //任何父类出现的地方 子类都可以代替
    //父类容器装子类对象 因为子类对象包含了父类的所有内容
    //方便进行对象储存和管理

    class GameObject
    {

    }
    class Player : GameObject
    {
        public void PlayerAtk()
        {
            Console.WriteLine("Player攻击");
        }
    }
    class Monster : GameObject
    {
        public void MonsterAtk()
        {
            Console.WriteLine("Monster攻击");
        }
    }
    class Boss : GameObject
    {
        public void BossAtk()
        {
            Console.WriteLine("Boss攻击");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("里氏替换原则");
            //如何使用
            //用父类容器 装 子类对象  任何父类可以出现的地方  都可以用子类代替
            GameObject Player = new Player();
            GameObject Monster = new Monster();
            GameObject[] Object = new GameObject[] {new Player(), new Monster(),new Boss()};    //只要是父类能出现的地方都能用子类代替
            //这里的对象的类型涉及到多态的知识点 在编译时是GameObject类型 在运行时是Player类型 
            //所以不能使用Player类里的方法

            //基本语法 
            //类对象 is 类名 
            //类对象 as 类名
            //is
            //判断一个对象是否为指定类对象
            //返回值为bool
            //这里is判断的是类对象在 运算时 是否为指定类 
            //但是因为继承类的多态性问题 比如这里的 Player 在运行时确实是 Player 但是他在编译时是 GameObject类型
            if (Player is GameObject)
            {
                //用来判断某对象是否为指定类 的对象
                Console.WriteLine("1");
                //因为多态 这里Player在编译时是GameObject类型 在运行时是Player类型
                //所以都会输出1
            }
            //as
            //将一个对象转换为指定类对象
            //返回值为指定类对象
            //失败返回为null
            Player p = Player as Player;
        }
    }
}
