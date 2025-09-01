namespace LessionThere3_成员方法_函数_
{
    //成员方法声明在类里
    //用来描述对象的行为
    //规则和函数声明规则相同
    //受到访问修饰符规则影响
    //返回值参数不做影响
    //方法数量不做限制

    //成员方法不能加static关键词
    //必须实例化对象再通过对象来使用 相当于对象执行了某个行为

    class Person
    {
        //小习惯：方法写前面 变量写后面
        public void Speak(string str)
        {
            Console.WriteLine("{0}说{1}",name,str);
        }
        
        public bool IsAdult()
        {
            return age >= 18;
        }

        public void AddFriend(Person p)
        {
            if (Friends == null)
            { 
                Friends = new Person[] { p };
            }
            else
            {
                Person[] NewFriend = new Person[Friends.Length + 1];
                for(int i = 0; i < Friends.Length; i++)
                {
                    NewFriend[i] = Friends[i];
                }
                NewFriend[NewFriend.Length -1] = p;
                Friends = NewFriend;
            }
            Console.WriteLine("现在{0}有{1}个朋友",name,Friends.Length);

        }
        public string name;
        public int age; 
        public Person[] Friends;
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("成员方法函数");
            //成员方法的使用
            //必须先实例化出对象 再通过对象来使用 相当于该对象执行力某个行为
            Person p1 = new Person();
            p1.name = "clark";
            p1.age = 20;
            p1.Speak("我是超人");
            if (p1.IsAdult()) 
            {
                p1.Speak("我成年了");
            }
            Person p2 = new Person();
            p2.name = "陆仁嘉";
            p1.AddFriend(p2);
            for (int i = 0; i < p1.Friends.Length; i++)
            {
                Console.WriteLine(p1.Friends[i].name);
            }
        }
    }
}
