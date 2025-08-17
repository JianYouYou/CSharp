namespace Lession16_三目运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("三目运算符");
            #region 基本语法
            //套路 三个空位 两个符号！！！
            //固定语法       空位      ?空位                     ： 空位;
            //关键信息       bool类型  ? bool类型为真是返回的内容  :   bool类型为假是返回的内容;
            //三目运算符 会有返回值 这个返回值类型必须一致 且必须使用
            #endregion

            #region 具体使用
            string str = true ? "条件为真" : "条件为假";
            Console.WriteLine(str);
            str = false ? "条件为真" : "条件为假";
            Console.WriteLine(str);
            //第二三空位 什么表达式都可以 只要 类型与返回类型相同；
            #endregion
        }
    }
}
