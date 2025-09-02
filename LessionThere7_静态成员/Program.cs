namespace LessionThere7_静态成员
{
    #region 静态成员
    //关键字 static
    //用static修饰的就是静态成员 成员变量 方法 属性
    //直接用类名.出就能使用的就是静态成员

    //静态成员在程序开始运行时就会分配空间
    //同生共死
    //静态成员具有唯一性和全局性
    //因为静态从程序开始就会分配空间所以会占用大量内存
    //所以不能全都用
    #endregion

    #region 自定义静态成员
    class Test
    {

        //静态变量
        public static float PI = 3.1415927f;
        //成员变量
        public int i = 100;
        //静态成员方法
        public static float Mianji(float x)
        {
            //静态成员里面不能用非静态对象 因为非静态对象需要实例化才能用
            //i     会直接报错
            //硬用的话 就直接在里面实例化一个新类对象
            Test t = new Test();
            Console.WriteLine(t.i);

            //反过来非静态函数可以直接使用静态函数
            //因为静态函数从程序一开始就已经有了具体内存
            return x * x * PI;

        }
        //成员方法
        public void Nothing()
        {
            Console.WriteLine("这就是一个成员方法");
        }

        public const float G = 1;//常量必须初始化
    }
    #endregion

    #region 静态变量的作用
    //常用唯一变量的声明
    //方便别人获取的对象声明
    //静态方法 
    //常用的唯一的方法声明 比如 数学计算函数
    #endregion

    #region 常量和静态变量
    //常量可以理解为特殊的静态变量
    //相同点：
    //都可以用类名.使用
    //不同点：
    //const必须初始化且不能修改
    //const只能修饰变量 static可以修饰很多
    //const必须写在访问修饰符后面 static没有这个要求
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("静态成员");
            //使用静态成员
            Test.Mianji(2); //静态成员不需要实例化就能用
                            //不需要实例一个类变量然后用.运算符访问 可以直接用类名. 

            //非静态对象需要先实例化对象
            Test t1 = new Test();
            t1 .Nothing();


        }
    }
}
