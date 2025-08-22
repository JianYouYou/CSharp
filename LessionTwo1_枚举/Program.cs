namespace LessionTwo1_枚举
{

    #region 基本概念
    //枚举是什么
    //是被命名的整型常量的集合（vector?)

    //申明枚举 申明枚举变量
    //申明枚举是创造一个自定义的枚举类型
    //申明枚举变量 是使用 自定义枚举类型 定义一个变量

    //怎么申明枚举
    //以E或者E_开头 作为命名规范
    //enum E_自定义枚举名
    //{

    //    自定义枚举名字,    //枚举中包裹的 整型常量 第一个默认值是0 下面会依次累加
    //    自定义枚举名字1,   //1
    //    自定义枚举名字2,   //2
    //}

    enum E_自定义枚举名
    {

        自定义枚举名字 = 5,    //可以给赋值 后面依旧累加
        自定义枚举名字1,       //6
        自定义枚举名字2,       //7
        自定义枚举名字3 = 100,  //中途再赋值 后面的累加根据这个新的赋值进行
        自定义枚举名字4,       //101
    }
    #endregion

    #region 在哪里申明
    //在namespace语句块中申明（常用）
    //在class语句块 struct语句块中
    //枚举不能在函数语句块中申明

    //这里只是申明枚举 
    //申明枚举变量 是在main函数里 使用枚举
    enum E_MonsterType
    {
        normol,
        boss,
    }

    enum E_PlayerType
    {
        main,
        other,
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举");
            #region 枚举的使用
            //枚举的使用在main函数体里
            //申明枚举变量
            //枚举变量类型 变量名 = 枚举名.枚举项（枚举里的名字）
            E_PlayerType playerType = E_PlayerType.main;
            if (playerType == E_PlayerType.main)        //判断玩家状态 是哪个玩家
            { 
                Console.WriteLine("主玩家逻辑");
            }
            else if(playerType == E_PlayerType.other)   //枚举变量名 ==枚举项
            {
                Console.WriteLine("其他玩家逻辑");
            }

            //枚举和switch是天生一对
            E_MonsterType MonsterType = E_MonsterType.boss;
            switch (MonsterType)
            {   
                case E_MonsterType.normol:
                    Console.WriteLine("普通怪物逻辑");
                    break;
                case E_MonsterType.boss:
                    Console.WriteLine("精英怪物逻辑");
                    break;
                default:
                    break;
            }
            #endregion

            #region 枚举的类型转换
            //相对来说不常用

            //枚举和int转换
            //使用括号强转
            int i = (int)playerType;    //前面playerType被定义是E_PlayerType.main 被默认赋值0 
            Console.WriteLine(i);       //所以打印出来的i是0
            //int转枚举
            //直接赋值
            playerType = 0;

            //枚举和string转换
            //用ToString()
            string str = playerType.ToString();
            Console.WriteLine(str);

            //把字符串转换成枚举
            Console.WriteLine(playerType);
            playerType = (E_PlayerType)Enum.Parse(typeof(E_PlayerType), "other");
            Console.WriteLine(playerType);
            //Parse 里 第一个参数是 你要转换成的是哪个 枚举类型 第二个参数是 用于转换的对应枚举项的字符串
            //转换完成后是一个通用类型 所以需要加括号强转成我们想要的自定义的枚举类型
            //输出枚举类变量 会自动效用ToString()函数
            #endregion

            #region 枚举的作用
            //在游戏开发中 对象很多时候 会有很多的状态
            //比如玩家 有一个动作状态 我们需要一个变量和标识 用来标识当前玩家是哪种状态
            //综合考虑 可能会考虑使用 int 来标识他的状态
            //比如1 行走 2 跑步。。。
            //枚举能帮助程序员 清晰的分清除状态的含义
            #endregion
        }
    }
}
