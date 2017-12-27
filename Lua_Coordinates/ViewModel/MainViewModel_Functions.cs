
using System;
using System.Linq;
using System.Windows;

namespace Lua_Coordinates
{
   /// <summary>
   /// 
   /// </summary>
   public partial class MainViewModel
   {

      private void cOpyTopBottom(object obj)
      {
         if(nameLeft=="" || nameLeft==null)
         {
            Clipboard.SetText(csetTopBottom);
         }
         else
         {
            Clipboard.SetText(nameLeft + ":setTopBottom(" + csetTopBottom + ")");
         }
      }

      private void cOpyLeftRight(object obj)
      {
         if (nameLeft == "" || nameLeft == null)
         {
            Clipboard.SetText(csetLeftRight);
         }
         else
         {
            Clipboard.SetText(nameLeft + ":setLeftRight(" + csetLeftRight+")");
         }
      }

      private void cOpyBoth(object obj)
      {
         if (nameLeft == "" || nameLeft == null)
         {
            Clipboard.SetText(csetLeftRight+ Environment.NewLine + csetTopBottom);
         }
         else
         {
            Clipboard.SetText(nameLeft + ":setLeftRight(" + csetLeftRight + ")" + Environment.NewLine + "\t" + nameLeft + ":setTopBottom(" + csetTopBottom + ")");
         }
      }
   }
}
