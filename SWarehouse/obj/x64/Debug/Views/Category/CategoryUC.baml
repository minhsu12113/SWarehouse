   M S B A M L   `   `   `  ����E  ASWarehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SWarehouse.Views.CategorySWarehouse.Views.Category  5      =#clr-namespace:SWarehouse.ConvertersSWarehouse.Converters  5	      E'clr-namespace:SWarehouse.CustomControlsSWarehouse.CustomControls  5
      *    $SWarehouse.Views.Category.CategoryUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:SWarehouse.Views.Category     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      3	converter#clr-namespace:SWarehouse.Converters  5	      4paging'clr-namespace:SWarehouse.CustomControls  5
         MaterialDesignBody#���   5      $��Regular"�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5        Stl_btn_addnew �� 
TargetType # MaterialDesignFlatLightBgButton �� BasedOn �� Property �� Value �� Orientation'  !MaterialDesignThemes.Wpf.PackIcon   Kind  ADD_NEW  Stl_btn_edit  MaterialDesignFlatButton  Stl_btn_delete0   *SWarehouse.Converters.ListViewIndexConvert  ListViewIndex��%�  &	       7  &	 �    7  &	     7  &	 �    �� 5   
   " ��6'   8   .�5      ��  � ��$ Stretch=�6;   �� 5       � �� �#364F6B6+   �� 5       � �� �#364F6B6,   �� 5       � ��$ 0 0 15 0q�6'   �� 5       � �� 5      �� 5      $ 
Horizontal=�6!   .+�5        $ PlusCircleOutline=�62   �� 5      $��10 0 0 0q�6$   #���  66   5      5      5       �� 5!   
   " ��6%   8   .�5"      ��  � �� �#34364F6+   �� 5#       � ��$ 5 0 5 0q�6(   5$      �� 5%   
   " ��6'   8   .�5&      ��  � ��
 � E��6+   �� 5'       � ��$ 5 0 5 0q�6(   �� 5(       � ��$	 5 0q�6'   5)        5*   
   6*   5+      .��5,      � $��10q�6   	 � RowDefinitions	 5-   
   �� 5.      $	��.1* �6   �� 5/      $��* �6   �� 50      $
��Auto �6   .+�53   
   � $��0��6   ���#121432
 � ColumnDefinitions
 54      �� 55      $
��Auto �6#   �� 56      $��* �6#   �� 57      $
��Auto �6#   �� 58      $
��Auto �6#   .+�5;      �� $��0��6    	 	CATEGORYS#��� 	 6(   $��Center=�6K   $��10q�6f   $��18(�6r   
�������$��SemiBold"�6�   �� 5<      $��2��6   #��[ 6%   ��6M   �� *AddNewCategoryCMD+�� 5>      $��1��6   
�������$	��0.3q�68   $��
15 10 5 10q�6N   $	��397��6b   $	��397��6q   $
��Left=�6�    �� CornerRadius$ 3��6�   ._�5?      �  5@       
 PrimaryHueMidBrush �� Color��%/   &	
       �� 5A      $ Transparent��6E   5B      
 5C      �� 5D      $	��.2* �6+   �� 5E      $��* �6+   .+�5G      �� $
��Auto��6   $
��Auto��6*   #��[ 6V   
���������68   �� *	SearchCMD+��6�   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Search=�   Size$ 19X�6�   �� 5H      $��1��6   $	��5 0q�6.    �� 
CaretBrush
 �����$��Center=�6�   $��16(�6�   
�������  ENTER_TEXT_TO_SEARCH)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6�   
������ ��6<   �� *SearchContent+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��6C   J� InputBindings 5I      �� 5J      
 �� Key$ Return��6G    �� Command 6)   �� *	SearchCMD+6G   .��5K   1   5L      5M      5N      5O      �� 5R   
   $��1��6   
�������$	��0.7q�63   $ 	0 0 15 15��6I   ._�5S      �� ��6   �� *
Categories+��5T      �� 5U      " ��6     MaterialDesignGridViewItem# [ 66   .�5V      ��  � ��$ Center=�6G   �� 5W       � ��$ Center=�6E   �� 5X       � ��$ 14(�65   �� 5Y       � ��$ 0q�64   5Z       �� View 5\      �� 5]      .P�5^      ��  �� DisplayMemberBinding 6)   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� 	Converter# [ ��5_      �� 5`   "     NO.#���  6,   
���   �$��SemiBold"�6\   $��10 0 0 0q�6r   5b      �� 5c       6)   �� *Name+��5d      �� 5e   "     NAME#���  6,   
���   �$��SemiBold"�6]   $��10 0 0 0q�6s   5g      �� 5h       6)   �� *UserCreated+��5i      �� 5j   "     USER_CREATED#���  6,   
���   �$��SemiBold"�6e   $��10 0 0 0q�6{   5l      �� 5m       6)   �� *CreatedTime+��5n      �� 5o   "     TIME_CREATED#���  6,   
���   �$��SemiBold"�6e   $��10 0 0 0q�6{   5q      �� 5r       6)   �� *ModifiedTime+��5s      �� 5t   "     TIME_MODIFIED#���  6,   
���   �$��SemiBold"�6f   $��10 0 0 0q�6|   5v      �� 5w       6)   �� *UserModified+��5x      �� 5y   "     USER_MODIFIED#���  6,   
���   �$��SemiBold"�6f   $��10 0 0 0q�6|   5{      �� 5|      ��5}      �� 5~   "    
 ACTION#���  6,   
���   �$��SemiBold"�6_   $��10 0 0 0q�6u    �� CellTemplate 5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� #��[ 61   ��6W   ��  �� $ ListViewL� �� Path$! DataContext.EditCategoryCMD���6�   �� .��5�   .     $
 Edit=�6F   $��19��6R   $��19��6]   5�   +   �� 5�   *   #��[ 61   $��0��6Y   ��6g   ��  �� $ ListViewL�$# DataContext.DeleteCategoryCMD���6�   �� .��5�   .     $ DeleteOutline=�6F   $��19��6[   $��19��6f   5�   +   5�   '   5�   #   5�      5�      5�      5�      (   "SWarehouse.CustomControls.PagingUC  5�   
   $��2��6   ���#121432$��Stretch=�6<    � DataContext 6Z   �� *PagingViewmodel+5�      5�      