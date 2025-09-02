namespace LessionThere6_索引器
{
    #region 索引器的基本概念
    //可以让对象像数组一样 可以通过下标索引访问其中的元素 使程序看起来更加客观 更容易编写
    //结构体里可以使用索引器
    #endregion

    #region 索引器语法
    //访问修饰符 返回值 this[参数类型 参数名,参数类型 参数名....] 和函数一样 参数类型什么类型都行
    //{
    //      内部的写法和规则和属性相同
    //      get{}
    //      set{}
    //}


    class Person
    {
        private Person[] friends;
                                        //this 这里和构造函数里的用法一样 自动匹配相应的用法
        public Person this[int index]   //friends是Person类型的数组 所以里面的每一个元素都是Person类型 
        {                               //所以这里的返回类型是Person
            get
            {
                 //索引器里可以写逻辑
                if(friends == null || index >friends.Length-1)
                {
                    return null;
                }
                return friends[index];
            }
            set
            {
                //和成员属性一样value代表传入的值
                friends[index] = value;
            }
        }

        //索引器可以重载
        //函数名相同 参数类型，数量，顺序不同
    }

    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("索引器");
            Person p1 = new Person();
            p1[0] = new Person();
        }
    }
}
