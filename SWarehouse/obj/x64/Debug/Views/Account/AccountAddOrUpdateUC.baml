   M S B A M L   `   `   `  ����E  ASWarehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SWarehouse.Views.AccountSWarehouse.Views.Account  5      9!clr-namespace:SWarehouse.UtilitysSWarehouse.Utilitys  5      =#clr-namespace:SWarehouse.ConvertersSWarehouse.Converters  5
      E'clr-namespace:SWarehouse.CustomControlsSWarehouse.CustomControls  5      ?$clr-namespace:SWarehouse.ValidationsSWarehouse.Validations  5      3    -SWarehouse.Views.Account.AccountAddOrUpdateUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:SWarehouse.Views.Account     5      4helper!clr-namespace:SWarehouse.Utilitys     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      3	converter#clr-namespace:SWarehouse.Converters  5
      4paging'clr-namespace:SWarehouse.CustomControls  5      0valid$clr-namespace:SWarehouse.Validations  5         MaterialDesignBody#���   5      $��Regular"�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5      2   ,SWarehouse.Converters.AvatarAccountConverter  AvatarAccountConverter �� 
TargetType * &MaterialDesignFilterChipAccentCheckBox �� BasedOn  CheckboxPermision �� Property �� Value �� Triggers P� Property	 P� Value��%  &	       &	      7    5   
   6+   �� 5   
   " ��6   8   .�5      ��  � ��$	 5 0q�6'   �� 5       � ��
 �����6+    5      P� 5       �@d�	IsChecked$
	 TrueY�6/   . �5      ��  � ��
 � � �63   5      5      5      .��5       � $	��390��6   $	��590��6   
 � ShowGridLines
 .   � RowDefinitions 5!   
   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   �� 5$      $��* �6   �� 5%      $
��Auto �6   �� 5&      $
��Auto �6   �� 5'      $
��Auto �6   �� 5(      $	��.1* �6   �� 5)      $
��Auto �6   .+�5+   
   �� $��Center=�6,   $
��5 15q�6I   $��18(�6W   $��SemiBold"�6e   ��6   �� *Header+6e   � 5/   
   $��2��6    � ColumnDefinitions 50      �� 51      $
��.27* �6#   �� 52      $��* �6#   �� 53      $
��.27* �6#   .+�57      A� $��1��6   $��10q�6'   
�������$	��0.7��6A   ��58      �� 59       j� Stretch$ UniformToFill=�6�    �� ImageSource 6!   �� *AccountCurrent.ImagePath+ �� 	Converter# [ 6�   5;      �� 5<      $��1��6   $��
130 0 0 10q�6%   $��Center=�69   $��Bottom=�6V    * &MaterialDesignFloatingActionMiniButton#��[ 5=      ��5<   q   �� *OpenDialogChooseImageCMD+��5=   U   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Camera=�   Size$ 19X�5>      �� 5@   
   -   5         ��Name$ tbx_username��5@      $��3��6(    ! MaterialDesignOutlinedTextBox#��[ 65   $��16(�6l   $��
17 7 17 20q�6z   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tài Khoản��6�   .��6�   ��5A      �� 5B       �� Path$ AccountCurrent.UserName�6    �� UpdateSourceTrigger$ PropertyChanged=�69    �� Mode$ TwoWay=�6_    �� ValidationRules 5C      0   *SWarehouse.Validations.EmptyRuleValidation  5D      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 64   5F      .��5G      5H      G� 5I   
   -   5         G�Name$ tbx_password��5I   #   $��4��6    % !MaterialDesignOutlinedPasswordBox#��[ 69   $��16(�6t   $��
17 7 17 20q�6�   $ Mật Khẩu��6�   (   "SWarehouse.Utilitys.PasswordHelper   Attach .    Password 5J      �� 5K      $ AccountCurrent.Password�6   $ TwoWay=�69   $ PropertyChanged=�6G    5L        5M       . 64   5O      5Q      G� 5R   
   -   5        $ tbx_confirmpassword��5R   #   $��5��6   #��[ 6@   $��16(�6{   $��	17 7 17 0q�6�   $ Nhập Lại Mật Khẩu��6�    .  5S      �� 5T      $ ConfirmPassword�6   $ TwoWay=�61   $ PropertyChanged=�6?    5U        5V       . 64   5X      5Z      �� 5\   
   $��7��6   $��	19 7 17 7q�6!   $!��Mật khẩu không khớp!��64   $��16(�6P   $��SemiBold"�6^   
��� E��y�6�   �� *IsErrorPassword+  BoolToVisibility# [ �� 5]   
    �� Orientation$ 
Horizontal=�6   $��7��6.   $��Right=�6;   $��5q�6W   .+�5^      �� $
��Lưu��6   $��69��6#   ��6.   �� *	SaveCMD+��5_      �� 5`      " ��6    	 MaterialDesignFlatButton# [	 60   .�5a      ��  � {� .  66    5b      ^� 5c       ^� 
Conditions 5d   "   �� 5e   &    �� Binding 60   ��  �� ElementName$ tbx_username��$ (Validation.HasError)�  �� Value	  False6x   �� 5f   &    60   �� $ tbx_password��$ (Validation.HasError)�	  False6x   �� 5g   &    60   �� $ tbx_confirmpassword��$ (Validation.HasError)�	  False6   �� 5h   &    60   �� *IsErrorPassword+	  False6T   0�5j   "   �� 5k   &    � {� . 6B   5m      5o      5q      �� 5r      #��[	 6   $��Hủy��6G   $��69��6U   ��6`   �� *	CancelCMD+5s      5t      5u      