namespace Lession21_控制台相关代码
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("控制台相关");

            //输入 补充
            //在Console.ReadKey() 括号里输入true 
            //在控制台进行输入 随便输入一个键后 直接结束进程 但是不会将输入的键显示出来
            //char c = Console.ReadKey(true).KeyChar;
            //但是输入的键依旧会存入c
            //Console.ReadLine();
            #region 控制台其他方法
            //一. 清空 clear
            Console.Clear();    //擦黑板

            //二设置控制台大小
            //设置 窗口大小缓冲区大小
            //注意
            //1.先设置窗口大小 再设计缓冲区大小
            //2.缓冲区大小不能小于窗口大小
            //3.窗口大小不能大于缓冲区最大大小

            //设置窗口大小
            Console.SetWindowSize(100, 50);

            //设置缓冲区大小       //buffer 缓冲
            Console.SetBufferSize(100, 50);

            //设置光标位置
            //左上角为原点(0 0 ) 右侧为x轴正方向 下方围殴y轴正方向 他是一个平面二位坐标系
            //注意：
            //1.边界问题 一定在缓冲区内进行设置
            //2.横轴距离单位不同 1y = 2x 视觉上的
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("123");

            //设置颜色相关
            //文字颜色设置        foreground 前景   consolecolor表示颜色
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1245");
            //设置一次颜色之后的所有文字都变色了
            //设置背景颜色
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //更换背景颜色之后需要 clear一次之后 才能全部变色

            //光标显隐
            //设置光标是否显示
            Console.CursorVisible = false;
            //true显示 false隐形
            //Cursor 光标 Visible 可见

            //关闭控制台
            Environment.Exit(0);
            //调试模式下不会自动关闭
            #endregion

        }
    }
}
