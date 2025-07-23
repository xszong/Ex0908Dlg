using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;  // 引入 Console 静态成员，方便直接使用 Write、WriteLine 等方法

namespace Ex0908Dlg
{
    // 定义一个名为 FindNumbers 的类，用于处理数字判断
    class FindNumbers
    {
        // 方法一：找出偶数
        // 使用 params 让方法可以接收任意数量的整数作为参数
        public void IsEven(params Int32[] numerical)
        {
            Write("偶數值：");
            for (int k = 0; k < numerical.Length; k++)
            {
                // 若数字除以2余数为0，则为偶数
                if (numerical[k] % 2 == 0)
                    Write($"{numerical[k],4}");  // 右对齐输出，占4个字符宽度
            }
            WriteLine();   // 输出完后换行
        }

        // 方法二：找出奇数
        public void IsOdd(params Int32[] numerical)
        {
            Write("奇數值：");
            for (int k = 0; k < numerical.Length; k++)
            {
                // 若数字除以2余数为1，则为奇数
                if (numerical[k] % 2 == 1)
                    Write($"{numerical[k],4}");  // 格式同上
            }
            WriteLine();  // 输出完后换行
        }

        // 方法三：找出能被3整除的数字
        public void IsDivide3(params Int32[] numerical)
        {
            Write("被3整除的數值：");
            for (int k = 0; k < numerical.Length; k++)
            {
                // 如果数字能被3整除（余数为0）
                if (numerical[k] % 3 == 0)
                    Write($"{numerical[k],4}");  // 格式同上
            }
            WriteLine();  // 输出完后换行
        }
    }
}
