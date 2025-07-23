using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;  // 引入静态 Console 类，方便使用 WriteLine 等方法

namespace Ex0908Dlg
{
    class Program
    {
        // 1. 定义一个委派（delegate），名为 Speculation，接收一个 Int32[] 类型的参数（整数数组），无返回值
        public delegate void Speculation(Int32[] numerical);

        static void Main()   // 主程序入口点
        {
            // 建立一个整数数组 figures，里面包含10个元素
            Int32[] figures =
               {21, 32, 33, 142, 115, 125, 317, 188, 192, 420};

            // 建立 FindNumbers 类的对象，用于调用判断方法
            FindNumbers searchNum = new FindNumbers();

            // 2. 使用 FindNumbers 类的方法创建委派对象
            // 3. 创建委派对象（单一任务），最初指向 IsEven 方法（找出偶数）
            Speculation evenPredicate = new Speculation(searchNum.IsEven);

            // 3.1 将更多方法添加到委派中，形成多播委派（Multicast Delegate）
            //     后续会依序调用 IsEven、IsOdd、IsDivide3 方法
            evenPredicate += searchNum.IsOdd;
            evenPredicate += searchNum.IsDivide3;

            // 4. 调用委派方法，传入整数数组作为参数
            //     三个方法会依序执行，分别处理数组中的数
            evenPredicate(figures);

            // 按任意键结束程序
            ReadKey();
        }
    }
}
