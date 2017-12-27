
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Lua_Coordinates
{


   /// <summary>
   /// 
   /// </summary>
   public partial class MainViewModel
   {
      private static MainViewModel _instance;
      /// <summary>
      /// 
      /// </summary>
      public static MainViewModel Instance
      {
         get { return _instance; }
         set
         {
            _instance = value;
            if (_instance != null)
               _instance.OnPropertyChanged("Instance");
         }
      }
      /// <summary>
      /// 
      /// </summary>
      public Window MyParentWindow { get; set; }

      private string _About;
      /// <summary>
      /// 
      /// </summary>
      public string About
      {
         get { return _About; }
         set
         {
            _About = value;
            OnPropertyChanged("About");

         }
      }

      private string _nameLeft;
      /// <summary>
      /// 
      /// </summary>
      public string nameLeft
      {
         get { return _nameLeft; }
         set
         {
            _nameLeft = value;
            OnPropertyChanged("nameLeft");

         }
      }

      private double _X;
      /// <summary>
      /// 
      /// </summary>
      public double X
      {
         get { return _X; }
         set
         {
            _X = value;
            OnPropertyChanged("X");

         }
      }
      private double _Y;
      /// <summary>
      /// 
      /// </summary>
      public double Y
      {
         get { return _Y; }
         set
         {
            _Y = value;
            OnPropertyChanged("Y");

         }
      }

      private double _W;
      /// <summary>
      /// 
      /// </summary>
      public double W
      {
         get { return _W; }
         set
         {
            _W = value;
            OnPropertyChanged("W");

         }
      }

      private double _H;
      /// <summary>
      /// 
      /// </summary>
      public double H
      {
         get { return _H; }
         set
         {
            _H = value;
            OnPropertyChanged("H");

         }
      }

      private int _curx;
      /// <summary>
      /// 
      /// </summary>
      public int curx
      {
         get { return _curx; }
         set
         {
            _curx = value;
            OnPropertyChanged("curx");

         }
      }
      private int _cury;
      /// <summary>
      /// 
      /// </summary>
      public int cury
      {
         get { return _cury; }
         set
         {
            _cury = value;
            OnPropertyChanged("cury");

         }
      }

      private string _LEFT;
      /// <summary>
      /// 
      /// </summary>
      public string LEFT
      {
         get { return _LEFT; }
         set
         {
            _LEFT = value;
            OnPropertyChanged("LEFT");

         }
      }
      private string _RIGHT;
      /// <summary>
      /// 
      /// </summary>
      public string RIGHT
      {
         get { return _RIGHT; }
         set
         {
            _RIGHT = value;
            OnPropertyChanged("RIGHT");

         }
      }
      private string _TOP;
      /// <summary>
      /// 
      /// </summary>
      public string TOP
      {
         get { return _TOP; }
         set
         {
            _TOP = value;
            OnPropertyChanged("TOP");

         }
      }
      private string _BOTTOM;
      /// <summary>
      /// 
      /// </summary>
      public string BOTTOM
      {
         get { return _BOTTOM; }
         set
         {
            _BOTTOM = value;
            OnPropertyChanged("BOTTOM");

         }
      }

      private string _setTopBottom;
      /// <summary>
      /// 
      /// </summary>
      public string setTopBottom
      {
         get { return _setTopBottom; }
         set
         {
            _setTopBottom = value;
            OnPropertyChanged("setTopBottom");

         }
      }
      private string _setLeftRight;
      /// <summary>
      /// 
      /// </summary>
      public string setLeftRight
      {
         get { return _setLeftRight; }
         set
         {
            _setLeftRight = value;
            OnPropertyChanged("setLeftRight");

         }
      }

      private string _csetTopBottom;
      /// <summary>
      /// 
      /// </summary>
      public string csetTopBottom
      {
         get { return _csetTopBottom; }
         set
         {
            _csetTopBottom = value;
            OnPropertyChanged("csetTopBottom");

         }
      }
      private string _csetLeftRight;
      /// <summary>
      /// 
      /// </summary>
      public string csetLeftRight
      {
         get { return _csetLeftRight; }
         set
         {
            _csetLeftRight = value;
            OnPropertyChanged("csetLeftRight");

         }
      }
   }//end Class
}
