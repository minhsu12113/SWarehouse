   M S B A M L   `   `   `  ����E  ASWarehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SWarehouse
SWarehouse  5   	   !    SWarehouse.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SWarehouse     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	   
������  � WindowStyle$
 None=�5       � 
ResizeMode$ NoResize=�6-    � AllowsTransparency .  � Title$ S-Warehouse��5   	   $	��750��6   $
��1300��6*    � WindowStartupLocation$ CenterScreen=�67     MainViewModel � DataContext# [ 6\   .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5   
   ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5      	   Kind$	 ExpandIn=�6.   
   Duration$
 0:0:0.8h�6>     5      $	 SlideInFromBottom=�6.   .��5   
   ��  �� CornerRadius$ 25��6   ���#121432._�5      )  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ 
MainDialog��6(      CloseOnClickAway . .��5      �  � ColumnDefinitions 5      �� 5      $	��.2* �6+   �� 5      $��* �6+   .+�5      �� $��
S-Warehoue��6    $	��Top=�62   $��Center=�6J   
�������$��16(�6z   $��0 27 0 0q�6�   �� 5!        MaterialDesignPaper#��[ 6   $��1��6O   $ 25��6_   ._�5"      �  � RowDefinitions 5#      �� 5$   "   $
��Auto �60   �� 5%   "   $��* �60   .+�5)      �� $��0��6)    �� Orientation$ 
Horizontal=�66   $��Right=�6O   $	��Top=�6k   .+�5*   "   �� -   5         ��Name$ btn_MinimizedWindow��5*   )     MaterialDesignFlatButton#��[ 6F   
���������5+   !   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ WindowMinimize=�6Y   �� 5,   "   -   5        $ btn_ShutDownApp��5,   )   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 0 25 0 0��6B   #��[ 6v   
���  ����5-   !     $ Power=�6P   5.      �� 52      $��1��6-   ��6:   �� *ViewCurrent+54      55      � 58      $��0��6   $��Center=�6+   .+�59      �  5:      �� 5;   "   $
��Auto �60   �� 5<   "   $��* �60   .+�5>      �� $��1��6&   $��0 49 0 0q�63   ��6E   �� *ListItemNavigate+ �� SelectedItem 6n   �� *SelectedView+��5?   "   �� 5@   &    �� 
TargetType" ��6,     MaterialDesignListBoxItem �� BasedOn# [ 6E   .�5A   *   ��  �� Property � �� �� Value$	 0 9q�6D   �� 5B   *    � ��$ Stretch=�6W   �� 5C   *    � ��$ Stretch=�6U    �� Triggers 5D   *   P� 5E   .    P� Property �@J�IsMouseOver P� Value . . �5F   2   ��  � �� �#34364F6O   5G   /   P� 5H   .    �@��
IsSelected . . �5I   2   ��  � �� �#34364F6O   5J   /   5L   '   ��5N   "   �� 5O   &   .R�5P   *   � $��39��6/   ��5Q   .   �� 5R   2   " �68   .�5S   6   ��  �@J�Opacity$	 0.6Q�6P    5T   6   �� 5U   :    �� Binding 6F   �� *
IsSelected+ �� Value True6e    N� EnterActions 5V   >   �� 5W   B   .��5X   F   ��  �� TargetProperty$ Opacity�6Q   .��5Y   J   W�   g� Duration$  0:0:0.3D�6Z   	! W� To$! 1X�6m   5Z   G   5[   C   " N� ExitActions" 5]   >   �� 5^   B   .��5_   F   �� $ Opacity�6Q   .��5`   J   W� $  0:0:0.3D�6Z   $	! 0.6X�6m   5a   G   5b   C   5d   ;   5f   3    5h   .   �� 5i   2   $��5 �6C   �� 5j   2   $	��.8* �6C   �� 5k   2   $��* �6C   .+�5m   .   �� $��0��65   $
��0 -5q�6E   
�������$ 0 7 7 0��6f   y�6}   �� *
IsSelected+   BooleanToVisibilityConverter# �� 	Converter## [ '  !MaterialDesignThemes.Wpf.PackIcon  5n   .   $��1��6F   $	��0 3q�6V   $
��Auto��6y   $
��Auto��6�   
�������$��Center=�6�   $��Center=�6�   $   Kind$ 6c   �� *Icon+6�   �� 5o   .   $��2��68   $��0 0 0 0q�6H   $��Center=�6v   $
��Left=�6�   
�������$��14(�6�   $��SemiBold"�6�   ��6Y   �� *DisplayName+6�   5p   +   5q   '   5s      5t      5u      5w      5x      5y      5z      5|      