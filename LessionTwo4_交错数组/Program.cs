namespace LessionTwo4_交错数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("交错数组");
            #region 基本概念
            //不常用 非重点
            //是数组的数组 每个维度的数量可以不同
            //交错数组每行的列数可能不同
            //二维数组每行的列数必须相同
            //交错数组可能有一行多一列 有一行少一列

            //和CPP里的多维数组一样 每行都是一个一维数组
            #endregion

            #region 交错数组的声明
            //变量类型[][] 交错数组名
            int[][] arr1;

            //变量类型[][] 交错数组名 = new 变量类型[行数][]; 
            //因为列数不同 所以不能写死列
            int[][] arr2 = new int[3][];

            //变量类型[][] 交错数组名 = new 变量类型[行数][]{一维数组1，一维数组2，}; 
            int[][] arr3 = new int[3][] { new int[]{1,2,3},
                                          new int[]{4,5,},
                                          new int[]{6}};

            //变量类型[][] 交错数组名 ={一维数组1，一维数组2，}; 
            int[][] arr4 = { new int[]{1,2,3},
                             new int[]{4,5,},
                             new int[]{6}};
            #endregion

            #region 数组的使用
            int[][] array = { new int[]{ 1, 2, 3 },
                              new int[]{ 4, 5},
                              new int[]{ 6 } };
            //1.数组的长度
            //先获得行数 然后获取每行的列数
            Console.WriteLine(array.GetLength(0));
            Console.WriteLine(array[0].Length);

            //2.获得数组的元素
            Console.WriteLine(array[0][1]);

            //3.修改数组的元素
            array[0][2] = 33;

            //4.遍历交错数组
            //使用长度函数 和 循环函数
            Console.WriteLine("******************************");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]);
                }
                Console.WriteLine();
            }
            //增加元素
            //声明一个大的新交错数组 然后用for循环将小数组赋值到大数组
            //删除元素
            //声明一个小的新交错数组 然后用for循环将大数组赋值到小数组
            //查找元素
            //用for循环遍历整个数组 并用if函数进行查找元素
            #endregion
        }
    }
}
