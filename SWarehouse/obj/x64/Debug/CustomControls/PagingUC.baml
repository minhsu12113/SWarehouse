   M S B A M L   `   `   `  ����E  ASWarehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SWarehouse.CustomControlsSWarehouse.CustomControls  5      (    "SWarehouse.CustomControls.PagingUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:SWarehouse.CustomControls     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � $��Stretch=�6     � ColumnDefinitions  5   
   �� 5      $
��.05* �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��Center=�6v   $��10 0 0 2q�6�   ��6#   �� *CountDisplay+ �� SelectedItem 6H   �� *SelectedCountDisplay+6�   �� 5   
   $��2��6   $��
15 15 0 10q�6%   $��Center=�69    �� Orientation$ 
Horizontal=�6T   .+�5      �� $��Hiển thị��6   �� 5      $�� ��6   �� 5      ��6   �� *TotalCountDisplay+�� 5      $��/��6   �� 5      ��6   �� *TotalCountItem+5      �� 5   
   $��3��6   $ 
Horizontal=�6%   $��Right=�6>   $��5q�6Z   .+�5      �� -   5        $��btn_PreviousPage��5   R   $��2q�6      MaterialDesignFlatButton#��[  6    
������ ���#13548A���#13548A��6j   �� *PreviousPageCMD+{�6�   �� *IsEnableBtnPreviousPage+��6�   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ ChevronDoubleLeft=�6&  �� 5      $��2q�6   #��[  6    $��1��6R   ���#13548A
������ ���#13548A��6^   ��  �� ElementName$ btn_PreviousPage�� �� Path$ ActualWidth� �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=���6�   �� *GotoFirstNumberCMD+y�6�   �� *VisibilityDotsDown+6O  �� 5      $��2q�6   #��[  6    {�.  ���#13548A
������ ���#13548A��6R     $ DotsHorizontal=�y�6�   �� *VisibilityDotsDown+6�   �� 5       ��6   �� *
PageList+��5!      �� 5"      .R�5#      �� $ 
Horizontal=�6%    K� IsItemsHost . 6>   5$      ��5&      �� 5'      .R�5(      �� $��2q�6!   #��[  6,   ��6^   �� *
PageNumber+��5)   !   �� *
Background+��5*   !   �� $ btn_PreviousPage��$ ActualWidth�$ OneWay=�$ PropertyChanged=���5+   !   �� $ DataContext.SelectPageCMD�	 �� RelativeSource	 �� *FindAncestor+
 �� AncestorType"
 ����5,   !   �� 5-      5/      �� 51      $��2q�6   #��[  6    {�.  ���#13548A
������ ���#13548Ay�6R   �� *VisibilityDotsUp+��6z     $ DotsHorizontal=�6�   �� 52      $��2q�6   #��[  6    ���#13548A
������ ���#13548Ay�6R   �� *VisibilityDotsUp+��6z   �� *GotoLastPageCMD+��6�   �� *TotalCountPage+6�   �� 53      -   5         ��Name$ btn_nextPage��53      $��5q�6+   #��[  67   $��2q�6j   
������ ���#13548A���#13548A��6u   �� *NextPageCMD+{�6�   �� *IsEnableBtnNextPage+$ TwoWay=�$ PropertyChanged=���6�     $ ChevronDoubleRight=�6Z  55      56      57      