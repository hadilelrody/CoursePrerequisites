   M S B A M L   `   `   `  ����R  NCourse Prerequsites WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Course_Prerequsites_WPF.UIsCourse_Prerequsites_WPF.UIs  5   	   6    0Course_Prerequsites_WPF.UIs.ViewStudentsInCourse   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Course_Prerequsites_WPF.UIs     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ ViewStudentsInCourse��5	   	   $	��650��6&   $	��600��63   ���	#FFFFFFFF.��5
      � $��10q�6   .+�5   
   �� -   5         ��Name$ BackBTN��5   3    � ToolTip$ Back to Course Settings��6      MetroCircleButtonStyle#���   6D   $��10,10,487,510q�6�   $��3��6�   .��5      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5      !� 5       j� Stretch$
 Fill=�6"     appbar_arrow_left !� Visual# [ 61   5      5      �� 5   
   $��Choose Course :��6   $��10,94,190.6,0q�6+   $	��Top=�6B     SectionHeaderTextStyle#��[ 6Z   $��28                    (�6�   ��5      �� 5      	 �� Color#	 � ��6"   5      �� 5   
   -   5        $��Display��5      $
��Left=�6#   $��46��6>   $��397,164,0,0q�6J   $	��Top=�6_   $	��136��6w   $��Segoe UI)�6�   $��Light"�6�   $��26(�6�   
����������	#FFF6A10C$��2��6�   �� 5   
   $
��Name��6   $
��Left=�6    $��25��6;   $��216,387,0,0q�6G   $	��Top=�6\   $	��106��6t   ���	#FFF9F5F5#��[ 6�   �� 5   
   -   5        
 ��Name$
 	StudNames��5      $
��Left=�6%   $	��259��6@   $	��Top=�6M   $	��531��6e    J� RenderTransformOrigin$ 2.547,4.793&�6q   $��
30,317,0,0q�6�   �� 5   
   -   5         ��Name$ CourseNames��5      $
��Left=�6(   $��34��6C   $��
216,94,0,0q�6O   $	��Top=�6c   $	��317��6{   $��1��6�   5       5!      