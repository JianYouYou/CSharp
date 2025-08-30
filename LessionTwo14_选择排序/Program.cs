namespace LessionTwo14_选择排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("选择排序");
            #region 选择排序的基本原理
            //建立中间商 依次比较 找出极值 放入目标位置 比较n轮
            //建一个索引 指向第n个元素 
            //用循环 大循环n次
            //每个大循环建立一个索引
            //从第i个(i = 0)开始 往后依次比 找到最大的 然后放到第n个位置

            int[] arr = { 1, 4, 6, 9, 3, 5, 2, 6 };
            //循环依次确定一个极值 所以第m次循环 极值放的位置是arr.Length - m;
            for (int m = 0; m < arr.Length; m++)
            {
                //声明一个中间商 索引
                int index = 0;
                //找最大值
                //已经固定的值不需要再比较一次 进行一大轮就确定一个 所以-m
                for (int n = 1; n < arr.Length - m ; n++)
                {
                    if (arr[index] < arr[n])
                    {
                        index = n;
                    }
                }

                //将极大值放在第arr.Length - m位置上
                //判断得出的极值是否已经在该在的位置 不需要换 比如得到的最大值（9）就在最后一个
                if (index != arr.Length - 1 - m )
                {
                    int temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - m];
                    arr[arr.Length - 1 - m] = temp;

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
