using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0908Dlg
{
   class Program
   {
      //1.定義委派，含有一個引數(數值)
      public delegate void Speculation(Int32[] numerical);

      static void Main()   //主程式
      {
         //建立一個陣列
         Int32[] figures =
            {21, 32, 33, 142, 115, 125, 317, 188, 192, 420};

         //建立物件
         FindNumbers searchNum = new FindNumbers();

         //2.FindNumbers類別所列示的方法成員
         //3.宣告委派物件-單一任務
         Speculation evenPredicate = new Speculation(searchNum.IsEven);

         //3.1 委派多重任務
         evenPredicate += searchNum.IsOdd;
         evenPredicate += searchNum.IsDivide3;

         //4.呼叫委派方法並以陣列為參數
         evenPredicate(figures);

         ReadKey();
      }
   }
}
