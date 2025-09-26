using System.Collections.Generic;
namespace LessionFour16_List排序
{
    #region 自己定义的类
    //自己写的类 想要实现排序 需要继承Icomparable接口 并实现排序方法
    class Test : IComparable<Test>  //带<>是泛型接口 有不带<>的非泛型 ，但是泛型更灵活
    {
        public int value;

        public Test(int value)
        {
            this.value = value;
        }

        public int CompareTo(Test other)
        {
            //返回值
            //小于0
            //放在传入对象的前边
            //等于0
            //原位不变
            //大于0
            //放在传入对象后面

            //简单理解为 一维坐标轴 传入对象在原点0 根据返回值不同 放在相应的位置
            if (this.value > other.value)
            {
                return 1;
            }
            else
            {
                return -1;
            }
            //这里if else语句可以用三目运算符
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List排序");
            #region List自带的排序
            // .sort();
            List<int> ints = new List<int>();
            ints.Add(4);
            ints.Add(2);
            ints.Add(1);
            ints.Add(3);
            ints.Add(6);
            ints.Add(5);
            for (int i = 0; i < ints.Count; i++)
            {
                Console.WriteLine(ints[i]);
            }
            ints.Sort();
            Console.WriteLine("华丽分割线");
            for (int i = 0; i < ints.Count; i++)
            {
                Console.WriteLine(ints[i]);
            }
            #endregion

            #region 自己定义的类排序
            Console.WriteLine("华丽分割线");
            List<Test> values = new List<Test>();
            values.Add(new Test(20));
            values.Add(new Test(70));
            values.Add(new Test(10));
            values.Add(new Test(90));
            values.Sort();
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine(values[i].value);
            }
            #endregion

            #region 通过委托函数进行排序
            Console.WriteLine("华丽分割线");

            //写一个委托函数 在委托里实现比较 用Sort(委托函数);调用这个委托
            //还可以用匿名函数 在Sort()括号里实现 
            //更简单是用lambad 匿名的delagate都不用
            #endregion

        }
    }
}
