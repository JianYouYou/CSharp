using static System.Net.Mime.MediaTypeNames;

namespace Execise2_唐老狮打小怪兽
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //唐老狮打小怪兽
            //唐老狮攻击力为8~12之间的一个值
            //小怪兽防御为10，血量为20
            //在控制台中通过打印信息表现
            //唐老狮打小怪兽的过程描述小怪兽的掉血情况
            //伤害计算公式:攻击力小于防御力时，减血为0，否则减血攻击力和防御力的差值
            //知识点:循环、随机数等等

            //设置随机唐老狮攻击力
            Random r = new Random();
            //设置怪兽的防御与血量
            int DEF = 10;
            int HP = 20;
            //设置回合数
            int Turn = 1;
            //循环攻击过程
            while (HP >= 0)
            {
                int ATK = r.Next(8, 13);
                Console.WriteLine("**************Turn{0}**************",Turn);
                Console.WriteLine("唐老师  -)===> 小怪兽");
                int DMG = ATK - DEF;
                Turn++;
                if (DMG > 0)          //也可以不定义DMG直接在条件里填写ATK > DEF条件表达式  DMG = ​Damage 伤害
                {
                    Console.WriteLine("唐老狮打出了{0}点伤害",DMG);
                    Console.WriteLine("小怪兽HP-{0}",DMG);
                    HP = HP - DMG;
                    if (HP <= 0)
                    {
                        Console.WriteLine("小怪兽HP=0;");  //如果HP<0下面的打印会打印负数,这里检测HP<=0 然后直接打印HP=0并break
                        Console.WriteLine("小怪兽被消灭了");
                        break;
                    }
                    Console.WriteLine("小怪兽HP={0}",HP);
                }
                else 
                { 
                    Console.WriteLine("MISS");
                }

            }
        }
    }
}
