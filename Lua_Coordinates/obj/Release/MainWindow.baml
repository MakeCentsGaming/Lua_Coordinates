   M S B A M L   `   `   `  ���� J  FLua_Coordinates, Version=0.1.1.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Lua_CoordinatesLua_Coordinates       Lua_Coordinates.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:Lua_Coordinates       � Title$  Lua Coordinates��$��484.785��$��604.5�� � Icon$ lua_coordinates.png��$��484.785��$��604.5�� � DataContext #   Lua_Coordinates.MainViewModel  .��� $��0,1,0,-1q�.+��� -    ��Name$ drawing��$��10,4.664,10,161.071q� � Cursor$ Cross�� � ContextMenu �� .@�m� $��Copy setLeftRight�� m� Command �� *CopyLeftRight+m� $��Copy setTopBottom�� �� *CopyTopBottom+m� $��	Copy both�� �� *
CopyBoth+ �� 
Background ��  �� ImageSource$ base.png��	 �� DefaultDrawingAttributes	 *  $System.Windows.Ink.DrawingAttributes  
   Color$
 Black���� -    ��Name$ textBox�� � ToolTip$, &Drag and drop new image for background��$��10,0,10,117.785q� �� TextWrapping$ NoWrap=�$�� ��$��27��$��Bottom=��� -    ��Name$ slider��$
��Left=�$��10,0,0,47.785q�$��Bottom=�$��70.143�� � Minimum$ 1Q� � Value �� *curx+�� -   $ slider_Copy��$
��Left=�$��68.087,0,0,27.636q�$��Bottom=�$��64.464�� J� RenderTransformOrigin$ 0.5,0.5&�$ 1Q� �� *cury+z�V� .~��� �� ��  �� Angle$ 270.305Q�T� �� -    ��Name$ label��$��Cursor Size��$
��Left=�$��21.965,0,0,24.99q�$��Bottom=��� -   $ textBox1�� �� 
IsReadOnly . $
��Left=�$��23��$��148.782,0,0,46.785q�$
 Wrap=�$��Bottom=�$��53.272������ *X+�� -   $ textBox1_Copy�� . $
��Left=�$��23��$��149.62,0,0,9q�$
 Wrap=�$��Bottom=�$��53.272������ *Y+�� -   $ label1��$��X��$
��Left=�$��125.333,0,0,46.785q�$��Bottom=��� -	   $ label1_Copy��$��Y��$
��Left=�$��125.776,0,0,9q�$��Bottom=��� -
    ��Name$ checkBox��$��Round��$
��Left=�$��10,0,0,6.99q�$��Bottom=� d� 	IsChecked$
 TrueY��� -    ��Name$ bl��$
��Left=�$��25.96��$��10,0,0,86.825q�$��Bottom=�$��27��
���   ��� -   $ wh��$
��Left=�$��25.96��$��42,0,0,86.825q�$��Bottom=�$��27�����	#FF0F0F0F J� OpacityMask
 �   ��� -   $	 blu��$
��Left=�$��25.96��$��74,0,0,86.825q�$��Bottom=�$��27�����	#FF1A10FB�� -   $	 red��$
��Left=�$��25.96��$��106,0,0,86.825q�$��Bottom=�$��27�����	#FFFF000C�� -   $ gr��$��138,0,0,86.825q����	#FF3AFF00$
��Left=�$��27��$��25.96��$��Bottom=��� -    ��Name$
 left��$ Anchor to the left��$��Right=�$��0,0,78,50.95q�$��Bottom=�$��63�� �� Text �� *LEFT+�� -   $	 top��$ Anchor to the top��$��Right=�$��	0,0,78,13q�$��Bottom=�$��63�� �� *TOP+�� -   $ right��$ Anchor to the right��$��Right=�$��0,0,10,50.95q�$��Bottom=�$��63�� �� *RIGHT+�� -   $ bottom��$ Anchor to the bottom��$��Right=�$��	0,0,10,13q�$��Bottom=�$��63�� �� *BOTTOM+�� -   $ label2��$��Anchor��$��Right=�$��0,0,92.933,90.825q�$��Bottom=��� -   $ label2_Copy��$
��Left��$��Right=�$��0,0,111.25,68.91q�$��Bottom=��� -   $ label2_Copy1��$��Right��$��Right=�$��0,0,34.993,68.815q�$��Bottom=��� -   $ label2_Copy2��$	��Top��$��Right=�$��0,0,110.63,31.085q�$��Bottom=��� -   $ label2_Copy3��$��Bottom��$��Right=�$��0,0,23.59,30.99q�$��Bottom=��� -   $ label1_Copy1��$��Width��$
��Left=�$��282.746,0,0,90.785q�$��Bottom=��� -   $ label1_Copy2��$��Height��$
��Left=�$��359.786,0,0,90.785q�$��Bottom=��� -   $ textBox1_Copy3�� . $��23��$��288.453,0,153.047,46.785q�$
 Wrap=�$��Bottom=����� *setLeftRight+�� -   $ textBox1_Copy4�� . $��23��$��288.453,0,153.047,10q�$
 Wrap=�$��Bottom=����� *setTopBottom+�� -   $ label2_Copy4��$��setLeftRight��$
��Left=�$��288.453,0,0,64.9q�$��Bottom=�$��72.333���� -   $ label2_Copy5��$��setTopBottom��$
��Left=�$��288.454,0,0,27.95q�$��Bottom=�$��87.534���� -   $ wh_Copy��$
��Left=�$��22.898��$��43.742,0,0,88.387q�$��Bottom=�$��23.626��
�������
 �   ��� -    $ textBox2��$ Width��$
��Left=�$��23��$��321.746,0,0,91.75q�$ NoWrap=�$��Bottom=�$��39.04������ *W+�� -!   $ textBox2_Copy��$ Height��$
��Left=�$��23��$��404.413,0,0,91.785q�$ NoWrap=�$��Bottom=�$��39.04������ *H+�� -"   $ 	drawerase��$
��Left=�$��176.707,0,0,89.825q�$��Bottom=�$��92.746���� -#    ��Name$ button��$ Clear drawing��$��Clear��$��0,0,10,91.785q�$��21.96��$��Bottom=�$��Right=�$��75���� $��0,0,10,144.071q����	#FF060606$��Right=�$��160.094��$��23��$��Bottom=����� *About+�� -$   $
 name��$ Widget name��$��0�� .  $��207.448,0,0,46.785q�$ NoWrap=�$
��Left=�$��76.005��$��23��$��Bottom=����� *
nameLeft+�� -%   $ label2_Copy6��$
��Name��$
��Left=�$��206.448,0,0,64.9q�$��Bottom=��� -&   $ label2_Copy7��$��Override Background��$
��Left=�$��6,0,0,138.775q�$��Bottom=��� -'   $ label2_Copy8��$��-��$��	-2,-8,0,0q�$	��Top=����	#FFF00606$
��Left=�$��26.364���� -(   $ label2_Copy9��$��+��$��0,0,-12,153.061q�$��Bottom=����	#FFF00606$��Right=�$��26.364��