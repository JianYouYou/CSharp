namespace Title1_通过W_A_S_D控制一个黄色方块移动
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
                //第一种清空之前信息的方式
                //Console.Clear();
                Console.SetCursorPosition(X, Y);
                Console.Write("■");
                char a = Console.ReadKey(true).KeyChar;

                //第二种方式 将上一个方块擦除
                Console.SetCursorPosition(X, Y);
                //将光标移到上一个方块打印的位置
                Console.Write("  ");
                //■在控制台占两个位置 所以这用两个空格代替
                //使用空格将上一个方块擦除 然后进入下一次循环    
                //相比第一种方式 第二种方式不会使控制台闪烁

                //question 用空格擦除方块不会导致光标错位吗 
                //打印空格之后 光标也会向后移动一个 此时光标还是在上一个方块打印结束后光标在的位置
                switch (a)
                {
                    case 'w':
                    case 'W':
                        Y = Y - 1;
                        if (Y < 0)
                        {
                            Y = 49;     //我们设置了竖的窗口大小和缓冲区大小为50 但是我们是从0开始计数的 所以Y最大49
                        }               //X同理
                        continue;
                    case 'a':
                    case 'A':
                        X = X - 2;      //y只-1 但是 x-2 是为了立体上使黄色方块横向移动的距离更合适
                        if (X < 0)      //误打误撞 ■ 是中文字符 在控制台里占2位置 x-2 更合适
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
                //我的思路是当方块移动出缓冲区 就从另一边出来
                //比如整蛊游戏《level devil》里的一关 门在最右边 玩家只需要往左走就能从传送到右边
                //课程讲的第二种边界问题解决办法 使方块停在原地
                //
                //switch (a)
                //{
                //    case 'w':
                //    case 'W':
                //        Y = Y - 1;
                //        if (Y < 0)
                //        {
                //            Y = 0;
                //        }
                //        continue;
                //    case 'a':
                //    case 'A':
                //        X = X - 2;
                //        if (X < 0)
                //        {
                //            X = 0;
                //        }
                //        continue;
                //    case 's':
                //    case 'S':
                //        Y = Y + 1;
                //        if (Y > 49)
                //        {
                //            Y = 49;
                //        }
                //        continue;
                //    case 'd':
                //    case 'D':
                //        X = X + 2;
                //        if (X > 199)
                //        {
                //            X = 199;
                //        }
                //        continue;
                //}
                        
            }
        }
    }
}
