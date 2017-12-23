
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
         Clipboard.SetText(csetTopBottom);
      }

      private void cOpyLeftRight(object obj)
      {
         Clipboard.SetText(csetLeftRight);
      }
   }
}
