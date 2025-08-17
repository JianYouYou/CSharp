namespace Lession22_随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("随机数");
            #region 产生随机数对象
            //固定写法
            //Random 随机数变量名 = new Random();
            Random r = new Random();
            //只有变量名是不同的 其他都是写死的
            #endregion

            #region 生产随机数
            int i = r.Next();   //生产一个非负数的随机数
            Console.WriteLine(i);
            //用的比较少 生产的随机数往往过大

            //可自己限定范围
            i = r.Next(100);    //生成一个 0 ~ 99的随机数 
                                //左边始终是0 左包含0 右不包含100
            
            i= r.Next(5,100);   //生产一个5~99的随时数 
                                //同样是左包含5 右不包含99
            #endregion
        }
    }
}
