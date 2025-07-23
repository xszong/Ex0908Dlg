using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0908Dlg
{
   class FindNumbers
   {
      //找出偶數
      public void IsEven(params Int32[] numerical)
      {
         Write("偶數值：");
         for (int k = 0; k < numerical.Length; k++)
         {
            //餘數為0
            if (numerical[k] % 2 == 0)
               Write($"{numerical[k],4}");
         }
         WriteLine();   //換行
      }

      //找出奇數
      public void IsOdd(params Int32[] numerical)
      {
         Write("奇數值：");
         for (int k = 0; k < numerical.Length; k++)
         {
            if (numerical[k] % 2 == 1)
               Write($"{numerical[k],4}");
         }
         WriteLine();
      }

      //被3整除的數值
      public void IsDivide3(params Int32[] numerical)
      {
         Write("被3整除的數值：");
         for (int k = 0; k < numerical.Length; k++)
         {
            //被3整除
            if (numerical[k] % 3 == 0)
               Write($"{numerical[k],4}");
         }
         WriteLine();
      }
   }
}
