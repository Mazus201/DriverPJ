   M S B A M L   `   `   `  ����H  DDriverProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DriverProjectDriverProject  5   	       DriverProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DriverProject     5   	     � WindowStyle$
  None=�5       � WindowStartupLocation$ CenterScreen=�6-    � Title$ Driver��5   	   $	��450��6   $	��800��6%   .��5	      � -   5         	  Brush#��[  5	      .+�5   
    � -   5        $��	FrmCenter��5        � NavigationUIVisibility$ Hidden=�6!   �� 5   
   -   5        $��BtnBack��5      $
��Left=�5      $��Bottom=�6,   $��25��5      $��25��6   $��x��5        BtnBack#��[ 5   '   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��2q�6.   $	��Top=�5      $��Right=�6-   .+�5      �� -   5        $��BtnMinimize��5      $��18��5      $��20��6!   $	��Top=�6,   ��5      �� 5       �� 
TargetType" ��6&   .R�5      ��  ��Name$ Bd��6!   
������ ._�5      F�  F�Name$ Pt��6#   =���� �     �     � � �  � � �  � � �  � � �  � 	 �� Stretch$ Uniform=�5      
�������$��2��6:   5      	 �� Triggers	 5      P� 5      
 P� Property
 �@J�IsMouseOver P� Value . . �5   "   ��  �� 
TargetName$ Bd��6)    �� Property � �� �� Value �	#FF0083FF6O   �� 5   "   $ Pt��6)    � ��
 �   �6K   5      5!      5#      �� 5$      -   5        $��BtnMaximize��5%      $��20��5$      $��20��6!   $	��5,0q�5&      ��5'      �� 5(      " ��6&   .R�5)      �� $ Bd��6!   
������ ._�5*      F� $ Pt��6#   +����        �@B @B �@B @B р� @B 	$ Uniform=�5+      
�������$��2��6:   5,      	 5-      P� 5.      
 �@J�IsMouseOver . . �5/   "   �� $ Bd��6)    � �� �	#FF8EFF636O   �� 50   "   $ Pt��6)    � ��
 �   �6K   51      53      55      �� 56      -   5        $��BtnClose��56   ,   $��20��6   $��20��6!   $��0q�6S   ��57      �� 58      " ��6&   .R�59      �� $ Bd��6!   
������ ._�5:      F� $ Pt��6#   =����        �@ @ � 5  5 �@  5 � 5 @ �@B @B 	$ Uniform=�5;      
�������$��2��6:   5<      	 5=      P� 5>      
 �@J�IsMouseOver . . �5?   "   �� $ Bd��6)    � ��
 �  ��6O   �� 5@   "   $ Pt��6)    � ��
 �   �6K   5A      5C      5E      5F      5G      5H      