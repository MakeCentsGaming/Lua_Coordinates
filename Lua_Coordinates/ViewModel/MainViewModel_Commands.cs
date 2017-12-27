using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lua_Coordinates
{
   public partial class MainViewModel
   {

      /* Exmaple
      private ICommand pClose;
      /// <summary>
      /// 
      /// </summary>
      public ICommand CmdClose
      {
         get { return pClose = new DelegateCommand(fnClose); }
      }
      */

      private ICommand copyTopBottom;
      /// <summary>
      /// 
      /// </summary>
      public ICommand CopyTopBottom
      {
         get { return copyTopBottom = new DelegateCommand(cOpyTopBottom); }
      }

      
      private ICommand copyLeftRight;
      /// <summary>
      /// 
      /// </summary>
      public ICommand CopyLeftRight
      {
         get { return copyLeftRight = new DelegateCommand(cOpyLeftRight); }
      }

      private ICommand copyBoth;
      /// <summary>
      /// 
      /// </summary>
      public ICommand CopyBoth
      {
         get { return copyBoth = new DelegateCommand(cOpyBoth); }
      }

   }
}
