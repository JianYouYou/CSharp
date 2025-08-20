namespace Execise3_营救公主
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 设定固定游戏界面
            //不变的游戏界面
            //设定控制台面积
            Console.SetWindowSize(50, 27);
            //设定缓冲区面积
            Console.SetBufferSize(50, 27);
            //清空游戏界面
            Console.Clear();
            //隐形指针
            Console.CursorVisible = false;
            #endregion

            #region 主界面
            int input = 0;      //根据input的值改变 判断按下空格时的功能
            int last = 0;       //根据last不同 分流是开始界面 还是结束界面
            while (true)
            {
                //当last = 0 时 input = 0 进入游戏亮 input = 1 退出游戏亮
                if (last == 0)
                {
                    if (input == 0)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(21, 8);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("进入游戏");
                        Console.SetCursorPosition(21, 10);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("退出游戏");
                        Console.SetCursorPosition(19, 12);
                        Console.WriteLine("按下空格选择");
                    }
                    if (input == 1)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(21, 8);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("进入游戏");
                        Console.SetCursorPosition(21, 10);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("退出游戏");
                        Console.SetCursorPosition(19, 12);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("按下空格选择");
                    }
                }
                //当last = 1 时 input = 0 返回主界面亮 input = 1 退出游戏亮
                if (last == 1)
                {
                    if (input == 0)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(21, 8);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("回到主界面");
                        Console.SetCursorPosition(21, 10);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("退出游戏");
                        Console.SetCursorPosition(19, 12);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("按下空格选择");
                    }
                    if (input == 1)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(21, 8);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("回到主界面");
                        Console.SetCursorPosition(21, 10);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("退出游戏");
                        Console.SetCursorPosition(19, 12);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("按下空格选择");
                    }
                }
                //读取用户输入 w上移 上面的选项亮 s下移 退出游戏亮
                char c1 = Console.ReadKey(true).KeyChar;
                switch (c1)
                {
                    case 'W':
                    case 'w':
                        input = 0;
                        continue;
                    case 'S':
                    case 's':
                        input = 1;
                        continue;

                    //用户输入' '空格 进行交互

                    //判断last等于多少 ==0 说明是处在开始界面 
                    //判断是否input == 0，为0说明是与上面选项（开始游戏）交互
                    //否则就是 退出游戏亮时交互 退出程序

                    //如果last != 0 说明是结束界面
                    //判断 input是否为0 为0说明是与上面选项（回到主界面）交互
                    //break回到开始
                    //否则就是 退出游戏亮时交互 退出程序
                    case ' ':
                        if (last == 0)
                        {
                            #region 进入游戏
                            if (input == 0)
                            {
                                #region 游戏界面

                                #region 设置战斗界面
                                //设置游戏边界
                                Console.Clear();
                                Console.WriteLine(" ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                                for (int i = 1; i < 20; i++)
                                {
                                    Console.WriteLine(" ■                                               ■");
                                }
                                Console.WriteLine(" ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                                for (int i = 1; i < 4; i++)
                                {
                                    Console.WriteLine(" ■                                               ■");
                                }
                                Console.WriteLine(" ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                                #endregion

                                #region 设置boss位置
                                //设计Boss
                                Console.SetCursorPosition(25, 15);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write('■');
                                #endregion

                                #region 设置玩家位置
                                //设置玩家颜色
                                Console.ForegroundColor = ConsoleColor.Green;
                                //设置玩家初始位置
                                int x = 25;
                                int y = 5;
                                //设置玩家位置
                                Console.SetCursorPosition(x, y);
                                #endregion

                                int gamePlay = 0;       //当玩家移动到boss四个方向之一的位置时 gamePlay = 1 开始进行战斗

                                while (true)
                                {
                                    #region 设置战斗
                                    //设置boss和player属性
                                    int bossHP = 20;
                                    int bossATK;
                                    int bossDEF = 10;
                                    int playerHP = 20;
                                    int playerATK;
                                    int playerDEF = 20;
                                    Random r = new Random();
                                    Random r1 = new Random();
                                    //触发战斗
                                    if (gamePlay == 1)
                                    {
                                        Console.SetCursorPosition(x, y);
                                        Console.Write("■");
                                        //对话框发出战斗开始提示
                                        Console.SetCursorPosition(3, 21);
                                        Console.Write("战斗开始！！！        按J进行攻击");

                                        while (bossHP > 0 && playerHP > 0)
                                        {
                                            //识别玩家输入攻击键j
                                            char atk = Console.ReadKey(true).KeyChar;
                                            switch (atk)
                                            {
                                                case 'j':
                                                case 'J':
                                                    bossATK = r.Next(18, 23);
                                                    playerATK = r1.Next(8, 13);
                                                    int playerDMG = playerATK - bossDEF;
                                                    int bossDMG = bossATK - playerDEF;

                                                    if (playerDMG > 0)
                                                    {
                                                        bossHP = bossHP - playerDMG;
                                                        Console.SetCursorPosition(3, 22);
                                                        Console.Write("打中了！造成{0}点伤害，boss血量剩余{1}         ", playerDMG, bossHP);
                                                    }
                                                    else
                                                    {
                                                        Console.SetCursorPosition(3, 22);
                                                        Console.Write("未能击破地方护甲                        ");
                                                    }
                                                    if (bossDMG > 0)
                                                    {
                                                        playerHP = playerHP - bossDMG;
                                                        Console.SetCursorPosition(3, 23);
                                                        Console.Write("被击中！收到{0}点伤害，player血量剩余{1}      ", bossDMG, playerHP);
                                                    }
                                                    else
                                                    {
                                                        Console.SetCursorPosition(3, 23);
                                                        Console.Write("我们抵挡了一次攻击                      ");
                                                    }
                                                    break;
                                            }

                                        }
                                        last = 1;
                                        input = 0;
                                        if (bossHP <= 0)
                                        {
                                            Console.Clear();
                                            Console.SetCursorPosition(21, 8);
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("成功！！");
                                            char c2 = Console.ReadKey(true).KeyChar;
                                            break;
                                        }
                                        if (playerHP <= 0)
                                        {
                                            Console.Clear();
                                            Console.SetCursorPosition(21, 8);
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("失败。。");
                                            char c2 = Console.ReadKey(true).KeyChar;
                                            break;
                                        }
                                    }
                                    #endregion

                                    #region 玩家移动
                                    Console.SetCursorPosition(x, y);
                                    Console.Write("■");
                                    char c = Console.ReadKey(true).KeyChar;
                                    Console.SetCursorPosition(x, y);
                                    Console.Write("  ");
                                    switch (c)
                                    {
                                        case 'W':
                                        case 'w':
                                            if (x == 25 && y == 16)
                                            {
                                                Console.Write("■");
                                                gamePlay = 1;
                                                continue;
                                            }
                                            y = y - 1;
                                            if (y < 1)
                                            {
                                                y = 1;
                                            }

                                            continue;
                                        case 'A':
                                        case 'a':
                                            if (x == 27 && y == 15)
                                            {
                                                gamePlay = 1;
                                                continue;
                                            }
                                            x = x - 2;
                                            if (x < 3)
                                            {
                                                x = 3;
                                            }
                                            continue;
                                        case 'S':
                                        case 's':
                                            if (x == 25 && y == 14)
                                            {
                                                gamePlay = 1;
                                                continue;
                                            }
                                            y = y + 1;
                                            if (y > 19)
                                            {
                                                y = 19;
                                            }
                                            continue;
                                        case 'D':
                                        case 'd':
                                            if (x == 23 && y == 15)
                                            {
                                                gamePlay = 1;
                                                continue;
                                            }
                                            x = x + 2;
                                            if (x > 47)
                                            {
                                                x = 47;
                                            }
                                            continue;
                                    }
                                    #endregion

                                }
                                #endregion
                            }
                            #endregion

                            
                            else
                            {   
                                #region 退出游戏
                                Environment.Exit(0);
                                #endregion
                            }
                            
                        }
                        else
                        {
                            if(input == 0)
                            {
                                last = 0;
                                break;
                            }
                            else 
                            {
                                Environment.Exit(0);
                            }
                        }
                            break;
                }
            }
            #endregion


        }
    }
}