namespace LessionTwo3_二维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("二维数组");

            #region 二位数组的声明
            //变量类型[ , ] 二维数组变量名;
            int[,] arr;
            //变量类型[,] 二维数组变量名 = new 变量类型[行,列];
            int[,] arr1 = new int[3, 3];
            //变量类型[,] 二维数组变量名 = new 变量类型[行,列]{{第0行的内容0,第0行的内容1,第0行的内容2},
            //                                              {第1行的内容0,第1行的内容1,第1行的内容2},
            //                                              {第2行的内容0,第2行的内容1,第2行的内容2}};
            //与一维数组一样 行列下标都是从0开始比如arr[1,0];其实是第二行的第一个；
            int[,] arr2 = new int[3, 3] { { 1, 2, 3},
                                          { 4, 5, 6 },
                                          { 7, 8, 9 } };
            //不给具体的行列数
            //变量类型[,] 二维数组变量名 = new 变量类型[,]{{第0行的内容0,第0行的内容1,第0行的内容2},
            //                                              {第1行的内容0,第1行的内容1,第1行的内容2},
            //                                              {第2行的内容0,第2行的内容1,第2行的内容2}};
            int[,] arr3 = new int[,] { { 1, 2, 3},
                                       { 4, 5, 6 },
                                       { 7, 8, 9 } };
            //直接加花括号
            //变量类型[,] 二维数组变量名 = {{第0行的内容0,第0行的内容1,第0行的内容2},
            //                            {第1行的内容0,第1行的内容1,第1行的内容2},
            //                            {第2行的内容0,第2行的内容1,第2行的内容2}};
            int[,] arr4 = { { 1, 2, 3},
                            { 4, 5, 6 },
                            { 7, 8, 9 } };
            #endregion

            #region 如何使用二维数组
            //1.二维数组的长度
            int[,] array = { { 1, 2, 3 },
                             { 4, 5, 6 }, };
            //分别获取行和列
            //得到多少行
            Console.WriteLine(array.GetLength(0));
            //得到多少列
            Console.WriteLine(array.GetLength(1));

            //2.获取二维数组中的元素
            //与一维数组一样 用索引获取
            //要注意行列都是以0开始 以Length-1为最大
            Console.WriteLine(array[1, 2]);
            //这里得到的是array二维数组的第二列的第三行的元素试 是6

            //3.修改二维数组中的元素
            array[0, 0] = 100;
            Console.WriteLine(array[0, 0]);

            //4.遍历二维数组
            //循环包循环 先遍布第0列 然后再遍历第1列
            Console.WriteLine("************************");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }

            //数组声明初始化之后不能增加 删除元素了
            //5.增加数组的元素
            //声明一个新的更大的二维数组 然后把原来小的数组的元素输入到新的数组
            //然后令小数组 = 大数组 就能实现增加数组元素的功能
            Console.WriteLine("************************");
            int[,] array1 = new int[3, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = array[i, j];
                }
            }
            array = array1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
            //6.删除数组的元素

            //6.1 只删除后面的
            Console.WriteLine("************************");
            int[,] array2 = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2[i, j] = array[i, j];
                }
            }
            array = array2;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
            //想删除某位置的元素 只要将循环条件改变 就能实现特定的删除元素
            //比如 想删除第1列的第2行元素
            int[,] array3 = new int[2, 3];
            for(int i = 1;i < 2; i++)
            {
                for(int j = 2;j < 3; j++)
                {
                    array3[i,j] = array[i,j+1];
                }
            }
            //6.2 只删除前面的
            //6.3 只删除中间的
            //7.查找数组的元素

            #endregion
        }
    }
    }

