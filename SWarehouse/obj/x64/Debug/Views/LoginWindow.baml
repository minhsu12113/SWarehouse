   M S B A M L   `   `   `  ����E  ASWarehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SWarehouse.ViewsSWarehouse.Views  5   	   9!clr-namespace:SWarehouse.UtilitysSWarehouse.Utilitys  5	   	   "    SWarehouse.Views.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SWarehouse.Views     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   .helper!clr-namespace:SWarehouse.Utilitys  5	   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	    � Title$ LoginWindow��5   	   $	��400��6   $	��700��6*     LoginViewModel � DataContext# [ 66    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�62   
������  � AllowsTransparency .  � WindowState 5   <   �� *WindowState+.  (System.Windows.Interactivity.Interaction	   Triggers	 5      /  )System.Windows.Interactivity.EventTrigger  5   
   
   	EventName$
 MouseLeftButtonDown��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *DragMoveCMD+   CommandParameter 6D   ��  �� RelativeSource ��  �� AncestorType$ WindowL�5       � 	Resources 5        PrimaryCorlor �� Color  SecondPrimaryCorlor  PrimaryHueLightBrush " PrimaryHueLightForegroundBrush  PrimaryHueMidBrush   PrimaryHueMidForegroundBrush 	 PrimaryHueDarkBrush !
 PrimaryHueDarkForegroundBrush  SecondaryHueMidBrush " SecondaryHueMidForegroundBrush��%�  &	       &	 !     &	 B     &	 c     &	 �     &	 �     &		 �     &	
 �     &	     &	 )    �� 5   
   $ #051E31��60   �� 5   
   $ #1F3959��66   �� 5   
   $ #13548A��67   �� 5   
   $ #FFFFFF��6A   �� 5    
   $ #5C5B5E��65   �� 5!   
   $ #FFFFFF��6?   �� 5"   
   $ #13548A��66   �� 5#   
   $ #FFFFFF��6@   �� 5&   
   $ #5C5B5E��67   �� 5'   
   $ #FFFFFF��6A   5(      .��5,      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5-   
   ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5.         Kind$ ExpandIn=�6.      Duration$ 0:0:0.8h�6>     5/      $ SlideInFromTop=�6.   .��51   
   �  � ColumnDefinitions 52      �� 53      $
��1.7* �6#   �� 54      $
��1.3* �6#   �� 55      $	��.5* �6#   .+�58      #	  MaterialDesignThemes.Wpf.Card	  $��	0 30 0 30q�6"   $��3��65   ���#E7364D.��59      �  � ShowGridLines .   � RowDefinitions 5:      �� 5;      $��* �6(   �� 5<      $��* �6(   �� 5=      $��* �6(   �� 5>      $��* �6(   �� 5?      $��* �6(    5A      �� 5B      $��* �6+   �� 5C      $��* �6+   .+�5E      �� $��0��6    $��0 0 30 0q�6-     WELCOME#���  6?   
�������$��24(�6s   $��Bottom=�6�   $��Center=�6�   �� 5F      $��20 0 0 0q�6   $��/Assets/warehouse-2.png��6.   $��Uniform=�6O   $��1��6a   $��3��6n   �� 5G      $��0 0 20 0q�6    $��4��62     APP_NAME#���  6?   
�������$��14(�6t   $	��Top=�6�   $��Center=�6�   5H      5I      	  5L      $��1��6"   $��5q�62   .��5M      �  5N      �� 5O      $��* �6(   �� 5P      $��2* �6(   �� 5Q      $��* �6(   �� 5R      $��* �6(   �� 5S      $��* �6(   �� 5T      $��* �6(   �� 5U      $��* �6(   .+�5Y      �� $��0��6     	 LOGIN#���  6-   $��Bottom=�6L   $��Center=�6g   $��24(�6�   ���#E7364D6�   �� 5Z      $��1��6   $��0 0 0 10q�6*   $��Bottom=�6<   ���#E7364D���#E7364D
������� , (MaterialDesignFloatingActionAccentButton#��[ 5[      -
  'System.Windows.Input.KeyboardNavigation 
  TabNavigation$
 None=�6�   ��6[   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ 
ShieldLock=�   Size$ 29X�6�   �� 5^      $��2��6   $��
19 0 19 10q�6+   $��16(�6?   $��Bottom=�6M     USERNAME)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6o   
���������5_      �� *CurrentAccount.UserName+ �� UpdateSourceTrigger$ PropertyChanged=�G� 5`      $��3��6#   $��	19 0 19 0q�60   $��16(�6C   $��Bottom=�6Q     PASSWORD# �  6s   
�������(   "SWarehouse.Utilitys.PasswordHelper   Attach .    Password 5a   >   �� *CurrentAccount.Password+$ PropertyChanged=� �� Mode$ TwoWay=��� 5d      $��4��6   $��17 0 0 0q�6,     PASSWORD_REMEMBER#���  6>   �� 5e      $��5��6   $��
15 10 15 0q�6*   ���#E7364D���#E7364D#���  6i     �� 	IsDefault  . ��5f      �� *
LoginCMD+66   �� 5g      $��6��6    $��Center=�6�   $��Center=�6�     LOGIN_FAILED#���  6�   $��SemiBold"�6�   
���  ��y�6-   �� *ShowTextWhenLoginFailed+   BooleanToVisibilityConverter! �� 	Converter#! [ 6  5i      5j      �� 5m      $��2��6   " �� Orientation$" 
Horizontal=�6)   $��Right=�6B   $	��Top=�6^   $
��0 30q�6v   .+�5n      �� 
������ 
������ ��6L     $ WindowMinimize=���6�   �� *MinimizedWindowCMD+�� 5o      
������ 
������ ��6L     $ Close=���6{   �� *CloseWindowCMD+5p      5r      5s      5t      