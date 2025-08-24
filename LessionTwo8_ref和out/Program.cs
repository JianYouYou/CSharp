namespace LessionTwo8_ref和out
{
    internal class Program
    {

        #region 作用
        //在函数内部改变外部传入的内容 里面变了 外面也要变
        #endregion

        static void ChangeValue(int value)  //这里其实是value = a 并不是让value和a公用一个栈空间
        {                                   //所以ChangeValue(a);再输出a不能让a编程3
            value = 3;
        }
        static void ChangeArrayValue(int[] arr) //这里是arr = array 虽然栈空间不同 但是是公用了一个堆空间 
        {                                       //所以改变arr[0]会改变array[0]            
            arr[0] =99;
        }
        static void ChangeArray(int[] arr) //这里是arr = array 这里new int[]给arr新键了一个堆空间 
        {                                   //所以改变arr改变了但是不会改变array           
            arr = new int[] { 10, 20, 30 };
        }

        #region ref的使用
        static void ChangeValueRef(ref int value)   //使用时也要在参数前加ref
        {
            value = 3;
        }

        static void ChangeArrayRef(ref int[] arr)
        {
            arr[0] = 10;
        }

        #endregion

        #region out的使用
        //out和ref的使用方法一样 都是在形参前面加上关键词out
        static void ChangeValueOut(out int value)   //使用时也要在参数前加out
        {
            value = 100;
        }

        static void ChangeArrayOut(out int[] arr)
        {
            //arr[0] = 10;  这里报错是因为需要完全初始化才行
            arr = new int[]{100,200,300 };
        }
        #endregion

        #region ref和out的区别
        //ref传入的变量必须初始化 out不用
        //out传入的变量必须在内部赋值 ref不用 必须在内部完全初始化

        //ref传入的变量必须初始化 在内部可改可不改
        //out传入的变量不用必须初始化 在内部必须修改
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 1;
            ChangeValue(a);
            Console.WriteLine(a);   //得到a=1 并没有被改变

            int[] array = { 1, 2, 3 };
            ChangeArrayValue(array);
            Console.WriteLine(array[0]);    //得到99 array[0]被改变了

            ChangeArray(array);
            Console.WriteLine(array[0]);    //得到array[0]还是没有被改变

            Console.WriteLine("***********************");

            ChangeValueRef(ref a);
            Console.WriteLine(a);

            ChangeArrayRef(ref array);
            Console.WriteLine(array[0]);

            Console.WriteLine("***********ref和out的区别************");
            int b;
            //ChangeValueRef(ref b);    b必须初始化才能用ref
            ChangeValueOut(out b);    //out不用
            Console.WriteLine(b);

            ChangeArrayOut(out array);
            Console.WriteLine(array[0] + " " + array[1] + " " + array[2]);
        }
    }
}
