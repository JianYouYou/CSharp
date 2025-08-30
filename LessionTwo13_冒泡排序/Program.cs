namespace LessionTwo13_冒泡排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("冒泡排序");

            #region 排序的基本概念
            //将一组"无序"的记录序列 调整为"有序"的记录序列
            //9 7 2 3 4 5 8 1
            //变为(升序或降序)
            //1 2 3 4 5 7 8 9
            //9 8 7 5 4 3 2 1

            //在程序中 序列一般存储在数组中
            //所以 排序 往往是对数组进行排序
            #endregion

            #region 基本原理
            //8 7 1 5 4 2 6 3 9 
            //两两相邻 不停比较 不停交换 比较n轮
            //每一都是i和i+1 然后 i++

            #endregion

            #region 代码实现
            //int[] arr = { 1, 3, 6, 2, 6, 5, 3, 7, 9, 4 };
            //for (int m = 1; m < arr.Length; m++)
            //{
            //    for (int i = 1; i < arr.Length - 1; i++)
            //    {
            //        int temp = arr[i];
            //        if (arr[i] > arr[i + 1])
            //        {
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //优化 
            //确定位置的数不必再比较
            //确定一轮后 极值（最大或最小） 已经放到了对应的位置
            //所以 每完成1轮 就可以少循环1轮
            //每完成一大轮 每个小轮就少循环1遍

            //int[] arr = { 1, 3, 6, 2, 6, 5, 3, 7, 9, 4 };
            //for (int m = 1; m < arr.Length; m++)
            //{
            //    for (int i = 1; i < arr.Length - 1 - m; i++)//优化：再减一个m
            //    {
            //        int temp = arr[i];
            //        if (arr[i] > arr[i + 1])
            //        {
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //特殊情况的优化
            //如果数组为：9 1 2 3 4 5 6 7 8
            //进行一次大循环就完成了 但是程序仍然会进行后续的循环
            //会浪费性能
            //可以添加一个条件判断是否进行了交换语句 如果没有进入就直接跳出循环

            int[] arr = { 1, 3, 6, 2, 6, 5, 3, 7, 9, 4 };

            for (int m = 1; m < arr.Length; m++)
            {
                bool what = false;
                for (int i = 1; i < arr.Length - 1 - m; i++)//优化：再减一个m
                {
                    int temp = arr[i];
                    if (arr[i] > arr[i + 1])
                    {
                        what = true;
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                    
                }
                if (!what)
                {
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion
        }
    }
}
