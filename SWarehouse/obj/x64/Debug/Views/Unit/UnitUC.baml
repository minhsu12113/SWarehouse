   M S B A M L   `   `   `  ����E  ASWarehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SWarehouse.Views.UnitSWarehouse.Views.Unit  5      =#clr-namespace:SWarehouse.ConvertersSWarehouse.Converters  5	      E'clr-namespace:SWarehouse.CustomControlsSWarehouse.CustomControls  5
      "    SWarehouse.Views.Unit.UnitUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:SWarehouse.Views.Unit     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      3	converter#clr-namespace:SWarehouse.Converters  5	      4paging'clr-namespace:SWarehouse.CustomControls  5
         MaterialDesignBody#���   5      $��Regular"�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5        Stl_btn_addnew �� 
TargetType # MaterialDesignFlatLightBgButton �� BasedOn �� Property �� Value �� Orientation'  !MaterialDesignThemes.Wpf.PackIcon   Kind  ADD_NEW  Stl_btn_edit  MaterialDesignFlatButton  Stl_btn_delete0   *SWarehouse.Converters.ListViewIndexConvert  ListViewIndex��%�  &	       7  &	 �    7  &	     7  &	 �    �� 5   
   " ��6'   8   .�5      ��  � ��$ Stretch=�6;   �� 5       � �� �#364F6B6+   �� 5       � �� �#364F6B6,   �� 5       � ��$ 0 0 15 0q�6'   �� 5       � �� 5      �� 5      $ 
Horizontal=�6!   .+�5        $ PlusCircleOutline=�62   �� 5      $��10 0 0 0q�6$   #���  66   5      5       5!      �� 5"   
   " ��6%   8   .�5#      ��  � �� �#34364F6+   �� 5$       � ��$ 5 0 5 0q�6(   5%      �� 5&   
   " ��6'   8   .�5'      ��  � ��
 � E��6+   �� 5(       � ��$ 5 0 5 0q�6(   �� 5)       � ��$	 5 0q�6'   5*        5+   
   6*   5,      .��5-      � $��10q�6   	 � RowDefinitions	 5.   
   �� 5/      $	��.1* �6   �� 50      $��* �6   �� 51      $
��Auto �6   .+�54   
   � $��0��6   ���#121432
 � ColumnDefinitions
 55      �� 56      $
��Auto �6#   �� 57      $��* �6#   �� 58      $
��Auto �6#   �� 59      $
��Auto �6#   .+�5<      �� $��0��6    		 UNITS#��� 	 6(   $��Center=�6G   $��10q�6b   $��18(�6n   
�������$��SemiBold"�6�   �� 5=      $��2��6   #��[ 6%   ��6M   �� *AddNewUnitCMD+�� 5?      $��1��6   
�������$	��0.3q�68   $��
15 10 5 10q�6N   $	��397��6b   $	��397��6q   $
��Left=�6�    �� CornerRadius$ 3��6�   ._�5@      �  5A       
 PrimaryHueMidBrush �� Color��%/   &	
       �� 5B      $ Transparent��6E   5C      
 5D      �� 5E      $	��.2* �6+   �� 5F      $��* �6+   .+�5H      �� $
��Auto��6   $
��Auto��6*   #��[ 68   
���������6j   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Search=�   Size$ 19X�6�   �� 5I      $��1��6   $	��5 0q�6.    �� 
CaretBrush
 �����$��Center=�6�   $��16(�6�   
�������  ENTER_TEXT_TO_SEARCH)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6�   
������ ��6<   �� *ContentSearch+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��6C   J� InputBindings 5J      �� 5K      
 �� Key$ Return��6K    �� Command 6)   �� *SearchUnitCMD+6K   .��5L   1   5M      5N      5O      5P      �� 5S   
   $��1��6   
�������$	��0.7q�63   $ 	0 0 15 15��6I   ._�5T      �� ��6   �� *Units+��5U      �� 5V      " ��6     MaterialDesignGridViewItem# [ 66   .�5W      ��  � ��$ Center=�6G   �� 5X       � ��$ Center=�6E   �� 5Y       � ��$ 14(�65   �� 5Z       � ��$ 0q�64   5[       �� View 5]      �� 5^      .P�5_      ��  �� DisplayMemberBinding 6)   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� 	Converter# [ ��5`      �� 5a   "     NO.#���  6,   
���   �$��SemiBold"�6\   $��10 0 0 0q�6r   5c      �� 5d       6)   �� *Name+��5e      �� 5f   "     NAME#���  6,   
���   �$��SemiBold"�6]   $��10 0 0 0q�6s   5h      �� 5i       6)   �� *UserCreated+��5j      �� 5k   "     USER_CREATED#���  6,   
���   �$��SemiBold"�6e   $��10 0 0 0q�6{   5m      �� 5n       6)   �� *CreatedTime+��5o      �� 5p   "     TIME_CREATED#���  6,   
���   �$��SemiBold"�6e   $��10 0 0 0q�6{   5r      �� 5s       6)   �� *ModifiedTime+��5t      �� 5u   "     TIME_MODIFIED#���  6,   
���   �$��SemiBold"�6f   $��10 0 0 0q�6|   5w      �� 5x       6)   �� *UserModified+��5y      �� 5z   "     USER_MODIFIED#���  6,   
���   �$��SemiBold"�6f   $��10 0 0 0q�6|   5|      �� 5}      ��5~      �� 5   "    
 ACTION#���  6,   
���   �$��SemiBold"�6_   $��10 0 0 0q�6u    �� CellTemplate 5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� #��[ 61   ��6W   ��  �� $ ListViewL� �� Path$ DataContext.EditUnitCMD���6�   �� .��5�   .     $
 Edit=�6F   $��19��6R   $��19��6]   5�   +   �� 5�   *   #��[ 61   $��0��6Y   ��6g   ��  �� $ ListViewL�$ DataContext.DeleteUnitCMD���6�   �� .��5�   .     $ DeleteOutline=�6F   $��19��6[   $��19��6f   5�   +   5�   '   5�   #   5�      5�      5�      5�      (   "SWarehouse.CustomControls.PagingUC  5�   
   $��2��6   ���#121432$��Stretch=�6<    � DataContext 6Z   �� *PagingViewmodel+5�      5�      