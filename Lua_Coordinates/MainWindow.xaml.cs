using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Reflection;
using System.Globalization;
using MakeCents;

namespace Lua_Coordinates
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainViewModel MVM { get { return this.DataContext as MainViewModel; } }
      public MainWindow()
      {
         InitializeComponent();
         clsDragNDrop.TextBoxDragNDrop(textBox, this);

         Version v = Assembly.GetExecutingAssembly().GetName().Version;
         MVM.About = string.Format(CultureInfo.InvariantCulture, @"Version {0}.{1}.{2} (r{3})", v.Major, v.Minor, v.Build, v.Revision);

         MVM.curx = 5;
         MVM.cury = 5;
         
         Set(left);
         Set(right);
         Set(top);
         Set(bottom);
         MVM.RIGHT = "false";
         MVM.BOTTOM = "false";

         string[] de = new string[] { "Draw", "Erase Point", "Erase Stroke" };
         drawerase.ItemsSource = de;
         drawerase.Text = "Draw";

      }

      private void Set(ComboBox bx)
      {
         string[] tf = new string[] { "true", "false" };
         bx.ItemsSource = tf;
         bx.Text = "true";
      }

      private void drawing_MouseMove(object sender, MouseEventArgs e)
      {
        
         int w = 1280;
         int h = 960;
         double hi = h / drawing.ActualHeight;
         double wi = w / drawing.ActualWidth;
         Point p = Mouse.GetPosition(drawing);
         MVM.X = wi * p.X;
         MVM.Y = hi * p.Y;

         UpdateSets();
      }

      private void UpdateSets()
      {
         bool walt = false;
         bool halt = false;
         //if bottom true then -960
         double w = MVM.X;
         if(MVM.LEFT == "false" && MVM.RIGHT == "true")
         {
            w -= 1280;
         }
         else if(MVM.RIGHT == "false" && MVM.LEFT=="false")
         {
            w -= 640;
         }
         else if (MVM.RIGHT == "true" && MVM.LEFT == "true")
         {
            walt = true;
         }

         //if right true then -1280
         double h = MVM.Y;
         if (MVM.TOP == "false" && MVM.BOTTOM == "true")
         {
            h-= 960;
         }
         else if (MVM.TOP == "false" && MVM.BOTTOM == "false")
         {
            h -= 480;
         }
         else if (MVM.TOP == "true" && MVM.BOTTOM == "true")
         {
            halt = true;
         }
         if(walt)
         {
            MVM.setLeftRight = MVM.LEFT + ", " + MVM.RIGHT + ", " + (int)w + ", " + (int)((w-1280)+MVM.W);
         }
         else
         {
            MVM.setLeftRight = MVM.LEFT + ", " + MVM.RIGHT + ", " + (int)w + ", " + (int)(w + MVM.W);
         }
         if (halt)
         {
            MVM.setTopBottom = MVM.TOP + ", " + MVM.BOTTOM + ", " + (int)h + ", " + (int)((h - 960)+MVM.H);
         }
         else
         {
            MVM.setTopBottom = MVM.TOP + ", " + MVM.BOTTOM + ", " + (int)h + ", " + (int)(h + MVM.H);
         }
         
         
      }

      private void textBox_TextChanged(object sender, TextChangedEventArgs e)
      {
         if (!File.Exists(textBox.Text)) return;
         ImageBrush ib = new ImageBrush();
         ib.ImageSource = new BitmapImage(new Uri(textBox.Text, UriKind.RelativeOrAbsolute));
         drawing.Background = ib;
      }

      private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
      {
         if(MVM.curx>0 && MVM.curx< 11)
         {
            drawing.DefaultDrawingAttributes.Width = MVM.curx;
            if (checkBox.IsChecked == true)
            {
               MVM.cury = MVM.curx;
            }

         }

         
      }

      private void slider_Copy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
      {
         if (MVM.cury > 0 && MVM.cury < 11)
         {
            drawing.DefaultDrawingAttributes.Height = MVM.cury;

            if (checkBox.IsChecked == true)
            {
               MVM.curx = MVM.cury;
            }
         }
      }

      private void bl_MouseDown(object sender, MouseButtonEventArgs e)
      {
         drawing.DefaultDrawingAttributes.Color = Colors.Black;
      }

      private void wh_MouseDown(object sender, MouseButtonEventArgs e)
      {
         drawing.DefaultDrawingAttributes.Color = Colors.White;
      }

      private void blu_MouseDown(object sender, MouseButtonEventArgs e)
      {
         drawing.DefaultDrawingAttributes.Color = Colors.Blue;
      }

      private void red_MouseDown(object sender, MouseButtonEventArgs e)
      {
         drawing.DefaultDrawingAttributes.Color = Colors.Red;
      }

      private void gr_MouseDown(object sender, MouseButtonEventArgs e)
      {
         drawing.DefaultDrawingAttributes.Color = Colors.Green;
      }

      private void left_SelectionChanged(object sender, SelectionChangedEventArgs e)
      {

      }

      private void left_DropDownClosed(object sender, EventArgs e)
      {
         UpdateSets();
      }

      private void right_DropDownClosed(object sender, EventArgs e)
      {
         UpdateSets();
      }

      private void top_DropDownClosed(object sender, EventArgs e)
      {
         UpdateSets();
      }

      private void bottom_DropDownClosed(object sender, EventArgs e)
      {
         UpdateSets();
      }

      private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
      {
         UpdateSets();
      }



      private void drawerase_DropDownClosed(object sender, EventArgs e)
      {
         switch(drawerase.Text)
         {
            case "Draw":
               drawing.EditingMode = InkCanvasEditingMode.Ink;
               break;

            case "Erase Point":
               drawing.EditingMode = InkCanvasEditingMode.EraseByPoint;
               break;

            case "Erase Stroke":
               drawing.EditingMode = InkCanvasEditingMode.EraseByStroke;
               break;
            default:
               break;

         }
      }

      private void drawing_MouseMove(object sender, MouseButtonEventArgs e)
      {
         UpdateSets();
      }

      private void button_Click_1(object sender, RoutedEventArgs e)
      {
         drawing.Strokes.Clear();
      }

      private void drawing_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
      {
         MVM.csetLeftRight = MVM.setLeftRight;
         MVM.csetTopBottom = MVM.setTopBottom;
      }

      /*FileStream fs = new FileStream(@"C:\Users\MakeCents\Desktop\test.png", FileMode.Open, FileAccess.Read);
StrokeCollection strokes = new StrokeCollection(fs);
drawing.Strokes = strokes;
fs.Close();*/


      /*using (FileStream fs = new FileStream(@"C:\Users\MakeCents\Desktop\test.png", FileMode.Create))
      {
         drawing.Strokes.Save(fs);
         fs.Close();
      }*/

   }

}
