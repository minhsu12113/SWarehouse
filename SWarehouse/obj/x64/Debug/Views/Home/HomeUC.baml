   M S B A M L   `   `   `  ����E  ASWarehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SWarehouse.Views.HomeSWarehouse.Views.Home  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      "    SWarehouse.Views.Home.HomeUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:SWarehouse.Views.Home     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      $	��.8* �6   �� 5      $	��.8* �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��15q�62      UniformCornerRadius$ 17Q�6>   .��5      �  5       �� 5!      $	��.5* �6(   �� 5"      $��* �6(    5$      �� 5%      $	��.7* �6+   �� 5&      $��* �6+   .+�5(      '  !MaterialDesignThemes.Wpf.PackIcon  $��0��6.   $��0��6;      Kind$ PackageVariantClosed=�6K   $
��Auto��6g   $
��Auto��6t   
�������$��Center=�6�   $��	10 10 7 7q�6�   �� 5)      $��0��6    $��1��6-   $��
Hàng Hóa��6=   $��Center=�6M   $��18(�6h   $
��Left=�6v   
�������6�   �� 5*      $��1��6    $��0��6-   $��2��6=   $��0 0 0 30q�6Q   $	��100��6c   $��Center=�6n   $��47(�6�   $��Center=�6�   $��SemiBold"�6�   5,      5-        5.      $��1��6"   $��15q�62   $ 17Q�6>   .��5/      �  50      �� 51      $	��.5* �6(   �� 52      $��* �6(    54      �� 55      $	��.7* �6+   �� 56      $��* �6+   .+�58        $��0��6.   $��0��6;   $ Buffer=�6K   $
��Auto��6Y   $
��Auto��6f   
�������$��Center=�6�   $��	10 10 7 7q�6�   �� 59      $��0��6    $��1��6-   $��
Danh Mục��6=   $��Center=�6M   $��18(�6h   $
��Left=�6v   
�������6�   �� 5:      $��1��6    $��0��6-   $��2��6=   $��0 0 0 30q�6Q   $	��100��6c   $��Center=�6n   $��47(�6�   $��Center=�6�   $��SemiBold"�6�   5<      5=        5>      $��2��6"   $��15q�62   $ 17Q�6>   .��5?      �  5@      �� 5A      $	��.5* �6(   �� 5B      $��* �6(    5D      �� 5E      $	��.7* �6+   �� 5F      $��* �6+   .+�5H        $��0��6.   $��0��6;   $
 Blur=�6K   $
��Auto��6W   $
��Auto��6d   
�������$��Center=�6�   $��	10 10 7 7q�6�   �� 5I      $��0��6    $��1��6-   $��Đơn Vị Tính��6=   $��Center=�6P   $��18(�6k   $
��Left=�6y   
�������6�   �� 5J      $��1��6    $��0��6-   $��2��6=   $��0 0 0 30q�6Q   $	��100��6c   $��Center=�6n   $��47(�6�   $��Center=�6�   $��SemiBold"�6�   5L      5M        5N      $��3��6"   $��15q�62   $ 17Q�6>   .��5O      �  5P      �� 5Q      $	��.5* �6(   �� 5R      $��* �6(    5T      �� 5U      $	��.7* �6+   �� 5V      $��* �6+   .+�5X        $��0��6.   $��0��6;   $ HumanHandsup=�6K   $
��Auto��6_   $
��Auto��6l   
�������$��Center=�6�   $��	10 10 7 7q�6�   �� 5Y      $��0��6    $��1��6-   $��Nhà Cung Cấp��6=   $��Center=�6Q   $��18(�6l   $
��Left=�6z   
�������6�   �� 5Z      $��1��6    $��0��6-   $��2��6=   $��0 0 0 30q�6Q   $	��100��6c   $��Center=�6n   $��47(�6�   $��Center=�6�   $��SemiBold"�6�   5\      5]      5^      #  LiveCharts.Wpf.CartesianChart  5_   
   $��1��6   $��5q�6*   &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Bottom=�6Y      Series 65   �� *SeriesCollection+   AxisY 5a        LiveCharts.Wpf.Axis  	   Title$	 Sales��6   
   LabelFormatter
 6)   �� *
YFormatter+6Q      AxisX 5d        $	 Month��6      Labels 6)   �� *Labels+6E   5f        5g   
   $��2��6   $��5q�6*   $ Bottom=�6Z    65   �� *SeriesCollection1+ 5i        $	 Salesman��6    6,   �� *	Labels1+6I    5l        $	 	Sold Apps��6   
 6-   �� *	Formatter+6T   5n      5o      5p      