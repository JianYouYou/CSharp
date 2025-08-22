namespace LessionTwo2_一维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("一维数组");

            #region 基本概念
            //数组是存储一组相同类型数据的集合
            //数组分为一维 多维 交错数组
            //一维数组简称数组
            #endregion

            #region 数组的申明
            //变量类型[] 数组名;   只是申明了一个数组 没有分配内存空间
            //变量类型 可以是 所有变量类型
            int[] arr1;
            //这里只是申明了一个数组 实际没有内存占用

            //变量类型[]数组名 = new 变量类型[数组的长度]
            int[] arr2 = new int[5];
            //这里申明了一个数组 并分配了内存占用 每个元素都默认初始化为0

            //变量类型[] 数组名 = new 变量类型[数组的长度]{内容1，内容2，内容3....}
            int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
            //如果限定了数组长度 那么申明时 花括号里的内容的数量 要与限定的数量相同

            //变量类型[] 数组名 = new 变量类型[]{内容1，内容2，内容3....}
            int[] arr4 = new int[] { 1, 2, 3, 4, 5, 6};
            //这里没有限定数组长度 编译器会根据你在花括号里给的内容数量分配数组占用的内存

            //int[] 数组名 ={内容1，内容2，内容3....}；
            int[] arr5 = { 1, 2, 3, 4 };
            //更快的申明方式 数组的内存占用根据后面的内容分配；

            //申明数组 早晚都要分配内容 所以一开始就初始化最好
            //内容的类型一定要与变量类型相同

            #endregion

            #region 数组的使用
            int[] array = { 1, 2, 3, 4, 5 };

            //1.数组的长度
            //数组名.Length
            Console.WriteLine(array.Length);
            //可以直接获得数组的长度

            //2.获取数组中的元素
            //数组中的下标和索引 都是从0开始的
            //范围 0 ~ Length-1
            Console.WriteLine(array[2]);
            //打印数组里第3个位置的元素
            //一定不能越界 超出数组的长度

            //3.修改数组中的元素
            //直接赋值
            array[0] = 99;
            Console.WriteLine(array[0]);

            //4.遍历数组 
            //如果数组长度过长 一个个打印不现实
            //通过循环 快熟获取数组中的每一个元素
            //for循环
            Console.WriteLine("****************************");
            for(int i = 0;i<array.Length;i++)
            {
                Console.WriteLine("array数组第{0}个元是：{1}",i,array[i]);
            }

            //5.增加数组的元素
            //数组初始化以后 不能够 直接添加新的元素
            //直接创造一个新的数组
            int[] array2 = new int[6];
            //"搬家"
            for(int i = 0; i<array.Length;i++)
            {
                array2[i] = array[i];
            }
            array = array2;
            array[5] = 999;
            Console.WriteLine(array);
            //这样原有的数组就能存6个元素了 第6个元素被默认初始化为0；
            //运行原理类似与 在内存空间里 新分配了一部分内存 （就是array2申明时分配的内存）
            //让array“指向”新的内存空间 然后原来被“指向”内存空间就会被编译器回收了

            //6.删除数组的元素
            //数组初始化后 不能 删除元素 
            //与5同理
            Console.WriteLine("****************************");
            int[] array3 = new int[5];
            for(int i = 0;i<array.Length;i++)
            {
                array3[i] = array[i];
            }
            array = array3;
            Console.WriteLine(array);

            //7.查找数组中的元素
            //查找某个值在数组中的位置
            //用for循环遍历 然后加上条件运算符
            int i2 = 3;
            for(int i = 0;i< array.Length;i++)
            {
                if (array[i] == i2)
                {
                    Console.WriteLine("和i2相同的元素在第{0}个位置", i);
                }
            }
            #endregion
        }
    }
}
