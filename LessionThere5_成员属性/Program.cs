namespace LessionThere5_成员属性
{
    #region 成员属性的概念
    //成员属性用来保护成员变量
    //为成员属性的获取和赋值添加逻辑
    //解决3P的局限性
    //能让成员属性在外部
    //只能获取 不能修改 或者 只能修改 不能获取

    //基本语法
    //访问修饰符号 属性类型 属性名
    //{
    //      get{}
    //      set{}
    //}

    #endregion

    #region 成员属性的声明
    class Person
    {
        private string name;
        private int money;
        private int height;
        //属性名使用帕斯卡命名法
        public string Name
        {
            get
            {
                //意味着 这个属性可以获取的内容
                //可以在返回之前添加一些逻辑规则
                return name;
            }
            set
            {
                //可以在设置之前添加一些逻辑规则
                //value 关键词 表示 外部传入的值 这里是传入给Name的
                //传入数据类型 需要和 返回值的类型相同
                name = value;
            }
        }

        public int Money
        {
            get
            {
                //这里的代码可以进行加密处理
                return money;
            }
            set
            {
                //加密处理 
                //想传进的值是 5 但实际传入内存的不是 5 可以防止用户修改数据 保护成员属性
                //例如用CE 搞修改器 风灵月影这一块

                if (money < 0)
                {
                    money = 0;
                    //让money不会为负
                }
                money = value;
            }
        }

        #region 成员属性加访问修饰符
        //成员属性中get 和 set 前可以加访问修饰符
        //默认不加 会使用声明属性是的 访问权限
        //加的访问修饰符要 低于属性的访问权限
        //不能让get 和 set的访问权限都低于属性

        //关于访问修饰符的高低
        //public > private

        //get 和 set 可以只有一个

        //自动属性
        //类中有一个特性 只希望外部能得不能改的 也没什么特殊处理
        //就可以使用自动属性
        public int Height
        {
            //大括号都不加 
            //自动生产成员变量来存内容和输出内容
            get;
            private set;
            //这样就实现了外部只能得不能改
            //反过来就是外部只能改不能得 
        }
        #endregion

    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员属性");

            //成员函数的使用
            Person p1 = new Person();
            p1.Name = "clark";
            //这句话执行的是 将clark这个数据 通过set 传入给name
            Console.WriteLine(p1.Name);
            //这句话执行的则是 通过 get 将name输出；
        }
    }
}
