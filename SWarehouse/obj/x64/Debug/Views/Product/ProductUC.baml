   M S B A M L   `   `   `  ����E  ASWarehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SWarehouse.Views.ProductSWarehouse.Views.Product  5      =#clr-namespace:SWarehouse.ConvertersSWarehouse.Converters  5	      E'clr-namespace:SWarehouse.CustomControlsSWarehouse.CustomControls  5
      (    "SWarehouse.Views.Product.ProductUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:SWarehouse.Views.Product     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      3	converter#clr-namespace:SWarehouse.Converters  5	      4paging'clr-namespace:SWarehouse.CustomControls  5
         MaterialDesignBody#���   5      $��Regular"�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5        Stl_btn_addnew �� 
TargetType # MaterialDesignFlatLightBgButton �� BasedOn �� Property �� Value �� Orientation'  !MaterialDesignThemes.Wpf.PackIcon   Kind  ADD_NEW  Stl_btn_edit  MaterialDesignFlatButton  Stl_btn_delete0   *SWarehouse.Converters.ListViewIndexConvert  ListViewIndex1   +SWarehouse.Converters.ProductImageConverter 	 ProductImage��%  &	       7  &	 �    7  &	     7  &	 �    &		 �    �� 5   
   " ��6'   8   .�5      ��  � ��$ Stretch=�6;   �� 5       � �� �#364F6B6+   �� 5       � �� �#364F6B6,   �� 5       � ��$ 0 0 15 0q�6'   �� 5       � �� 5      �� 5      $ 
Horizontal=�6!   .+�5        $ PlusCircleOutline=�62   �� 5      $��10 0 0 0q�6$   #���  66   5      5      5       �� 5!   
   " ��6%   8   .�5"      ��  � �� �#34364F6+   �� 5#       � ��$ 5 0 5 0q�6(   5$      �� 5%   
   " ��6'   8   .�5&      ��  � ��
 � E��6+   �� 5'       � ��$ 5 0 5 0q�6(   �� 5(       � ��$	 5 0q�6'   5)        5*   
   6*     5+   
   6*   5,      .��5-      � $��10q�6   	 � RowDefinitions	 5.   
   �� 5/      $	��.1* �6   �� 50      $��* �6   �� 51      $
��Auto �6   .+�54   
   � $��0��6   ���#121432
 � ColumnDefinitions
 55      �� 56      $
��Auto �6#   �� 57      $��* �6#   �� 58      $
��Auto �6#   �� 59      $
��Auto �6#   .+�5<      �� $��0��6    
 PRODUCT#��� 
 6(   $��Center=�6I   $��10q�6d   $��18(�6p   
�������$��SemiBold"�6�   �� 5=      $��2��6   #��[ 6%   ��6M   �� *AddNewProductCMD+�� 5?      $��1��6   
�������$	��0.3q�68   $��
15 10 5 10q�6N   $	��397��6b   $	��397��6q   $
��Left=�6�    �� CornerRadius$ 3��6�   ._�5@      �  5A        PrimaryHueMidBrush �� Color��%/   &	       �� 5B      $ Transparent��6E   5C      
 5D      �� 5E      $	��.2* �6+   �� 5F      $��* �6+   .+�5H      �� $
��Auto��6   $
��Auto��6*   #��[ 6]   
���������68   �� *SearchProductCMD+��6�   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Search=�   Size$ 19X�6�   �� 5I      $��1��6   $	��5 0q�6.    �� 
CaretBrush
 �����$��Center=�6�   $��16(�6�   
�������  ENTER_TEXT_TO_SEARCH)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6�   
������ ��6<   �� *ContentSearch+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��6C   J� InputBindings 5J      �� 5K      
 �� Key$ Return��6N    �� Command 6)   �� *SearchProductCMD+6N   .��5L   1   5M      5N      5O      5P      �� 5S   
   $��1��6   $��Hidden=�6$   .��5T      �� $
��left=�6<   $	��0 5q�6W   ��6   �� *
Products+��5U      �� 5V      .R�5W      �  � Orientation$ 
Horizontal=�6$   5X      ��5Z      �� 5[      .R�5\      #  MaterialDesignThemes.Wpf.Card  $	��200��6.   $	��270��6:   $��5 5 5 5q�6G   ��5]      �� 5^   "   "  6(   .�5_   &   ��  �@J�Opacity$ 0Q�6@    �� Triggers 5`   &   :� 5a   *    :� RoutedEvent$ Loaded��67   .[�5b   .   �� .��5c   2   ��  �� TargetProperty$ Opacity�6=   .��5d   6   W�  g� Duration$ 0:0:0.3D�6F   	 W� To$ 1X�6Y   5e   3   5f   /   5g   +   5i   #   .��5k      � 	 5l   "   �� 5m   &   $��* �64   �� 5n   &   $	��.4* �64   .+�5q   "   �� $��0��6(   $��Uniform=�6z   ��65   �� *	ImagePath+ �� 	Converter# [	 6z   � 5t   "   $��1��6'   $��0 0 0 0q�64   
 5u   &   �� 5v   *   $
��Auto �6;   �� 5w   *   $��* �6;   	 5y   &   �� 5z   *   $��* �68   �� 5{   *   $��* �68   �� 5|   *   $��* �68   .+�5   &   �� $��0��60   $��0��6=   $��Tên Sản Phẩm: ��6M   $��5 5 0 0q�6c   �� 5�   &   $��0��60   $��1��6=   $��15 5 5 0q�6c   $��SemiBold"�6u   $��CharacterEllipsis=�6�   ��6M   �� *Name+6�   �� 5�   &   $��1��60   $��0��6=   $��Danh Mục: ��6M   $��5 5 0 0q�6_   �� 5�   &   $��1��60   $��1��6=   $��5 5 5 0q�6f   $��SemiBold"�6w   $��CharacterEllipsis=�6�   ��6M   �� *	CatName+6�   �� 5�   &   $��2��60   $��0��6=   $��Nhà Cung Cấp: ��6M   $��5 5 0 0q�6c   �� 5�   &   $��2��60   $��1��6=   $��5 5 5 0q�6f   $��SemiBold"�6w   $��CharacterEllipsis=�6�   ��6M   �� *	SupName+6�   5�   #   � 5�   "   $��	gird_Edit��64   $��0��6'   $��2��6E   
���������5�   &   �� 5�   *   " �60   .�5�   .   ��  �@J�Opacity$ 0Q�6H    5�   .   P� 5�   2    P� Property �@J�IsMouseOver P� Value . . �5�   6   ��  �@J�Opacity$	 0.3Q�6P   5�   3   �� 5�   2    �� Binding 6>   �� *IsMouseOver+  �� ElementName$  
stack_edit��! �� Value! True6u   .a�5�   6   ��  �@J�Opacity$	 0.3Q�6P   5�   3   5�   +   5�   #   �� 5�   "   $��
stack_edit��6-   $��0��6?   $��3��6L   $ 
Horizontal=�6`   $��Center=�6y   $��Center=�6�   ��5�   &   �� 5�   *   " ��60   .�5�   .   ��  �@J�Opacity$ 0Q�6H    5�   .   �� 5�   2    6>   �� *IsMouseOver+$  	gird_Edit��! True6t   .a�5�   6   ��  �@J�Opacity$ 1Q�6P   5�   3   P� 5�   2    �@J�IsMouseOver . . �5�   6   ��  �@J�Opacity$ 1Q�6P   5�   3   5�   +   .+�5�   &   �� $��5q�6-    * &MaterialDesignFloatingActionMiniButton#��[ 68   ��6x     $
 Edit=�$ 17X���5�   -   �� " �� RelativeSource" �� # �� AncestorType$# ItemsControlL�$ �� Path$ $ DataContext.EditProductCMD���6�   �� �� 5�   &   $��10 0 0 0q�6-   #��[ 6?   ��6     $ Delete=�$ 17X���5�   -   �� " �� $# ItemsControlL�$"$ DataContext.DeleteProductCMD���6�   �� 5�   #   5�      5�      5�      5�      5�      (   "SWarehouse.CustomControls.PagingUC  5�   
   $��2��6   ���#121432$��Stretch=�6<   % � DataContext% 6Z   �� *PagingViewmodel+5�      5�      