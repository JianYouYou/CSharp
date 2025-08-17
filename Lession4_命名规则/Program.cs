namespace lession4_命名规则
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 命名规则
            //1.不能以数字开头
            //2.不能有特殊符号，可以用下划线（_）
            //3.不能重名
            //4.不能用程序关键字命名
            //5.体现变量作用
            //6.不要用汉字
            #endregion

            #region 命名法
            //规则：
            //驼峰命名法：第一个单词小写，之后的单词首字母大写
            string myName = "简由由";
            string myReallyName = "殷超越";
            //帕斯卡命名法：所有单词首字母大写 (一般用在函数、类的命名)
            string MyName = "简由由";
            #endregion

            #region 练习题
            //按照驼峰命名法命名以下变量(使用英文)
            //我的年龄、我的性别、我的攻击力、我的防御力、你的身高、你的体重
            byte myAge = 21;
            char mysex = '男';
            double myAttackPower = 5.0;
            double myDefenseCapability = 10.0;
            float myHeight = 180.0f;
            float myWeight = 220.0f;
            #endregion

        }
    }
}
