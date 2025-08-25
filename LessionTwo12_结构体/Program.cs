namespace LessionTwo12_结构体
{
    #region 基本概念
    //是一种自定义变量类型 类似枚举需要自己定义
    //他是数据和函数的集合
    //在结构体里 可以声明各种变量和函数方法

    //用来标识存在关系的数据集合 
    #endregion
    #region 基本语法
    //写在namespace命名空间里
    //关键字struct
    //命名用帕斯卡命名 首字母全大写
    struct JieGouTi
    {
        //第一部分 
        //变量

        //第二部分
        //结构体

        //第三部分
        //函数
    }

    #endregion
    #region 实例

    #region 访问修饰符
    //修饰结构体里变量和函数 是否能被外部使用 
    //public    公共的 可以被外部访问
    //private   私有的 只能在内部使用
    //不写 默认为private

    #endregion

    struct Student
    {
        //结构体里声明的变量不能初始化
        public int ages;
        public bool sex;
        public int number;
        public string name;
        //结构体内可以声明任意类型 包括结构体 但是不能是自己
        //Student s;

        //主要用来表现 数据结构的行为的
        //结构体声明函数 不需要加static
        //结构体内的函数可以使用结构体声明的变量
        public void Speak()
        {
            Console.WriteLine("我的名字是{0}我今年{1}岁",name,ages);
            //这里可以直接用结构体声明的变量
        }
        #region 构造函数
        //构造函数一般用来方便初始化 不用在命名一个一个赋值
        //构造函数没有返回值
        //函数名必须和结构名相同
        //必须有参数
        //如果声明了构造函数 那么必须在其中对所有变量数据出书哈
        public Student(int ages,bool sex,int number,string name)
        {
            //区分变量是 构造函数自己的变量 还是 外部传入的变量 
            //用this 就能区分
            this.ages = ages;
            this.sex = sex;
            this.number = number;
            this.name = name;
            //加了this.的就是构造函数自己形参的变量
            //后面没加的就是结构体声明的变量
        }

        //构造函数也可以重载
        #endregion


    }


    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("结构体");
            #region 结构体的使用
            //声明变量 
            //变量类型 + 变量名
            Student s1;
            s1.ages = 21;
            Student s2 = new Student(21,true,10,"简由由");
            s2.Speak();
            #endregion
        }
    }
}
