   M S B A M L   `   `   `  ����R  NCourse Prerequsites WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Course_Prerequsites_WPF.UIsCourse_Prerequsites_WPF.UIs  5   	   1    +Course_Prerequsites_WPF.UIs.StudentControls   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Course_Prerequsites_WPF.UIs     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ StudentControls��5	   	   $	��650��6!   $	��600��6.   .��5
      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $	��26* �6   �� 5      $
��214* �6   �� 5      $	��47* �6   .+�5   
   �� -   5         ��Name$ BackBTN��5   #    � ToolTip$ Log Out��6      MetroCircleButtonStyle#���   64   $
��Left=�6e   $	��Top=�6�   $��55��6�   $��55��6�   $��0��6�   $��0��6�   $��2��6�   $��	10,10,0,0q�6�   .��5      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5      !� 5       j� Stretch$
 Fill=�6"     appbar_arrow_left	 !� Visual#	 [ 61   5      5      �� 5   
   -   5        $# viewallavailablecoursesbutton��5      $ ��View all available courses��68   $	��Top=�6]   $��102,123,47,0q�6u   $��57��6�   $��1��6�   $��18(�6�   $��Segoe UI)�6�   $��Light"�6�   
����������	#FFF6A10C$��1��62  �� 5   
   -   5        $ viewmycoursesbutton��5      $��View my courses��6.   $	��Top=�6H   $��102,223,47,0q�6`   $��57��6w   $��2��6�   $��22(�6�   $��Segoe UI)�6�   $��Light"�6�   
����������	#FFF6A10C$��1��6  �� 5   
   -   5        $( "viewallavailablecoursesbutton_Copy��5      $��Register for a course��6=   $	��Top=�6]   $��102,323,47,0q�6u   $��57��6�   $��3��6�   $��23(�6�   $��Segoe UI)�6�   $��Light"�6�   
����������	#FFF6A10C$��1��6"  �� 5   
   -   5        $ editmydatabutton��5      $��Edit my data��6+   $	��Top=�6B   $��102,426,47,0q�6Z   $��57��6p   $��4��6|   $��20(�6�   $��Segoe UI)�6�   $��Light"�6�   
����������	#FFF6A10C$��1��6
  �� 5   
   $��Student Controls��6   $	��Top=�6,   $��Center=�6D   $��
90,30,48,0q�6a     PageHeaderTextStyle#��[ 6u   $��1��6�   5       5!      