   M S B A M L   `   `   `  ����E  ASWarehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SWarehouse.Views.ProductSWarehouse.Views.Product  5      ?$clr-namespace:SWarehouse.ValidationsSWarehouse.Validations  5      =#clr-namespace:SWarehouse.ConvertersSWarehouse.Converters  5
      E'clr-namespace:SWarehouse.CustomControlsSWarehouse.CustomControls  5      1    +SWarehouse.Views.Product.ProductAddOrUpdate   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:SWarehouse.Views.Product     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      0valid$clr-namespace:SWarehouse.Validations  5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      3	converter#clr-namespace:SWarehouse.Converters  5
      4paging'clr-namespace:SWarehouse.CustomControls  5         MaterialDesignBody#���   5      $��Regular"�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5       �� 
TargetType  Slt_btn_save  MaterialDesignFlatButton �� BasedOn �� Property �� Value �� Triggers ^� 
Conditions	 �� Binding
 �� ElementName �� Path �� Value1   +SWarehouse.Converters.ProductImageConverter  ProductImageConverter��%,  &	       7  &	     �� 5   
   " ��6   8   .�5      ��  � {� .  6*    5      ^� 5       5      �� 5      	 6$   �� $
 tbx_name��$ (Validation.HasError)�	 False6h   �� 5      	 6$   �� $
 cbx_cat��$ (Validation.HasError)�	 False6g   �� 5      	 6$   �� $
 cbx_unit��$ (Validation.HasError)�	 False6h   �� 5      	 6$   �� $
 cbx_sup��$ (Validation.HasError)�	 False6g   0�5      �� 5       � {� . 66   5!      5#        5$   
   6*   5%      .��5&      � 
������� � RowDefinitions 5'   
   �� 5(      $��* �6   �� 5)      $��* �6   �� 5*      $��* �6   �� 5+      $��* �6   �� 5,      $��* �6   �� 5-      $��* �6   �� 5.      $��* �6    � ColumnDefinitions 50   
   �� 51      $��* �6   �� 52      $��* �6   .+�54   
   �� $��0��6   $��8��6!   $	��0.7q�62   
�������$��5q�6]    �� CornerRadius$ 7��6h   $	��320��6y   $	��320��6�   ._�55      � .+�56      �� $��Uniform=�6u   $��2q�6�   ��6   �� *ProductCurrent.ImagePath+ �� 	Converter# [ 6�   �� 57      $��Right=�6   $��Bottom=�65   $��5q�6P    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6[   ���#7D8085���#7D8085
������� J� Opacity$	 0.7Q�58   �   ��6D   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Camera=�   Size$ 19X���59      �� *OpenDialogChooseImageCMD+5:      5;      �� 5<   
   $��0��6   $��1��6!   $��Add new��61   $��	17 17 7 7q�6@   $��16(�6S   $��SemiBold"�6a   �� 5=   
   -   5         ��Name$ tbx_name��5=   /   $��1��6   $��1��6    ! MaterialDesignOutlinedTextBox#��[ 6A   $	��320��6x   $��15q�6�     NAME)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6�   $��14(�6�   .��6�   ��5>      �� 5?      $ ProductCurrent.Name�6    �� UpdateSourceTrigger$ PropertyChanged=�65    �� Mode$ TwoWay=�6[    �� ValidationRules 5@      0   *SWarehouse.Validations.EmptyRuleValidation  5A      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 64   5C      .��5D      5E      �� 5F   
   -   5         ��Name$ cbx_cat��5F   0   $��2��6   $��1��6     �� DisplayMemberPath$
 Name��6d    " MaterialDesignOutlinedComboBox#��[ 6}   $	��320��6�   $��15q�6�   $ 
Danh Mục��6�   $��14(�6�   ��6A   �� *
Categories+ �� SelectedItem 5G      �� 5H      $ CategorySelected�6   $ PropertyChanged=�62   $ TwoWay=�6X    5I      7   1SWarehouse.Validations.NullSelectedItemValidation  5J       . 6;   5L      5N      �� 5O   
   -   5        $ cbx_unit��5O   0   $��3��6   $��1��6    $
 Name��6`   #��[ 6y   $	��320��6�   $��15q�6�   $ Đơn Vị Tính��6�   $��14(�6�   ��6B   �� *Units+ 5P      �� 5Q      $ UnitSelected�6   $ PropertyChanged=�6.   $ TwoWay=�6T    5R        5S       . 6;   5U      5W      �� 5X   
   -   5        $ cbx_sup��5X   0   $��4��6   $��1��6    $
 Name��6c   #��[ 6|   $	��320��6�   $��15q�6�   $ Nhà Cung Cấp��6�   $��14(�6�   ��6A   �� *	Suppliers+ 5Y      �� 5Z      $ SupplierSelected�6   $ PropertyChanged=�62   $ TwoWay=�6X    5[        5\       . 6;   5^      5`      �� 5a   
   $��7��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��5q�6g   .+�5b      �� -   5         ��Name$ btn_save��5b      #��[ 6'    	 SAVE#��� 	 6M    �� 	IsDefault . ��6n   �� $
 
btn_cancel��$ ActualWidth���6�   �� *	SaveCMD+6�   �� 5c      -   5        $ 
btn_cancel��5c      $	��5 0q�6)    

 CANCEL#��� 
 66   #��[ 6Y   ��6�   �� *	CancelCMD+5d      5e      5f      