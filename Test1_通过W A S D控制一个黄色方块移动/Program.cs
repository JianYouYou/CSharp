namespace Test1_通过W_A_S_D控制一个黄色方块移动
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //通过W A S D控制一个黄色方块移动
            //  while switch 输入输出
            //设置文字颜色
            //光标隐形
            //循环设置光标位置 WS上下移动 AD左右移动

            //设置缓冲区大小
            Console.SetBufferSize(200, 50);
            //设置窗口大小
            Console.SetWindowSize(200, 50);

            //设置背景颜色
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            //设置文字颜色
            Console.ForegroundColor = ConsoleColor.Yellow;

            //设置光标初始位置
            int X = 100;
            int Y = 25;
            Console.SetCursorPosition(X, Y);
            //不会打印正方形 P代表 Player

            //光标隐形
            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(X, Y);
                Console.Write("■");
                char a = Console.ReadKey(true).KeyChar;
                switch (a)
                {
                    case 'w':
                    case 'W':
                        Y = Y - 1;
                        if (Y < 0)
                        {
                            Y = 49;     //我们设置了竖的窗口大小和缓冲区大小为50 但是我们是从0开始计数的 所以最长49
                        }               //X同理
                        continue;
                    case 'a':
                    case 'A':
                        X = X - 2;
                        if (X < 0)
                        {
                            X = 199;
                        }
                        continue;
                    case 's':
                    case 'S':
                        Y = Y + 1;
                        if (Y > 49)
                        {
                            Y = 0;
                        }
                        continue;
                    case 'd':
                    case 'D':
                        X = X + 2;
                        if (X > 199)
                        {
                            X = 0;
                        }
                        continue;
                }
            }
        }
    }
}
