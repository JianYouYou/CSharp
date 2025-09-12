namespace LessionThere17_多态Vob
{
    //让继承同一父类的子类 在执行相同方法是有不同的表现
    //让同一个对象有唯一行为的特征

    class Father
    {
        public void SpeekName()
        {
            Console.WriteLine("Father的名字");
        }
    }
    class Son : Father
    {
        public void SpeekName()
        {
            Console.WriteLine("Son的名字");
        }
    }

    //运行时多态（vob，抽象函数，接口）
    //正经来说没有vob的说法
    //virtual 虚函数           虚函数可以被子类重写
    //override 重写           在子类 重写父类的函数前加上
    //base 父类               用来表示父类
    class GameObject
    {
        public virtual void ATK()
        {
            //加上virtual表示是虚函数
            Console.WriteLine("游戏对象ATK");
        }
        //虚函数的目的就是给子类重写
    }
    class Player : GameObject
    {
        public override void ATK()
        {
            //加上override 表示重写虚函数 子类有不一样的表现
            //base的作用是代表父类 通过base保留父类的行为 执行一次父类的虚函数
            base.ATK();
            Console.WriteLine("子类ATK");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("多态Vob");
            Father f = new Son();
            f.SpeekName();
            //在编译时f为Father类型
            (f as Son).SpeekName();
            //将f转换为Son
            GameObject Player = new Player();
            Player.ATK();
        }
    }
}
