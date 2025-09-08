namespace LessionThere11_内部类和分布类
{    //相比之前的学习 这节不怎么重要
    #region 内部类
    //内部类 
    //在类里再声明一个类
    //使用时 要用包裹者点明自己
    //亲密关系的体现
    //访问修饰符的作用很大

    //套娃 人有身体 身体是一个类 身体上有四肢 四肢又是一个类
    class Person
    {
        public Body body;
        //在类里再写一个类
        public class Body
        {
        }
    }
    #endregion

    #region 分布类
    //把一个类分成几部分声明
    //分部分描述一个类
    //关键词
    //partial 在类前写
    //分布类可以写在多个脚本里
    //分布类的访问修饰符需要一致
    //分布类里不能有重复类型
    #endregion

    #region 分布方法
    //将方法的声明和实现分离
    //与CPP里 声明和定义分开 相似

    //在一个类里声明
    //在另一个分布类里实现
    //也比较鸡肋 懂就行

    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("内部类和分部类");
            #region 内部类的使用
            //使用内部类需要用上级套娃点出来
            Person LuRen = new Person();
            Person.Body body = new Person.Body();
            //可以用 但非必要用 直接把套娃的类和上一级套娃写在同一级可能用 
            #endregion

        }
    }
}
