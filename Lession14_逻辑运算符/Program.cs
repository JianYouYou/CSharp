namespace Lession14_逻辑运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("逻辑运算符");
            //对bool类型进行逻辑运算
            //优先度 逻辑运算符 低于< 条件运算符 低于< 算术运算符
            //可以解决条件运算符无法进行多位运算的缺点（一个表达式同时比两次）
            #region 逻辑与
            //符号 &&
            //规则 都为真时为真 有一个假就为假 同真为真
            bool result = true && false;
            Console.WriteLine(result);
            result = true && true;
            Console.WriteLine(result);
            //两边变量的类型 ： bool变量 条件运算符
            int i = 1;
            result = i < 2 && i > 0;
            Console.WriteLine(result);

            //多个逻辑与 结合运用
            int i2 = 5;
            result = i2 < 2 && i2 > 0 && i2 < 5 && i2 > 5;
            //false && true && false && false;
            Console.WriteLine(result);
            //先将条件运算符运算完 再进行逻辑运算符的比较；
            #endregion
            Console.WriteLine("*****************************");
            
            #region 逻辑或
            //符号 ||
            //规则 有真就为真 同假为假
            result = true || false;
            Console.WriteLine(result);
            result = true || true;
            Console.WriteLine(result); 
            result = false || false;
            Console.WriteLine(result); 
            result = false || true;
            Console.WriteLine(result);
            //同样可以多个逻辑或同时使用
            #endregion
            Console.WriteLine("*****************************");

            #region 逻辑非
            //符号 !
            //规则 对bool值取反 真变假 假变真
            //放在bool值前 变量前 条件表达式前
            result = !true;
            result = !(3 > 2);    //逻辑非的优先级较高 用在条件表达式之前需要将表达式用括号括起

            #endregion
            Console.WriteLine("*****************************");

            #region 混合使用时 优先级问题
            //优先级 逻辑非(!) >条件运算符 > 算术运算符 > 逻辑与(&&) > 逻辑或(||)
            #endregion

            #region 逻辑运算符的短路规则
            int i3 = 1;
            // ||有真为真 左边i3 > 0已经为真 右边的++i3就不在进行运算
            result = i3 > 0 || ++i3 >= 1;
            Console.WriteLine(i3);

            Console.WriteLine("*****************************");
            #region question
            //前面所讲 多个运算符同时使用时 会将条件运算全部运算完再进行逻辑运算符
            //那这里的短路规则是如何进行的
            //AI解读 在复杂表达式中，当逻辑运算符左侧满足短路条件时，​右侧的自增运算不会执行。
            int i4 = 2;
            result = i4 > 0 && i4 > 1 || ++i4 > 1 && i4 > 2;    //i4 = 2; result = true
            //全部运算完在比较  true   true    true    true 此时得到 true 但是为什么i4 != 3;
            Console.WriteLine(i4);
            Console.WriteLine(result);
            #endregion
            #endregion


        }
    }
}
