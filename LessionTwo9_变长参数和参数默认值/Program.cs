namespace LessionTwo9_变长参数和参数默认值
{
    internal class Program
    {
        #region 变长参数关键词
        //举例函数要计算 n个整数的和
        //我们不能给函数设定n个形参 这时候就要用变长参数关键词
        //变长参数关键词 params
        static int Sum(params int[] arr)   //代表这是个变成参数 输入的实参都会加入到数组里
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        //params后面必须为数组 
        //数组的类型可以为任意类型
        //函数形参可以有别的类型参数 和params关键词修饰的参数（形参可以混合填）
        //函数形参 最多有一个params修饰的参数 且这个参数只能在最后一个
        #endregion

        #region 参数默认值
        //有参数默认值的参数 一般称为可选参数
        //作用是 当调用函数时 可以不传入参数 不传入会使用默认值作为参数的值
        static void speak(string s = "使用默认参数") 
        {
            Console.WriteLine(s);
        }

        //支持多参数默认值 每个参数都可以有默认值
        //混用可选参数 和普通参数 可选参数要在普通参数后面

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("变长参数和参数默认值");

            Sum(1, 2, 3, 4, 5, 6, 7, 8);//可以加n个实参

            //参数默认值
            speak();
            speak("123");
        }
    }
}
