   M S B A M L   `   `   `  ����  Course Prerequsites WPF.    (Course_Prerequsites_WPF.UIs.AddNewCourse   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Add New Course��5   	   $	��600��6    $	��700��6-   .��5      � .+�5   
   �� -   5         ��Name$ BackBTN��5   3    � ToolTip$ Back to Course Settings��6      MetroCircleButtonStyle#���   6D   $��10,10,607,482q�6�   .��5	      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5
      !� 5       j� Stretch$
 Fill=�6"     appbar_arrow_left !� Visual# [ 61   5      5      �� 5   
     SectionHeaderTextStyle#��[ 6   $
��Code��6D   $
��Left=�6P   $	��Top=�6k   $��	90,19,0,0q�6�   #��� ��6�   �� 5   
   #��[ 6   $��Course Name��6D   $
��Left=�6W   $	��Top=�6r   $��29��6�   $��	90,60,0,0q�6�   #��� ��6�   �� 5   
   #��[ 6   $��Maximum Student Capacity��6D   $
��Left=�6d   $	��Top=�6   $��
90,109,0,0q�6�   #��� ��6�   �� 5   
   #��[ 6   $��Current Student Capacity��6D   $
��Left=�6d   $	��Top=�6   $��
90,159,0,0q�6�   #��� ��6�   �� 5   
   #��[ 6   $��Passing Grade ��6D   $
��Left=�6Z   $	��Top=�6u   $��
90,214,0,0q�6�   #��� ��6�   �� 5   
   #��[ 6   $��Course Grade ��6D   $
��Left=�6Y   $	��Top=�6t   $��
90,260,0,0q�6�   #��� ��6�   �� 5   
   #��[ 6   $��Hours��6D   $
��Left=�6Q   $	��Top=�6l   $��
90,305,0,0q�6�   #��� ��6�   �� 5   
   #��[ 6   $��
Instructor��6D   $
��Left=�6W   $	��Top=�6r   $��
90,358,0,0q�6�   #��� ��6�   �� 5   
   #��[ 6   $��Description��6D   $
��Left=�6W   $	��Top=�6r   $��
90,412,0,0q�6�   #��� ��6�   �� 5   
   -   5        	 ��Name$	 CodeTextBox��5   �   $��Segoe UI)�6   $��Light"�6(   $
��Left=�6;   $��27��6V   
 �� TextWrapping$

 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��236��6�    �� 	IsEnabled . $. (Text Box can't contain '#' or '*' or '%'��6�   $��
372,19,0,0q�6  �� 5   
   -   5        $	 CourseNameTextBox��5   �   $��Segoe UI)�6   $��Light"�6(   $
��Left=�6;   $��27��6V   $

 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��236��6�   $. (Text Box can't contain '#' or '*' or '%'��6�   $��
372,60,0,0q�6�   �� 5   
   -   5        $$	 MaximumNumberOfStudentsTextBox��5   �   $��Segoe UI)�6   $��Light"�6(   $
��Left=�6;   $��27��6V   $

 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��236��6�   $��372,109,0,0q�6�   �� 5   
   -   5        $$	 CurrentNumberOfStudentsTextBox��5   �   $��Segoe UI)�6   $��Light"�6(   $
��Left=�6;   $��26��6V   $

 Wrap=�6b   $��0��6v   $	��Top=�6   $	��236��6�   $��372,159,0,0q�6�   {�.  6�   �� 5   
   -   5        $	 PassingGradeTextBox��5   �   $��Segoe UI)�6   $��Light"�6(   $
��Left=�6;   $��27��6V   $

 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��236��6�   $��372,209,0,0q�6�   �� 5   
   -   5        $	 CourseGradeTextBox��5   �   $��Segoe UI)�6   $��Light"�6(   $
��Left=�6;   $��27��6V   $

 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��236��6�   $��372,260,0,0q�6�   �� 5    
   -   5        $	 HoursTextBox��5    �   $��Segoe UI)�6   $��Light"�6(   $
��Left=�6;   $��28��6V   $

 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��236��6�   $  ��6�   $��372,305,0,0q�6�   �� 5!   
   -	   5        $	 InstructorTextBox��5!   �   $��Segoe UI)�6   $��Light"�6(   $
��Left=�6;   $��27��6V   $

 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��236��6�   $. (Text Box can't contain '#' or '*' or '%'��6�   $��372,358,0,0q�6�   �� 5"   
   -
   5        $	 DescriptionTextBox��5"   �   $��Segoe UI)�6   $��Light"�6(   $
��Left=�6;   $��54��6V   $

 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��236��6�   $. (Text Box can't contain '#' or '*' or '%'��6�   $��372,412,0,0q�6�   �� 5%   
   -   5        $ AddCourseButton��5%   �   $��	Next Step��6   $
��Left=�6%   $��48��6@   $��238,497,0,0q�6L   $	��Top=�6a   $	��171��6y   $��Segoe UI)�6�   $��Light"�6�   $��28(�6�   
����������	#FFF6A10C6  5'      5(      